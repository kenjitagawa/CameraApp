using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCamera
{
    public class Camera : ICamera
    {
        #region Constantes
        public const string ERR_MSG_CARTE_MANQUANTE = "Carte manquante";
        public const string ERR_MSG_CARTE_PRÉSENTE = "Carte déjà présente";
        public const string ERR_MSG_CARTE_VIDE = "Carte vide";
        private const string NOM_FICHIER_PARAMETRES = "parametres.txt";

        #endregion


        #region Propriétés et Champs

        private enuDimension m_dimension;
        /// <summary>
        /// Obtient et définit le paramètre dimension de la caméra.
        /// </summary>
        public enuDimension Dimension
        { 
            get { return m_dimension; }
            set { m_dimension = value; }
        }

        
        private enuFlash m_flash;
        /// <summary>
        /// Obtient et définit le paramètre flash de la caméra.
        /// </summary>
        public enuFlash Flash
        { 
            get { return m_flash; }
            set { m_flash = value; }
        }

        private ICarteMemoire m_objCarteMemoireCourante = null;
        /// <summary>
        /// Obtient la carte mémoire qui est actuellement dans la caméra. Au départ, comme il n’y en a pas, la valeur est null.
        /// </summary>
        public ICarteMemoire CarteMemoireCourante
        {
            get { return m_objCarteMemoireCourante; }
            private set { m_objCarteMemoireCourante = value; }
        }

        private int m_posPhotoCourante;
        /// <summary>
        /// Indique l’indice de la photo actuellement affichée sur la caméra.
        /// </summary>
        public int PosPhotoCourante
        {
            get { return m_posPhotoCourante; }
            private set { m_posPhotoCourante = value; }
        }

        private enuQualite m_qualite;
        /// <summary>
        /// Obtient et définit le paramètre qualité de la caméra.
        /// </summary>
        public enuQualite Qualite
        {
            get { return m_qualite; }
            set { m_qualite = value; }
        }

        private enuSensibilite m_sensibilite;
        /// <summary>
        /// Obtient et définit le paramètre sensibilité de la caméra.
        /// </summary>
        public enuSensibilite Sensibilite
        {
            get { return m_sensibilite; }
            set { m_sensibilite = value; }
        }

        /// <summary>
        /// Retournera l’objet photo contenu dans la collection de la carte mémoire courante à la position indiquée par la position courante. 
        /// </summary>
        public IPhoto PhotoCourante 
        {
            get 
            {
                if (CarteMemoireCourante != null)
                {
                    IPhoto photoCourante = CarteMemoireCourante.PhotoAt(PosPhotoCourante);

                    if (photoCourante != null)
                        return photoCourante;
                }

                return null;
            }

        }

        /// <summary>
        /// Le facteur de compression est déterminé à partir de la qualité sélectionnée de la caméra. 
        /// </summary>
        public int FacteurCompression 
        {
            get
            { 
                switch (Qualite)
                {
                    case enuQualite.Excellente:
                        return 4;

                    case enuQualite.Bonne:
                        return 12;

                    case enuQualite.Moyenne:
                        return 20;

                    case enuQualite.Faible:
                        return 50;

                    default:
                        return -1;

                }
            }
        }

        /// <summary>
        /// Calcule la taille de la photo selon la formule => (largeurEnPixel X hauteurEnPixel X taille d’un pixel) / facteur de compression de la caméra
        /// </summary>
        public long TailleEnOctetsEstimee 
        { 
            get
            {
                Size taillePhoto = TailleEnPixelsSelonDimension;
                return (taillePhoto.Height * taillePhoto.Width * Photo.TAILLE_PIXEL) / FacteurCompression;
            }
        
        }

        /// <summary>
        /// La taille en pixels selon la dimension
        /// </summary>
        public Size TailleEnPixelsSelonDimension 
        {  
            get
            {
                switch (Dimension)
                {
                    case enuDimension.Maximale:
                        return new Size(4000, 3000);

                    case enuDimension.Large:
                        return new Size(3840, 2160);

                    case enuDimension.Grande:
                        return new Size(3000, 2000);

                    case enuDimension.Moyenne:
                        return new Size(1600, 1200);

                    case enuDimension.Petite:
                        return new Size(640, 480);

                    default:
                        return new Size(0, 0);

                }
            }
        
        }


        #endregion


        #region Constructeur
        /// <summary>
        /// Instancie les propriétés de la classe Camera
        /// </summary>
        public Camera()
        {
            CarteMemoireCourante = null;
            PosPhotoCourante = -1;
            Dimension = enuDimension.Maximale;
            Qualite = enuQualite.Excellente;
            Sensibilite = enuSensibilite.ISO_64;
            Flash = enuFlash.Activé;
        }

        #endregion



        #region Méthodes

        /// <summary>
        /// Permet de lire les valeurs des paramètres dans le fichier et d'initialiser les 4 variables membres suivantes : dimension, qualité, sensibilité et flash. 
        /// </summary>
        public void ChargerParametres()
        {
            StreamReader objFichier = new StreamReader(NOM_FICHIER_PARAMETRES);

            string[] fichierLignes = objFichier.ReadToEnd().Split('\n'); // (ReadToEnd) =>Trouve dans Notion C# (https://sites.google.com/site/notionscsharpcem/fichiertexte)

            Dimension = (enuDimension)int.Parse(fichierLignes[0]);
            Qualite = (enuQualite)int.Parse(fichierLignes[1]);
            Sensibilite = (enuSensibilite)int.Parse(fichierLignes[2]);
            Flash = (enuFlash)int.Parse(fichierLignes[3]);

            objFichier.Close();


        }

        public void DimensionSuivante()
        {
            // Check if value is the last. If yes, then return to 1. Otherwhise, +1.
            if (Dimension == enuDimension.Petite)
            {
                Dimension = enuDimension.Maximale;
            }
            else
                Dimension++;
        }

        public void EjecterCarteMemoire()
        {
            if (CarteMemoireCourante == null)
                throw new InvalidOperationException(ERR_MSG_CARTE_MANQUANTE);
            CarteMemoireCourante = null;
        }

        public void EnregistrerParametres()
        {
            StreamWriter objFichier = new StreamWriter(NOM_FICHIER_PARAMETRES);

            objFichier.WriteLine((int)Dimension);
            objFichier.WriteLine((int)Qualite);
            objFichier.WriteLine((int)Sensibilite);
            objFichier.WriteLine((int)Flash);

            objFichier.Close ();
        }

        public void InsererCarteMemoire(ICarteMemoire pCarteMemoire)
        {
            
            if (CarteMemoireCourante != null)
                throw new InvalidOperationException (ERR_MSG_CARTE_PRÉSENTE);

            if (pCarteMemoire == null)
                throw new ArgumentNullException(ERR_MSG_CARTE_MANQUANTE);

            else
            { 
                CarteMemoireCourante = pCarteMemoire;
                PosPhotoCourante = 0;
            }


        }

        public bool PeutPrendreUnePhoto()
        {
            if (CarteMemoireCourante != null)
            {
                if (CarteMemoireCourante.EspaceDisponible > TailleEnOctetsEstimee)
                    return true;
            }
            return false;
        }

        public void PhotoPrecedente()
        {
            if (CarteMemoireCourante != null)
            {
                if (CarteMemoireCourante.NbPhotos <= 0)
                    throw new InvalidOperationException(ERR_MSG_CARTE_VIDE);

                if (PosPhotoCourante > 0)
                    PosPhotoCourante--;
                else
                    PosPhotoCourante = CarteMemoireCourante.NbPhotos - 1;
            }
            else
            {
                throw new InvalidOperationException(ERR_MSG_CARTE_MANQUANTE);
            }
        }

        public void PhotoSuivante()
        {
            if (CarteMemoireCourante != null)
            {
                if (CarteMemoireCourante.EspaceUtilise == 0)
                    throw new InvalidOperationException(ERR_MSG_CARTE_VIDE);

                if (PosPhotoCourante < CarteMemoireCourante.NbPhotos - 1)
                    PosPhotoCourante++;

                else
                    PosPhotoCourante = 0;
            }
            else
                throw new InvalidOperationException(ERR_MSG_CARTE_MANQUANTE);
        }

        public void PrendrePhoto()
        {
            //public Photo(Size pTailleEnPixels, int pFacteurCompression, enuSensibilite pSensibilite, enuFlash pFlash)
            IPhoto photo = new Photo(TailleEnPixelsSelonDimension, FacteurCompression, Sensibilite, Flash);


            if (CarteMemoireCourante != null)
            {
                if (CarteMemoireCourante.PeutAjouter(photo))
                {
                    CarteMemoireCourante.Ajouter(photo);
                    PosPhotoCourante = CarteMemoireCourante.NbPhotos - 1;
                }
                else
                    throw new InvalidOperationException(CarteMemoire.ERR_MSG_ESPACE_INSUFFISANT);
            }
            else 
                throw new InvalidOperationException(ERR_MSG_CARTE_MANQUANTE);
        }

        public void QualiteSuivante()
        {
            if (Qualite == enuQualite.Faible)
                Qualite = enuQualite.Excellente;
            else
                Qualite++;
        }

        public void SensibiliteSuivante()
        {
            if (Sensibilite == enuSensibilite.ISO_800)
                Sensibilite = enuSensibilite.ISO_64;
            else
                Sensibilite++;
        }

        public void SupprimerPhotoCourante()
        {
            if (CarteMemoireCourante != null)
            { 
                if (CarteMemoireCourante.EspaceUtilise == 0)
                    throw new InvalidOperationException(ERR_MSG_CARTE_VIDE);

                CarteMemoireCourante.SupprimerAt(PosPhotoCourante);
                PosPhotoCourante = CarteMemoireCourante.NbPhotos - 1;
            }
            else 
                throw new InvalidOperationException(ERR_MSG_CARTE_MANQUANTE);
        }

        public void ViderLaCarte()
        {

            if (CarteMemoireCourante != null)
            { 
                if (CarteMemoireCourante.EspaceDisponible <= 0)
                    throw new InvalidOperationException(ERR_MSG_CARTE_VIDE);
                
                CarteMemoireCourante.Vider();
                PosPhotoCourante = -1;
            }
            else
                throw new InvalidOperationException(ERR_MSG_CARTE_MANQUANTE);
        }


        #endregion
    }
}
