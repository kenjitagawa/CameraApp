using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCamera
{
    public class CarteMemoire : ICarteMemoire
    {

        #region Constantes 

        public const int TAILLE_MIN = 8; //  8 Mo
        public const int TAILLE_MAX = 8192; // 8192 Mo
        public const string ERR_MSG_ESPACE_INSUFFISANT = "Espace insuffisant";

        #endregion

        #region Propriétés et Champs


        /// <summary>
        /// Calcule l’espace en octets disponible sur la carte mémoire.
        /// </summary>
        public long EspaceDisponible
        {
            get
            {
                return TailleEnOctets - EspaceUtilise;
            }
        }


        private long m_espaceUtilise;
        /// <summary>
        /// Obtient l’espace utilisé en octets.
        /// </summary>
        public long EspaceUtilise
        {
            get { return m_espaceUtilise; }
            private set { m_espaceUtilise = value; }
        }


        private List<IPhoto> m_colPhotos;
        /// <summary>
        /// Obtient le nombre de photos actuellement stockées dans la collection.
        /// </summary>
        public int NbPhotos
        {
            get { return m_colPhotos.Count; }
        }

        private string m_nom;
        /// <summary>
        /// Obtient le nom de la carte mémoire.
        /// </summary>
        public string Nom
        {
            get { return m_nom; }
            private set { m_nom = value; }
        }


        private long m_tailleEnOctets;
        /// <summary>
        /// Obtient la taille en octets de la carte mémoire. 
        /// </summary>
        public long TailleEnOctets
        {
            get { return m_tailleEnOctets; }
            private set { m_tailleEnOctets = value; }
        }

        #endregion

        #region Méthodes

        public CarteMemoire(string pNom, int pTailleEnMegaOctets)
        { 
            Nom = pNom;

            if (pTailleEnMegaOctets <= TAILLE_MAX && pTailleEnMegaOctets >= TAILLE_MIN)
                TailleEnOctets = (long)pTailleEnMegaOctets * 1024 * 1024; //mb  * 1024 => kb * 1024 => b
            else
                throw new ArgumentOutOfRangeException();

            EspaceUtilise = 0;
            m_colPhotos = new List<IPhoto>();
        }


        public void Ajouter(IPhoto pobjPhoto)
        {
            if (pobjPhoto != null)
            {
                if (PeutAjouter(pobjPhoto))
                {
                    m_colPhotos.Add(pobjPhoto);
                    EspaceUtilise += pobjPhoto.TailleEnOctets;
                }
                else
                {
                    throw new InvalidOperationException(ERR_MSG_ESPACE_INSUFFISANT);
                }
            }
            else
                throw new ArgumentNullException();
        }


        /// <summary>
        /// Permet de stocker dans la collection de photos, les données qui sont dans le fichier dont le nom est formé à l’aide du nom de la carte et du suffixe .txt 
        /// </summary>
        public void ChargerPhotos()
        {
            m_colPhotos.Clear();
            EspaceUtilise = 0;

            StreamReader objFichier = new StreamReader($"{Nom}.txt");

            while (!objFichier.EndOfStream)
            { 
                string ligne = objFichier.ReadLine();
                Photo photo = new Photo(ligne);

                EspaceUtilise += photo.TailleEnOctets;


                m_colPhotos.Add(photo);
            }

            objFichier.Close();

        }

        public void EnregistrerPhotos()
        {
            
            StreamWriter objFichier = new StreamWriter($"{Nom}.txt");

            foreach (Photo photo in m_colPhotos)
            {
                objFichier.WriteLine(photo.ToString());
            }

            objFichier.Close ();

        }

        public bool PeutAjouter(IPhoto pobjPhoto)
        {
            if (pobjPhoto != null && pobjPhoto.TailleEnOctets < EspaceDisponible)
            {
                return true;
            }
            return false;
        }

        public IPhoto PhotoAt(int pPosition)
        {
            if (pPosition <= NbPhotos && pPosition >= 0)
                return m_colPhotos[pPosition];

            else
                throw new ArgumentOutOfRangeException();

        }

        public void SupprimerAt(int pPosition)
        {
            if (pPosition <= NbPhotos && pPosition >= 0)
            {
                EspaceUtilise -= m_colPhotos[pPosition].TailleEnOctets;
                m_colPhotos.RemoveAt(pPosition);
            }
            else
                throw new ArgumentOutOfRangeException();
        }

        public void Vider()
        {
            m_colPhotos.Clear();
            EspaceUtilise = 0;
        }


        #endregion

    }
}
