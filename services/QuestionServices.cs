using Projet1_questions.daos;
using Projet1_questions.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.services
{
    public class QuestionServices
    {
        //Importer lises des comptes personnes (ID) ..1
        public static List<String> GetIdPersonnes()
        {
            QuestionDao dao = new SqlQuestion();
            return dao.GetListePersonne();
        }

        //Ajout d'un nouveau compte (Enseignant / Etudiant) ..2
        public static void AjouterPersonne(Personne perso)
        {
            QuestionDao dao = new SqlQuestion();
            dao.AjouterNouvellePersonne(perso);
        }

        //Authentifier un compte (Enseignant / Etudiant) ..3
        public static Personne AuthentifierPerso(Personne perso)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.AuthentifierPersonne(perso);
        }

        //Recuperer toutes les questions ..4
        public static ListeQuestions ChargerQuestions(string id_enseignant)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.ChargerLesQuestions(id_enseignant);
        }

        //Recuperer les etudiant d'un groupe ..5
        public static List<Etudiant> EtudiantsGroupe(string id_groupe)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.GetListeEtudiants(id_groupe);
        }

        //Ajouter un groupe..6
        public static void CreerGroupe(Groupe unGroupe)
        {
            QuestionDao dao = new SqlQuestion();
            dao.SetGroupe(unGroupe);
        }

        //Recuperer tout les groupes..7
        public static List<Groupe> ChargerGroupes(Personne perso)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.GetListeGroupes(perso);
        }

        //Supprission d'un groupe..8
        public static void SupprimerGroupe(string id_groupe)
        {
            QuestionDao dao = new SqlQuestion();
            dao.SupprimerGroupe(id_groupe);
        }

        //Modification d'un groupe..9
        public static void ModifierGroupe(string id_groupe, string titre)
        {
            QuestionDao dao = new SqlQuestion();
            dao.ModifierGroupe(id_groupe,titre);
        }

        //Rechercher etudiants ..10
        public static List<Etudiant> RechercherEtudiant(string motCle)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.GetRechercheEtudiants(motCle);
        }

        //Verifier si un etudiant appartient à un groupe  ..11
        public static bool VerifierEtudiantDansGroupe(string id_etudiant,string id_goupe)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.IsEtudiantDansGroupe(id_etudiant,id_goupe);
        }

        //Envoyer une invitation de joindre un groupe  ..12
        public static void EnvoyerInvitation(Invitation invit)
        {
            QuestionDao dao = new SqlQuestion();
            dao.SetInvitation(invit);
        }

        //Recuperer la liste des invitation envoyees par n enseignant  ..13
        public static List<Invitation> ChargerInvitation(Personne perso)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.GetListeInvitations(perso);
        }

        //Annuler une invitation en cours  ..14
        public static void AnnulerInvitation(Invitation invit)
        {
            QuestionDao dao = new SqlQuestion();
            dao.DeleteInvitation(invit);
        }

        //Recuperer un titre d'un groupe  ..15
        public static string TitreGroupe(string id_groupe)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.GetTitreGroupe(id_groupe);
        }

        //Verifier si une une invitation est en cours existe   ..16
        public static bool VerifierInvitation(string id_etudiant, string id_goupe)
        {
            QuestionDao dao = new SqlQuestion();
            return dao.IsInvitationExiste(id_etudiant, id_goupe);
        }

        //Modifier le mot de passe d'une personne   ..17
        public static void ModifierMotPasse(string id_personne, string mot_passe)
        {
            QuestionDao dao = new SqlQuestion();
            dao.SetNouveauPasse(id_personne, mot_passe);
        }

        //Modifier les infos d'une personne   ..18
        public static void ModifierInfos(Personne perso)
        {
            QuestionDao dao = new SqlQuestion();
            dao.SetInfosPersonne(perso);
        }

        //Repondre (accepter / rejeter) une invitation    ..19
        public static void RepondreInvitation(Invitation invit, string reponse)
        {
            QuestionDao dao = new SqlQuestion();
            dao.SetReponseInvitation(invit, reponse);
        }


        //Generer un nouveau id_question   ..20
        public static int NouveauIdQuestion()
        {
            QuestionDao dao = new SqlQuestion();
            return dao.GetNewIdQuestion();
        }

        //Ajouter une nouvelle question
        public static void AjouterQuestion(Question ques)
        {
            QuestionDao dao = new SqlQuestion();
            dao.SetQuestion(ques);
        }

        //Aupprimer une  question
        public static void SupprimerQuestion(Question ques)
        {
            QuestionDao dao = new SqlQuestion();
            dao.DeleteQuestion(ques);
        }

        //Modifier une  question
        public static void ModifierQuestion(Question ques)
        {
            QuestionDao dao = new SqlQuestion();
            dao.EditerQuestion(ques);
        }

        //Chercher liste des matieres
        public static List<string> ListerMatieres()
        {
            QuestionDao dao = new SqlQuestion();
            return dao.ListeMatiere();
        }




    }
}
