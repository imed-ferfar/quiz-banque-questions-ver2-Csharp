
namespace Projet1_questions.ui
{
    partial class FenEnseignant
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
            this.PnlBtns = new System.Windows.Forms.Panel();
            this.BtnMonCompte = new System.Windows.Forms.Button();
            this.BtnExamen = new System.Windows.Forms.Button();
            this.BtnGroupes = new System.Windows.Forms.Button();
            this.BtnQuestions = new System.Windows.Forms.Button();
            this.PnlHaut = new System.Windows.Forms.Panel();
            this.LinkedLid = new System.Windows.Forms.LinkLabel();
            this.lblId = new System.Windows.Forms.Label();
            this.LinkedLnom = new System.Windows.Forms.LinkLabel();
            this.lblNom = new System.Windows.Forms.Label();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlCentre = new System.Windows.Forms.Panel();
            this.PnlBtns.SuspendLayout();
            this.PnlHaut.SuspendLayout();
            this.PnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBtns
            // 
            this.PnlBtns.BackColor = System.Drawing.Color.Teal;
            this.PnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlBtns.Controls.Add(this.BtnMonCompte);
            this.PnlBtns.Controls.Add(this.BtnExamen);
            this.PnlBtns.Controls.Add(this.BtnGroupes);
            this.PnlBtns.Controls.Add(this.BtnQuestions);
            this.PnlBtns.Location = new System.Drawing.Point(666, 3);
            this.PnlBtns.Name = "PnlBtns";
            this.PnlBtns.Size = new System.Drawing.Size(202, 500);
            this.PnlBtns.TabIndex = 0;
            // 
            // BtnMonCompte
            // 
            this.BtnMonCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMonCompte.Location = new System.Drawing.Point(5, 374);
            this.BtnMonCompte.Name = "BtnMonCompte";
            this.BtnMonCompte.Size = new System.Drawing.Size(190, 118);
            this.BtnMonCompte.TabIndex = 3;
            this.BtnMonCompte.Text = "Mon Compte";
            this.BtnMonCompte.UseVisualStyleBackColor = true;
            this.BtnMonCompte.Click += new System.EventHandler(this.BtnMonCompte_Click);
            // 
            // BtnExamen
            // 
            this.BtnExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExamen.Location = new System.Drawing.Point(5, 252);
            this.BtnExamen.Name = "BtnExamen";
            this.BtnExamen.Size = new System.Drawing.Size(190, 118);
            this.BtnExamen.TabIndex = 2;
            this.BtnExamen.Text = "Déposer Examen";
            this.BtnExamen.UseVisualStyleBackColor = true;
            this.BtnExamen.Click += new System.EventHandler(this.BtnExamen_Click);
            // 
            // BtnGroupes
            // 
            this.BtnGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGroupes.Location = new System.Drawing.Point(5, 128);
            this.BtnGroupes.Name = "BtnGroupes";
            this.BtnGroupes.Size = new System.Drawing.Size(190, 118);
            this.BtnGroupes.TabIndex = 1;
            this.BtnGroupes.Text = "Gestion Groupes";
            this.BtnGroupes.UseVisualStyleBackColor = true;
            this.BtnGroupes.Click += new System.EventHandler(this.BtnGroupes_Click);
            // 
            // BtnQuestions
            // 
            this.BtnQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestions.Location = new System.Drawing.Point(5, 5);
            this.BtnQuestions.Name = "BtnQuestions";
            this.BtnQuestions.Size = new System.Drawing.Size(190, 118);
            this.BtnQuestions.TabIndex = 0;
            this.BtnQuestions.Text = "Banque de Questions";
            this.BtnQuestions.UseVisualStyleBackColor = true;
            this.BtnQuestions.Click += new System.EventHandler(this.BtnQuestions_Click);
            // 
            // PnlHaut
            // 
            this.PnlHaut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlHaut.Controls.Add(this.LinkedLid);
            this.PnlHaut.Controls.Add(this.lblId);
            this.PnlHaut.Controls.Add(this.LinkedLnom);
            this.PnlHaut.Controls.Add(this.lblNom);
            this.PnlHaut.Location = new System.Drawing.Point(5, 5);
            this.PnlHaut.Name = "PnlHaut";
            this.PnlHaut.Size = new System.Drawing.Size(875, 45);
            this.PnlHaut.TabIndex = 1;
            // 
            // LinkedLid
            // 
            this.LinkedLid.AutoSize = true;
            this.LinkedLid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedLid.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LinkedLid.Location = new System.Drawing.Point(272, 9);
            this.LinkedLid.Name = "LinkedLid";
            this.LinkedLid.Size = new System.Drawing.Size(21, 20);
            this.LinkedLid.TabIndex = 8;
            this.LinkedLid.TabStop = true;
            this.LinkedLid.Text = "...";
            this.LinkedLid.Click += new System.EventHandler(this.BtnMonCompte_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(206, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(69, 20);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "№ DA : ";
            // 
            // LinkedLnom
            // 
            this.LinkedLnom.AutoSize = true;
            this.LinkedLnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedLnom.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LinkedLnom.Location = new System.Drawing.Point(64, 9);
            this.LinkedLnom.Name = "LinkedLnom";
            this.LinkedLnom.Size = new System.Drawing.Size(21, 20);
            this.LinkedLnom.TabIndex = 6;
            this.LinkedLnom.TabStop = true;
            this.LinkedLnom.Text = "...";
            this.LinkedLnom.Click += new System.EventHandler(this.BtnMonCompte_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(11, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 20);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom : ";
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlPrincipal.Controls.Add(this.PnlCentre);
            this.PnlPrincipal.Controls.Add(this.PnlBtns);
            this.PnlPrincipal.Location = new System.Drawing.Point(5, 56);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(875, 504);
            this.PnlPrincipal.TabIndex = 2;
            // 
            // PnlCentre
            // 
            this.PnlCentre.Location = new System.Drawing.Point(3, 3);
            this.PnlCentre.Name = "PnlCentre";
            this.PnlCentre.Size = new System.Drawing.Size(664, 499);
            this.PnlCentre.TabIndex = 1;
            // 
            // FenEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.PnlPrincipal);
            this.Controls.Add(this.PnlHaut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FenEnseignant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FenEnseignant";
            this.PnlBtns.ResumeLayout(false);
            this.PnlHaut.ResumeLayout(false);
            this.PnlHaut.PerformLayout();
            this.PnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBtns;
        private System.Windows.Forms.Button BtnExamen;
        private System.Windows.Forms.Button BtnGroupes;
        private System.Windows.Forms.Button BtnQuestions;
        private System.Windows.Forms.Panel PnlHaut;
        private System.Windows.Forms.LinkLabel LinkedLnom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Button BtnMonCompte;
        private System.Windows.Forms.LinkLabel LinkedLid;
        private System.Windows.Forms.Panel PnlCentre;
    }
}