
namespace Projet1_questions.ui.enseignant
{
    partial class PanneauInvitation
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAnnulerInv = new System.Windows.Forms.Button();
            this.DGVinvitation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEnvoyerInv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVEtuds = new System.Windows.Forms.DataGridView();
            this.id_etudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBgroupes = new System.Windows.Forms.ComboBox();
            this.TxtRecherche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_etud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVinvitation)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEtuds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnAnnulerInv);
            this.panel1.Controls.Add(this.DGVinvitation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 245);
            this.panel1.TabIndex = 0;
            // 
            // BtnAnnulerInv
            // 
            this.BtnAnnulerInv.Enabled = false;
            this.BtnAnnulerInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerInv.Location = new System.Drawing.Point(669, 201);
            this.BtnAnnulerInv.Name = "BtnAnnulerInv";
            this.BtnAnnulerInv.Size = new System.Drawing.Size(161, 32);
            this.BtnAnnulerInv.TabIndex = 6;
            this.BtnAnnulerInv.Text = "Annuler invitation";
            this.BtnAnnulerInv.UseVisualStyleBackColor = true;
            this.BtnAnnulerInv.Click += new System.EventHandler(this.BtnAnnulerInv_Click);
            // 
            // DGVinvitation
            // 
            this.DGVinvitation.AllowUserToAddRows = false;
            this.DGVinvitation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVinvitation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVinvitation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVinvitation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_etud,
            this.nom_prenom,
            this.id_groupe,
            this.titre,
            this.date,
            this.heure,
            this.commentaire});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVinvitation.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVinvitation.Location = new System.Drawing.Point(9, 45);
            this.DGVinvitation.Name = "DGVinvitation";
            this.DGVinvitation.Size = new System.Drawing.Size(821, 150);
            this.DGVinvitation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invitations envoyées (en cours)";
            // 
            // BtnEnvoyerInv
            // 
            this.BtnEnvoyerInv.Enabled = false;
            this.BtnEnvoyerInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnvoyerInv.Location = new System.Drawing.Point(669, 112);
            this.BtnEnvoyerInv.Name = "BtnEnvoyerInv";
            this.BtnEnvoyerInv.Size = new System.Drawing.Size(161, 32);
            this.BtnEnvoyerInv.TabIndex = 2;
            this.BtnEnvoyerInv.Text = "Envoyer invitation";
            this.BtnEnvoyerInv.UseVisualStyleBackColor = true;
            this.BtnEnvoyerInv.Click += new System.EventHandler(this.BtnEnvoyerInv_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.DGVEtuds);
            this.panel2.Controls.Add(this.BtnEnvoyerInv);
            this.panel2.Controls.Add(this.CBgroupes);
            this.panel2.Controls.Add(this.TxtRecherche);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 156);
            this.panel2.TabIndex = 3;
            // 
            // DGVEtuds
            // 
            this.DGVEtuds.AllowUserToAddRows = false;
            this.DGVEtuds.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEtuds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVEtuds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEtuds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_etudiant,
            this.nom,
            this.prenom,
            this.courriel});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVEtuds.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVEtuds.Location = new System.Drawing.Point(9, 11);
            this.DGVEtuds.Name = "DGVEtuds";
            this.DGVEtuds.Size = new System.Drawing.Size(821, 99);
            this.DGVEtuds.TabIndex = 6;
            // 
            // id_etudiant
            // 
            this.id_etudiant.HeaderText = "N DA";
            this.id_etudiant.Name = "id_etudiant";
            this.id_etudiant.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 185;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Width = 185;
            // 
            // courriel
            // 
            this.courriel.HeaderText = "Courriel";
            this.courriel.Name = "courriel";
            this.courriel.ReadOnly = true;
            this.courriel.Width = 254;
            // 
            // CBgroupes
            // 
            this.CBgroupes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBgroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBgroupes.FormattingEnabled = true;
            this.CBgroupes.Location = new System.Drawing.Point(419, 116);
            this.CBgroupes.Name = "CBgroupes";
            this.CBgroupes.Size = new System.Drawing.Size(188, 26);
            this.CBgroupes.TabIndex = 0;
            // 
            // TxtRecherche
            // 
            this.TxtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecherche.Location = new System.Drawing.Point(189, 116);
            this.TxtRecherche.Name = "TxtRecherche";
            this.TxtRecherche.Size = new System.Drawing.Size(189, 24);
            this.TxtRecherche.TabIndex = 4;
            this.TxtRecherche.TextChanged += new System.EventHandler(this.TxtRecherche_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rechercher etudiant :";
            // 
            // id_etud
            // 
            this.id_etud.HeaderText = "N DA";
            this.id_etud.Name = "id_etud";
            this.id_etud.ReadOnly = true;
            this.id_etud.Width = 95;
            // 
            // nom_prenom
            // 
            this.nom_prenom.HeaderText = "Nom & Prénom";
            this.nom_prenom.Name = "nom_prenom";
            this.nom_prenom.ReadOnly = true;
            this.nom_prenom.Width = 175;
            // 
            // id_groupe
            // 
            this.id_groupe.HeaderText = "ID groupe";
            this.id_groupe.Name = "id_groupe";
            this.id_groupe.ReadOnly = true;
            this.id_groupe.Width = 105;
            // 
            // titre
            // 
            this.titre.HeaderText = "Titre groupe";
            this.titre.Name = "titre";
            this.titre.ReadOnly = true;
            this.titre.Width = 175;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // heure
            // 
            this.heure.HeaderText = "Heure";
            this.heure.Name = "heure";
            this.heure.ReadOnly = true;
            this.heure.Width = 90;
            // 
            // commentaire
            // 
            this.commentaire.HeaderText = "Commentaire";
            this.commentaire.Name = "commentaire";
            this.commentaire.ReadOnly = true;
            this.commentaire.Width = 650;
            // 
            // PanneauInvitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(3, 50);
            this.Name = "PanneauInvitation";
            this.Size = new System.Drawing.Size(875, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVinvitation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEtuds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAnnulerInv;
        private System.Windows.Forms.DataGridView DGVinvitation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEnvoyerInv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBgroupes;
        private System.Windows.Forms.TextBox TxtRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVEtuds;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_etudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn courriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_etud;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaire;
    }
}
