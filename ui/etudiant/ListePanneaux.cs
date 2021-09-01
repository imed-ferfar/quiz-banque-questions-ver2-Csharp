using Projet1_questions.modele;
using Projet1_questions.singleton;
using Projet1_questions.ui.etudiant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.ui
{
    class ListePanneaux
    {
        public List<PanneauQuiz> listing { get; }
        //public Profil monProfil { get; }
        public  Scenario monScenario { get; }
        private PanneauQuiz monPanneau;

        // constructeurs
        public ListePanneaux()
        {
        }

        public ListePanneaux(Scenario monScenario)
        {
            listing = new List<PanneauQuiz>();
            this.monScenario = monScenario;
            remplirListeDePanneaux(monScenario);
        }

        // Ajouter une nombre définit (monScenario1.getSize()) de panneaux
        private void remplirListeDePanneaux(Scenario monScenario1)
        {
            int cle;
            for (int i = 0; i < monScenario1.GetSize(); i++)
            {
                cle = monScenario1.tableauCles()[i];
                switch (monScenario1.GetQuestionN(cle).titre)
                {
                    case "Choisir la ou les bonnes réponses":
                        monPanneau = new PanneauQCM((QCM)monScenario1.GetQuestionN(cle));
                        listing.Add(monPanneau);
                        break;
                    case "Trouver l'erreur dans ce code":
                        monPanneau = new PanneauErrImg((Erreur_image)monScenario1.GetQuestionN(cle));
                        listing.Add(monPanneau);
                        break;
                    case "Trouver le resultat d'execution de ce code":
                        monPanneau = new PanneauResExec((Resultat_execution)monScenario1.GetQuestionN(cle));
                        listing.Add(monPanneau);
                        break;
                }
            }
        }

        public PanneauQuiz GetListing(int position)
        {
            return listing.ElementAt(position);
        }

        public int GetSize()
        {
            return listing.Count;
        }

        // pour ajouter un panneau
        public void AjouterPanneau(PanneauQuiz panneau)
        {
            listing.Add(panneau);
        }

        public bool FinReponses()
        {
            for (int i = 0; i < listing.Count; i++)
            {
                if (listing.ElementAt(i).Reponse == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
