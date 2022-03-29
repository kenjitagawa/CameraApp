using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCamera
{
    public class Photo : IPhoto
    {

        #region Constantes

        public const int TAILLE_PIXEL = 3;
        public const int LARGEUR_MIN = 640;
        public const int LARGEUR_MAX = 8192;
        public const int HAUTEUR_MIN = 480;
        public const int HAUTEUR_MAX = 8192;
        public const int COMPRESSION_MIN = 1;
        public const int COMPRESSION_MAX = 500;

        #endregion

        #region Propriétés et Champs

        private DateTime m_date;
        /// <summary>
        /// Obtient la date et l’heure où la photo a été prise.
        /// </summary>
        public DateTime Date 
        {
            get { return m_date; }
            private set { m_date = value; }
        }

        private int m_facteurCompression;
        /// <summary>
        /// Obtient le facteur de compression de la photo.
        /// </summary>
        public int FacteurCompression 
        {
            get { return m_facteurCompression; }
            private set { m_facteurCompression = value; }
        }


        private enuFlash m_flash;
        /// <summary>
        /// Obtient si le flash est activé ou désactivé sur la photo.
        /// </summary>
        public enuFlash Flash 
        { 
            get { return m_flash; } 
            private set { m_flash = value; }
        }

        private enuSensibilite m_sensibilite;
        /// <summary>
        /// Obtient la sensibilité utilisée pour la photo.
        /// </summary>
        public enuSensibilite Sensibilite 
        {
            get { return m_sensibilite; }
            private set { m_sensibilite = value; }
        }


        private Size m_tailleEnPixels;
        /// <summary>
        /// Obtient la taille en pixels de la photo. 
        /// </summary>
        public Size TailleEnPixels 
        {
            get { return m_tailleEnPixels; }
            private set { m_tailleEnPixels = value; }
        }


        /// <summary>
        /// Calcule la taille en octets de la photo à l’aide de la formule 
        /// </summary>
        public int TailleEnOctets
        {
            get 
            {
                return (TAILLE_PIXEL * (int)m_tailleEnPixels.Width * (int)m_tailleEnPixels.Height)/FacteurCompression;
            }
        
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Initialise une instance à partir d’une chaîne dont les données sont séparées par une virgule. 
        /// </summary>
        /// <param name="pInfosPhoto">Chaîne avec les données</param>
        public Photo(string pInfosPhoto)
        {
            // largeur, hauteur en pixel, flash, sensibilité, facteur de compression, date hre 
            // 3000,2000,0,4,4,2014-03-28 12:56:45

            string[] infosPhoto = pInfosPhoto.Split(',');

            TailleEnPixels = new Size(int.Parse(infosPhoto[0]), int.Parse(infosPhoto[1]));
            Flash = (enuFlash)int.Parse(infosPhoto[2]);
            Sensibilite = (enuSensibilite)int.Parse(infosPhoto[3]);
            FacteurCompression = int.Parse(infosPhoto[4]);
            Date = DateTime.Parse(infosPhoto[5]);

        }


        /// <summary>
        /// Initialise une instance avec les données passées en paramètres
        /// </summary>
        /// <param name="pTailleEnPixels">Taille de image en Size => Width, Height</param>
        /// <param name="pFacteurCompression">Facteur de compression de l'image</param>
        /// <param name="pSensibilite">Sensibilite de la camera</param>
        /// <param name="pFlash">Flash alume</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Photo(Size pTailleEnPixels, int pFacteurCompression, enuSensibilite pSensibilite, enuFlash pFlash)
        {

            if ((pTailleEnPixels.Width <= LARGEUR_MAX && pTailleEnPixels.Width >= LARGEUR_MIN) && (pTailleEnPixels.Height <= HAUTEUR_MAX && pTailleEnPixels.Height >= HAUTEUR_MIN))
                TailleEnPixels = pTailleEnPixels;
            else
                throw new ArgumentOutOfRangeException();
    
            Flash = pFlash;
            Sensibilite = pSensibilite;
            Date = DateTime.Now;


            if (pFacteurCompression <= COMPRESSION_MAX && pFacteurCompression >= COMPRESSION_MIN)
                FacteurCompression = pFacteurCompression;
            else
                throw new ArgumentOutOfRangeException();

        }

        /// <summary>
        /// Retourne la représentation de cette instance sous forme de chaîne dont les données sont séparées par des virgules .
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{TailleEnPixels.Width},{TailleEnPixels.Height},{(int)Flash},{(int)Sensibilite},{FacteurCompression},{Date.ToString("yyyy-MM-dd HH:mm:ss")}" ;
        }

        #endregion

    }
}
