using Projet1_questions.modele;
using System;
using System.Windows.Forms;

namespace Projet1_questions.ui.enseignant.modif
{
    public partial class PanAjoutQuesRes : UserControl
    {
        private Resultat_execution maQuestion;

        //conetructeur#1 (ajout qcm)
        public PanAjoutQuesRes()
        {
            InitializeComponent();
        }

        //conetructeur#2 (modif Resultat_execution)
        public PanAjoutQuesRes(Resultat_execution maQuestion) : this()
        {
            this.maQuestion = maQuestion;
            ModifierQuestion();
        }


        //Modifier qcm
        private void ModifierQuestion()
        {
            TxtCode.Text = maQuestion.le_code;
            TxtReponse.Text = maQuestion.reponse;
            TxtPond.Text = maQuestion.ponderation.ToString();
            ChkBPartage.Checked = maQuestion.partage;
        }
        //Getters
        public bool Partage()
        {
            Console.WriteLine("ChkBPartage :" + ChkBPartage);
            return ChkBPartage.Checked;
        }
        public string Le_code()
        {
            return TxtCode.Text;
        }

        public string la_reponse()
        {
            return TxtReponse.Text;
        }
        public int Ponderation()
        {
            return Int32.Parse(TxtPond.Text);
        }



        //Reinitialiser() les champs
        public void Reinitialiser()
        {
            TxtCode.Text = ("");
            TxtReponse.Text = ("");
            TxtPond.Text = "1";
            ChkBPartage.Checked = true;
        }

        //valider les champs de saisi
        public bool ValiderData()
        {
            if (TxtCode.Text.Equals(""))
            {
                MessageBox.Show("La question est obligatoire! Vauillez taper une partie de code", "Saisie de valeurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtReponse.Text.Equals(""))
            {
                MessageBox.Show("Le resultat d'execution du code tapé ci-dissus est obligatoire!", "Saisie de valeurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

      
    }
}
