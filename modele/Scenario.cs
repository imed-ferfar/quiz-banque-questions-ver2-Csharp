using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.modele
{
    class Scenario : ListeQuestions
    {
        private ListeQuestions listeQuestion;
        private int typeQuestChoisies; //choisi par l'utilisateur(1,2,3,4,5,6,7) où  1=QCM, 2=ErreurImg, 4=ResExec
        private readonly Random random = new Random();
        private int[] tabCle;
        int[] tabTemp;

        // Constructeurs
        public Scenario() 
        {
        }

        
        //Constructeur de la classe Scenario
        public Scenario(int nombreQues, ListeQuestions listeQuestion, int typeQuestChoisies) //: this()
        {
            this.listeQuestion = listeQuestion;
            this.typeQuestChoisies = typeQuestChoisies;
            tabCle = listeQuestion.tableauCles();

            // creer un tableau pour recevoir les reponses
            tabTemp = new int[nombreQues];
            RemplirTableauAleatoire(tabTemp);
            for (int i = 0; i < tabTemp.Length; i++)
            {
                try
                {
                    AjouterQuestion(listeQuestion.GetQuestionN(tabTemp[i]));
                }
                catch (QuestionDejaPresenteException e)
                {
                    MessageBox.Show(e.ques.ToString(),"Erreur ajout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            AfficherQuestions();// test visuel
        }

        private void RemplirTableauAleatoire(int[] tab)
        {
            int val;  //stocker valeur aleatoire
            int max = listeQuestion.MaxCle();  // la plus grande cle dans la liste des questions
            int min = listeQuestion.MinCle();  // la plus petite cle dans la liste des questions
            String titre;    //titre d'une question
            Console.WriteLine("min :" + min + ",   max :" + max);        //test visuel
            Console.WriteLine("Lise aleatoire des questions : " + tab.Count()); //test visuel
            Console.WriteLine("typeQuestChoisies : " + typeQuestChoisies);   //test visuel
            for (int i = 0; i < tab.Count(); i++)
            {
                val = (random.Next(min,max+1));   //exemple 5
                titre = GetTitre(val);
                switch (typeQuestChoisies)
                {
                    case 1:  //QCM
                        while (!VerifierValeur(tab, val, i) || (!titre.Equals("Choisir la ou les bonnes réponses")))//"Choisir la ou les bonnes réponses")) //listeQuestion.GetTitreQCM();
                        {
                            //test visuel
                            Console.WriteLine(val + "---->" + (VerifierValeur(tab, val, i) + "---" +titre));
                            val = (random.Next(min, max + 1));
                            titre = GetTitre(val);
                        }
                        break;

                    case 2:  //ErreurImg
                        while (!VerifierValeur(tab, val, i) || (!titre.Equals("Trouver l'erreur dans ce code")))
                        {
                            val = (random.Next(min, max + 1));
                            titre = GetTitre(val);
                        }
                        break;
                    case 4:  //ResExe
                        while (!VerifierValeur(tab, val, i) || (!titre.Equals("Trouver le resultat d'execution de ce code")))
                        {
                            val = (random.Next(min, max + 1));
                            titre = GetTitre(val);
                        }
                        break;
                    case 3:
                        while (!VerifierValeur(tab, val, i) || (titre.Equals("Trouver le resultat d'execution de ce code")))
                        {
                            val = (random.Next(min, max + 1));
                            titre = GetTitre(val);
                        }
                        break;
                    case 6:
                        while (!VerifierValeur(tab, val, i) || (titre.Equals("Choisir la ou les bonnes réponses")))
                        {
                            val = (random.Next(min, max + 1));
                            titre = GetTitre(val);
                        }
                        break;
                    case 5:
                        while (!VerifierValeur(tab, val, i) || (titre.Equals("Trouver l'erreur dans ce code")))
                        {
                            val = (random.Next(min, max + 1));
                            titre = GetTitre(val);
                        }
                        break;
                    case 7:
                        while (!VerifierValeur(tab, val, i))
                        {
                            val = (random.Next(min, max + 1));
                        }
                        break;
                    default:
                        MessageBox.Show("Désolé! veuillez repeter svp", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                tab[i] = val;
                Console.WriteLine(tab[i]);//test visuel
            }
        }

        private bool VerifierValeur(int[] tab, int nombre, int position)
        {
            if (!tabCle.Contains(nombre))
                return false;
            for (int i = 0; i < position; i++)
            {
                if (nombre == tab[i])
                    return false;
            }
            return true;
        }

        private string GetTitre(int cle)
        {
            string titre;
            try
            {
                titre = listeQuestion.GetQuestionN(cle).titre;
            }
            catch (KeyNotFoundException ex)
            {
                titre = "";
                Console.WriteLine(ex.Message);
            }
            return titre;
        }
    }
}