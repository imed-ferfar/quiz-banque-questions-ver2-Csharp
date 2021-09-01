
namespace Projet1_questions.ui.etudiant
{
    partial class PanneauProfilEtud
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
            this.BtnModifMotPasse = new System.Windows.Forms.Button();
            this.LblMotPasse = new System.Windows.Forms.Label();
            this.TxtCourriel = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtDA = new System.Windows.Forms.TextBox();
            this.LblCourriel = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblDA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVgroupe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVinvitation = new System.Windows.Forms.DataGridView();
            this.BtnInvit = new System.Windows.Forms.Button();
            this.RBaccepter = new System.Windows.Forms.RadioButton();
            this.RBrejeter = new System.Windows.Forms.RadioButton();
            this.id_groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nom_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_grou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVgroupe)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVinvitation)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnModifMotPasse);
            this.panel1.Controls.Add(this.LblMotPasse);
            this.panel1.Controls.Add(this.TxtCourriel);
            this.panel1.Controls.Add(this.TxtPrenom);
            this.panel1.Controls.Add(this.TxtNom);
            this.panel1.Controls.Add(this.TxtDA);
            this.panel1.Controls.Add(this.LblCourriel);
            this.panel1.Controls.Add(this.LblPrenom);
            this.panel1.Controls.Add(this.LblNom);
            this.panel1.Controls.Add(this.LblDA);
            this.panel1.Location = new System.Drawing.Point(466, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 299);
            this.panel1.TabIndex = 1;
            // 
            // BtnModifMotPasse
            // 
            this.BtnModifMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifMotPasse.Location = new System.Drawing.Point(203, 224);
            this.BtnModifMotPasse.MinimumSize = new System.Drawing.Size(25, 25);
            this.BtnModifMotPasse.Name = "BtnModifMotPasse";
            this.BtnModifMotPasse.Size = new System.Drawing.Size(179, 25);
            this.BtnModifMotPasse.TabIndex = 12;
            this.BtnModifMotPasse.Text = "Modifier mot de passe";
            this.BtnModifMotPasse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModifMotPasse.UseVisualStyleBackColor = true;
            this.BtnModifMotPasse.Click += new System.EventHandler(this.BtnModifMotPasse_Click);
            // 
            // LblMotPasse
            // 
            this.LblMotPasse.AutoSize = true;
            this.LblMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotPasse.Location = new System.Drawing.Point(31, 226);
            this.LblMotPasse.Name = "LblMotPasse";
            this.LblMotPasse.Size = new System.Drawing.Size(120, 18);
            this.LblMotPasse.TabIndex = 8;
            this.LblMotPasse.Text = "Mot de passe :";
            // 
            // TxtCourriel
            // 
            this.TxtCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCourriel.Location = new System.Drawing.Point(203, 160);
            this.TxtCourriel.Name = "TxtCourriel";
            this.TxtCourriel.Size = new System.Drawing.Size(179, 24);
            this.TxtCourriel.TabIndex = 7;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrenom.Location = new System.Drawing.Point(203, 112);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(179, 24);
            this.TxtPrenom.TabIndex = 6;
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(203, 65);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(179, 24);
            this.TxtNom.TabIndex = 5;
            // 
            // TxtDA
            // 
            this.TxtDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDA.Location = new System.Drawing.Point(203, 22);
            this.TxtDA.Name = "TxtDA";
            this.TxtDA.ReadOnly = true;
            this.TxtDA.Size = new System.Drawing.Size(179, 24);
            this.TxtDA.TabIndex = 0;
            // 
            // LblCourriel
            // 
            this.LblCourriel.AutoSize = true;
            this.LblCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCourriel.Location = new System.Drawing.Point(73, 165);
            this.LblCourriel.Name = "LblCourriel";
            this.LblCourriel.Size = new System.Drawing.Size(78, 18);
            this.LblCourriel.TabIndex = 3;
            this.LblCourriel.Text = "Courriel :";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrenom.Location = new System.Drawing.Point(74, 117);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(77, 18);
            this.LblPrenom.TabIndex = 2;
            this.LblPrenom.Text = "Prénom :";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.Location = new System.Drawing.Point(97, 70);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(54, 18);
            this.LblNom.TabIndex = 1;
            this.LblNom.Text = "Nom :";
            // 
            // LblDA
            // 
            this.LblDA.AutoSize = true;
            this.LblDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDA.Location = new System.Drawing.Point(46, 27);
            this.LblDA.Name = "LblDA";
            this.LblDA.Size = new System.Drawing.Size(105, 18);
            this.LblDA.TabIndex = 0;
            this.LblDA.Text = "Numéro DA :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.DGVgroupe);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 299);
            this.panel2.TabIndex = 13;
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
            this.DGVgroupe.Location = new System.Drawing.Point(3, 56);
            this.DGVgroupe.Name = "DGVgroupe";
            this.DGVgroupe.Size = new System.Drawing.Size(434, 227);
            this.DGVgroupe.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lise de mes groupes :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.BtnInvit);
            this.panel3.Controls.Add(this.DGVinvitation);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(11, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 225);
            this.panel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Invitations recues pour joindre un groupe :";
            // 
            // DGVinvitation
            // 
            this.DGVinvitation.AllowUserToAddRows = false;
            this.DGVinvitation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVinvitation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVinvitation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVinvitation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_prenom,
            this.id_grou,
            this.titr,
            this.date,
            this.heure,
            this.commentaire});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVinvitation.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVinvitation.Location = new System.Drawing.Point(8, 49);
            this.DGVinvitation.Name = "DGVinvitation";
            this.DGVinvitation.Size = new System.Drawing.Size(850, 128);
            this.DGVinvitation.TabIndex = 14;
            // 
            // BtnInvit
            // 
            this.BtnInvit.Enabled = false;
            this.BtnInvit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvit.Location = new System.Drawing.Point(716, 183);
            this.BtnInvit.Name = "BtnInvit";
            this.BtnInvit.Size = new System.Drawing.Size(142, 32);
            this.BtnInvit.TabIndex = 15;
            this.BtnInvit.Text = "OK";
            this.BtnInvit.UseVisualStyleBackColor = true;
            this.BtnInvit.Click += new System.EventHandler(this.BtnInvit_Click);
            // 
            // RBaccepter
            // 
            this.RBaccepter.AutoSize = true;
            this.RBaccepter.Checked = true;
            this.RBaccepter.Enabled = false;
            this.RBaccepter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBaccepter.Location = new System.Drawing.Point(3, 4);
            this.RBaccepter.Name = "RBaccepter";
            this.RBaccepter.Size = new System.Drawing.Size(84, 22);
            this.RBaccepter.TabIndex = 17;
            this.RBaccepter.TabStop = true;
            this.RBaccepter.Text = "Accepter";
            this.RBaccepter.UseVisualStyleBackColor = true;
            // 
            // RBrejeter
            // 
            this.RBrejeter.AutoSize = true;
            this.RBrejeter.Enabled = false;
            this.RBrejeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBrejeter.Location = new System.Drawing.Point(125, 4);
            this.RBrejeter.Name = "RBrejeter";
            this.RBrejeter.Size = new System.Drawing.Size(73, 22);
            this.RBrejeter.TabIndex = 18;
            this.RBrejeter.Text = "Rejeter";
            this.RBrejeter.UseVisualStyleBackColor = true;
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
            this.titre.HeaderText = "Titre";
            this.titre.Name = "titre";
            this.titre.ReadOnly = true;
            this.titre.Width = 287;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.RBaccepter);
            this.panel4.Controls.Add(this.RBrejeter);
            this.panel4.Location = new System.Drawing.Point(469, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 36);
            this.panel4.TabIndex = 19;
            // 
            // nom_prenom
            // 
            this.nom_prenom.HeaderText = "Nom & Prénom";
            this.nom_prenom.Name = "nom_prenom";
            this.nom_prenom.ReadOnly = true;
            this.nom_prenom.Width = 175;
            // 
            // id_grou
            // 
            this.id_grou.HeaderText = "ID groupe";
            this.id_grou.Name = "id_grou";
            this.id_grou.ReadOnly = true;
            this.id_grou.Width = 105;
            // 
            // titr
            // 
            this.titr.HeaderText = "Titre groupe";
            this.titr.Name = "titr";
            this.titr.ReadOnly = true;
            this.titr.Width = 175;
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
            // PanneauProfilEtud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(1, 51);
            this.Name = "PanneauProfilEtud";
            this.Size = new System.Drawing.Size(900, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVgroupe)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVinvitation)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnModifMotPasse;
        private System.Windows.Forms.Label LblMotPasse;
        private System.Windows.Forms.TextBox TxtCourriel;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtDA;
        private System.Windows.Forms.Label LblCourriel;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblDA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVgroupe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVinvitation;
        private System.Windows.Forms.Button BtnInvit;
        private System.Windows.Forms.RadioButton RBrejeter;
        private System.Windows.Forms.RadioButton RBaccepter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_grou;
        private System.Windows.Forms.DataGridViewTextBoxColumn titr;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaire;
    }
}
