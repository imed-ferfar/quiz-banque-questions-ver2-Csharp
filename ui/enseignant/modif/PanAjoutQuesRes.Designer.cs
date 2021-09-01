
namespace Projet1_questions.ui.enseignant.modif
{
    partial class PanAjoutQuesRes
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
            this.ChkBPartage = new System.Windows.Forms.CheckBox();
            this.TxtReponse = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChkBPartage
            // 
            this.ChkBPartage.AutoSize = true;
            this.ChkBPartage.Checked = true;
            this.ChkBPartage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBPartage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBPartage.Location = new System.Drawing.Point(45, 24);
            this.ChkBPartage.Name = "ChkBPartage";
            this.ChkBPartage.Size = new System.Drawing.Size(94, 22);
            this.ChkBPartage.TabIndex = 12;
            this.ChkBPartage.Text = "Partagée";
            this.ChkBPartage.UseVisualStyleBackColor = true;
            // 
            // TxtReponse
            // 
            this.TxtReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReponse.Location = new System.Drawing.Point(359, 261);
            this.TxtReponse.Name = "TxtReponse";
            this.TxtReponse.Size = new System.Drawing.Size(466, 24);
            this.TxtReponse.TabIndex = 13;
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode.Location = new System.Drawing.Point(359, 24);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(466, 215);
            this.TxtCode.TabIndex = 14;
            this.TxtCode.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tapez une partie du programme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Le rsultat dexecution de code ci-dissus :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ponderation";
            // 
            // TxtPond
            // 
            this.TxtPond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPond.Location = new System.Drawing.Point(293, 24);
            this.TxtPond.Name = "TxtPond";
            this.TxtPond.Size = new System.Drawing.Size(33, 24);
            this.TxtPond.TabIndex = 17;
            this.TxtPond.Text = "1";
            this.TxtPond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanAjoutQuesRes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.TxtReponse);
            this.Controls.Add(this.ChkBPartage);
            this.Name = "PanAjoutQuesRes";
            this.Size = new System.Drawing.Size(843, 308);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ChkBPartage;
        private System.Windows.Forms.TextBox TxtReponse;
        private System.Windows.Forms.RichTextBox TxtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPond;
    }
}
