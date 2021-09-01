
namespace Projet1_questions.ui.enseignant
{
    partial class PanneauBanqueQuestion
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PnlHautModif = new System.Windows.Forms.Panel();
            this.ComBmatModif = new System.Windows.Forms.ComboBox();
            this.TxtTitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdQues = new System.Windows.Forms.TextBox();
            this.PnlCentreModif = new System.Windows.Forms.Panel();
            this.PnlBasModif = new System.Windows.Forms.Panel();
            this.BtnOKmodif = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelBasAjout = new System.Windows.Forms.Panel();
            this.BtnOKajout = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.PanelCentreAjout = new System.Windows.Forms.Panel();
            this.PnlHautAjout = new System.Windows.Forms.Panel();
            this.ComBmat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComBTypeQues = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.ChkBMesQuestion = new System.Windows.Forms.CheckBox();
            this.DGVquestion = new System.Windows.Forms.DataGridView();
            this.id_question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_enseignant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCQuestion = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.PnlHautModif.SuspendLayout();
            this.PnlBasModif.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PanelBasAjout.SuspendLayout();
            this.PnlHautAjout.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVquestion)).BeginInit();
            this.tabCQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.AccessibleName = "tabPage3";
            this.tabPage3.Controls.Add(this.PnlHautModif);
            this.tabPage3.Controls.Add(this.PnlCentreModif);
            this.tabPage3.Controls.Add(this.PnlBasModif);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(852, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modifier question";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PnlHautModif
            // 
            this.PnlHautModif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlHautModif.Controls.Add(this.ComBmatModif);
            this.PnlHautModif.Controls.Add(this.TxtTitre);
            this.PnlHautModif.Controls.Add(this.label1);
            this.PnlHautModif.Controls.Add(this.label5);
            this.PnlHautModif.Controls.Add(this.TxtIdQues);
            this.PnlHautModif.Location = new System.Drawing.Point(2, 6);
            this.PnlHautModif.Name = "PnlHautModif";
            this.PnlHautModif.Size = new System.Drawing.Size(851, 48);
            this.PnlHautModif.TabIndex = 9;
            // 
            // ComBmatModif
            // 
            this.ComBmatModif.FormattingEnabled = true;
            this.ComBmatModif.ItemHeight = 18;
            this.ComBmatModif.Items.AddRange(new object[] {
            "420-A07-BB"});
            this.ComBmatModif.Location = new System.Drawing.Point(596, 11);
            this.ComBmatModif.Name = "ComBmatModif";
            this.ComBmatModif.Size = new System.Drawing.Size(235, 26);
            this.ComBmatModif.TabIndex = 8;
            this.ComBmatModif.Text = "Choisir la matiere de la question";
            // 
            // TxtTitre
            // 
            this.TxtTitre.Location = new System.Drawing.Point(190, 11);
            this.TxtTitre.Name = "TxtTitre";
            this.TxtTitre.ReadOnly = true;
            this.TxtTitre.Size = new System.Drawing.Size(389, 24);
            this.TxtTitre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "№ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Titre :";
            // 
            // TxtIdQues
            // 
            this.TxtIdQues.Location = new System.Drawing.Point(48, 11);
            this.TxtIdQues.Name = "TxtIdQues";
            this.TxtIdQues.ReadOnly = true;
            this.TxtIdQues.Size = new System.Drawing.Size(78, 24);
            this.TxtIdQues.TabIndex = 5;
            // 
            // PnlCentreModif
            // 
            this.PnlCentreModif.BackColor = System.Drawing.Color.Transparent;
            this.PnlCentreModif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlCentreModif.Location = new System.Drawing.Point(2, 51);
            this.PnlCentreModif.Name = "PnlCentreModif";
            this.PnlCentreModif.Size = new System.Drawing.Size(849, 315);
            this.PnlCentreModif.TabIndex = 8;
            // 
            // PnlBasModif
            // 
            this.PnlBasModif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBasModif.Controls.Add(this.BtnOKmodif);
            this.PnlBasModif.Controls.Add(this.button2);
            this.PnlBasModif.Location = new System.Drawing.Point(6, 374);
            this.PnlBasModif.Name = "PnlBasModif";
            this.PnlBasModif.Size = new System.Drawing.Size(840, 40);
            this.PnlBasModif.TabIndex = 7;
            // 
            // BtnOKmodif
            // 
            this.BtnOKmodif.Location = new System.Drawing.Point(681, 5);
            this.BtnOKmodif.Name = "BtnOKmodif";
            this.BtnOKmodif.Size = new System.Drawing.Size(133, 27);
            this.BtnOKmodif.TabIndex = 2;
            this.BtnOKmodif.Text = "OK";
            this.BtnOKmodif.UseVisualStyleBackColor = true;
            this.BtnOKmodif.Click += new System.EventHandler(this.BtnOKmodif_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelBasAjout);
            this.tabPage2.Controls.Add(this.PanelCentreAjout);
            this.tabPage2.Controls.Add(this.PnlHautAjout);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ajouter question";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelBasAjout
            // 
            this.PanelBasAjout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBasAjout.Controls.Add(this.BtnOKajout);
            this.PanelBasAjout.Controls.Add(this.BtnReset);
            this.PanelBasAjout.Location = new System.Drawing.Point(6, 374);
            this.PanelBasAjout.Name = "PanelBasAjout";
            this.PanelBasAjout.Size = new System.Drawing.Size(840, 40);
            this.PanelBasAjout.TabIndex = 6;
            // 
            // BtnOKajout
            // 
            this.BtnOKajout.Location = new System.Drawing.Point(681, 5);
            this.BtnOKajout.Name = "BtnOKajout";
            this.BtnOKajout.Size = new System.Drawing.Size(133, 27);
            this.BtnOKajout.TabIndex = 2;
            this.BtnOKajout.Text = "OK";
            this.BtnOKajout.UseVisualStyleBackColor = true;
            this.BtnOKajout.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(530, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(133, 27);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // PanelCentreAjout
            // 
            this.PanelCentreAjout.BackColor = System.Drawing.Color.Transparent;
            this.PanelCentreAjout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelCentreAjout.Location = new System.Drawing.Point(0, 53);
            this.PanelCentreAjout.Name = "PanelCentreAjout";
            this.PanelCentreAjout.Size = new System.Drawing.Size(849, 315);
            this.PanelCentreAjout.TabIndex = 7;
            // 
            // PnlHautAjout
            // 
            this.PnlHautAjout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlHautAjout.Controls.Add(this.ComBmat);
            this.PnlHautAjout.Controls.Add(this.label2);
            this.PnlHautAjout.Controls.Add(this.ComBTypeQues);
            this.PnlHautAjout.Location = new System.Drawing.Point(0, 0);
            this.PnlHautAjout.Name = "PnlHautAjout";
            this.PnlHautAjout.Size = new System.Drawing.Size(851, 48);
            this.PnlHautAjout.TabIndex = 0;
            // 
            // ComBmat
            // 
            this.ComBmat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComBmat.FormattingEnabled = true;
            this.ComBmat.ItemHeight = 18;
            this.ComBmat.Items.AddRange(new object[] {
            "420-A07-BB"});
            this.ComBmat.Location = new System.Drawing.Point(580, 13);
            this.ComBmat.Name = "ComBmat";
            this.ComBmat.Size = new System.Drawing.Size(235, 26);
            this.ComBmat.TabIndex = 5;
            this.ComBmat.Text = "Choisir la matiere de la question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choisir le type de question :";
            // 
            // ComBTypeQues
            // 
            this.ComBTypeQues.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComBTypeQues.FormattingEnabled = true;
            this.ComBTypeQues.ItemHeight = 18;
            this.ComBTypeQues.Items.AddRange(new object[] {
            "Choisir la ou les bonnes réponses",
            "Trouver l\'erreur dans ce code",
            "Trouver le resultat d\'execution de ce code"});
            this.ComBTypeQues.Location = new System.Drawing.Point(251, 13);
            this.ComBTypeQues.Name = "ComBTypeQues";
            this.ComBTypeQues.Size = new System.Drawing.Size(309, 26);
            this.ComBTypeQues.TabIndex = 4;
            this.ComBTypeQues.Text = "Choisir le type de question";
            this.ComBTypeQues.SelectedIndexChanged += new System.EventHandler(this.ComBTypeQues_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.BtnModifier);
            this.tabPage1.Controls.Add(this.BtnSupprimer);
            this.tabPage1.Controls.Add(this.ChkBMesQuestion);
            this.tabPage1.Controls.Add(this.DGVquestion);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste des question";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(223, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Afficher la question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Enabled = false;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Location = new System.Drawing.Point(543, 9);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(132, 33);
            this.BtnModifier.TabIndex = 6;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Enabled = false;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.Location = new System.Drawing.Point(696, 9);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(132, 33);
            this.BtnSupprimer.TabIndex = 5;
            this.BtnSupprimer.Text = "Suuprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // ChkBMesQuestion
            // 
            this.ChkBMesQuestion.AutoSize = true;
            this.ChkBMesQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkBMesQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBMesQuestion.Location = new System.Drawing.Point(37, 15);
            this.ChkBMesQuestion.Name = "ChkBMesQuestion";
            this.ChkBMesQuestion.Size = new System.Drawing.Size(128, 22);
            this.ChkBMesQuestion.TabIndex = 2;
            this.ChkBMesQuestion.Text = "Mes question";
            this.ChkBMesQuestion.UseVisualStyleBackColor = false;
            this.ChkBMesQuestion.CheckedChanged += new System.EventHandler(this.ChkBMesQuestion_CheckedChanged);
            // 
            // DGVquestion
            // 
            this.DGVquestion.AllowUserToAddRows = false;
            this.DGVquestion.AllowUserToDeleteRows = false;
            this.DGVquestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVquestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVquestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVquestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_question,
            this.titre,
            this.question,
            this.id_enseignant});
            this.DGVquestion.Location = new System.Drawing.Point(3, 48);
            this.DGVquestion.Name = "DGVquestion";
            this.DGVquestion.Size = new System.Drawing.Size(843, 370);
            this.DGVquestion.TabIndex = 0;
            // 
            // id_question
            // 
            this.id_question.HeaderText = "ID";
            this.id_question.Name = "id_question";
            this.id_question.ReadOnly = true;
            this.id_question.Width = 63;
            // 
            // titre
            // 
            this.titre.HeaderText = "Titre";
            this.titre.Name = "titre";
            this.titre.ReadOnly = true;
            this.titre.Width = 290;
            // 
            // question
            // 
            this.question.HeaderText = "Question";
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.Width = 750;
            // 
            // id_enseignant
            // 
            this.id_enseignant.HeaderText = "ID Enseignant";
            this.id_enseignant.Name = "id_enseignant";
            this.id_enseignant.ReadOnly = true;
            this.id_enseignant.Width = 110;
            // 
            // tabCQuestion
            // 
            this.tabCQuestion.Controls.Add(this.tabPage1);
            this.tabCQuestion.Controls.Add(this.tabPage2);
            this.tabCQuestion.Controls.Add(this.tabPage3);
            this.tabCQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCQuestion.Location = new System.Drawing.Point(4, 4);
            this.tabCQuestion.Name = "tabCQuestion";
            this.tabCQuestion.SelectedIndex = 0;
            this.tabCQuestion.Size = new System.Drawing.Size(860, 448);
            this.tabCQuestion.TabIndex = 0;
            // 
            // PanneauBanqueQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tabCQuestion);
            this.Location = new System.Drawing.Point(3, 50);
            this.Name = "PanneauBanqueQuestion";
            this.Size = new System.Drawing.Size(867, 455);
            this.tabPage3.ResumeLayout(false);
            this.PnlHautModif.ResumeLayout(false);
            this.PnlHautModif.PerformLayout();
            this.PnlBasModif.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.PanelBasAjout.ResumeLayout(false);
            this.PnlHautAjout.ResumeLayout(false);
            this.PnlHautAjout.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVquestion)).EndInit();
            this.tabCQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelBasAjout;
        private System.Windows.Forms.Button BtnOKajout;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Panel PnlHautAjout;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox ChkBMesQuestion;
        private System.Windows.Forms.DataGridView DGVquestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_question;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_enseignant;
        private System.Windows.Forms.TabControl tabCQuestion;
        private System.Windows.Forms.Panel PanelCentreAjout;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Panel PnlHautModif;
        private System.Windows.Forms.Panel PnlCentreModif;
        private System.Windows.Forms.Panel PnlBasModif;
        private System.Windows.Forms.Button BtnOKmodif;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdQues;
        private System.Windows.Forms.ComboBox ComBmat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComBTypeQues;
        private System.Windows.Forms.ComboBox ComBmatModif;
        private System.Windows.Forms.Button button1;
    }
}
