using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.modele
{
    public class ListeQuestions
    {
        protected const string TITRE_QCM = "Choisir la ou les bonnes réponses";
        protected const string TITRE_IMG_ERR = "Trouver l'erreur dans ce code";
        protected const string TITRE_RES_EXE = "Trouver le resultat d'execution de ce code";
        private Dictionary<int, Question> mapQuestion;
        public ListeQuestions()
        {
            mapQuestion = new Dictionary<int, Question>();
        }

        public void AjouterQuestion(Question maQuestion)
        {

        if (VerifierDoublon(maQuestion))
                throw new QuestionDejaPresenteException(maQuestion, "Question en double!!!");
        else 
                mapQuestion.Add(maQuestion.id_question, maQuestion);
        }

        private bool VerifierDoublon(Question maQuestion)
        {
            foreach (KeyValuePair<int, Question> entry in mapQuestion)
            {
                if (maQuestion.Equals(entry.Value))
                    return true;
            }
            return false;
        }

        public bool SupprimerQuestion(int cle)
        {
            if (mapQuestion.ContainsKey(cle))
            {
                mapQuestion.Remove(cle);
                MessageBox.Show("La question N : " + cle + " a été bien supprimée", "Seppression avec succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Désolé le ID_question : " + cle + " est non trouvé", "Erreur de seppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public Question GetQuestionN(int cle)
        {
            return mapQuestion[cle];
        }

        public int GetSize()
        {
            return mapQuestion.Count;
        }

        public int[] tableauCles()
        {
            int[] tab = new int[mapQuestion.Count()];
            int i = 0;
            foreach (KeyValuePair<int, Question> tmp in mapQuestion)
            {
                tab[i] = tmp.Key;
                i++;
            }
            return tab;  //   [cle1,cle2,cle3 ........clen]
        }

        public void ListerQuestion()
        {
            Console.WriteLine("=========Listing des questions=========");
            foreach (KeyValuePair<int, Question> tmp in mapQuestion)
                Console.WriteLine("clé: " + tmp.Key + " | " + tmp.Value);
        }

        public int MinCle()
        {
            int minVal = tableauCles()[0];
            for (int i = 1; i < tableauCles().Count(); i++)
            {
                if (tableauCles()[i] < minVal)
                    minVal = tableauCles()[i];
            }
            return minVal;
        }

        public int MaxCle()
        {
            int maxVal = tableauCles()[0];
            for (int i = 1; i < tableauCles().Count(); i++)
            {
                if (tableauCles()[i] > maxVal)
                    maxVal = tableauCles()[i];
            }
            return maxVal;
        }

        public void AfficherQuestions()
        {
            Console.WriteLine("=========Listing des questions=========");
            foreach (KeyValuePair<int, Question> tmp in mapQuestion)
                {
                Console.WriteLine("clé: " + tmp.Key + " | " + tmp.Value);
            }
        }

        
        
    }
}
