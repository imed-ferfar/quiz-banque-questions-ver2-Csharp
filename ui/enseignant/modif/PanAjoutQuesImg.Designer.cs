
namespace Projet1_questions.ui.enseignant.modif
{
    partial class PanAjoutQuesImg
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
            this.PnlImage = new System.Windows.Forms.Panel();
            this.BtnImage = new System.Windows.Forms.Button();
            this.TxtUrlImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNligne = new System.Windows.Forms.TextBox();
            this.TxtErreur = new System.Windows.Forms.TextBox();
            this.TxtCorrection = new System.Windows.Forms.TextBox();
            this.ChkBPartage = new System.Windows.Forms.CheckBox();
            this.PnlReponse = new System.Windows.Forms.Panel();
            this.oFDimage = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPond = new System.Windows.Forms.TextBox();
            this.PnlReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlImage
            // 
            this.PnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlImage.Location = new System.Drawing.Point(327, 50);
            this.PnlImage.Name = "PnlImage";
            this.PnlImage.Size = new System.Drawing.Size(504, 241);
            this.PnlImage.TabIndex = 0;
            // 
            // BtnImage
            // 
            this.BtnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImage.Location = new System.Drawing.Point(327, 20);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(131, 27);
            this.BtnImage.TabIndex = 1;
            this.BtnImage.Text = "Choisir image";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // TxtUrlImage
            // 
            this.TxtUrlImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrlImage.Location = new System.Drawing.Point(469, 20);
            this.TxtUrlImage.Name = "TxtUrlImage";
            this.TxtUrlImage.ReadOnly = true;
            this.TxtUrlImage.Size = new System.Drawing.Size(361, 24);
            this.TxtUrlImage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Détails de l\'erreur sur une image :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "№ ligne :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Erreur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correction :";
            // 
            // TxtNligne
            // 
            this.TxtNligne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNligne.Location = new System.Drawing.Point(119, 11);
            this.TxtNligne.Name = "TxtNligne";
            this.TxtNligne.Size = new System.Drawing.Size(178, 24);
            this.TxtNligne.TabIndex = 7;
            // 
            // TxtErreur
            // 
            this.TxtErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtErreur.Location = new System.Drawing.Point(119, 58);
            this.TxtErreur.Name = "TxtErreur";
            this.TxtErreur.Size = new System.Drawing.Size(178, 24);
            this.TxtErreur.TabIndex = 8;
            // 
            // TxtCorrection
            // 
            this.TxtCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorrection.Location = new System.Drawing.Point(119, 105);
            this.TxtCorrection.Name = "TxtCorrection";
            this.TxtCorrection.Size = new System.Drawing.Size(178, 24);
            this.TxtCorrection.TabIndex = 9;
            // 
            // ChkBPartage
            // 
            this.ChkBPartage.AutoSize = true;
            this.ChkBPartage.Checked = true;
            this.ChkBPartage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBPartage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBPartage.Location = new System.Drawing.Point(204, 36);
            this.ChkBPartage.Name = "ChkBPartage";
            this.ChkBPartage.Size = new System.Drawing.Size(94, 22);
            this.ChkBPartage.TabIndex = 13;
            this.ChkBPartage.Text = "Partagée";
            this.ChkBPartage.UseVisualStyleBackColor = true;
            // 
            // PnlReponse
            // 
            this.PnlReponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlReponse.Controls.Add(this.TxtCorrection);
            this.PnlReponse.Controls.Add(this.label4);
            this.PnlReponse.Controls.Add(this.TxtNligne);
            this.PnlReponse.Controls.Add(this.TxtErreur);
            this.PnlReponse.Controls.Add(this.label2);
            this.PnlReponse.Controls.Add(this.label3);
            this.PnlReponse.Location = new System.Drawing.Point(9, 136);
            this.PnlReponse.Name = "PnlReponse";
            this.PnlReponse.Size = new System.Drawing.Size(312, 155);
            this.PnlReponse.TabIndex = 14;
            // 
            // oFDimage
            // 
            this.oFDimage.DefaultExt = "png";
            this.oFDimage.Filter = "Fichiers png (*.png)|*.png|Fichiers JPEG (*.jpeg)|*.jpeg|Fichiers bitmap (*.bmp)|" +
    "*.bmp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ponderation";
            // 
            // TxtPond
            // 
            this.TxtPond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPond.Location = new System.Drawing.Point(123, 36);
            this.TxtPond.Name = "TxtPond";
            this.TxtPond.Size = new System.Drawing.Size(33, 24);
            this.TxtPond.TabIndex = 15;
            this.TxtPond.Text = "1";
            this.TxtPond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanAjoutQuesImg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPond);
            this.Controls.Add(this.PnlReponse);
            this.Controls.Add(this.ChkBPartage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUrlImage);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.PnlImage);
            this.Name = "PanAjoutQuesImg";
            this.Size = new System.Drawing.Size(843, 308);
            this.PnlReponse.ResumeLayout(false);
            this.PnlReponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlImage;
        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.TextBox TxtUrlImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNligne;
        private System.Windows.Forms.TextBox TxtErreur;
        private System.Windows.Forms.TextBox TxtCorrection;
        private System.Windows.Forms.CheckBox ChkBPartage;
        private System.Windows.Forms.Panel PnlReponse;
        private System.Windows.Forms.OpenFileDialog oFDimage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPond;
    }
}
