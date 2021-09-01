using Projet1_questions.modele;
using Projet1_questions.singleton;
using Projet1_questions.ui;
using Projet1_questions.ui.etudiant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.services
{
    class ScenarioServices
    {
        private static Profil monProfil;
        public static ListePanneaux lancerScenario(int nbrQuestions, ListeQuestions listeQuestion, Etudiant etudiant, int typeQuestChoisies)
        {

            monProfil = Profil.GetProfil(etudiant, nbrQuestions);
            Scenario monScenario = new Scenario(nbrQuestions, listeQuestion, typeQuestChoisies);

            ListePanneaux listePanneau = new ListePanneaux(monScenario);//, monProfil);
            Console.WriteLine("Mon profil = "+ monProfil);
            return listePanneau;
        }

        public static void Repondre(string reponse, int position)
        {
            if (reponse.Equals("true"))
                monProfil.AjouterNote(position);
        }

        public static PanneauResultat AfficherResultat()
        {
            PanneauResultat panneauResultat = new PanneauResultat();
            return panneauResultat;
        }
        public static Profil GetProfil()
        {
            return monProfil;
        }
    }
}
