using Projet1_questions.modele;
using Projet1_questions.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.ui.enseignant.affficherQues
{
    public partial class FenetreAfficheQuestion : Form
    {
        //
        private QCM questionQCM { get; set; }
        public CheckBox[] tabChoix { get; set; }
        public Label lblQuestion { get; set; }
        //
        private Erreur_image questionImg;
        private Panel pnlResultat;
        private Label label1, label2, label3;
        private TextBox txtN, txtErreur, txtCorrection;
        //
        private Resultat_execution questionResExe;
        private TextBox TxtCode;
        private Panel PnlResultExec;
        private TextBox TxtReponse;
        private Label LblResultat;

        public FenetreAfficheQuestion()
        {
            InitializeComponent();
        }

        public FenetreAfficheQuestion(Question question) :this()
        {
            lblTitre.Text = question.titre;
            if (question is QCM)
            {
                questionQCM = (QCM)question;
                ModifierContenuQCM();
            }
            else if (question is Erreur_image)
            {
                questionImg = (Erreur_image)question;
                ModifierContenuImg();
            } else
            {
                questionResExe = (Resultat_execution)question;
                ModifierContenuResExe();
            }
        }

        //Affichage une question QCM
        private void ModifierContenuQCM()
        {
            lblQuestion = new Label();
            lblQuestion.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblQuestion.Text = (questionQCM.la_question);
            lblQuestion.Location = new Point(91, 111);
            lblQuestion.Size = new Size(750, 45);
            Controls.Add(lblQuestion);
           

            int y = 90;
            tabChoix = new CheckBox[questionQCM.liste_choix.Count];

            for (int i = 0; i < questionQCM.liste_choix.Count; i++)
            {
                tabChoix[i] = new CheckBox();
                tabChoix[i].Enabled = false;
                tabChoix[i].Size = new Size(710, 50);
                tabChoix[i].Text = questionQCM.liste_choix.ElementAt(i).choix;
                tabChoix[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                tabChoix[i].BackColor = Color.Gainsboro;
                tabChoix[i].Location = new Point(51, (y + 69));

                if (questionQCM.liste_choix.ElementAt(i).statut_choix)
                    tabChoix[i].Checked = true;
                Controls.Add(tabChoix[i]);
                y += 59;
            }
        }

        //Affichage une question Erreur sur image
        private void ModifierContenuImg()
        {
            lblQuestion = new Label();
            lblQuestion.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblQuestion.Size = new Size(630, 285);
            lblQuestion.Location = new Point(99, 95);
            Image image = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + questionImg.url_image);
            lblQuestion.Image = GestionImage.AjusterImage(image, 630, 285);
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
            pnlResultat.Location = new Point(117, 399);
            pnlResultat.Size = new Size(590, 74);
            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(36, 9);
            label1.Size = new Size(60, 18);
            label1.Text = "N ligne";
            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(171, 9);
            label2.Size = new Size(55, 18);
            label2.Text = "Erreur";
            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(390, 9);
            label3.Size = new Size(88, 18);
            label3.Text = "Correction";
            // txtN
            txtN.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtN.Location = new Point(39, 38);
            txtN.Size = new Size(76, 24);
            txtN.Text = questionImg.num_ligne.ToString();
            txtN.ReadOnly = true;
            // txtErreur
            txtErreur.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtErreur.Location = new Point(174, 38);
            txtErreur.Size = new Size(162, 24);
            txtErreur.Text = questionImg.erreur;
            txtErreur.ReadOnly = true;
            // txtCorrection
            txtCorrection.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtCorrection.Location = new Point(393, 38);
            txtCorrection.Size = new Size(162, 24);
            txtCorrection.Text = questionImg.correction;
            txtCorrection.ReadOnly = true;
            // 
            Controls.Add(this.pnlResultat);
        }

        //Affichage une question Resultat d'Execution
        private void ModifierContenuResExe()
        {
            TxtCode = new TextBox();
            PnlResultExec = new Panel();
            LblResultat = new Label();
            TxtReponse = new TextBox();

            // TxtCode
            TxtCode.Text = questionResExe.le_code;
            TxtCode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            TxtCode.Location = new Point(115, 123);
            TxtCode.Multiline = true;
            TxtCode.ReadOnly = true;
            TxtCode.Size = new Size(575, 200);
            // PnlResultExec
            PnlResultExec.BorderStyle = BorderStyle.Fixed3D;
            PnlResultExec.Controls.Add(this.TxtReponse);
            PnlResultExec.Controls.Add(this.LblResultat);
            PnlResultExec.Location = new Point(155, 350);
            PnlResultExec.Size = new Size(432, 130);
            // LblResultat
            LblResultat.AutoSize = true;
            LblResultat.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            LblResultat.Location = new Point(20, 12);
            LblResultat.Size = new Size(80, 18);
            // TxtReponse
            TxtReponse.Text = questionResExe.reponse;
            TxtReponse.AcceptsReturn = true;
            TxtReponse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            TxtReponse.Location = new Point(106, 13);
            TxtReponse.Multiline = true;
            TxtReponse.Size = new Size(299, 108);
            TxtReponse.ReadOnly = true;

            Controls.Add(this.PnlResultExec);
            Controls.Add(this.TxtCode);
        }
    }
}
