using Projet1_questions.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.ui.enseignant.modif
{
    public partial class PanAjoutQCM : UserControl
    {
        public List<TextBox> listeChoix { get; set; }
        public List<CheckBox> listeBonnesReponses { get; set; }
        private TextBox nouveauText;
        private CheckBox nouveauCheck;
        private QCM maQuestion;
        private int nombreCh = 2;
        //conetructeur#1 (ajout qcm)
        public PanAjoutQCM()
        {
            InitializeComponent();
            AjoutQuestion();
        }

        //conetructeur#2 (modif qcm)
        public PanAjoutQCM(QCM maQuestion) : this()
        {
            this.maQuestion = maQuestion;
            ModifierQuestion();
        }

        //Ajouter qcm
        public void AjoutQuestion()
        {
            listeChoix = new List<TextBox>();
            listeChoix.Add(TxtChoix1);
            listeChoix.Add(TxtChoix2);

            listeBonnesReponses = new List<CheckBox>();
            listeBonnesReponses.Add(CheckBox1);
            listeBonnesReponses.Add(CheckBox2);
        }

        //Modifier qcm
        private void ModifierQuestion()
        {
            TxtQuestion.Text = (maQuestion.la_question);
            nombreCh = maQuestion.liste_choix.Count;
            TxtNbrChoix.Text = nombreCh.ToString();
            while (nombreCh != listeChoix.Count)
                AjoutSupprimChoix(nombreCh);
            for (int i = 0; i < nombreCh; i++)
            {
                listeChoix.ElementAt(i).Text = maQuestion.liste_choix.ElementAt(i).choix;
                if (maQuestion.liste_choix.ElementAt(i).statut_choix)
                {
                    listeBonnesReponses.ElementAt(i).Checked = true;
                }
            }
            ChkBPartage.Checked = maQuestion.partage;
            TxtPond.Text = maQuestion.ponderation.ToString();
        }

        // + ou - d'un choix de question
        private void AjoutSupprimChoix(int nombre)
        {
            if (nombre > listeChoix.Count)
            {
                listeChoix.Add(NouveauTextBox());
                listeBonnesReponses.Add(NouveauCheckBox());
            }
            else if (nombre < listeChoix.Count)
            {
                Controls.Remove(listeChoix.ElementAt(listeChoix.Count - 1));
                listeChoix.RemoveAt(listeChoix.Count - 1);
                Controls.Remove(listeBonnesReponses.ElementAt(listeBonnesReponses.Count - 1));
                listeBonnesReponses.RemoveAt(listeBonnesReponses.Count - 1);
            }
        }

        // nouveau TextBox (choix)
        private TextBox NouveauTextBox()
        {
            nouveauText = new TextBox();
            nouveauText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            nouveauText.Location = new Point(TxtChoix1.Location.X, 67 + ((listeChoix.Count + 1) * 42));
            nouveauText.Size = new Size(742, 24);
            Controls.Add(nouveauText);

            return nouveauText;
        }

        // nouveau CheckBox (statut_choix)
        private CheckBox NouveauCheckBox()
        {
            nouveauCheck = new CheckBox();
            nouveauCheck.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            nouveauCheck.Location = new Point(CheckBox1.Location.X, 67 + ((listeChoix.Count) * 42));
            nouveauCheck.Size = new Size(15, 14);
            Controls.Add(nouveauCheck);

            return nouveauCheck;
        }

        //Getters
        public string LaQuestion()
        {
            return TxtQuestion.Text;
        }
        public int Ponderation()
        {
            return Int32.Parse(TxtPond.Text);
        }
        public bool Partage()
        {
            return ChkBPartage.Checked;
        }

        //Reinitialiser() les champs
        public void Reinitialiser()
        {
            TxtQuestion.Text = "";
            TxtPond.Text = "1";
            for (int i = 0; i < listeChoix.Count; i++)
            {
                listeChoix.ElementAt(i).Text = "";
                listeBonnesReponses.ElementAt(i).Checked = false;
            }
        }

        //valider les champs de saisi
        public bool ValiderData()
        {
            if (TxtQuestion.Text.Equals(""))
            {
                MessageBox.Show("La question est obligatoire!", "Saisie de valeurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < listeChoix.Count; i++)
            {
                if (listeChoix.ElementAt(i).Text.Equals(""))
                {
                    MessageBox.Show("Veuillez completer tous les champs manquants", "Saisie de valeurs", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
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

            for (int i = 0; i < listeBonnesReponses.Count; i++)
            {
                if (listeBonnesReponses.ElementAt(i).Checked)
                {
                    return true;
                }
            }
            
            MessageBox.Show("Vous devez cocher au moins une bonne réponse", "Choix des bonnes reponses", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }



        private void BtnPlusChoix_Click(object sender, EventArgs e)
        {
            nombreCh++;
            TxtNbrChoix.Text = nombreCh.ToString();
            AjoutSupprimChoix(nombreCh);
            if (nombreCh == 5)
                BtnPlusChoix.Enabled = false;
            BtnMoinsChoix.Enabled = true;
        }

        private void BtnMoinsChoix_Click(object sender, EventArgs e)
        {
            nombreCh--;
            TxtNbrChoix.Text = nombreCh.ToString();
            AjoutSupprimChoix(nombreCh);
            if (nombreCh == 2)
                BtnMoinsChoix.Enabled = false;
            BtnPlusChoix.Enabled = true;
        }

  

    }
}
