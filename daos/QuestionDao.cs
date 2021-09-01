using Projet1_questions.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Projet1_questions.daos
{
    public interface QuestionDao
    {
        List<String> GetListePersonne(); //..1

        void AjouterNouvellePersonne(Personne perso);//..2

        Personne AuthentifierPersonne(Personne perso);//..3

        ListeQuestions ChargerLesQuestions(string id_enseignant);//..4

        List<Etudiant> GetListeEtudiants(string id_groupe);//..5

        void SetGroupe(Groupe unGroupe);//..6

        List<Groupe> GetListeGroupes(Personne perso);//..7

        void SupprimerGroupe(string id_groupe);//..8

        void ModifierGroupe(string id_groupe,string titre);//..9

        List<Etudiant> GetRechercheEtudiants(string moCle); // ..10

        bool IsEtudiantDansGroupe(string id_etudiant,string id_groupe); // ..11

        void SetInvitation(Invitation invit);  // ..12

        List<Invitation> GetListeInvitations(Personne perso);   // ..13

        void DeleteInvitation(Invitation invit);   // ..14

        string GetTitreGroupe(string id_grpupe);   // ..15

        bool IsInvitationExiste(string id_etudiant, string id_groupe);

        void SetNouveauPasse(string id_personne, string mot_passe);

        void SetInfosPersonne(Personne perso);

        void SetReponseInvitation(Invitation invit, string reponse);

        int GetNewIdQuestion();

        void SetQuestion(Question ques);

        void DeleteQuestion(Question ques);

        void EditerQuestion(Question ques);

        List<string> ListeMatiere();

        //une autre methodes
    }
}
