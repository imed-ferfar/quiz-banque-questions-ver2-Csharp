
namespace Projet1_questions.ui
{
    partial class PanneauDebut
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LBmatiere = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbListeNbQues = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChBImage = new System.Windows.Forms.CheckBox();
            this.ChBErreur = new System.Windows.Forms.CheckBox();
            this.ChBQCM = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LBmatiere);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(33, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 157);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "note : Désolé, ce choix n\'est pas encore fonctionnel";
            // 
            // LBmatiere
            // 
            this.LBmatiere.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LBmatiere.FormattingEnabled = true;
            this.LBmatiere.ItemHeight = 20;
            this.LBmatiere.Location = new System.Drawing.Point(77, 17);
            this.LBmatiere.Name = "LBmatiere";
            this.LBmatiere.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LBmatiere.Size = new System.Drawing.Size(228, 124);
            this.LBmatiere.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CbListeNbQues);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(35, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 70);
            this.panel2.TabIndex = 1;
            // 
            // CbListeNbQues
            // 
            this.CbListeNbQues.FormattingEnabled = true;
            this.CbListeNbQues.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "25"});
            this.CbListeNbQues.Location = new System.Drawing.Point(75, 20);
            this.CbListeNbQues.Name = "CbListeNbQues";
            this.CbListeNbQues.Size = new System.Drawing.Size(228, 26);
            this.CbListeNbQues.TabIndex = 2;
            this.CbListeNbQues.Text = "Choisir nombre de question";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ChBImage);
            this.panel3.Controls.Add(this.ChBErreur);
            this.panel3.Controls.Add(this.ChBQCM);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(33, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 163);
            this.panel3.TabIndex = 2;
            // 
            // ChBImage
            // 
            this.ChBImage.AutoSize = true;
            this.ChBImage.Checked = true;
            this.ChBImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBImage.Location = new System.Drawing.Point(75, 110);
            this.ChBImage.Name = "ChBImage";
            this.ChBImage.Size = new System.Drawing.Size(409, 24);
            this.ChBImage.TabIndex = 2;
            this.ChBImage.Text = "Trouver le resultat d\'exécution d\'une partie de code";
            this.ChBImage.UseVisualStyleBackColor = true;
            // 
            // ChBErreur
            // 
            this.ChBErreur.AutoSize = true;
            this.ChBErreur.Checked = true;
            this.ChBErreur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBErreur.Location = new System.Drawing.Point(75, 69);
            this.ChBErreur.Name = "ChBErreur";
            this.ChBErreur.Size = new System.Drawing.Size(351, 24);
            this.ChBErreur.TabIndex = 1;
            this.ChBErreur.Text = "Trouver une erreur dans une partie de code";
            this.ChBErreur.UseVisualStyleBackColor = true;
            // 
            // ChBQCM
            // 
            this.ChBQCM.AutoSize = true;
            this.ChBQCM.Checked = true;
            this.ChBQCM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBQCM.Location = new System.Drawing.Point(75, 27);
            this.ChBQCM.Name = "ChBQCM";
            this.ChBQCM.Size = new System.Drawing.Size(216, 24);
            this.ChBQCM.TabIndex = 0;
            this.ChBQCM.Text = "Question à choix multiple";
            this.ChBQCM.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Veuillez choisir le nombre de question";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veuillez choisir les tags des questions";
            // 
            // PanneauDebut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(1, 51);
            this.Name = "PanneauDebut";
            this.Size = new System.Drawing.Size(900, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CbListeNbQues;
        private System.Windows.Forms.CheckBox ChBImage;
        private System.Windows.Forms.CheckBox ChBErreur;
        private System.Windows.Forms.CheckBox ChBQCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox LBmatiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}