
using System.Drawing;

namespace Projet1_questions.ui
{
    partial class FenEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenEtudiant));
            this.pnlEntete = new System.Windows.Forms.Panel();
            this.cbGroupes = new System.Windows.Forms.ComboBox();
            this.LinkedLntf = new System.Windows.Forms.LinkLabel();
            this.LinkedLid = new System.Windows.Forms.LinkLabel();
            this.LinkedLnom = new System.Windows.Forms.LinkLabel();
            this.lblGroupe = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.PnlBtns = new System.Windows.Forms.Panel();
            this.BtnProfil = new System.Windows.Forms.Button();
            this.BtnExamen = new System.Windows.Forms.Button();
            this.BtnLancerQuiz = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlEntete.SuspendLayout();
            this.PnlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEntete
            // 
            this.pnlEntete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEntete.Controls.Add(this.cbGroupes);
            this.pnlEntete.Controls.Add(this.LinkedLntf);
            this.pnlEntete.Controls.Add(this.LinkedLid);
            this.pnlEntete.Controls.Add(this.LinkedLnom);
            this.pnlEntete.Controls.Add(this.lblGroupe);
            this.pnlEntete.Controls.Add(this.lblId);
            this.pnlEntete.Controls.Add(this.lblNom);
            this.pnlEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEntete.Location = new System.Drawing.Point(1, 2);
            this.pnlEntete.Name = "pnlEntete";
            this.pnlEntete.Size = new System.Drawing.Size(900, 45);
            this.pnlEntete.TabIndex = 0;
            // 
            // cbGroupes
            // 
            this.cbGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupes.FormattingEnabled = true;
            this.cbGroupes.Location = new System.Drawing.Point(462, 6);
            this.cbGroupes.Name = "cbGroupes";
            this.cbGroupes.Size = new System.Drawing.Size(145, 26);
            this.cbGroupes.TabIndex = 10;
            // 
            // LinkedLntf
            // 
            this.LinkedLntf.AutoSize = true;
            this.LinkedLntf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedLntf.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LinkedLntf.Location = new System.Drawing.Point(853, 3);
            this.LinkedLntf.MinimumSize = new System.Drawing.Size(37, 37);
            this.LinkedLntf.Name = "LinkedLntf";
            this.LinkedLntf.Size = new System.Drawing.Size(37, 37);
            this.LinkedLntf.TabIndex = 6;
            this.LinkedLntf.Click += new System.EventHandler(this.BtnProfil_Click);
            // 
            // LinkedLid
            // 
            this.LinkedLid.AutoSize = true;
            this.LinkedLid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedLid.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LinkedLid.Location = new System.Drawing.Point(279, 9);
            this.LinkedLid.Name = "LinkedLid";
            this.LinkedLid.Size = new System.Drawing.Size(21, 20);
            this.LinkedLid.TabIndex = 5;
            this.LinkedLid.TabStop = true;
            this.LinkedLid.Text = "...";
            this.LinkedLid.Click += new System.EventHandler(this.BtnProfil_Click);
            // 
            // LinkedLnom
            // 
            this.LinkedLnom.AutoSize = true;
            this.LinkedLnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedLnom.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LinkedLnom.Location = new System.Drawing.Point(66, 9);
            this.LinkedLnom.Name = "LinkedLnom";
            this.LinkedLnom.Size = new System.Drawing.Size(21, 20);
            this.LinkedLnom.TabIndex = 4;
            this.LinkedLnom.TabStop = true;
            this.LinkedLnom.Text = "...";
            this.LinkedLnom.Click += new System.EventHandler(this.BtnProfil_Click);
            // 
            // lblGroupe
            // 
            this.lblGroupe.AutoSize = true;
            this.lblGroupe.Location = new System.Drawing.Point(366, 6);
            this.lblGroupe.Name = "lblGroupe";
            this.lblGroupe.Size = new System.Drawing.Size(100, 20);
            this.lblGroupe.TabIndex = 2;
            this.lblGroupe.Text = "Groupe (s): ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(213, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(69, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "№ DA : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // PnlBtns
            // 
            this.PnlBtns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlBtns.Controls.Add(this.BtnProfil);
            this.PnlBtns.Controls.Add(this.BtnExamen);
            this.PnlBtns.Controls.Add(this.BtnLancerQuiz);
            this.PnlBtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlBtns.Location = new System.Drawing.Point(615, 51);
            this.PnlBtns.Name = "PnlBtns";
            this.PnlBtns.Size = new System.Drawing.Size(286, 615);
            this.PnlBtns.TabIndex = 2;
            // 
            // BtnProfil
            // 
            this.BtnProfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnProfil.Location = new System.Drawing.Point(0, 409);
            this.BtnProfil.Name = "BtnProfil";
            this.BtnProfil.Size = new System.Drawing.Size(282, 202);
            this.BtnProfil.TabIndex = 2;
            this.BtnProfil.Text = "Mon compte";
            this.BtnProfil.UseVisualStyleBackColor = true;
            this.BtnProfil.Click += new System.EventHandler(this.BtnProfil_Click);
            // 
            // BtnExamen
            // 
            this.BtnExamen.Location = new System.Drawing.Point(0, 201);
            this.BtnExamen.Name = "BtnExamen";
            this.BtnExamen.Size = new System.Drawing.Size(282, 209);
            this.BtnExamen.TabIndex = 1;
            this.BtnExamen.Text = "Passer un Examen";
            this.BtnExamen.UseVisualStyleBackColor = true;
            this.BtnExamen.Click += new System.EventHandler(this.BtnExamen_Click);
            // 
            // BtnLancerQuiz
            // 
            this.BtnLancerQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLancerQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLancerQuiz.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLancerQuiz.Location = new System.Drawing.Point(0, 0);
            this.BtnLancerQuiz.Name = "BtnLancerQuiz";
            this.BtnLancerQuiz.Size = new System.Drawing.Size(282, 202);
            this.BtnLancerQuiz.TabIndex = 0;
            this.BtnLancerQuiz.Text = "Lancer Quiz";
            this.BtnLancerQuiz.UseVisualStyleBackColor = true;
            this.BtnLancerQuiz.Click += new System.EventHandler(this.BtnLancerQuiz_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(1, 51);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(608, 615);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // FenEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 671);
            this.Controls.Add(this.PnlBtns);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlEntete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FenEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenetre quiz Etudiant";
            this.pnlEntete.ResumeLayout(false);
            this.pnlEntete.PerformLayout();
            this.PnlBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEntete;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblGroupe;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel PnlBtns;
        private System.Windows.Forms.Button BtnLancerQuiz;
        private System.Windows.Forms.Button BtnExamen;
        private System.Windows.Forms.Button BtnProfil;
        private System.Windows.Forms.LinkLabel LinkedLid;
        private System.Windows.Forms.LinkLabel LinkedLnom;
        private System.Windows.Forms.LinkLabel LinkedLntf;
        private System.Windows.Forms.ComboBox cbGroupes;
    }
}