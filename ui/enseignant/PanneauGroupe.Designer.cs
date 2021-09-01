
namespace Projet1_questions.ui.enseignant
{
    partial class PanneauGroupe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVgroupe = new System.Windows.Forms.DataGridView();
            this.id_groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSerialiseGrEtd = new System.Windows.Forms.Button();
            this.BtnExportJSON = new System.Windows.Forms.Button();
            this.LblGroupeCour = new System.Windows.Forms.Label();
            this.DGVEtuds = new System.Windows.Forms.DataGridView();
            this.id_etudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.BtnExporterCsv = new System.Windows.Forms.Button();
            this.BtnImporterCsv = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVgroupe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEtuds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DGVgroupe);
            this.panel1.Controls.Add(this.BtnSupprimer);
            this.panel1.Controls.Add(this.BtnModifier);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnAjout);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 174);
            this.panel1.TabIndex = 0;
            // 
            // DGVgroupe
            // 
            this.DGVgroupe.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVgroupe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVgroupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVgroupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_groupe,
            this.titre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVgroupe.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVgroupe.Location = new System.Drawing.Point(9, 33);
            this.DGVgroupe.Name = "DGVgroupe";
            this.DGVgroupe.Size = new System.Drawing.Size(664, 131);
            this.DGVgroupe.TabIndex = 5;
            this.DGVgroupe.SelectionChanged += new System.EventHandler(this.DGVgroupe_SelectionChanged);
            // 
            // id_groupe
            // 
            this.id_groupe.HeaderText = "ID groupe";
            this.id_groupe.Name = "id_groupe";
            this.id_groupe.ReadOnly = true;
            this.id_groupe.Width = 121;
            // 
            // titre
            // 
            this.titre.HeaderText = "Titre";
            this.titre.Name = "titre";
            this.titre.ReadOnly = true;
            this.titre.Width = 490;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.Location = new System.Drawing.Point(690, 135);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(143, 29);
            this.BtnSupprimer.TabIndex = 5;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Location = new System.Drawing.Point(690, 84);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(143, 29);
            this.BtnModifier.TabIndex = 4;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des groupes :";
            // 
            // BtnAjout
            // 
            this.BtnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjout.Location = new System.Drawing.Point(690, 33);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(143, 29);
            this.BtnAjout.TabIndex = 2;
            this.BtnAjout.Text = "Créer";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des etudiants du groupe:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BtnImporterCsv);
            this.panel2.Controls.Add(this.BtnExporterCsv);
            this.panel2.Controls.Add(this.BtnSerialiseGrEtd);
            this.panel2.Controls.Add(this.BtnExportJSON);
            this.panel2.Controls.Add(this.LblGroupeCour);
            this.panel2.Controls.Add(this.DGVEtuds);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(14, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 232);
            this.panel2.TabIndex = 3;
            // 
            // BtnSerialiseGrEtd
            // 
            this.BtnSerialiseGrEtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSerialiseGrEtd.ForeColor = System.Drawing.Color.Red;
            this.BtnSerialiseGrEtd.Location = new System.Drawing.Point(141, 36);
            this.BtnSerialiseGrEtd.Name = "BtnSerialiseGrEtd";
            this.BtnSerialiseGrEtd.Size = new System.Drawing.Size(129, 30);
            this.BtnSerialiseGrEtd.TabIndex = 7;
            this.BtnSerialiseGrEtd.Text = "Serialiser groupe";
            this.BtnSerialiseGrEtd.UseVisualStyleBackColor = true;
            this.BtnSerialiseGrEtd.Click += new System.EventHandler(this.BtnSerialiseGrEtd_Click);
            // 
            // BtnExportJSON
            // 
            this.BtnExportJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportJSON.ForeColor = System.Drawing.Color.Red;
            this.BtnExportJSON.Location = new System.Drawing.Point(9, 36);
            this.BtnExportJSON.Name = "BtnExportJSON";
            this.BtnExportJSON.Size = new System.Drawing.Size(126, 30);
            this.BtnExportJSON.TabIndex = 6;
            this.BtnExportJSON.Text = "Exporter JSON";
            this.BtnExportJSON.UseVisualStyleBackColor = true;
            this.BtnExportJSON.Click += new System.EventHandler(this.BtnExportJSON_Click);
            // 
            // LblGroupeCour
            // 
            this.LblGroupeCour.AutoSize = true;
            this.LblGroupeCour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGroupeCour.ForeColor = System.Drawing.Color.Red;
            this.LblGroupeCour.Location = new System.Drawing.Point(720, 13);
            this.LblGroupeCour.MinimumSize = new System.Drawing.Size(110, 0);
            this.LblGroupeCour.Name = "LblGroupeCour";
            this.LblGroupeCour.Size = new System.Drawing.Size(110, 20);
            this.LblGroupeCour.TabIndex = 5;
            this.LblGroupeCour.Text = ".";
            this.LblGroupeCour.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DGVEtuds
            // 
            this.DGVEtuds.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEtuds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVEtuds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEtuds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_etudiant,
            this.nom,
            this.prenom,
            this.courriel});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVEtuds.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVEtuds.Location = new System.Drawing.Point(9, 72);
            this.DGVEtuds.Name = "DGVEtuds";
            this.DGVEtuds.Size = new System.Drawing.Size(821, 142);
            this.DGVEtuds.TabIndex = 0;
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
            // BtnExporterCsv
            // 
            this.BtnExporterCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExporterCsv.ForeColor = System.Drawing.Color.Red;
            this.BtnExporterCsv.Location = new System.Drawing.Point(429, 36);
            this.BtnExporterCsv.Name = "BtnExporterCsv";
            this.BtnExporterCsv.Size = new System.Drawing.Size(126, 30);
            this.BtnExporterCsv.TabIndex = 8;
            this.BtnExporterCsv.Text = "Exporter CSV";
            this.BtnExporterCsv.UseVisualStyleBackColor = true;
            this.BtnExporterCsv.Click += new System.EventHandler(this.BtnExporterCsv_Click);
            // 
            // BtnImporterCsv
            // 
            this.BtnImporterCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImporterCsv.ForeColor = System.Drawing.Color.Red;
            this.BtnImporterCsv.Location = new System.Drawing.Point(297, 36);
            this.BtnImporterCsv.Name = "BtnImporterCsv";
            this.BtnImporterCsv.Size = new System.Drawing.Size(126, 30);
            this.BtnImporterCsv.TabIndex = 9;
            this.BtnImporterCsv.Text = "Importer CSV";
            this.BtnImporterCsv.UseVisualStyleBackColor = true;
            this.BtnImporterCsv.Click += new System.EventHandler(this.BtnImporterCsv_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // PanneauGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(5, 55);
            this.Name = "PanneauGroupe";
            this.Size = new System.Drawing.Size(875, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVgroupe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEtuds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVEtuds;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_etudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn courriel;
        private System.Windows.Forms.DataGridView DGVgroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.Label LblGroupeCour;
        private System.Windows.Forms.Button BtnSerialiseGrEtd;
        private System.Windows.Forms.Button BtnExportJSON;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnImporterCsv;
        private System.Windows.Forms.Button BtnExporterCsv;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}
