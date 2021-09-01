using Projet1_questions.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.services
{
    class PresentationServices
    {
        //Afficher la liste des etudiants dans un groupe #1
        public static DLL_projet.GroupeEtudiantsDll ListerEtudiant(DataGridView DGVEtuds, DLL_projet.GroupeDll unGroupe)
        {
            Etudiant etud;
            //recuperer liste des etudiants dans un groupe

            List<Etudiant> listeEtuds = QuestionServices.EtudiantsGroupe(unGroupe.id_groupe);
            DLL_projet.GroupeEtudiantsDll grEtd = new DLL_projet.GroupeEtudiantsDll(unGroupe);

            foreach (Etudiant etd in listeEtuds)
                grEtd.AjouterEtudiant(new DLL_projet.EtudiantDll(etd.id_personne,etd.nom,etd.prenom,etd.courriel));

            DGVEtuds.Rows.Clear();
            for (int i = 0; i < listeEtuds.Count; i++)
            {
                etud = listeEtuds.ElementAt(i);
                Console.WriteLine("etud :" + etud.ToString());
                DGVEtuds.Rows.Insert(i, etud.id_personne, etud.nom, etud.prenom, etud.courriel);
            }
            return grEtd;
        }

        //Afficher la liste des etudiants recherches #2
        public static void ListerEtudiant(List<Etudiant> listeEtuds, DataGridView DGVEtuds)
        {
            Etudiant etud;
            DGVEtuds.Rows.Clear();
            for (int i = 0; i < listeEtuds.Count; i++)
            {
                etud = listeEtuds.ElementAt(i);
                Console.WriteLine("etud :" + etud.ToString());
                DGVEtuds.Rows.Insert(i, etud.id_personne, etud.nom, etud.prenom, etud.courriel);
            }
        }

        //Afficher la liste des groupes pour un enseignant
        public static List<Groupe> ListerGroupe(DataGridView DGVgroupe, Personne perso)
        {
            //recuperer les groupes de l'enseignant
            List<Groupe> mesGroupes = QuestionServices.ChargerGroupes(perso);
            Groupe unGroupe;
            DGVgroupe.Rows.Clear();
            for (int i = 0; i < mesGroupes.Count; i++)
            {
                unGroupe = mesGroupes.ElementAt(i);
                DGVgroupe.Rows.Insert(i, unGroupe.id_groupe, unGroupe.titre);
            }
            return mesGroupes;
        }


        //Afficher la liste des invitation pour un enseignant
        public static List<Invitation> ListerInvitation(DataGridView DGVinvitation, Personne perso)
        {
            Invitation invit;
            //recuperer liste des invitation de l'enseignant
            List<Invitation> listInvit = QuestionServices.ChargerInvitation(perso);
            DGVinvitation.Rows.Clear();
            if (perso is Enseignant)
                for (int i = 0; i < listInvit.Count; i++)
                {
                    invit = listInvit.ElementAt(i);
                    DGVinvitation.Rows.Insert(i, invit.id_etudiant, invit.nom + " " + invit.prenom, invit.id_groupe, invit.titre, invit.date, invit.heure, invit.commentaire);
                }
            else
                for (int i = 0; i < listInvit.Count; i++)
                {
                    invit = listInvit.ElementAt(i);
                    DGVinvitation.Rows.Insert(i, invit.nom + " " + invit.prenom, invit.id_groupe, invit.titre, invit.date, invit.heure, invit.commentaire);
                }

            return listInvit;
        }

        public static ListeQuestions ListerQuestion(DataGridView DGVquestion, string id_enseignant)
        {
            //recuperer les questions de l'enseignant
            DGVquestion.Rows.Clear();
            ListeQuestions listingQues = QuestionServices.ChargerQuestions(id_enseignant);
            Question uneQuestion;
            DGVquestion.Rows.Clear();
            string id_enseig, laQuestion = ""; ;
            for (int i = 0; i < listingQues.GetSize(); i++)
            {
                uneQuestion = listingQues.GetQuestionN(listingQues.tableauCles()[i]);
                id_enseig = uneQuestion.id_enseignant;
                if (uneQuestion is QCM)
                    laQuestion = ((QCM)uneQuestion).la_question;
                else if (uneQuestion is Erreur_image)
                    laQuestion = ((Erreur_image)uneQuestion).url_image;
                else if (uneQuestion is Resultat_execution)
                    laQuestion = ((Resultat_execution)uneQuestion).le_code;
                DGVquestion.Rows.Insert(i, uneQuestion.id_question, uneQuestion.titre, laQuestion, id_enseig);
            }
            //DGVquestion.fi
            return listingQues;
        }
        public static ListeQuestions ListerQuestion(DataGridView DGVquestion, string id_enseignant, char c)
        {
            //recuperer les questions de l'enseignant
            DGVquestion.Rows.Clear();
            ListeQuestions listingQues = QuestionServices.ChargerQuestions(id_enseignant);
            Question uneQuestion;
            DGVquestion.Rows.Clear();
            string id_enseig, laQuestion = "";
            int cpt = 0;
            for (int i = 0; i < listingQues.GetSize(); i++)
            {
                uneQuestion = listingQues.GetQuestionN(listingQues.tableauCles()[i]);
                id_enseig = uneQuestion.id_enseignant;
                    if (id_enseignant.Equals(id_enseig))
                    {
                        if (uneQuestion is QCM)
                            laQuestion = ((QCM)uneQuestion).la_question;
                        else if (uneQuestion is Erreur_image)
                            laQuestion = ((Erreur_image)uneQuestion).url_image;
                        else if (uneQuestion is Resultat_execution)
                            laQuestion = ((Resultat_execution)uneQuestion).le_code;
                        DGVquestion.Rows.Insert(cpt, uneQuestion.id_question, uneQuestion.titre, laQuestion, id_enseignant);
                    cpt++;
                    }
            }
            //DGVquestion.fi
            return listingQues;
        }
    }
}
