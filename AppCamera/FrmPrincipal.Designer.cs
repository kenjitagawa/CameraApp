namespace AppCamera
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionPrendreUnePhoto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionSupprimerPhoto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionViderLaCarteMemoire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditionPhotoPrecedente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionPhotoSuivante = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParametres = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParametresDimension = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDimensionMaximale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDimensionLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDimensionGrande = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDimensionMoyenne = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDimensionPetite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParametresQualite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQualiteExcellente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQualiteBonne = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQualiteMoyenne = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQualiteFaible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParametresSensibilite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSensibiliteISO64 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSensibiliteISO100 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSensibiliteISO200 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSensibiliteISO400 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSensibiliteISO800 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParametresFlash = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlashActive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlashDesactive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialVoirDeFace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialVoirDeDos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrendreUnePhoto = new System.Windows.Forms.Button();
            this.grpInfosCarteMemoire = new System.Windows.Forms.GroupBox();
            this.lblEspace = new System.Windows.Forms.Label();
            this.lblEspaceDisponible = new System.Windows.Forms.Label();
            this.btnQualiteSuivante = new System.Windows.Forms.Button();
            this.ctmQualite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmQualiteExcellente = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmQualiteBonne = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmQualiteMoyenne = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmQualiteFaible = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDimensionSuivante = new System.Windows.Forms.Button();
            this.ctmDimension = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmDimensionMaximale = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmDimensionLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmDimensionGrande = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmDimensionMoyenne = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmDimensionPetite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSensibiliteSuivante = new System.Windows.Forms.Button();
            this.ctmSensibilite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmSensibilite64 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmSensibilite100 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmSensibilite200 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmSensibilite400 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmSensibilite800 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFlash = new System.Windows.Forms.Button();
            this.ctmFlash = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmFlashActive = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmFlashDesactive = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhotoSuivante = new System.Windows.Forms.Button();
            this.btnPhotoPrecedente = new System.Windows.Forms.Button();
            this.btnSupprimerPhoto = new System.Windows.Forms.Button();
            this.grpInfoPhoto = new System.Windows.Forms.GroupBox();
            this.lblTailleEnOctets = new System.Windows.Forms.Label();
            this.lblDimPhoto = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.lblSensPhoto = new System.Windows.Forms.Label();
            this.lblPriseLe = new System.Windows.Forms.Label();
            this.lblPhotoCourante = new System.Windows.Forms.Label();
            this.lblPhotoDate = new System.Windows.Forms.Label();
            this.lblPhotoFlash = new System.Windows.Forms.Label();
            this.lblPhotoTailleEnPixels = new System.Windows.Forms.Label();
            this.lblPhotoSensibilite = new System.Windows.Forms.Label();
            this.lblPhotoTailleEnOctets = new System.Windows.Forms.Label();
            this.grpInfosCamera = new System.Windows.Forms.GroupBox();
            this.lblCM = new System.Windows.Forms.Label();
            this.lblQualite = new System.Windows.Forms.Label();
            this.lblDimCamera = new System.Windows.Forms.Label();
            this.lblCameraDimension = new System.Windows.Forms.Label();
            this.lblCameraQualite = new System.Windows.Forms.Label();
            this.lblF1 = new System.Windows.Forms.Label();
            this.lblCameraCarteMemoire = new System.Windows.Forms.Label();
            this.lblCameraSensibilite = new System.Windows.Forms.Label();
            this.lblSensCamera = new System.Windows.Forms.Label();
            this.lblCameraFlash = new System.Windows.Forms.Label();
            this.picCameraDeFace = new System.Windows.Forms.PictureBox();
            this.tltCamera = new System.Windows.Forms.ToolTip(this.components);
            this.radCarteMemoire0Mo = new System.Windows.Forms.RadioButton();
            this.imlCartesMemoires = new System.Windows.Forms.ImageList(this.components);
            this.radCarteMemoire1Go = new System.Windows.Forms.RadioButton();
            this.radCarteMemoire32Mo = new System.Windows.Forms.RadioButton();
            this.radCarteMemoire8Go = new System.Windows.Forms.RadioButton();
            this.chkPower = new System.Windows.Forms.CheckBox();
            this.mnuPrincipal.SuspendLayout();
            this.grpInfosCarteMemoire.SuspendLayout();
            this.ctmQualite.SuspendLayout();
            this.ctmDimension.SuspendLayout();
            this.ctmSensibilite.SuspendLayout();
            this.ctmFlash.SuspendLayout();
            this.grpInfoPhoto.SuspendLayout();
            this.grpInfosCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCameraDeFace)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuEdition,
            this.mnuParametres,
            this.mnuSpecial});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(696, 24);
            this.mnuPrincipal.TabIndex = 4;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuEdition
            // 
            this.mnuEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditionPrendreUnePhoto,
            this.mnuEditionSupprimerPhoto,
            this.mnuEditionViderLaCarteMemoire,
            this.mnuEditionSep1,
            this.mnuEditionPhotoPrecedente,
            this.mnuEditionPhotoSuivante});
            this.mnuEdition.Name = "mnuEdition";
            this.mnuEdition.Size = new System.Drawing.Size(56, 20);
            this.mnuEdition.Text = "&Édition";
            // 
            // mnuEditionPrendreUnePhoto
            // 
            this.mnuEditionPrendreUnePhoto.Name = "mnuEditionPrendreUnePhoto";
            this.mnuEditionPrendreUnePhoto.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.mnuEditionPrendreUnePhoto.Size = new System.Drawing.Size(250, 22);
            this.mnuEditionPrendreUnePhoto.Text = "Prendre une photo";
            this.mnuEditionPrendreUnePhoto.Click += new System.EventHandler(this.mnuEditionPrendreUnePhoto_Click);
            // 
            // mnuEditionSupprimerPhoto
            // 
            this.mnuEditionSupprimerPhoto.Name = "mnuEditionSupprimerPhoto";
            this.mnuEditionSupprimerPhoto.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuEditionSupprimerPhoto.Size = new System.Drawing.Size(250, 22);
            this.mnuEditionSupprimerPhoto.Text = "Supprimer la photo courante";
            this.mnuEditionSupprimerPhoto.Click += new System.EventHandler(this.mnuEditionSupprimerPhoto_Click);
            // 
            // mnuEditionViderLaCarteMemoire
            // 
            this.mnuEditionViderLaCarteMemoire.Name = "mnuEditionViderLaCarteMemoire";
            this.mnuEditionViderLaCarteMemoire.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.mnuEditionViderLaCarteMemoire.Size = new System.Drawing.Size(250, 22);
            this.mnuEditionViderLaCarteMemoire.Text = "Vider la carte mémoire";
            this.mnuEditionViderLaCarteMemoire.Click += new System.EventHandler(this.mnuEditionViderLaCarteMemoire_Click);
            // 
            // mnuEditionSep1
            // 
            this.mnuEditionSep1.Name = "mnuEditionSep1";
            this.mnuEditionSep1.Size = new System.Drawing.Size(247, 6);
            // 
            // mnuEditionPhotoPrecedente
            // 
            this.mnuEditionPhotoPrecedente.Name = "mnuEditionPhotoPrecedente";
            this.mnuEditionPhotoPrecedente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.mnuEditionPhotoPrecedente.Size = new System.Drawing.Size(250, 22);
            this.mnuEditionPhotoPrecedente.Text = "Photo précédente";
            this.mnuEditionPhotoPrecedente.Click += new System.EventHandler(this.mnuEditionPhotoPrecedente_Click);
            // 
            // mnuEditionPhotoSuivante
            // 
            this.mnuEditionPhotoSuivante.Name = "mnuEditionPhotoSuivante";
            this.mnuEditionPhotoSuivante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.mnuEditionPhotoSuivante.Size = new System.Drawing.Size(250, 22);
            this.mnuEditionPhotoSuivante.Text = "Photo suivante";
            this.mnuEditionPhotoSuivante.Click += new System.EventHandler(this.mnuEditionPhotoSuivante_Click);
            // 
            // mnuParametres
            // 
            this.mnuParametres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuParametresDimension,
            this.mnuParametresQualite,
            this.mnuParametresSensibilite,
            this.mnuParametresFlash});
            this.mnuParametres.Name = "mnuParametres";
            this.mnuParametres.Size = new System.Drawing.Size(78, 20);
            this.mnuParametres.Text = "&Paramètres";
            // 
            // mnuParametresDimension
            // 
            this.mnuParametresDimension.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDimensionMaximale,
            this.mnuDimensionLarge,
            this.mnuDimensionGrande,
            this.mnuDimensionMoyenne,
            this.mnuDimensionPetite});
            this.mnuParametresDimension.Name = "mnuParametresDimension";
            this.mnuParametresDimension.Size = new System.Drawing.Size(131, 22);
            this.mnuParametresDimension.Text = "Dimension";
            // 
            // mnuDimensionMaximale
            // 
            this.mnuDimensionMaximale.Checked = true;
            this.mnuDimensionMaximale.CheckOnClick = true;
            this.mnuDimensionMaximale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDimensionMaximale.Name = "mnuDimensionMaximale";
            this.mnuDimensionMaximale.Size = new System.Drawing.Size(126, 22);
            this.mnuDimensionMaximale.Text = "Maximale";
            this.mnuDimensionMaximale.Click += new System.EventHandler(this.mnuDimensionMaximale_Click);
            // 
            // mnuDimensionLarge
            // 
            this.mnuDimensionLarge.CheckOnClick = true;
            this.mnuDimensionLarge.Name = "mnuDimensionLarge";
            this.mnuDimensionLarge.Size = new System.Drawing.Size(126, 22);
            this.mnuDimensionLarge.Text = "Large";
            this.mnuDimensionLarge.Click += new System.EventHandler(this.mnuDimensionLarge_Click);
            // 
            // mnuDimensionGrande
            // 
            this.mnuDimensionGrande.CheckOnClick = true;
            this.mnuDimensionGrande.Name = "mnuDimensionGrande";
            this.mnuDimensionGrande.Size = new System.Drawing.Size(126, 22);
            this.mnuDimensionGrande.Text = "Grande";
            this.mnuDimensionGrande.Click += new System.EventHandler(this.mnuDimensionGrande_Click);
            // 
            // mnuDimensionMoyenne
            // 
            this.mnuDimensionMoyenne.CheckOnClick = true;
            this.mnuDimensionMoyenne.Name = "mnuDimensionMoyenne";
            this.mnuDimensionMoyenne.Size = new System.Drawing.Size(126, 22);
            this.mnuDimensionMoyenne.Text = "Moyenne";
            this.mnuDimensionMoyenne.Click += new System.EventHandler(this.mnuDimensionMoyenne_Click);
            // 
            // mnuDimensionPetite
            // 
            this.mnuDimensionPetite.CheckOnClick = true;
            this.mnuDimensionPetite.Name = "mnuDimensionPetite";
            this.mnuDimensionPetite.Size = new System.Drawing.Size(126, 22);
            this.mnuDimensionPetite.Text = "Petite";
            this.mnuDimensionPetite.Click += new System.EventHandler(this.mnuDimensionPetite_Click);
            // 
            // mnuParametresQualite
            // 
            this.mnuParametresQualite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQualiteExcellente,
            this.mnuQualiteBonne,
            this.mnuQualiteMoyenne,
            this.mnuQualiteFaible});
            this.mnuParametresQualite.Name = "mnuParametresQualite";
            this.mnuParametresQualite.Size = new System.Drawing.Size(131, 22);
            this.mnuParametresQualite.Text = "Qualité";
            // 
            // mnuQualiteExcellente
            // 
            this.mnuQualiteExcellente.Checked = true;
            this.mnuQualiteExcellente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQualiteExcellente.Name = "mnuQualiteExcellente";
            this.mnuQualiteExcellente.Size = new System.Drawing.Size(127, 22);
            this.mnuQualiteExcellente.Text = "Excellente";
            this.mnuQualiteExcellente.Click += new System.EventHandler(this.mnuQualiteExcellente_Click);
            // 
            // mnuQualiteBonne
            // 
            this.mnuQualiteBonne.Name = "mnuQualiteBonne";
            this.mnuQualiteBonne.Size = new System.Drawing.Size(127, 22);
            this.mnuQualiteBonne.Text = "Bonne";
            this.mnuQualiteBonne.Click += new System.EventHandler(this.mnuQualiteBonne_Click);
            // 
            // mnuQualiteMoyenne
            // 
            this.mnuQualiteMoyenne.Name = "mnuQualiteMoyenne";
            this.mnuQualiteMoyenne.Size = new System.Drawing.Size(127, 22);
            this.mnuQualiteMoyenne.Text = "Moyenne";
            this.mnuQualiteMoyenne.Click += new System.EventHandler(this.mnuQualiteMoyenne_Click);
            // 
            // mnuQualiteFaible
            // 
            this.mnuQualiteFaible.Name = "mnuQualiteFaible";
            this.mnuQualiteFaible.Size = new System.Drawing.Size(127, 22);
            this.mnuQualiteFaible.Text = "Faible";
            this.mnuQualiteFaible.Click += new System.EventHandler(this.mnuQualiteFaible_Click);
            // 
            // mnuParametresSensibilite
            // 
            this.mnuParametresSensibilite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSensibiliteISO64,
            this.mnuSensibiliteISO100,
            this.mnuSensibiliteISO200,
            this.mnuSensibiliteISO400,
            this.mnuSensibiliteISO800});
            this.mnuParametresSensibilite.Name = "mnuParametresSensibilite";
            this.mnuParametresSensibilite.Size = new System.Drawing.Size(131, 22);
            this.mnuParametresSensibilite.Text = "Sensibilité";
            // 
            // mnuSensibiliteISO64
            // 
            this.mnuSensibiliteISO64.Name = "mnuSensibiliteISO64";
            this.mnuSensibiliteISO64.Size = new System.Drawing.Size(113, 22);
            this.mnuSensibiliteISO64.Text = "ISO 64";
            this.mnuSensibiliteISO64.Click += new System.EventHandler(this.mnuSensibiliteISO64_Click);
            // 
            // mnuSensibiliteISO100
            // 
            this.mnuSensibiliteISO100.Checked = true;
            this.mnuSensibiliteISO100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSensibiliteISO100.Name = "mnuSensibiliteISO100";
            this.mnuSensibiliteISO100.Size = new System.Drawing.Size(113, 22);
            this.mnuSensibiliteISO100.Text = "ISO 100";
            this.mnuSensibiliteISO100.Click += new System.EventHandler(this.mnuSensibiliteISO100_Click);
            // 
            // mnuSensibiliteISO200
            // 
            this.mnuSensibiliteISO200.Name = "mnuSensibiliteISO200";
            this.mnuSensibiliteISO200.Size = new System.Drawing.Size(113, 22);
            this.mnuSensibiliteISO200.Text = "ISO 200";
            this.mnuSensibiliteISO200.Click += new System.EventHandler(this.mnuSensibiliteISO200_Click);
            // 
            // mnuSensibiliteISO400
            // 
            this.mnuSensibiliteISO400.Name = "mnuSensibiliteISO400";
            this.mnuSensibiliteISO400.Size = new System.Drawing.Size(113, 22);
            this.mnuSensibiliteISO400.Text = "ISO 400";
            this.mnuSensibiliteISO400.Click += new System.EventHandler(this.mnuSensibiliteISO400_Click);
            // 
            // mnuSensibiliteISO800
            // 
            this.mnuSensibiliteISO800.Name = "mnuSensibiliteISO800";
            this.mnuSensibiliteISO800.Size = new System.Drawing.Size(113, 22);
            this.mnuSensibiliteISO800.Text = "ISO 800";
            this.mnuSensibiliteISO800.Click += new System.EventHandler(this.mnuSensibiliteISO800_Click);
            // 
            // mnuParametresFlash
            // 
            this.mnuParametresFlash.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFlashActive,
            this.mnuFlashDesactive});
            this.mnuParametresFlash.Name = "mnuParametresFlash";
            this.mnuParametresFlash.Size = new System.Drawing.Size(131, 22);
            this.mnuParametresFlash.Text = "Flash";
            // 
            // mnuFlashActive
            // 
            this.mnuFlashActive.CheckOnClick = true;
            this.mnuFlashActive.Name = "mnuFlashActive";
            this.mnuFlashActive.Size = new System.Drawing.Size(124, 22);
            this.mnuFlashActive.Text = "Activé";
            this.mnuFlashActive.Click += new System.EventHandler(this.mnuFlashActive_Click);
            // 
            // mnuFlashDesactive
            // 
            this.mnuFlashDesactive.Checked = true;
            this.mnuFlashDesactive.CheckOnClick = true;
            this.mnuFlashDesactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFlashDesactive.Name = "mnuFlashDesactive";
            this.mnuFlashDesactive.Size = new System.Drawing.Size(124, 22);
            this.mnuFlashDesactive.Text = "Désactivé";
            this.mnuFlashDesactive.Click += new System.EventHandler(this.mnuFlashDesactive_Click);
            // 
            // mnuSpecial
            // 
            this.mnuSpecial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpecialVoirDeFace,
            this.mnuSpecialVoirDeDos});
            this.mnuSpecial.Name = "mnuSpecial";
            this.mnuSpecial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpecial.Text = "&Spécial";
            // 
            // mnuSpecialVoirDeFace
            // 
            this.mnuSpecialVoirDeFace.Name = "mnuSpecialVoirDeFace";
            this.mnuSpecialVoirDeFace.Size = new System.Drawing.Size(135, 22);
            this.mnuSpecialVoirDeFace.Text = "Voir de face";
            this.mnuSpecialVoirDeFace.Click += new System.EventHandler(this.mnuSpecialVoirDeFace_Click);
            // 
            // mnuSpecialVoirDeDos
            // 
            this.mnuSpecialVoirDeDos.Checked = true;
            this.mnuSpecialVoirDeDos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSpecialVoirDeDos.Name = "mnuSpecialVoirDeDos";
            this.mnuSpecialVoirDeDos.Size = new System.Drawing.Size(135, 22);
            this.mnuSpecialVoirDeDos.Text = "Voir de dos";
            this.mnuSpecialVoirDeDos.Click += new System.EventHandler(this.mnuSpecialVoirDeDos_Click);
            // 
            // btnPrendreUnePhoto
            // 
            this.btnPrendreUnePhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnPrendreUnePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrendreUnePhoto.Location = new System.Drawing.Point(332, 100);
            this.btnPrendreUnePhoto.Name = "btnPrendreUnePhoto";
            this.btnPrendreUnePhoto.Size = new System.Drawing.Size(50, 28);
            this.btnPrendreUnePhoto.TabIndex = 1;
            this.tltCamera.SetToolTip(this.btnPrendreUnePhoto, "Prendre une photo");
            this.btnPrendreUnePhoto.UseVisualStyleBackColor = false;
            this.btnPrendreUnePhoto.Click += new System.EventHandler(this.mnuEditionPrendreUnePhoto_Click);
            // 
            // grpInfosCarteMemoire
            // 
            this.grpInfosCarteMemoire.BackColor = System.Drawing.Color.Transparent;
            this.grpInfosCarteMemoire.Controls.Add(this.lblEspace);
            this.grpInfosCarteMemoire.Controls.Add(this.lblEspaceDisponible);
            this.grpInfosCarteMemoire.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfosCarteMemoire.ForeColor = System.Drawing.Color.PowderBlue;
            this.grpInfosCarteMemoire.Location = new System.Drawing.Point(54, 266);
            this.grpInfosCarteMemoire.Name = "grpInfosCarteMemoire";
            this.grpInfosCarteMemoire.Size = new System.Drawing.Size(299, 45);
            this.grpInfosCarteMemoire.TabIndex = 15;
            this.grpInfosCarteMemoire.TabStop = false;
            this.grpInfosCarteMemoire.Text = "Infos Carte Mémoire";
            this.grpInfosCarteMemoire.Visible = false;
            // 
            // lblEspace
            // 
            this.lblEspace.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspace.ForeColor = System.Drawing.Color.LightBlue;
            this.lblEspace.Location = new System.Drawing.Point(5, 21);
            this.lblEspace.Name = "lblEspace";
            this.lblEspace.Size = new System.Drawing.Size(152, 18);
            this.lblEspace.TabIndex = 16;
            this.lblEspace.Text = "Espace disponible : ";
            // 
            // lblEspaceDisponible
            // 
            this.lblEspaceDisponible.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspaceDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblEspaceDisponible.Location = new System.Drawing.Point(161, 21);
            this.lblEspaceDisponible.Name = "lblEspaceDisponible";
            this.lblEspaceDisponible.Size = new System.Drawing.Size(122, 18);
            this.lblEspaceDisponible.TabIndex = 15;
            // 
            // btnQualiteSuivante
            // 
            this.btnQualiteSuivante.BackColor = System.Drawing.Color.Transparent;
            this.btnQualiteSuivante.ContextMenuStrip = this.ctmQualite;
            this.btnQualiteSuivante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQualiteSuivante.Location = new System.Drawing.Point(491, 190);
            this.btnQualiteSuivante.Name = "btnQualiteSuivante";
            this.btnQualiteSuivante.Size = new System.Drawing.Size(35, 36);
            this.btnQualiteSuivante.TabIndex = 24;
            this.tltCamera.SetToolTip(this.btnQualiteSuivante, "Passer à la qualité suivante");
            this.btnQualiteSuivante.UseVisualStyleBackColor = false;
            this.btnQualiteSuivante.Click += new System.EventHandler(this.btnQualiteSuivante_Click);
            // 
            // ctmQualite
            // 
            this.ctmQualite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmQualiteExcellente,
            this.ctmQualiteBonne,
            this.ctmQualiteMoyenne,
            this.ctmQualiteFaible});
            this.ctmQualite.Name = "ctmQualite";
            this.ctmQualite.Size = new System.Drawing.Size(128, 92);
            // 
            // ctmQualiteExcellente
            // 
            this.ctmQualiteExcellente.Checked = true;
            this.ctmQualiteExcellente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctmQualiteExcellente.Name = "ctmQualiteExcellente";
            this.ctmQualiteExcellente.Size = new System.Drawing.Size(127, 22);
            this.ctmQualiteExcellente.Text = "Excellente";
            this.ctmQualiteExcellente.Click += new System.EventHandler(this.mnuQualiteExcellente_Click);
            // 
            // ctmQualiteBonne
            // 
            this.ctmQualiteBonne.Name = "ctmQualiteBonne";
            this.ctmQualiteBonne.Size = new System.Drawing.Size(127, 22);
            this.ctmQualiteBonne.Text = "Bonne";
            this.ctmQualiteBonne.Click += new System.EventHandler(this.mnuQualiteBonne_Click);
            // 
            // ctmQualiteMoyenne
            // 
            this.ctmQualiteMoyenne.Name = "ctmQualiteMoyenne";
            this.ctmQualiteMoyenne.Size = new System.Drawing.Size(127, 22);
            this.ctmQualiteMoyenne.Text = "Moyenne";
            this.ctmQualiteMoyenne.Click += new System.EventHandler(this.mnuQualiteMoyenne_Click);
            // 
            // ctmQualiteFaible
            // 
            this.ctmQualiteFaible.Name = "ctmQualiteFaible";
            this.ctmQualiteFaible.Size = new System.Drawing.Size(127, 22);
            this.ctmQualiteFaible.Text = "Faible";
            this.ctmQualiteFaible.Click += new System.EventHandler(this.mnuQualiteFaible_Click);
            // 
            // btnDimensionSuivante
            // 
            this.btnDimensionSuivante.BackColor = System.Drawing.Color.Transparent;
            this.btnDimensionSuivante.ContextMenuStrip = this.ctmDimension;
            this.btnDimensionSuivante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDimensionSuivante.Location = new System.Drawing.Point(413, 190);
            this.btnDimensionSuivante.Name = "btnDimensionSuivante";
            this.btnDimensionSuivante.Size = new System.Drawing.Size(35, 36);
            this.btnDimensionSuivante.TabIndex = 23;
            this.tltCamera.SetToolTip(this.btnDimensionSuivante, "Passer à la dimension suivante");
            this.btnDimensionSuivante.UseVisualStyleBackColor = false;
            this.btnDimensionSuivante.Click += new System.EventHandler(this.btnDimensionSuivante_Click);
            // 
            // ctmDimension
            // 
            this.ctmDimension.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmDimensionMaximale,
            this.ctmDimensionLarge,
            this.ctmDimensionGrande,
            this.ctmDimensionMoyenne,
            this.ctmDimensionPetite});
            this.ctmDimension.Name = "ctmDimension";
            this.ctmDimension.Size = new System.Drawing.Size(127, 114);
            // 
            // ctmDimensionMaximale
            // 
            this.ctmDimensionMaximale.Checked = true;
            this.ctmDimensionMaximale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctmDimensionMaximale.Name = "ctmDimensionMaximale";
            this.ctmDimensionMaximale.Size = new System.Drawing.Size(126, 22);
            this.ctmDimensionMaximale.Text = "Maximale";
            this.ctmDimensionMaximale.Click += new System.EventHandler(this.mnuDimensionMaximale_Click);
            // 
            // ctmDimensionLarge
            // 
            this.ctmDimensionLarge.Name = "ctmDimensionLarge";
            this.ctmDimensionLarge.Size = new System.Drawing.Size(126, 22);
            this.ctmDimensionLarge.Text = "Large";
            this.ctmDimensionLarge.Click += new System.EventHandler(this.mnuDimensionLarge_Click);
            // 
            // ctmDimensionGrande
            // 
            this.ctmDimensionGrande.Name = "ctmDimensionGrande";
            this.ctmDimensionGrande.Size = new System.Drawing.Size(126, 22);
            this.ctmDimensionGrande.Text = "Grande";
            this.ctmDimensionGrande.Click += new System.EventHandler(this.mnuDimensionGrande_Click);
            // 
            // ctmDimensionMoyenne
            // 
            this.ctmDimensionMoyenne.Name = "ctmDimensionMoyenne";
            this.ctmDimensionMoyenne.Size = new System.Drawing.Size(126, 22);
            this.ctmDimensionMoyenne.Text = "Moyenne";
            this.ctmDimensionMoyenne.Click += new System.EventHandler(this.mnuDimensionMoyenne_Click);
            // 
            // ctmDimensionPetite
            // 
            this.ctmDimensionPetite.Name = "ctmDimensionPetite";
            this.ctmDimensionPetite.Size = new System.Drawing.Size(126, 22);
            this.ctmDimensionPetite.Text = "Petite";
            this.ctmDimensionPetite.Click += new System.EventHandler(this.mnuDimensionPetite_Click);
            // 
            // btnSensibiliteSuivante
            // 
            this.btnSensibiliteSuivante.BackColor = System.Drawing.Color.Transparent;
            this.btnSensibiliteSuivante.ContextMenuStrip = this.ctmSensibilite;
            this.btnSensibiliteSuivante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSensibiliteSuivante.Location = new System.Drawing.Point(492, 359);
            this.btnSensibiliteSuivante.Name = "btnSensibiliteSuivante";
            this.btnSensibiliteSuivante.Size = new System.Drawing.Size(33, 32);
            this.btnSensibiliteSuivante.TabIndex = 20;
            this.tltCamera.SetToolTip(this.btnSensibiliteSuivante, "Passer à la sensisibilité ISO suivante");
            this.btnSensibiliteSuivante.UseVisualStyleBackColor = false;
            this.btnSensibiliteSuivante.Click += new System.EventHandler(this.btnSensibiliteSuivante_Click);
            // 
            // ctmSensibilite
            // 
            this.ctmSensibilite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmSensibilite64,
            this.ctmSensibilite100,
            this.ctmSensibilite200,
            this.ctmSensibilite400,
            this.ctmSensibilite800});
            this.ctmSensibilite.Name = "ctmSensibilite";
            this.ctmSensibilite.Size = new System.Drawing.Size(114, 114);
            // 
            // ctmSensibilite64
            // 
            this.ctmSensibilite64.Name = "ctmSensibilite64";
            this.ctmSensibilite64.Size = new System.Drawing.Size(113, 22);
            this.ctmSensibilite64.Text = "ISO 64";
            this.ctmSensibilite64.Click += new System.EventHandler(this.mnuSensibiliteISO64_Click);
            // 
            // ctmSensibilite100
            // 
            this.ctmSensibilite100.Checked = true;
            this.ctmSensibilite100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctmSensibilite100.Name = "ctmSensibilite100";
            this.ctmSensibilite100.Size = new System.Drawing.Size(113, 22);
            this.ctmSensibilite100.Text = "ISO 100";
            this.ctmSensibilite100.Click += new System.EventHandler(this.mnuSensibiliteISO100_Click);
            // 
            // ctmSensibilite200
            // 
            this.ctmSensibilite200.Name = "ctmSensibilite200";
            this.ctmSensibilite200.Size = new System.Drawing.Size(113, 22);
            this.ctmSensibilite200.Text = "ISO 200";
            this.ctmSensibilite200.Click += new System.EventHandler(this.mnuSensibiliteISO200_Click);
            // 
            // ctmSensibilite400
            // 
            this.ctmSensibilite400.Name = "ctmSensibilite400";
            this.ctmSensibilite400.Size = new System.Drawing.Size(113, 22);
            this.ctmSensibilite400.Text = "ISO 400";
            this.ctmSensibilite400.Click += new System.EventHandler(this.mnuSensibiliteISO400_Click);
            // 
            // ctmSensibilite800
            // 
            this.ctmSensibilite800.Name = "ctmSensibilite800";
            this.ctmSensibilite800.Size = new System.Drawing.Size(113, 22);
            this.ctmSensibilite800.Text = "ISO 800";
            this.ctmSensibilite800.Click += new System.EventHandler(this.mnuSensibiliteISO800_Click);
            // 
            // btnFlash
            // 
            this.btnFlash.BackColor = System.Drawing.Color.Transparent;
            this.btnFlash.ContextMenuStrip = this.ctmFlash;
            this.btnFlash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFlash.Location = new System.Drawing.Point(414, 359);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(34, 32);
            this.btnFlash.TabIndex = 19;
            this.tltCamera.SetToolTip(this.btnFlash, "Activer/désactiver le flash");
            this.btnFlash.UseVisualStyleBackColor = false;
            this.btnFlash.Click += new System.EventHandler(this.btnBasculerFlash_Click);
            // 
            // ctmFlash
            // 
            this.ctmFlash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmFlashActive,
            this.ctmFlashDesactive});
            this.ctmFlash.Name = "ctmFlash";
            this.ctmFlash.Size = new System.Drawing.Size(125, 48);
            // 
            // ctmFlashActive
            // 
            this.ctmFlashActive.Name = "ctmFlashActive";
            this.ctmFlashActive.Size = new System.Drawing.Size(124, 22);
            this.ctmFlashActive.Text = "Activé";
            this.ctmFlashActive.Click += new System.EventHandler(this.mnuFlashActive_Click);
            // 
            // ctmFlashDesactive
            // 
            this.ctmFlashDesactive.Checked = true;
            this.ctmFlashDesactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctmFlashDesactive.Name = "ctmFlashDesactive";
            this.ctmFlashDesactive.Size = new System.Drawing.Size(124, 22);
            this.ctmFlashDesactive.Text = "Désactivé";
            this.ctmFlashDesactive.Click += new System.EventHandler(this.mnuFlashDesactive_Click);
            // 
            // btnPhotoSuivante
            // 
            this.btnPhotoSuivante.BackColor = System.Drawing.Color.Transparent;
            this.btnPhotoSuivante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhotoSuivante.Location = new System.Drawing.Point(491, 281);
            this.btnPhotoSuivante.Name = "btnPhotoSuivante";
            this.btnPhotoSuivante.Size = new System.Drawing.Size(18, 21);
            this.btnPhotoSuivante.TabIndex = 18;
            this.tltCamera.SetToolTip(this.btnPhotoSuivante, "Visualiser la photo suivante");
            this.btnPhotoSuivante.UseVisualStyleBackColor = false;
            this.btnPhotoSuivante.Click += new System.EventHandler(this.mnuEditionPhotoSuivante_Click);
            // 
            // btnPhotoPrecedente
            // 
            this.btnPhotoPrecedente.BackColor = System.Drawing.Color.Transparent;
            this.btnPhotoPrecedente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhotoPrecedente.Location = new System.Drawing.Point(432, 281);
            this.btnPhotoPrecedente.Name = "btnPhotoPrecedente";
            this.btnPhotoPrecedente.Size = new System.Drawing.Size(18, 21);
            this.btnPhotoPrecedente.TabIndex = 17;
            this.tltCamera.SetToolTip(this.btnPhotoPrecedente, "Visualiser la photo précédente");
            this.btnPhotoPrecedente.UseVisualStyleBackColor = false;
            this.btnPhotoPrecedente.Click += new System.EventHandler(this.mnuEditionPhotoPrecedente_Click);
            // 
            // btnSupprimerPhoto
            // 
            this.btnSupprimerPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimerPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimerPhoto.Location = new System.Drawing.Point(48, 101);
            this.btnSupprimerPhoto.Name = "btnSupprimerPhoto";
            this.btnSupprimerPhoto.Size = new System.Drawing.Size(30, 28);
            this.btnSupprimerPhoto.TabIndex = 0;
            this.tltCamera.SetToolTip(this.btnSupprimerPhoto, "Supprimer la photo courante");
            this.btnSupprimerPhoto.UseVisualStyleBackColor = false;
            this.btnSupprimerPhoto.Click += new System.EventHandler(this.mnuEditionSupprimerPhoto_Click);
            // 
            // grpInfoPhoto
            // 
            this.grpInfoPhoto.BackColor = System.Drawing.Color.Transparent;
            this.grpInfoPhoto.Controls.Add(this.lblTailleEnOctets);
            this.grpInfoPhoto.Controls.Add(this.lblDimPhoto);
            this.grpInfoPhoto.Controls.Add(this.lblF2);
            this.grpInfoPhoto.Controls.Add(this.lblSensPhoto);
            this.grpInfoPhoto.Controls.Add(this.lblPriseLe);
            this.grpInfoPhoto.Controls.Add(this.lblPhotoCourante);
            this.grpInfoPhoto.Controls.Add(this.lblPhotoDate);
            this.grpInfoPhoto.Controls.Add(this.lblPhotoFlash);
            this.grpInfoPhoto.Controls.Add(this.lblPhotoTailleEnPixels);
            this.grpInfoPhoto.Controls.Add(this.lblPhotoSensibilite);
            this.grpInfoPhoto.Controls.Add(this.lblPhotoTailleEnOctets);
            this.grpInfoPhoto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoPhoto.ForeColor = System.Drawing.Color.PowderBlue;
            this.grpInfoPhoto.Location = new System.Drawing.Point(53, 313);
            this.grpInfoPhoto.Name = "grpInfoPhoto";
            this.grpInfoPhoto.Size = new System.Drawing.Size(299, 91);
            this.grpInfoPhoto.TabIndex = 15;
            this.grpInfoPhoto.TabStop = false;
            this.grpInfoPhoto.Text = "Infos Photo";
            this.grpInfoPhoto.Visible = false;
            // 
            // lblTailleEnOctets
            // 
            this.lblTailleEnOctets.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTailleEnOctets.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTailleEnOctets.Location = new System.Drawing.Point(5, 70);
            this.lblTailleEnOctets.Name = "lblTailleEnOctets";
            this.lblTailleEnOctets.Size = new System.Drawing.Size(106, 18);
            this.lblTailleEnOctets.TabIndex = 20;
            this.lblTailleEnOctets.Text = "Taille octets :";
            // 
            // lblDimPhoto
            // 
            this.lblDimPhoto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimPhoto.ForeColor = System.Drawing.Color.LightBlue;
            this.lblDimPhoto.Location = new System.Drawing.Point(5, 54);
            this.lblDimPhoto.Name = "lblDimPhoto";
            this.lblDimPhoto.Size = new System.Drawing.Size(100, 18);
            this.lblDimPhoto.TabIndex = 19;
            this.lblDimPhoto.Text = "Dimension :";
            // 
            // lblF2
            // 
            this.lblF2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF2.ForeColor = System.Drawing.Color.LightBlue;
            this.lblF2.Location = new System.Drawing.Point(161, 37);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(58, 18);
            this.lblF2.TabIndex = 18;
            this.lblF2.Text = "Flash :";
            // 
            // lblSensPhoto
            // 
            this.lblSensPhoto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensPhoto.ForeColor = System.Drawing.Color.LightBlue;
            this.lblSensPhoto.Location = new System.Drawing.Point(5, 37);
            this.lblSensPhoto.Name = "lblSensPhoto";
            this.lblSensPhoto.Size = new System.Drawing.Size(92, 18);
            this.lblSensPhoto.TabIndex = 17;
            this.lblSensPhoto.Text = "Sensibilite :";
            // 
            // lblPriseLe
            // 
            this.lblPriseLe.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriseLe.ForeColor = System.Drawing.Color.LightBlue;
            this.lblPriseLe.Location = new System.Drawing.Point(5, 19);
            this.lblPriseLe.Name = "lblPriseLe";
            this.lblPriseLe.Size = new System.Drawing.Size(74, 18);
            this.lblPriseLe.TabIndex = 16;
            this.lblPriseLe.Text = "Prise le : ";
            // 
            // lblPhotoCourante
            // 
            this.lblPhotoCourante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoCourante.ForeColor = System.Drawing.Color.LightBlue;
            this.lblPhotoCourante.Location = new System.Drawing.Point(228, 70);
            this.lblPhotoCourante.Name = "lblPhotoCourante";
            this.lblPhotoCourante.Size = new System.Drawing.Size(71, 18);
            this.lblPhotoCourante.TabIndex = 14;
            this.lblPhotoCourante.Text = "999/999     ";
            this.lblPhotoCourante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhotoDate
            // 
            this.lblPhotoDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPhotoDate.Location = new System.Drawing.Point(83, 19);
            this.lblPhotoDate.Name = "lblPhotoDate";
            this.lblPhotoDate.Size = new System.Drawing.Size(206, 18);
            this.lblPhotoDate.TabIndex = 15;
            // 
            // lblPhotoFlash
            // 
            this.lblPhotoFlash.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoFlash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPhotoFlash.Location = new System.Drawing.Point(215, 37);
            this.lblPhotoFlash.Name = "lblPhotoFlash";
            this.lblPhotoFlash.Size = new System.Drawing.Size(97, 18);
            this.lblPhotoFlash.TabIndex = 13;
            // 
            // lblPhotoTailleEnPixels
            // 
            this.lblPhotoTailleEnPixels.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoTailleEnPixels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPhotoTailleEnPixels.Location = new System.Drawing.Point(105, 54);
            this.lblPhotoTailleEnPixels.Name = "lblPhotoTailleEnPixels";
            this.lblPhotoTailleEnPixels.Size = new System.Drawing.Size(179, 18);
            this.lblPhotoTailleEnPixels.TabIndex = 10;
            // 
            // lblPhotoSensibilite
            // 
            this.lblPhotoSensibilite.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoSensibilite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPhotoSensibilite.Location = new System.Drawing.Point(97, 37);
            this.lblPhotoSensibilite.Name = "lblPhotoSensibilite";
            this.lblPhotoSensibilite.Size = new System.Drawing.Size(66, 18);
            this.lblPhotoSensibilite.TabIndex = 12;
            // 
            // lblPhotoTailleEnOctets
            // 
            this.lblPhotoTailleEnOctets.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoTailleEnOctets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPhotoTailleEnOctets.Location = new System.Drawing.Point(109, 70);
            this.lblPhotoTailleEnOctets.Name = "lblPhotoTailleEnOctets";
            this.lblPhotoTailleEnOctets.Size = new System.Drawing.Size(124, 18);
            this.lblPhotoTailleEnOctets.TabIndex = 11;
            // 
            // grpInfosCamera
            // 
            this.grpInfosCamera.BackColor = System.Drawing.Color.Transparent;
            this.grpInfosCamera.Controls.Add(this.lblCM);
            this.grpInfosCamera.Controls.Add(this.lblQualite);
            this.grpInfosCamera.Controls.Add(this.lblDimCamera);
            this.grpInfosCamera.Controls.Add(this.lblCameraDimension);
            this.grpInfosCamera.Controls.Add(this.lblCameraQualite);
            this.grpInfosCamera.Controls.Add(this.lblF1);
            this.grpInfosCamera.Controls.Add(this.lblCameraCarteMemoire);
            this.grpInfosCamera.Controls.Add(this.lblCameraSensibilite);
            this.grpInfosCamera.Controls.Add(this.lblSensCamera);
            this.grpInfosCamera.Controls.Add(this.lblCameraFlash);
            this.grpInfosCamera.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfosCamera.ForeColor = System.Drawing.Color.PowderBlue;
            this.grpInfosCamera.Location = new System.Drawing.Point(54, 170);
            this.grpInfosCamera.Name = "grpInfosCamera";
            this.grpInfosCamera.Size = new System.Drawing.Size(299, 93);
            this.grpInfosCamera.TabIndex = 14;
            this.grpInfosCamera.TabStop = false;
            this.grpInfosCamera.Text = "Infos Caméra";
            this.grpInfosCamera.Visible = false;
            // 
            // lblCM
            // 
            this.lblCM.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCM.ForeColor = System.Drawing.Color.LightBlue;
            this.lblCM.Location = new System.Drawing.Point(4, 19);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(125, 18);
            this.lblCM.TabIndex = 18;
            this.lblCM.Text = "Carte Mémoire :";
            // 
            // lblQualite
            // 
            this.lblQualite.ContextMenuStrip = this.ctmQualite;
            this.lblQualite.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualite.ForeColor = System.Drawing.Color.LightBlue;
            this.lblQualite.Location = new System.Drawing.Point(4, 72);
            this.lblQualite.Name = "lblQualite";
            this.lblQualite.Size = new System.Drawing.Size(73, 18);
            this.lblQualite.TabIndex = 15;
            this.lblQualite.Text = "Qualite :";
            // 
            // lblDimCamera
            // 
            this.lblDimCamera.ContextMenuStrip = this.ctmDimension;
            this.lblDimCamera.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimCamera.ForeColor = System.Drawing.Color.LightBlue;
            this.lblDimCamera.Location = new System.Drawing.Point(4, 55);
            this.lblDimCamera.Name = "lblDimCamera";
            this.lblDimCamera.Size = new System.Drawing.Size(99, 18);
            this.lblDimCamera.TabIndex = 14;
            this.lblDimCamera.Text = "Dimension :";
            // 
            // lblCameraDimension
            // 
            this.lblCameraDimension.ContextMenuStrip = this.ctmDimension;
            this.lblCameraDimension.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraDimension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCameraDimension.Location = new System.Drawing.Point(100, 55);
            this.lblCameraDimension.Name = "lblCameraDimension";
            this.lblCameraDimension.Size = new System.Drawing.Size(188, 18);
            this.lblCameraDimension.TabIndex = 10;
            // 
            // lblCameraQualite
            // 
            this.lblCameraQualite.ContextMenuStrip = this.ctmQualite;
            this.lblCameraQualite.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraQualite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCameraQualite.Location = new System.Drawing.Point(78, 72);
            this.lblCameraQualite.Name = "lblCameraQualite";
            this.lblCameraQualite.Size = new System.Drawing.Size(210, 18);
            this.lblCameraQualite.TabIndex = 11;
            // 
            // lblF1
            // 
            this.lblF1.ContextMenuStrip = this.ctmFlash;
            this.lblF1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF1.ForeColor = System.Drawing.Color.LightBlue;
            this.lblF1.Location = new System.Drawing.Point(158, 37);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(58, 18);
            this.lblF1.TabIndex = 17;
            this.lblF1.Text = "Flash :";
            // 
            // lblCameraCarteMemoire
            // 
            this.lblCameraCarteMemoire.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraCarteMemoire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCameraCarteMemoire.Location = new System.Drawing.Point(136, 19);
            this.lblCameraCarteMemoire.Name = "lblCameraCarteMemoire";
            this.lblCameraCarteMemoire.Size = new System.Drawing.Size(152, 18);
            this.lblCameraCarteMemoire.TabIndex = 9;
            // 
            // lblCameraSensibilite
            // 
            this.lblCameraSensibilite.ContextMenuStrip = this.ctmSensibilite;
            this.lblCameraSensibilite.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraSensibilite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCameraSensibilite.Location = new System.Drawing.Point(96, 37);
            this.lblCameraSensibilite.Name = "lblCameraSensibilite";
            this.lblCameraSensibilite.Size = new System.Drawing.Size(66, 18);
            this.lblCameraSensibilite.TabIndex = 12;
            this.lblCameraSensibilite.Click += new System.EventHandler(this.lblCameraSensibilite_Click);
            // 
            // lblSensCamera
            // 
            this.lblSensCamera.ContextMenuStrip = this.ctmSensibilite;
            this.lblSensCamera.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensCamera.ForeColor = System.Drawing.Color.LightBlue;
            this.lblSensCamera.Location = new System.Drawing.Point(4, 37);
            this.lblSensCamera.Name = "lblSensCamera";
            this.lblSensCamera.Size = new System.Drawing.Size(92, 18);
            this.lblSensCamera.TabIndex = 16;
            this.lblSensCamera.Text = "Sensibilite :";
            // 
            // lblCameraFlash
            // 
            this.lblCameraFlash.ContextMenuStrip = this.ctmFlash;
            this.lblCameraFlash.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraFlash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCameraFlash.Location = new System.Drawing.Point(212, 37);
            this.lblCameraFlash.Name = "lblCameraFlash";
            this.lblCameraFlash.Size = new System.Drawing.Size(89, 18);
            this.lblCameraFlash.TabIndex = 13;
            // 
            // picCameraDeFace
            // 
            this.picCameraDeFace.Image = global::AppCamera.Properties.Resources.CameraFace;
            this.picCameraDeFace.Location = new System.Drawing.Point(0, 625);
            this.picCameraDeFace.Name = "picCameraDeFace";
            this.picCameraDeFace.Size = new System.Drawing.Size(576, 443);
            this.picCameraDeFace.TabIndex = 6;
            this.picCameraDeFace.TabStop = false;
            // 
            // radCarteMemoire0Mo
            // 
            this.radCarteMemoire0Mo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCarteMemoire0Mo.Checked = true;
            this.radCarteMemoire0Mo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radCarteMemoire0Mo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radCarteMemoire0Mo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.radCarteMemoire0Mo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radCarteMemoire0Mo.ImageIndex = 4;
            this.radCarteMemoire0Mo.ImageList = this.imlCartesMemoires;
            this.radCarteMemoire0Mo.Location = new System.Drawing.Point(596, 40);
            this.radCarteMemoire0Mo.Name = "radCarteMemoire0Mo";
            this.radCarteMemoire0Mo.Size = new System.Drawing.Size(78, 96);
            this.radCarteMemoire0Mo.TabIndex = 10;
            this.radCarteMemoire0Mo.TabStop = true;
            this.tltCamera.SetToolTip(this.radCarteMemoire0Mo, "Éjecter la carte mémoire de la caméra");
            this.radCarteMemoire0Mo.UseVisualStyleBackColor = true;
            this.radCarteMemoire0Mo.CheckedChanged += new System.EventHandler(this.radCarteMemoire0Mo_CheckedChanged);
            // 
            // imlCartesMemoires
            // 
            this.imlCartesMemoires.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlCartesMemoires.ImageStream")));
            this.imlCartesMemoires.TransparentColor = System.Drawing.Color.Transparent;
            this.imlCartesMemoires.Images.SetKeyName(0, "SanDisk0Mo.bmp");
            this.imlCartesMemoires.Images.SetKeyName(1, "SanDisk32Mo.bmp");
            this.imlCartesMemoires.Images.SetKeyName(2, "SanDisk1Go.bmp");
            this.imlCartesMemoires.Images.SetKeyName(3, "SanDisk8GB.bmp");
            this.imlCartesMemoires.Images.SetKeyName(4, "SanDisk0MoPale.bmp");
            this.imlCartesMemoires.Images.SetKeyName(5, "SanDisk32MoPale.bmp");
            this.imlCartesMemoires.Images.SetKeyName(6, "SanDisk1GoPale.bmp");
            this.imlCartesMemoires.Images.SetKeyName(7, "SanDisk8GBPale.bmp");
            // 
            // radCarteMemoire1Go
            // 
            this.radCarteMemoire1Go.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCarteMemoire1Go.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radCarteMemoire1Go.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radCarteMemoire1Go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.radCarteMemoire1Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radCarteMemoire1Go.ImageIndex = 2;
            this.radCarteMemoire1Go.ImageList = this.imlCartesMemoires;
            this.radCarteMemoire1Go.Location = new System.Drawing.Point(596, 244);
            this.radCarteMemoire1Go.Name = "radCarteMemoire1Go";
            this.radCarteMemoire1Go.Size = new System.Drawing.Size(78, 96);
            this.radCarteMemoire1Go.TabIndex = 11;
            this.tltCamera.SetToolTip(this.radCarteMemoire1Go, "Introduire cette carte mémoire de 1Go dans la caméra");
            this.radCarteMemoire1Go.UseVisualStyleBackColor = true;
            this.radCarteMemoire1Go.CheckedChanged += new System.EventHandler(this.radCarteMemoire1Go_CheckedChanged);
            // 
            // radCarteMemoire32Mo
            // 
            this.radCarteMemoire32Mo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCarteMemoire32Mo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radCarteMemoire32Mo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radCarteMemoire32Mo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.radCarteMemoire32Mo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radCarteMemoire32Mo.ImageIndex = 1;
            this.radCarteMemoire32Mo.ImageList = this.imlCartesMemoires;
            this.radCarteMemoire32Mo.Location = new System.Drawing.Point(596, 142);
            this.radCarteMemoire32Mo.Name = "radCarteMemoire32Mo";
            this.radCarteMemoire32Mo.Size = new System.Drawing.Size(78, 96);
            this.radCarteMemoire32Mo.TabIndex = 12;
            this.tltCamera.SetToolTip(this.radCarteMemoire32Mo, "Introduire cette carte mémoire de 32Mo dans la caméra");
            this.radCarteMemoire32Mo.UseVisualStyleBackColor = true;
            this.radCarteMemoire32Mo.CheckedChanged += new System.EventHandler(this.radCarteMemoire32Mo_CheckedChanged);
            // 
            // radCarteMemoire8Go
            // 
            this.radCarteMemoire8Go.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCarteMemoire8Go.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radCarteMemoire8Go.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radCarteMemoire8Go.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radCarteMemoire8Go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.radCarteMemoire8Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radCarteMemoire8Go.ImageIndex = 3;
            this.radCarteMemoire8Go.ImageList = this.imlCartesMemoires;
            this.radCarteMemoire8Go.Location = new System.Drawing.Point(596, 346);
            this.radCarteMemoire8Go.Name = "radCarteMemoire8Go";
            this.radCarteMemoire8Go.Size = new System.Drawing.Size(78, 96);
            this.radCarteMemoire8Go.TabIndex = 13;
            this.tltCamera.SetToolTip(this.radCarteMemoire8Go, "Introduire cette carte mémoire de 8Go dans la caméra");
            this.radCarteMemoire8Go.UseVisualStyleBackColor = true;
            this.radCarteMemoire8Go.CheckedChanged += new System.EventHandler(this.radCarteMemoire8Go_CheckedChanged);
            // 
            // chkPower
            // 
            this.chkPower.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPower.BackColor = System.Drawing.Color.Transparent;
            this.chkPower.FlatAppearance.BorderSize = 0;
            this.chkPower.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkPower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkPower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPower.Location = new System.Drawing.Point(491, 120);
            this.chkPower.Name = "chkPower";
            this.chkPower.Size = new System.Drawing.Size(33, 28);
            this.chkPower.TabIndex = 25;
            this.tltCamera.SetToolTip(this.chkPower, "Allumer ou éteindre la caméra");
            this.chkPower.UseVisualStyleBackColor = false;
            this.chkPower.CheckedChanged += new System.EventHandler(this.chkPower_CheckedChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AppCamera.Properties.Resources.CameraDos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(696, 455);
            this.Controls.Add(this.chkPower);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.picCameraDeFace);
            this.Controls.Add(this.btnPhotoSuivante);
            this.Controls.Add(this.grpInfosCarteMemoire);
            this.Controls.Add(this.btnPhotoPrecedente);
            this.Controls.Add(this.btnPrendreUnePhoto);
            this.Controls.Add(this.btnSupprimerPhoto);
            this.Controls.Add(this.btnQualiteSuivante);
            this.Controls.Add(this.grpInfosCamera);
            this.Controls.Add(this.btnFlash);
            this.Controls.Add(this.grpInfoPhoto);
            this.Controls.Add(this.btnDimensionSuivante);
            this.Controls.Add(this.btnSensibiliteSuivante);
            this.Controls.Add(this.radCarteMemoire1Go);
            this.Controls.Add(this.radCarteMemoire32Mo);
            this.Controls.Add(this.radCarteMemoire0Mo);
            this.Controls.Add(this.radCarteMemoire8Go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Caméra Numérique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipalCamera_FormClosing);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.grpInfosCarteMemoire.ResumeLayout(false);
            this.ctmQualite.ResumeLayout(false);
            this.ctmDimension.ResumeLayout(false);
            this.ctmSensibilite.ResumeLayout(false);
            this.ctmFlash.ResumeLayout(false);
            this.grpInfoPhoto.ResumeLayout(false);
            this.grpInfosCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCameraDeFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecial;
        private System.Windows.Forms.PictureBox picCameraDeFace;
        private System.Windows.Forms.Button btnPrendreUnePhoto;
        private System.Windows.Forms.ToolStripMenuItem mnuParametres;
        private System.Windows.Forms.ToolStripMenuItem mnuParametresSensibilite;
        private System.Windows.Forms.ToolStripMenuItem mnuSensibiliteISO64;
        private System.Windows.Forms.ToolStripMenuItem mnuSensibiliteISO100;
        private System.Windows.Forms.ToolStripMenuItem mnuSensibiliteISO200;
        private System.Windows.Forms.ToolStripMenuItem mnuSensibiliteISO400;
        private System.Windows.Forms.ToolStripMenuItem mnuSensibiliteISO800;
        private System.Windows.Forms.ToolStripMenuItem mnuParametresFlash;
        private System.Windows.Forms.ToolStripMenuItem mnuFlashActive;
        private System.Windows.Forms.ToolStripMenuItem mnuFlashDesactive;
        private System.Windows.Forms.ToolStripMenuItem mnuParametresQualite;
        private System.Windows.Forms.ToolStripMenuItem mnuQualiteExcellente;
        private System.Windows.Forms.ToolStripMenuItem mnuQualiteBonne;
        private System.Windows.Forms.ToolStripMenuItem mnuQualiteMoyenne;
        private System.Windows.Forms.ToolStripMenuItem mnuQualiteFaible;
        private System.Windows.Forms.ToolStripMenuItem mnuParametresDimension;
        private System.Windows.Forms.ToolStripMenuItem mnuDimensionMaximale;
        private System.Windows.Forms.ToolStripMenuItem mnuDimensionLarge;
        private System.Windows.Forms.ToolStripMenuItem mnuDimensionGrande;
        private System.Windows.Forms.ToolStripMenuItem mnuDimensionMoyenne;
        private System.Windows.Forms.ToolStripMenuItem mnuDimensionPetite;
        private System.Windows.Forms.ToolStripMenuItem mnuEdition;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionPrendreUnePhoto;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionSupprimerPhoto;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionPhotoSuivante;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionPhotoPrecedente;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialVoirDeFace;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialVoirDeDos;
        private System.Windows.Forms.Label lblCameraQualite;
        private System.Windows.Forms.Label lblCameraDimension;
        private System.Windows.Forms.Label lblCameraCarteMemoire;
        private System.Windows.Forms.GroupBox grpInfosCamera;
        private System.Windows.Forms.Label lblCameraFlash;
        private System.Windows.Forms.Label lblCameraSensibilite;
        private System.Windows.Forms.GroupBox grpInfoPhoto;
        private System.Windows.Forms.Label lblPhotoCourante;
        private System.Windows.Forms.Label lblPhotoFlash;
        private System.Windows.Forms.Label lblPhotoTailleEnPixels;
        private System.Windows.Forms.Label lblPhotoSensibilite;
        private System.Windows.Forms.Label lblPhotoTailleEnOctets;
        private System.Windows.Forms.Label lblPhotoDate;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionViderLaCarteMemoire;
        private System.Windows.Forms.ToolStripSeparator mnuEditionSep1;
        private System.Windows.Forms.Button btnSupprimerPhoto;
        private System.Windows.Forms.Button btnSensibiliteSuivante;
        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.Button btnPhotoSuivante;
        private System.Windows.Forms.Button btnPhotoPrecedente;
        private System.Windows.Forms.Button btnQualiteSuivante;
        private System.Windows.Forms.Button btnDimensionSuivante;
        private System.Windows.Forms.ToolTip tltCamera;
        private System.Windows.Forms.RadioButton radCarteMemoire0Mo;
        private System.Windows.Forms.RadioButton radCarteMemoire1Go;
        private System.Windows.Forms.RadioButton radCarteMemoire32Mo;
        private System.Windows.Forms.RadioButton radCarteMemoire8Go;
        private System.Windows.Forms.GroupBox grpInfosCarteMemoire;
        private System.Windows.Forms.Label lblEspaceDisponible;
        private System.Windows.Forms.ContextMenuStrip ctmDimension;
        private System.Windows.Forms.ToolStripMenuItem ctmDimensionMaximale;
        private System.Windows.Forms.ToolStripMenuItem ctmDimensionLarge;
        private System.Windows.Forms.ToolStripMenuItem ctmDimensionGrande;
        private System.Windows.Forms.ToolStripMenuItem ctmDimensionMoyenne;
        private System.Windows.Forms.ToolStripMenuItem ctmDimensionPetite;
        private System.Windows.Forms.ContextMenuStrip ctmQualite;
        private System.Windows.Forms.ToolStripMenuItem ctmQualiteExcellente;
        private System.Windows.Forms.ToolStripMenuItem ctmQualiteBonne;
        private System.Windows.Forms.ToolStripMenuItem ctmQualiteMoyenne;
        private System.Windows.Forms.ToolStripMenuItem ctmQualiteFaible;
        private System.Windows.Forms.ContextMenuStrip ctmSensibilite;
        private System.Windows.Forms.ToolStripMenuItem ctmSensibilite64;
        private System.Windows.Forms.ToolStripMenuItem ctmSensibilite100;
        private System.Windows.Forms.ToolStripMenuItem ctmSensibilite200;
        private System.Windows.Forms.ToolStripMenuItem ctmSensibilite400;
        private System.Windows.Forms.ToolStripMenuItem ctmSensibilite800;
        private System.Windows.Forms.ContextMenuStrip ctmFlash;
        private System.Windows.Forms.ToolStripMenuItem ctmFlashActive;
        private System.Windows.Forms.ToolStripMenuItem ctmFlashDesactive;
        private System.Windows.Forms.ImageList imlCartesMemoires;
        private System.Windows.Forms.Label lblSensCamera;
        private System.Windows.Forms.Label lblQualite;
        private System.Windows.Forms.Label lblDimCamera;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Label lblEspace;
        private System.Windows.Forms.Label lblPriseLe;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.Label lblSensPhoto;
        private System.Windows.Forms.Label lblDimPhoto;
        private System.Windows.Forms.Label lblTailleEnOctets;
        private System.Windows.Forms.CheckBox chkPower;
    }
}

