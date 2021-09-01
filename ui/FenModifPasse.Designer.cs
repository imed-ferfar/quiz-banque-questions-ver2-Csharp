
namespace Projet1_questions.ui
{
    partial class FenModifPasse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPasseActuel = new System.Windows.Forms.TextBox();
            this.TxtMotPasse = new System.Windows.Forms.TextBox();
            this.TxtMotPasseConfirm = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.ChkBmotPasse = new System.Windows.Forms.CheckBox();
            this.ChkBmotPasseConfirm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de passe actuel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nouveau mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmer mot de passe :";
            // 
            // TxtPasseActuel
            // 
            this.TxtPasseActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPasseActuel.Location = new System.Drawing.Point(221, 24);
            this.TxtPasseActuel.Name = "TxtPasseActuel";
            this.TxtPasseActuel.PasswordChar = '*';
            this.TxtPasseActuel.Size = new System.Drawing.Size(170, 24);
            this.TxtPasseActuel.TabIndex = 3;
            // 
            // TxtMotPasse
            // 
            this.TxtMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMotPasse.Location = new System.Drawing.Point(221, 83);
            this.TxtMotPasse.Name = "TxtMotPasse";
            this.TxtMotPasse.PasswordChar = '*';
            this.TxtMotPasse.Size = new System.Drawing.Size(170, 24);
            this.TxtMotPasse.TabIndex = 4;
            // 
            // TxtMotPasseConfirm
            // 
            this.TxtMotPasseConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMotPasseConfirm.Location = new System.Drawing.Point(221, 122);
            this.TxtMotPasseConfirm.Name = "TxtMotPasseConfirm";
            this.TxtMotPasseConfirm.PasswordChar = '*';
            this.TxtMotPasseConfirm.Size = new System.Drawing.Size(170, 24);
            this.TxtMotPasseConfirm.TabIndex = 5;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Location = new System.Drawing.Point(296, 180);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(95, 27);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Location = new System.Drawing.Point(170, 180);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(95, 27);
            this.BtnAnnuler.TabIndex = 7;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // ChkBmotPasse
            // 
            this.ChkBmotPasse.AutoSize = true;
            this.ChkBmotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBmotPasse.Location = new System.Drawing.Point(221, 54);
            this.ChkBmotPasse.Name = "ChkBmotPasse";
            this.ChkBmotPasse.Size = new System.Drawing.Size(143, 19);
            this.ChkBmotPasse.TabIndex = 12;
            this.ChkBmotPasse.Text = "Afficher mot de passe";
            this.ChkBmotPasse.UseVisualStyleBackColor = true;
            this.ChkBmotPasse.CheckedChanged += new System.EventHandler(this.ChkBmotPasse_CheckedChanged);
            // 
            // ChkBmotPasseConfirm
            // 
            this.ChkBmotPasseConfirm.AutoSize = true;
            this.ChkBmotPasseConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBmotPasseConfirm.Location = new System.Drawing.Point(221, 152);
            this.ChkBmotPasseConfirm.Name = "ChkBmotPasseConfirm";
            this.ChkBmotPasseConfirm.Size = new System.Drawing.Size(143, 19);
            this.ChkBmotPasseConfirm.TabIndex = 13;
            this.ChkBmotPasseConfirm.Text = "Afficher mot de passe";
            this.ChkBmotPasseConfirm.UseVisualStyleBackColor = true;
            this.ChkBmotPasseConfirm.CheckedChanged += new System.EventHandler(this.ChkBmotPasseConfirm_CheckedChanged);
            // 
            // FenModifPasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 219);
            this.Controls.Add(this.ChkBmotPasseConfirm);
            this.Controls.Add(this.ChkBmotPasse);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtMotPasseConfirm);
            this.Controls.Add(this.TxtMotPasse);
            this.Controls.Add(this.TxtPasseActuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FenModifPasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification du mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPasseActuel;
        private System.Windows.Forms.TextBox TxtMotPasse;
        private System.Windows.Forms.TextBox TxtMotPasseConfirm;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.CheckBox ChkBmotPasse;
        private System.Windows.Forms.CheckBox ChkBmotPasseConfirm;
    }
}