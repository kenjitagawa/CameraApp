using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCamera
{
    public partial class FrmPrincipal : Form
    {
        // =======================================
        // CHAMPS : variables membre du formulaire
        // ---------------------------------------
        public const string APP_INFO = " (Nom Prénom)";

        public const string ERR_MSG_ESPACE_INSUFFISANT_FORM = "Espace insuffisant pour prendre une photo avec les paramètres actuels !";

        private Camera m_objCamera;
        private CarteMemoire m_objCarteMemoire32Mo;
        private CarteMemoire m_objCarteMemoire1Go;
        private CarteMemoire m_objCarteMemoire8Go;
        private const int MAX_PHOTOS = 999;
        //==========================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            //---------------------------------------------------------------------
            m_objCarteMemoire32Mo = new CarteMemoire("Sandisk 32Mo", 32);
            m_objCarteMemoire32Mo.ChargerPhotos();
            m_objCarteMemoire1Go = new CarteMemoire("UltraII 1Go", 1024);
            m_objCarteMemoire1Go.ChargerPhotos();
            m_objCarteMemoire8Go = new CarteMemoire("SDHC 8Go", 8192);
            m_objCarteMemoire8Go.ChargerPhotos();
            //---------------------------------------------------------------------
            m_objCamera = new Camera();
            m_objCamera.ChargerParametres();
            //---------------------------------------------------------------------
            MettreAJourSelonContexte();
            AfficherInfosCamera();
            AfficherInfosCarteMemoire();
            AfficherInfosPhotoCourante();
            //------------------------------------------------------------------------
            Cocher(mnuParametresDimension.DropDownItems, (int)m_objCamera.Dimension);
            Cocher(ctmDimension.Items, (int)m_objCamera.Dimension);
            Cocher(mnuParametresQualite.DropDownItems, (int)m_objCamera.Qualite);
            Cocher(ctmQualite.Items, (int)m_objCamera.Qualite);
            Cocher(mnuParametresSensibilite.DropDownItems, (int)m_objCamera.Sensibilite);
            Cocher(ctmSensibilite.Items, (int)m_objCamera.Sensibilite);
            Cocher(mnuParametresFlash.DropDownItems, (int)m_objCamera.Flash);
            Cocher(ctmFlash.Items, (int)m_objCamera.Flash);
        }

        #region Méthodes pour afficher les infos : Caméra , Carte Mémoire et Photo Courante
        //==================================================================================
        /// <summary>
        /// Permet de formater la taille en Mo, en Ko ou en octets. 
        /// </summary>
        /// <param name="pTailleEnOctets">taille fournie en octets</param>
        /// <returns>chaine représentant la taille formatée </returns>
        /// ---------------------------------------------------------------------------------
        private string FormaterTaille(long pTailleEnOctets)
        {
            // TODO 1 à compléter
            throw new NotImplementedException();
        }
        //==========================================================================
        /// <summary>
        /// Affiche les informations de la zone grpInfosCamera 
        /// </summary>
        /// --------------------------------------------------------------------------------
        private void AfficherInfosCamera()
        {
            // TODO 2 à compléter, voir démo







            //NE PAS MODIFIER------------------
            Cocher(mnuParametresDimension.DropDownItems, (int)m_objCamera.Dimension);
            Cocher(ctmDimension.Items, (int)m_objCamera.Dimension);
            Cocher(mnuParametresQualite.DropDownItems, (int)m_objCamera.Qualite);
            Cocher(ctmQualite.Items, (int)m_objCamera.Qualite);
            Cocher(mnuParametresSensibilite.DropDownItems, (int)m_objCamera.Sensibilite);
            Cocher(ctmSensibilite.Items, (int)m_objCamera.Sensibilite);
            Cocher(mnuParametresFlash.DropDownItems, (int)m_objCamera.Flash);
            Cocher(ctmFlash.Items, (int)m_objCamera.Flash);
        }
        //-------------------------------------------------------------------------------
        /// <summary>
        /// Affiche les informations de la zone grpInfosCarteMemoire
        /// </summary>
        private void AfficherInfosCarteMemoire()
        {
            //TODO 3 à compléter, voir démo
        }
        //-------------------------------------------------------------------------------
        /// <summary>
        /// Affiche les informations de la zone grpInfoPhoto
        /// </summary>
        private void AfficherInfosPhotoCourante()
        {
            // TODO 4 à compléter, voir démo
        }
        #endregion

        #region Mettre à jour selon le contexte
        //===============================================================================
        private void MettreAJourSelonContexte()
        {
            bool cameraFonctionnelle = chkPower.Checked && mnuSpecialVoirDeDos.Checked;
            bool cartePresente = m_objCamera.CarteMemoireCourante != null;
            bool carteNonVide = cartePresente && m_objCamera.CarteMemoireCourante.NbPhotos > 0;

            mnuEdition.Enabled = cameraFonctionnelle;
            mnuParametres.Enabled = cameraFonctionnelle;

            btnPrendreUnePhoto.Enabled = cameraFonctionnelle && cartePresente && m_objCamera.CarteMemoireCourante.NbPhotos < MAX_PHOTOS;
            mnuEditionPrendreUnePhoto.Enabled = cameraFonctionnelle && cartePresente && m_objCamera.CarteMemoireCourante.NbPhotos < MAX_PHOTOS;

            btnSupprimerPhoto.Enabled = cameraFonctionnelle && carteNonVide;
            mnuEditionSupprimerPhoto.Enabled = cameraFonctionnelle && carteNonVide;

            mnuEditionViderLaCarteMemoire.Enabled = cameraFonctionnelle && carteNonVide;

            mnuEditionPhotoPrecedente.Enabled = cameraFonctionnelle && carteNonVide && m_objCamera.CarteMemoireCourante.NbPhotos > 1;
            btnPhotoPrecedente.Enabled = mnuEditionPhotoPrecedente.Enabled;
            mnuEditionPhotoSuivante.Enabled = cameraFonctionnelle && carteNonVide && m_objCamera.CarteMemoireCourante.NbPhotos > 1;
            btnPhotoSuivante.Enabled = mnuEditionPhotoSuivante.Enabled;

            btnQualiteSuivante.Enabled = cameraFonctionnelle;
            btnDimensionSuivante.Enabled = cameraFonctionnelle;
            btnSensibiliteSuivante.Enabled = cameraFonctionnelle;
            btnFlash.Enabled = cameraFonctionnelle;

            grpInfoPhoto.Visible = cameraFonctionnelle;
            grpInfosCamera.Visible = cameraFonctionnelle;
            grpInfosCarteMemoire.Visible = cameraFonctionnelle;
        }

        #endregion

        #region Événements du bouton ChkPower et des  boutons radio associés aux cartes mémoires
        //=====================================================================================
        private void chkPower_CheckedChanged(object sender, EventArgs e)
        {
            MettreAJourSelonContexte();
        }
        //-------------------------------------------------------------------------------
        private void radCarteMemoire0Mo_CheckedChanged(object sender, EventArgs e)
        {
            if (radCarteMemoire0Mo.Checked)
            {
                radCarteMemoire0Mo.ImageIndex = 4;
                if (m_objCamera.CarteMemoireCourante != null)
                    m_objCamera.EjecterCarteMemoire();
                AfficherInfosCamera();
                AfficherInfosCarteMemoire();
                AfficherInfosPhotoCourante();
                MettreAJourSelonContexte();
            }
            else
                radCarteMemoire0Mo.ImageIndex = 0;
        }
        //-------------------------------------------------------------------------------
        private void radCarteMemoire32Mo_CheckedChanged(object sender, EventArgs e)
        {
            if (radCarteMemoire32Mo.Checked)
            {
                radCarteMemoire32Mo.ImageIndex = 5;
                if (m_objCamera.CarteMemoireCourante != null)
                    m_objCamera.EjecterCarteMemoire();
                m_objCamera.InsererCarteMemoire(m_objCarteMemoire32Mo);
                AfficherInfosCamera();
                AfficherInfosCarteMemoire();
                AfficherInfosPhotoCourante();
                MettreAJourSelonContexte();
            }
            else
                radCarteMemoire32Mo.ImageIndex = 1;
        }
        //-------------------------------------------------------------------------------
        private void radCarteMemoire1Go_CheckedChanged(object sender, EventArgs e)
        {
            if (radCarteMemoire1Go.Checked)
            {
                radCarteMemoire1Go.ImageIndex = 6;
                if (m_objCamera.CarteMemoireCourante != null)
                    m_objCamera.EjecterCarteMemoire();
                m_objCamera.InsererCarteMemoire(m_objCarteMemoire1Go);
                AfficherInfosCamera();
                AfficherInfosCarteMemoire();
                AfficherInfosPhotoCourante();
                MettreAJourSelonContexte();
            }
            else
                radCarteMemoire1Go.ImageIndex = 2;
        }
        //-------------------------------------------------------------------------------
        private void radCarteMemoire8Go_CheckedChanged(object sender, EventArgs e)
        {
            if (radCarteMemoire8Go.Checked)
            {
                radCarteMemoire8Go.ImageIndex = 7;
                if (m_objCamera.CarteMemoireCourante != null)
                    m_objCamera.EjecterCarteMemoire();
                m_objCamera.InsererCarteMemoire(m_objCarteMemoire8Go);
                AfficherInfosCamera();
                AfficherInfosCarteMemoire();
                AfficherInfosPhotoCourante();
                MettreAJourSelonContexte();
            }
            else
                radCarteMemoire8Go.ImageIndex = 3;
        }
        #endregion

        #region Menu Fichier
        //==========================================================================
        private void mnuFichierChargerParametres_Click(object sender, EventArgs e)
        {
            m_objCamera.ChargerParametres();
            AfficherInfosCamera();
            //AfficherInfosPhotoCourante();
            //AfficherInfosCarteMemoire();
            MettreAJourSelonContexte();
        }
        //==========================================================================
        private void mnuFichierEnregistrerParametres_Click(object sender, EventArgs e)
        {
            m_objCamera.EnregistrerParametres();
            //AfficherInfosCamera();
            //AfficherInfosPhotoCourante();
            //AfficherInfosCarteMemoire();
            MettreAJourSelonContexte();
        }
        //==========================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //==========================================================================
        private void FrmPrincipalCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_objCarteMemoire32Mo.EnregistrerPhotos();
            m_objCarteMemoire1Go.EnregistrerPhotos();
            m_objCarteMemoire8Go.EnregistrerPhotos();

            m_objCamera.EnregistrerParametres();
        }
        #endregion

        #region Menu Edition
        //-------------------------------------------------------------------------------
        private void mnuEditionPrendreUnePhoto_Click(object sender, EventArgs e)
        {
            if (m_objCamera.PeutPrendreUnePhoto())
                m_objCamera.PrendrePhoto();
            else
                MessageBox.Show(ERR_MSG_ESPACE_INSUFFISANT_FORM,
                                  Application.ProductName,
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
            AfficherInfosPhotoCourante();
            AfficherInfosCarteMemoire();
            MettreAJourSelonContexte();
        }
        //-------------------------------------------------------------------------------
        private void mnuEditionSupprimerPhoto_Click(object sender, EventArgs e)
        {
            if (m_objCamera.CarteMemoireCourante != null && m_objCamera.CarteMemoireCourante.NbPhotos > 0)
            {
                m_objCamera.SupprimerPhotoCourante();
                AfficherInfosPhotoCourante();
                AfficherInfosCarteMemoire();
                MettreAJourSelonContexte();
            }
        }
        //-------------------------------------------------------------------------------
        private void mnuEditionViderLaCarteMemoire_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous réellement supprimer toutes les photos sur la carte",
                                                   Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reponse == DialogResult.OK)
            {
                m_objCamera.ViderLaCarte(); // H14 24-02
                AfficherInfosPhotoCourante();
                AfficherInfosCarteMemoire();
                MettreAJourSelonContexte();
            }
        }
        //-------------------------------------------------------------------------------
        private void mnuEditionPhotoPrecedente_Click(object sender, EventArgs e)
        {
            m_objCamera.PhotoPrecedente();
            AfficherInfosPhotoCourante();
        }
        //-------------------------------------------------------------------------------
        private void mnuEditionPhotoSuivante_Click(object sender, EventArgs e)
        {
            m_objCamera.PhotoSuivante();
            AfficherInfosPhotoCourante();
        }
        #endregion

        #region Menu Paramètres

        #region Méthode Cocher une option d'un menu --NE PAS modifier
        //----------------------------------------------------------------
        /// <summary>
        /// Permet de cocher l'option correspondant à un index.
        /// </summary>
        /// <param name="pCollection">colletion des options du menu</param>
        /// <param name="pIndex">index de l'option à cocher</param>
        /// ---------------------------------------------------------------
        private void Cocher(ToolStripItemCollection pCollection, int pIndex)
        {
            foreach (ToolStripMenuItem objElement in pCollection)
            {
                objElement.Checked = false; // on décoche toutes les options
            }
            ((ToolStripMenuItem)pCollection[pIndex]).Checked = true; // on coche la bonne
        }
        #endregion

        #region Menu Parametres/Dimension
        //-------------------------------------------------------------------------------
        private void mnuDimensionMaximale_Click(object sender, EventArgs e)
        {
            m_objCamera.Dimension = enuDimension.Maximale;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuDimensionLarge_Click(object sender, EventArgs e)
        {
            m_objCamera.Dimension = enuDimension.Large;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuDimensionGrande_Click(object sender, EventArgs e)
        {
            m_objCamera.Dimension = enuDimension.Grande;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuDimensionMoyenne_Click(object sender, EventArgs e)
        {
            m_objCamera.Dimension = enuDimension.Moyenne;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuDimensionPetite_Click(object sender, EventArgs e)
        {
            m_objCamera.Dimension = enuDimension.Petite;
            AfficherInfosCamera();
        }
        //==============================================================================
        private void btnDimensionSuivante_Click(object sender, EventArgs e)
        {
            m_objCamera.DimensionSuivante();
            AfficherInfosCamera();
        }
        #endregion

        #region Menu Parametres/Qualite
        //-------------------------------------------------------------------------------
        private void mnuQualiteExcellente_Click(object sender, EventArgs e)
        {
            m_objCamera.Qualite = enuQualite.Excellente;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuQualiteBonne_Click(object sender, EventArgs e)
        {
            m_objCamera.Qualite = enuQualite.Bonne;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuQualiteMoyenne_Click(object sender, EventArgs e)
        {
            m_objCamera.Qualite = enuQualite.Moyenne;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuQualiteFaible_Click(object sender, EventArgs e)
        {
            m_objCamera.Qualite = enuQualite.Faible;
            AfficherInfosCamera();
        }
        //===============================================================================
        private void btnQualiteSuivante_Click(object sender, EventArgs e)
        {
            m_objCamera.QualiteSuivante();
            AfficherInfosCamera();
        }
        #endregion

        #region Menu Parametres/Sensibilité
        //-------------------------------------------------------------------------------
        private void mnuSensibiliteISO64_Click(object sender, EventArgs e)
        {
            m_objCamera.Sensibilite = enuSensibilite.ISO_64;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuSensibiliteISO100_Click(object sender, EventArgs e)
        {
            m_objCamera.Sensibilite = enuSensibilite.ISO_100;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuSensibiliteISO200_Click(object sender, EventArgs e)
        {
            m_objCamera.Sensibilite = enuSensibilite.ISO_200;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuSensibiliteISO400_Click(object sender, EventArgs e)
        {
            m_objCamera.Sensibilite = enuSensibilite.ISO_400;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuSensibiliteISO800_Click(object sender, EventArgs e)
        {
            m_objCamera.Sensibilite = enuSensibilite.ISO_800;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void btnSensibiliteSuivante_Click(object sender, EventArgs e)
        {
            m_objCamera.SensibiliteSuivante();
            AfficherInfosCamera();
        }
        #endregion

        #region Menu Parametres/Flash
        //-------------------------------------------------------------------------------
        private void mnuFlashActive_Click(object sender, EventArgs e)
        {
            m_objCamera.Flash = enuFlash.Activé;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void mnuFlashDesactive_Click(object sender, EventArgs e)
        {
            m_objCamera.Flash = enuFlash.Désactivé;
            AfficherInfosCamera();
        }
        //-------------------------------------------------------------------------------
        private void btnBasculerFlash_Click(object sender, EventArgs e)
        {
            if (m_objCamera.Flash == enuFlash.Activé)
                m_objCamera.Flash = enuFlash.Désactivé;
            else
                m_objCamera.Flash = enuFlash.Activé;
            AfficherInfosCamera();
        }
        #endregion

        #endregion

        #region Menu Spécial --> NE PAS modifier
        //===============================================================================
        private void mnuSpecialVoirDeFace_Click(object sender, EventArgs e)
        {
            picCameraDeFace.Location = new Point(0, 0);
            mnuSpecialVoirDeDos.Checked = false;
            mnuSpecialVoirDeFace.Checked = true;
            chkPower.Visible = false;
            MettreAJourSelonContexte();
        }
        //===============================================================================
        private void mnuSpecialVoirDeDos_Click(object sender, EventArgs e)
        {
            picCameraDeFace.Location = new Point(0, 625);
            mnuSpecialVoirDeDos.Checked = true;
            mnuSpecialVoirDeFace.Checked = false;
            chkPower.Visible = true;
            MettreAJourSelonContexte();
        }

        #endregion

        private void lblCameraSensibilite_Click(object sender, EventArgs e)
        {

        }
    }
}
