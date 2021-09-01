using Projet1_questions.modele;
using Projet1_questions.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Projet1_questions.ui
{
    public partial class PanneauDebut : UserControl
    {
        private int typeQuestion; //{1,2,4}
        public PanneauDebut()
        {
            InitializeComponent();

            CbListeNbQues.SelectedIndex = 0;
            string[] listeMat = QuestionServices.ListerMatieres().ToArray();
            LBmatiere.Items.AddRange(listeMat);
            LBmatiere.SelectedIndex = 0;

        }



        public List<string> GetListeTags()
        {
            List<string> listeTags = new List<string>();

            foreach (int i in LBmatiere.SelectedIndices)
            {
                listeTags.Add(LBmatiere.Items[i].ToString());
               // Console.WriteLine("allooooo"+i+ "   "+ listeTags[i]);
            }
            return listeTags;
        }

        public int GetNombreQuestions()
        {
            return Int32.Parse((string)CbListeNbQues.SelectedItem);
        }

        public int GetTypeQuestion()
        {
            typeQuestion = 0;
            if (ChBQCM.Checked)
            {
                typeQuestion += 1;
            }
            if (ChBErreur.Checked)
            {
                typeQuestion += 2;
            }
            if (ChBImage.Checked)
            {
                typeQuestion += 4;
            }
            Console.WriteLine("typeQuestion = "+ typeQuestion);
            return typeQuestion;
        }


        public bool ValiderSaisi()
        {
            if (LBmatiere.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Veuillez choisir au moins un tag !!!", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CbListeNbQues.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez choisir le nombre de question !!!", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(ChBQCM.Checked|| ChBErreur.Checked || ChBImage.Checked))
            {
                MessageBox.Show("Veuillez choisir au moins un type de question !!!", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        
    }
}
