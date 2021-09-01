using Projet1_questions.modele;
using Projet1_questions.services;
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

namespace Projet1_questions.ui.enseignant.modif
{
    public partial class PanAjoutQuesImg : UserControl
    {
        public string url_image {get;set;}
        public int id_question { get; set; }
        private Erreur_image maQuestion;
        private DialogResult res;
        Image image;
        
        string pathDestination;
        PictureBox PBimage;

        //conetructeur#1 (ajout qcm)
        public PanAjoutQuesImg()
        {
            InitializeComponent();
            AjoutQuestion();
        }

        //conetructeur#2 (modif ques Erreur_image)
        public PanAjoutQuesImg(Erreur_image maQuestion) : this()
        {
            this.maQuestion = maQuestion;
            Console.WriteLine(maQuestion.ToString());
            ModifierQuestion();
        }

        //Getters
        public int Ponderation()
        {
            return Int32.Parse(TxtPond.Text);
        }
        public bool Partage()
        {
            return ChkBPartage.Checked;
        }
        public int NumLigne()
        {
            return Int32.Parse(TxtNligne.Text);
        }
        public string Erreur()
        {
            return TxtErreur.Text;
        }
        public string Correction()
        {
            return TxtCorrection.Text;
        }

        //Ajouter ques Erreur_image
        public void AjoutQuestion()
        {
            image = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/icones/choisir.jpg");
            PnlImage.BackgroundImage = GestionImage.AjusterImage(image, PnlImage.Width, PnlImage.Height);

        }

        //Modifier ques Erreur_image
        private void ModifierQuestion()
        {
            url_image = maQuestion.url_image;
            TxtUrlImage.Text = url_image;
            image = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + url_image);
            PnlImage.BackgroundImage = GestionImage.AjusterImage(image, PnlImage.Width, PnlImage.Height);

            TxtNligne.Text = maQuestion.num_ligne.ToString();
            TxtErreur.Text = maQuestion.erreur;
            TxtCorrection.Text = maQuestion.correction;

            TxtPond.Text = maQuestion.ponderation.ToString();
            ChkBPartage.Checked = maQuestion.partage;

        }

        //bouton choisir une image
        private void BtnImage_Click(object sender, EventArgs e)
        {
            PBimage = new PictureBox();
            res = oFDimage.ShowDialog();
            id_question = QuestionServices.NouveauIdQuestion();
            url_image = "/ImageErreurs/question" + id_question + ".png";
            pathDestination = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + url_image;

            if (res == DialogResult.OK)
            {
                PBimage.ImageLocation = oFDimage.FileName;
                File.Copy(PBimage.ImageLocation, pathDestination);

                TxtUrlImage.Text = PBimage.ImageLocation;
                image = Image.FromFile(PBimage.ImageLocation);
                PnlImage.BackgroundImage = GestionImage.AjusterImage(image, PnlImage.Width, PnlImage.Height);

                //Console.WriteLine("pb.ImageLocation : " + pb.ImageLocation + "\npb : " + pb.ToString());
            }
        }

        //valider les champs de saisi
        public bool ValiderData()
        {
            if (TxtUrlImage.Text.Equals(""))
            {
                MessageBox.Show("Vous devez choisir une image!", "Saisie de valeurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((TxtNligne.Text.Equals("")) || (TxtErreur.Text.Equals("")) || (TxtCorrection.Text.Equals("")))
            {
                MessageBox.Show("Vous devez comleter les champs manquants!", "Saisie de valeurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                if (Int32.Parse(TxtNligne.Text) <= 0)
                {
                    MessageBox.Show("Le numéro de ligne doit etre un entier positif.", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La ponderation doit etre un nombre entier entre [1 - 5]", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                if ((Int32.Parse(TxtPond.Text) < 1) || (Int32.Parse(TxtPond.Text) > 5))
                {
                    MessageBox.Show("La ponderation doit etre entre [1 - 5]", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La ponderation doit etre un nombre entier entre [1 - 5]", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //Reinitialiser() les champs
        public void Reinitialiser()
        {
            TxtUrlImage.Text = "";
            TxtPond.Text = "1";
            TxtNligne.Text = "";
            TxtErreur.Text = "";
            TxtCorrection.Text = "";
        }
    }
}
