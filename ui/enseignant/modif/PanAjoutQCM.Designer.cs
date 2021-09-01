
namespace Projet1_questions.ui.enseignant.modif
{
    partial class PanAjoutQCM
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
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtChoix1 = new System.Windows.Forms.TextBox();
            this.TxtChoix2 = new System.Windows.Forms.TextBox();
            this.TxtNbrChoix = new System.Windows.Forms.TextBox();
            this.BtnMoinsChoix = new System.Windows.Forms.Button();
            this.BtnPlusChoix = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkBPartage = new System.Windows.Forms.CheckBox();
            this.TxtPond = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestion.Location = new System.Drawing.Point(124, 19);
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(691, 24);
            this.TxtQuestion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "La question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de choix proposés :";
            // 
            // TxtChoix1
            // 
            this.TxtChoix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChoix1.Location = new System.Drawing.Point(26, 109);
            this.TxtChoix1.Name = "TxtChoix1";
            this.TxtChoix1.Size = new System.Drawing.Size(742, 24);
            this.TxtChoix1.TabIndex = 3;
            // 
            // TxtChoix2
            // 
            this.TxtChoix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChoix2.Location = new System.Drawing.Point(26, 151);
            this.TxtChoix2.Name = "TxtChoix2";
            this.TxtChoix2.Size = new System.Drawing.Size(742, 24);
            this.TxtChoix2.TabIndex = 4;
            // 
            // TxtNbrChoix
            // 
            this.TxtNbrChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNbrChoix.Location = new System.Drawing.Point(16, 3);
            this.TxtNbrChoix.Name = "TxtNbrChoix";
            this.TxtNbrChoix.ReadOnly = true;
            this.TxtNbrChoix.Size = new System.Drawing.Size(33, 24);
            this.TxtNbrChoix.TabIndex = 5;
            this.TxtNbrChoix.Text = "2";
            this.TxtNbrChoix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnMoinsChoix
            // 
            this.BtnMoinsChoix.Enabled = false;
            this.BtnMoinsChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoinsChoix.Location = new System.Drawing.Point(60, 3);
            this.BtnMoinsChoix.Name = "BtnMoinsChoix";
            this.BtnMoinsChoix.Size = new System.Drawing.Size(19, 23);
            this.BtnMoinsChoix.TabIndex = 6;
            this.BtnMoinsChoix.Text = "-";
            this.BtnMoinsChoix.UseVisualStyleBackColor = true;
            this.BtnMoinsChoix.Click += new System.EventHandler(this.BtnMoinsChoix_Click);
            // 
            // BtnPlusChoix
            // 
            this.BtnPlusChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlusChoix.Location = new System.Drawing.Point(81, 3);
            this.BtnPlusChoix.Name = "BtnPlusChoix";
            this.BtnPlusChoix.Size = new System.Drawing.Size(19, 23);
            this.BtnPlusChoix.TabIndex = 7;
            this.BtnPlusChoix.Text = "+";
            this.BtnPlusChoix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlusChoix.UseVisualStyleBackColor = true;
            this.BtnPlusChoix.Click += new System.EventHandler(this.BtnPlusChoix_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.Location = new System.Drawing.Point(788, 109);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.CheckBox1.TabIndex = 8;
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox2.Location = new System.Drawing.Point(788, 151);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(15, 14);
            this.CheckBox2.TabIndex = 9;
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bonne réponse";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtNbrChoix);
            this.panel1.Controls.Add(this.BtnMoinsChoix);
            this.panel1.Controls.Add(this.BtnPlusChoix);
            this.panel1.Location = new System.Drawing.Point(268, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 36);
            this.panel1.TabIndex = 11;
            // 
            // ChkBPartage
            // 
            this.ChkBPartage.AutoSize = true;
            this.ChkBPartage.Checked = true;
            this.ChkBPartage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBPartage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBPartage.Location = new System.Drawing.Point(578, 71);
            this.ChkBPartage.Name = "ChkBPartage";
            this.ChkBPartage.Size = new System.Drawing.Size(94, 22);
            this.ChkBPartage.TabIndex = 12;
            this.ChkBPartage.Text = "Partagée";
            this.ChkBPartage.UseVisualStyleBackColor = true;
            // 
            // TxtPond
            // 
            this.TxtPond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPond.Location = new System.Drawing.Point(519, 71);
            this.TxtPond.Name = "TxtPond";
            this.TxtPond.Size = new System.Drawing.Size(33, 24);
            this.TxtPond.TabIndex = 8;
            this.TxtPond.Text = "1";
            this.TxtPond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ponderation";
            // 
            // PanAjoutQCM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPond);
            this.Controls.Add(this.ChkBPartage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.TxtChoix2);
            this.Controls.Add(this.TxtChoix1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQuestion);
            this.Name = "PanAjoutQCM";
            this.Size = new System.Drawing.Size(843, 308);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtChoix1;
        private System.Windows.Forms.TextBox TxtChoix2;
        private System.Windows.Forms.TextBox TxtNbrChoix;
        private System.Windows.Forms.Button BtnMoinsChoix;
        private System.Windows.Forms.Button BtnPlusChoix;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ChkBPartage;
        private System.Windows.Forms.TextBox TxtPond;
        private System.Windows.Forms.Label label4;
    }
}
