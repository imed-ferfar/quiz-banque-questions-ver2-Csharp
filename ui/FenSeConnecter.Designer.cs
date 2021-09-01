
using System;

namespace Projet1_questions
{
    partial class FenSeConnecter
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenSeConnecter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkMotPasseOublie = new System.Windows.Forms.LinkLabel();
            this.LinkNouveauUtilisateur = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.txtMotPasse = new System.Windows.Forms.TextBox();
            this.txtUtilisteur = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RadioBtnEtud = new System.Windows.Forms.RadioButton();
            this.RadioBtnEnsei = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkMotPasseOublie);
            this.panel1.Controls.Add(this.LinkNouveauUtilisateur);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSeConnecter);
            this.panel1.Controls.Add(this.txtMotPasse);
            this.panel1.Controls.Add(this.txtUtilisteur);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 280);
            this.panel1.TabIndex = 0;
            // 
            // linkMotPasseOublie
            // 
            this.linkMotPasseOublie.AutoSize = true;
            this.linkMotPasseOublie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMotPasseOublie.Location = new System.Drawing.Point(87, 173);
            this.linkMotPasseOublie.Name = "linkMotPasseOublie";
            this.linkMotPasseOublie.Size = new System.Drawing.Size(149, 15);
            this.linkMotPasseOublie.TabIndex = 7;
            this.linkMotPasseOublie.TabStop = true;
            this.linkMotPasseOublie.Text = "mot de passe oublié ?";
            this.linkMotPasseOublie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMotPasseOublie_LinkClicked);
            // 
            // LinkNouveauUtilisateur
            // 
            this.LinkNouveauUtilisateur.AutoSize = true;
            this.LinkNouveauUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkNouveauUtilisateur.Location = new System.Drawing.Point(83, 250);
            this.LinkNouveauUtilisateur.Name = "LinkNouveauUtilisateur";
            this.LinkNouveauUtilisateur.Size = new System.Drawing.Size(157, 18);
            this.LinkNouveauUtilisateur.TabIndex = 6;
            this.LinkNouveauUtilisateur.TabStop = true;
            this.LinkNouveauUtilisateur.Text = "Créez votre compte";
            this.LinkNouveauUtilisateur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNouveauUtilisateur_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 46);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se connecter";
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeConnecter.Location = new System.Drawing.Point(90, 206);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(143, 27);
            this.btnSeConnecter.TabIndex = 3;
            this.btnSeConnecter.Text = "Connexion";
            this.btnSeConnecter.UseVisualStyleBackColor = true;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // txtMotPasse
            // 
            this.txtMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotPasse.Location = new System.Drawing.Point(90, 146);
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.PasswordChar = '*';
            this.txtMotPasse.Size = new System.Drawing.Size(143, 24);
            this.txtMotPasse.TabIndex = 2;
            this.txtMotPasse.Text = "11111111";
            // 
            // txtUtilisteur
            // 
            this.txtUtilisteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilisteur.Location = new System.Drawing.Point(90, 105);
            this.txtUtilisteur.Name = "txtUtilisteur";
            this.txtUtilisteur.Size = new System.Drawing.Size(143, 24);
            this.txtUtilisteur.TabIndex = 1;
            this.txtUtilisteur.Text = "1111111";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.RadioBtnEtud);
            this.panel3.Controls.Add(this.RadioBtnEnsei);
            this.panel3.Location = new System.Drawing.Point(12, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 40);
            this.panel3.TabIndex = 5;
            // 
            // RadioBtnEtud
            // 
            this.RadioBtnEtud.AutoSize = true;
            this.RadioBtnEtud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnEtud.Location = new System.Drawing.Point(178, 3);
            this.RadioBtnEtud.Name = "RadioBtnEtud";
            this.RadioBtnEtud.Size = new System.Drawing.Size(96, 24);
            this.RadioBtnEtud.TabIndex = 1;
            this.RadioBtnEtud.Text = "Etudiant";
            this.RadioBtnEtud.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEnsei
            // 
            this.RadioBtnEnsei.AutoSize = true;
            this.RadioBtnEnsei.Checked = true;
            this.RadioBtnEnsei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnEnsei.Location = new System.Drawing.Point(16, 3);
            this.RadioBtnEnsei.Name = "RadioBtnEnsei";
            this.RadioBtnEnsei.Size = new System.Drawing.Size(120, 24);
            this.RadioBtnEnsei.TabIndex = 0;
            this.RadioBtnEnsei.TabStop = true;
            this.RadioBtnEnsei.Text = "Enseignant";
            this.RadioBtnEnsei.UseVisualStyleBackColor = true;
            this.RadioBtnEnsei.Click += new System.EventHandler(this.RadioBtnEnsei_Click);
            // 
            // FenSeConnecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 279);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FenSeConnecter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Se connecter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.TextBox txtMotPasse;
        private System.Windows.Forms.TextBox txtUtilisteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RadioBtnEtud;
        private System.Windows.Forms.RadioButton RadioBtnEnsei;
        private System.Windows.Forms.LinkLabel LinkNouveauUtilisateur;
        private System.Windows.Forms.LinkLabel linkMotPasseOublie;
    }
}

