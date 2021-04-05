namespace JeuEchec
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.ptbLogoMenu = new System.Windows.Forms.PictureBox();
            this.btnLancerPartie = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cmbJoueur1 = new System.Windows.Forms.ComboBox();
            this.cmbJoueur2 = new System.Windows.Forms.ComboBox();
            this.lblJoueur1 = new System.Windows.Forms.Label();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.btnCharger = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnModifierJoueur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.ptbLogoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLogoMenu
            // 
            this.ptbLogoMenu.Image = ((System.Drawing.Image) (resources.GetObject("ptbLogoMenu.Image")));
            this.ptbLogoMenu.Location = new System.Drawing.Point(88, 60);
            this.ptbLogoMenu.Name = "ptbLogoMenu";
            this.ptbLogoMenu.Size = new System.Drawing.Size(107, 99);
            this.ptbLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogoMenu.TabIndex = 0;
            this.ptbLogoMenu.TabStop = false;
            // 
            // btnLancerPartie
            // 
            this.btnLancerPartie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLancerPartie.Location = new System.Drawing.Point(43, 419);
            this.btnLancerPartie.Name = "btnLancerPartie";
            this.btnLancerPartie.Size = new System.Drawing.Size(191, 30);
            this.btnLancerPartie.TabIndex = 1;
            this.btnLancerPartie.Text = "Lancer une partie";
            this.btnLancerPartie.UseVisualStyleBackColor = false;
            this.btnLancerPartie.Click += new System.EventHandler(this.btnLancerPartie_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitre.Location = new System.Drawing.Point(53, 26);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(181, 31);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Jeu d\'échec";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbJoueur1
            // 
            this.cmbJoueur1.FormattingEnabled = true;
            this.cmbJoueur1.Location = new System.Drawing.Point(43, 213);
            this.cmbJoueur1.Name = "cmbJoueur1";
            this.cmbJoueur1.Size = new System.Drawing.Size(190, 21);
            this.cmbJoueur1.TabIndex = 3;
            this.cmbJoueur1.SelectedIndexChanged += new System.EventHandler(this.cmbJoueur1_SelectedIndexChanged);
            // 
            // cmbJoueur2
            // 
            this.cmbJoueur2.FormattingEnabled = true;
            this.cmbJoueur2.Location = new System.Drawing.Point(43, 293);
            this.cmbJoueur2.Name = "cmbJoueur2";
            this.cmbJoueur2.Size = new System.Drawing.Size(190, 21);
            this.cmbJoueur2.TabIndex = 4;
            this.cmbJoueur2.SelectedIndexChanged += new System.EventHandler(this.cmbJoueur2_SelectedIndexChanged);
            // 
            // lblJoueur1
            // 
            this.lblJoueur1.Location = new System.Drawing.Point(44, 195);
            this.lblJoueur1.Name = "lblJoueur1";
            this.lblJoueur1.Size = new System.Drawing.Size(96, 18);
            this.lblJoueur1.TabIndex = 5;
            this.lblJoueur1.Text = "Joueur #1";
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.Location = new System.Drawing.Point(45, 276);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(94, 17);
            this.lblJoueur2.TabIndex = 6;
            this.lblJoueur2.Text = "Joueur #2";
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(43, 390);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(84, 23);
            this.btnCharger.TabIndex = 7;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(149, 390);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(84, 23);
            this.btnSauvegarder.TabIndex = 8;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModifierJoueur
            // 
            this.btnModifierJoueur.Location = new System.Drawing.Point(43, 361);
            this.btnModifierJoueur.Name = "btnModifierJoueur";
            this.btnModifierJoueur.Size = new System.Drawing.Size(189, 23);
            this.btnModifierJoueur.TabIndex = 9;
            this.btnModifierJoueur.Text = "Modifier les joueurs";
            this.btnModifierJoueur.UseVisualStyleBackColor = true;
            this.btnModifierJoueur.Click += new System.EventHandler(this.btnModifierJoueur_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.btnModifierJoueur);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.lblJoueur2);
            this.Controls.Add(this.lblJoueur1);
            this.Controls.Add(this.cmbJoueur2);
            this.Controls.Add(this.cmbJoueur1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnLancerPartie);
            this.Controls.Add(this.ptbLogoMenu);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize) (this.ptbLogoMenu)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnModifierJoueur;

        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Button btnSauvegarder;
        
        private System.Windows.Forms.Label lblJoueur2;

        private System.Windows.Forms.ComboBox cmbJoueur2;
        private System.Windows.Forms.Label lblJoueur1;

        private System.Windows.Forms.ComboBox cmbJoueur1;

        private System.Windows.Forms.Label lblTitre;

        private System.Windows.Forms.Button btnLancerPartie;

        private System.Windows.Forms.PictureBox ptbLogoMenu;

        #endregion
    }
}