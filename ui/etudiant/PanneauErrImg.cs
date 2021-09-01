using Projet1_questions.modele;
using Projet1_questions.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.ui.etudiant
{
    class PanneauErrImg : PanneauQuiz
    {
        private Erreur_image questionImg;
        public Label lblQuestion { get; set; }
        private Panel pnlResultat;
        private Label label1, label2, label3;
        private TextBox txtN, txtErreur, txtCorrection;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PanneauErrImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PanneauErrImg";
            this.ResumeLayout(false);

        }

        public PanneauErrImg(Erreur_image questionImg) : base(questionImg)
        {
            this.questionImg = questionImg;
            ModifierContenuImg();
        }


        //Afficher une question Image avec erreur
         private void ModifierContenuImg()
         {

             lblQuestion = new Label();
             //lblQuestion.Background(new java.awt.Color(51, 51, 255));
             lblQuestion.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
             lblQuestion.Size = new Size(630, 285);
             lblQuestion.Location = new Point(149, 101);
             Image image = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + questionImg.url_image);
             lblQuestion.Image = GestionImage.AjusterImage(image,630,285);
             Controls.Add(lblQuestion);

             pnlResultat = new Panel();
             label1 = new Label();
             label2 = new Label();
             label3 = new Label();
             txtN = new TextBox();
             txtErreur = new TextBox();
             txtCorrection = new TextBox();

             pnlResultat.BorderStyle = BorderStyle.Fixed3D;
             pnlResultat.Controls.Add(txtCorrection);
             pnlResultat.Controls.Add(txtErreur);
             pnlResultat.Controls.Add(txtN);
             pnlResultat.Controls.Add(label3);
             pnlResultat.Controls.Add(label2);
             pnlResultat.Controls.Add(label1);
             pnlResultat.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
             pnlResultat.Location = new Point(167, 405);
             pnlResultat.Size = new Size(590, 74);
             // 
             // label1
             // 
             label1.AutoSize = true;
             label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
             label1.Location = new Point(36, 9);
             label1.Size = new Size(60, 18);
             label1.Text = "N ligne";
             // 
             // label2
             // 
             label2.AutoSize = true;
             label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
             label2.Location = new Point(171, 9);
             label2.Size = new Size(55, 18);
             label2.Text = "Erreur";
             // 
             // label3
             // 
             label3.AutoSize = true;
             label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
             label3.Location = new Point(390, 9);
             label3.Size = new Size(88, 18);
             label3.Text = "Correction";
             // 
             // txtN
             // 
             txtN.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
             txtN.Location = new Point(39, 38);
             txtN.Name = "txtN";
             txtN.Size = new Size(76, 24);
             txtN.TabIndex = 0;
             // 
             // txtErreur
             // 
             txtErreur.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
             txtErreur.Location = new Point(174, 38);
             txtErreur.Name = "txtErreur";
             txtErreur.Size = new Size(162, 24);
             txtErreur.TabIndex = 1;
             // 
             // txtCorrection
             // 
             txtCorrection.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
             txtCorrection.Location = new Point(393, 38);
             txtCorrection.Name = "txtCorrection";
             txtCorrection.Size = new Size(162, 24);
             txtCorrection.TabIndex = 2;
             // 
             Controls.Add(this.pnlResultat);
         }


        // Valider Réponse Erreur sur image
        public override bool ValiderReponse()
        {
            bool flag = false;
            if (txtN.Text.Equals(questionImg.num_ligne.ToString()) & txtErreur.Text.Contains(questionImg.erreur)
                & txtCorrection.Text.Contains(questionImg.correction))
            {
                flag = true;
                Console.WriteLine("okkkk");
            }
                
            txtN.ReadOnly = true;
            txtErreur.ReadOnly = true;
            txtCorrection.ReadOnly = true;
            AfficherLblresultat(flag);
            Reponse = flag.ToString();
            return flag;
        }


    }
}
