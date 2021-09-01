using MySql.Data.MySqlClient;
using Projet1_questions.modele;
using Projet1_questions.singleton;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.daos
{
    public class SqlQuestion : QuestionDao
    {
        //1)Importer lises des comptes personnes (ID)
        public List<string> GetListePersonne()
        {
            DbCommand cmd;
            List<string> list_id = new List<string>();
            DbDataReader dr;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT id_personne FROM `personne`";
                cmd.CommandType = CommandType.Text;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list_id.Add((string)dr["id_personne"]);
                   // Console.WriteLine("id_personne : " + dr["id_personne"]);
                    //Ou:
                    //listeProds.Items.Add(dr.Getstring("NUM") + ": " + dr.Getstring("DESIGN"));
                }
                BdConnexion.Fermer();
            }
            return list_id;
        }

        //2)Ajout d'une nouvelle personne (Enseignant / Etudiant)
        public void AjouterNouvellePersonne(Personne perso)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq = "";
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                if (perso is Enseignant)
                    rq = "INSERT INTO `personne` (`id_personne`, `nom`, `prenom`, `courriel`, `motPasse`, `etat`) VALUES" +
                    "(@id_personne, @nom, @prenom, @courriel, @motPasse, 'true');" +
                    "INSERT INTO  enseignant  (id_enseignant ) VALUES (@id_personne)";
                else
                    rq = "INSERT INTO `personne` (`id_personne`, `nom`, `prenom`, `courriel`, `motPasse`, `etat`) VALUES" +
                    "(@id_personne, @nom, @prenom, @courriel, @motPasse, 'true');" +
                    "INSERT INTO etudiant (id_etudiant) VALUES (@id_personne)";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_personne", perso.id_personne);
                sqlCmd.Parameters.AddWithValue("nom", perso.nom);
                sqlCmd.Parameters.AddWithValue("prenom", perso.prenom);
                sqlCmd.Parameters.AddWithValue("courriel", perso.courriel);
                sqlCmd.Parameters.AddWithValue("motPasse", perso.motPasse);

                dr = sqlCmd.ExecuteReader();
                BdConnexion.Fermer();
            }
        }

        //3)Authentifier un compte (Enseignant / Etudiant)
        public Personne AuthentifierPersonne(Personne perso)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq;
            string id_personne="", nom="", prenom="", courriel="", motPasse="", etat="";
            string titre = "", id_groupe="";
            Groupe unGroupe;
            List<Groupe> list_groupe = new List<Groupe>();
            bool flag = false;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                if (perso is Enseignant)
                    rq = "SELECT * FROM personne p JOIN enseignant e ON(p.id_personne= e.id_enseignant) WHERE p.id_personne = @id_personne AND p.motPasse = @motPasse";
                else
                    rq = "SELECT * FROM personne p JOIN etudiant e ON(p.id_personne= e.id_etudiant) WHERE p.id_personne = @id_personne AND p.motPasse = @motPasse";

                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_personne", perso.id_personne);
                sqlCmd.Parameters.AddWithValue("motPasse", perso.motPasse);

                dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                {
                    id_personne = (string)dr["id_personne"]; // perso.id_personne;
                    nom = (string)dr["nom"];
                    prenom = (string)dr["prenom"];
                    courriel = (string)dr["courriel"];
                    motPasse = (string)dr["motPasse"]; // perso.motPasse;
                    etat = (string)dr["etat"];
                    BdConnexion.Fermer();
                    flag = true;
                }
            }
            //recuperer les groupes de la personne
            if (flag)
            {
                using (MySqlConnection cnx = BdConnexion.GetConnexion())
                {
                    if (perso is Enseignant)
                        rq = "SELECT * FROM groupe  WHERE id_enseignant = @id_personne";
                    else
                        rq = "SELECT * FROM affectation a JOIN groupe g ON(a.id_groupe= g.id_groupe) WHERE a.id_etudiant = @id_personne";

                    sqlCmd = (MySqlCommand)cnx.CreateCommand();
                    sqlCmd.CommandText = rq;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("id_personne", perso.id_personne);
                    dr = sqlCmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id_groupe = (string)dr["id_groupe"]; // perso.id_personne;
                        titre = (string)dr["titre"];
                        //   id_personne = (string)dr["id_personne"];
                        unGroupe = new Groupe(id_groupe, titre, id_personne);
                        list_groupe.Add(unGroupe);
                    }
                    /*if (dr["id_groupe"] == DBNull.Value)
                        id_groupe = "N/A";
                    else
                        id_groupe = (string)dr["id_groupe"];*/
                }
                BdConnexion.Fermer();
                if (perso is Etudiant)
                    perso = new Etudiant(id_personne, nom, prenom, courriel, motPasse, etat);
                else
                    perso = new Enseignant(id_personne, nom, prenom, courriel, motPasse, etat);

                perso.listinGroupe = list_groupe;
                return perso;
            } else
                return null;
            
        }

        //4)Charger les questions de la bdd
        public ListeQuestions ChargerLesQuestions(string id_enseig)
        {
            //DbCommand cmd;
            DbDataReader dr, dr2;
            ListeQuestions maListeQues = new ListeQuestions();
            string titre, id_enseignant, id_matiere, la_question, url_image, erreur, correction, le_code,reponse;

            int id_question, ponderation, num_ligne;
            bool partage, statut_choix;
            QCM maQcm;
            Erreur_image maQesImg;
            Resultat_execution maQuesExe;
            //QCM maQcm;
            List<int> listTemp = new List<int>();

            MySqlCommand sqlCmd;
            string rq, choix;

            //charger QCM
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                sqlCmd = cnx.CreateCommand();
                sqlCmd.CommandText = "SELECT *  FROM question q JOIN qcm c ON(q.id_question = c.id_question) " +
                    "WHERE (id_enseignant LIKE @id_enseignant) OR partage = 'true'";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_enseignant", id_enseig);
                dr = sqlCmd.ExecuteReader();
                while (dr.Read())
                {
                    id_question = Int32.Parse((string)(dr["id_question"]));
                    titre = (string)(dr["titre"]);
                    ponderation = Int32.Parse((string)(dr["ponderation"]));
                    partage = Convert.ToBoolean((string)(dr["partage"]));
                    id_enseignant = (string)(dr["id_enseignant"]);
                    id_matiere = (string)(dr["id_matiere"]);
                    la_question = (string)(dr["la_question"]);

                    maQcm = new QCM(id_question, titre, ponderation, partage, id_enseignant, id_matiere, la_question);
                  //  Console.WriteLine("Question : " + maQcm.ListerQCM());
                    maListeQues.AjouterQuestion(maQcm);
                    listTemp.Add(id_question);
                }
                    BdConnexion.Fermer();
            }
            //charger les choix de chaque QCM
            foreach (int tmp in listTemp)
            {
                using (MySqlConnection cnx = BdConnexion.GetConnexion())
                {
                    rq = "SELECT * FROM `liste_choix` where id_question = @id_question";
                    sqlCmd = (MySqlCommand)cnx.CreateCommand();
                    sqlCmd.CommandText = rq;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("id_question", tmp);
                    dr2 = sqlCmd.ExecuteReader();
                    Choix unChoix;
                    while (dr2.Read())
                    {
                        choix = (string)(dr2["choix"]);
                        statut_choix = Convert.ToBoolean((string)(dr2["statut_choix"]));
                        unChoix = new Choix(choix, statut_choix);
                        maQcm = (QCM)maListeQues.GetQuestionN(tmp);
                        maQcm.AjouterChoix(unChoix);
                    }
                    //Console.WriteLine("Question : " + ((QCM)maListeQues.GetQuestionN(tmp)).ListerQCM());
                }
                    BdConnexion.Fermer();
            }
            // charger Image erreur
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                sqlCmd = cnx.CreateCommand();
                sqlCmd.CommandText = "SELECT *  FROM question q JOIN erreur_image c ON(q.id_question = c.id_question) " +
                    "WHERE (id_enseignant LIKE @id_enseignant) OR partage = 'true'";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_enseignant", id_enseig);
                dr = sqlCmd.ExecuteReader();
                while (dr.Read())
                {
                    id_question = Int32.Parse((string)(dr["id_question"]));
                    titre = (string)(dr["titre"]);
                    ponderation = Int32.Parse((string)(dr["ponderation"]));
                    partage = Convert.ToBoolean((string)(dr["partage"]));
                    id_enseignant = (string)(dr["id_enseignant"]);
                    id_matiere = (string)(dr["id_matiere"]);

                    url_image = (string)(dr["url_image"]);
                    num_ligne = dr.GetInt32(8);
                   // dr.Getstring("DESIGN")
                    erreur = (string)(dr["erreur"]);
                    correction = (string)(dr["correction"]);


                    maQesImg = new Erreur_image(id_question, titre, ponderation, partage, id_enseignant, id_matiere, url_image, num_ligne, erreur, correction);
                    //Console.WriteLine("Question : " + maQesImg.ToString());
                    maListeQues.AjouterQuestion(maQesImg);
                }
                BdConnexion.Fermer();
            }

            // charger Resultat execution
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                sqlCmd = cnx.CreateCommand();
                sqlCmd.CommandText = "SELECT *  FROM question q JOIN resultat_execution c ON(q.id_question = c.id_question) " +
                    "WHERE(id_enseignant LIKE @id_enseignant) OR partage = 'true'";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_enseignant", id_enseig);
                dr = sqlCmd.ExecuteReader();
                while (dr.Read())
                {
                    id_question = Int32.Parse((string)(dr["id_question"]));
                    titre = (string)(dr["titre"]);
                    ponderation = Int32.Parse((string)(dr["ponderation"]));
                    partage = Convert.ToBoolean((string)(dr["partage"]));
                    id_enseignant = (string)(dr["id_enseignant"]);
                    id_matiere = (string)(dr["id_matiere"]);

                    le_code = (string)(dr["le_code"]);
                    // dr.Getstring("DESIGN")
                    reponse = (string)(dr["reponse"]);

                    maQuesExe = new Resultat_execution(id_question, titre, ponderation, partage, id_enseignant, id_matiere, le_code, reponse);
                  //  Console.WriteLine("Question : " + maQuesExe.ToString());
                    maListeQues.AjouterQuestion(maQuesExe);
                }
                BdConnexion.Fermer();
            }
            return maListeQues;
        }

        //5) Liste des etudiants d'un groupe
        public List<Etudiant> GetListeEtudiants(string id_groupe)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq,id_etiduant,nom,prenom,courriel;
            List<Etudiant> list_etud = new List<Etudiant>();
            Etudiant etud;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "SELECT p.id_personne,p.nom,p.prenom,p.courriel FROM etudiant e " +
                    "JOIN affectation a ON(e.id_etudiant= a.id_etudiant) " +
                    "JOIN personne p ON(e.id_etudiant= p.id_personne)" +
                    "WHERE a.id_groupe = @id_groupe";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_groupe", id_groupe);

                dr = sqlCmd.ExecuteReader();
                while (dr.Read())
                {
                    id_etiduant = (string)dr["id_personne"];
                    nom = (string)dr["nom"];
                    prenom = (string)dr["prenom"];
                    courriel = (string)dr["courriel"];
                    etud = new Etudiant(id_etiduant, nom, prenom, courriel);
                    list_etud.Add(etud);
                    //Ou:
                    //listeProds.Items.Add(dr.Getstring("NUM") + ": " + dr.Getstring("DESIGN"));
                }
                BdConnexion.Fermer();
            }
            return list_etud;
        }

        //6)Ajouter un nouveau groupe
        public void SetGroupe(Groupe unGroupe)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq = "";
            bool flag = true;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "INSERT INTO `groupe` (`id_groupe`, `titre`, `id_enseignant`) VALUES" +
                "(@id_groupe, @titre, @id_enseignant);";
                try
                {
                    sqlCmd = (MySqlCommand)cnx.CreateCommand();
                    sqlCmd.CommandText = rq;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("id_groupe", unGroupe.id_groupe);
                    sqlCmd.Parameters.AddWithValue("titre", unGroupe.titre);
                    sqlCmd.Parameters.AddWithValue("id_enseignant", unGroupe.id_enseignant);
                
                    dr = sqlCmd.ExecuteReader();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Désolé, cet ID_groupe déjà utilisé, veuillez le changer\n"+
                        e.Message, "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                BdConnexion.Fermer();
                if (flag)
                    MessageBox.Show("Le groupe suivant a été bien ajouté :\nID_groupe : "+ unGroupe.id_groupe
                    +"\nTitre : "+ unGroupe.titre, "Ajout avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //7) Recuperer liste des groupes d'un enseignant
        public List<Groupe> GetListeGroupes(Personne perso)
        {
            MySqlCommand sqlCmd = null;
            DbDataReader dr;
            List<Groupe> list_gr = new List<Groupe>();
            string rq = "", id_groupe, titre;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                if (perso is Enseignant)
                    rq = "SELECT * FROM groupe where id_enseignant = @id_personne";
                else
                    rq = "SELECT * FROM affectation a JOIN groupe g ON (a.id_groupe = g.id_groupe) " +
                        "WHERE a.id_etudiant = @id_personne  ";

                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_personne", perso.id_personne);
                dr = sqlCmd.ExecuteReader();
               
                while (dr.Read())
                {
                    id_groupe = (string)dr["id_groupe"];
                    titre = (string)dr["titre"];
                    list_gr.Add(new Groupe(id_groupe,titre));
                }
                return list_gr;
            }
        }

        //8) Supprimer un goupe
        public void SupprimerGroupe(string id_groupe)
        {
            MySqlCommand sqlCmd = null;
            DbDataReader dr;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = "DELETE FROM groupe where id_groupe = @id_groupe";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_groupe", id_groupe);
                dr = sqlCmd.ExecuteReader();
                MessageBox.Show("Le groupe suivant a été bien supprimé :\nID_groupe : " +id_groupe
                    , "Supprision avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //9) Modification un goupe
        public void ModifierGroupe(string id_groupe, string titre)
        {
            MySqlCommand sqlCmd = null;
            DbDataReader dr;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = "UPDATE groupe SET titre = @titre WHERE id_groupe = @id_groupe";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_groupe", id_groupe);
                sqlCmd.Parameters.AddWithValue("titre", titre);
                dr = sqlCmd.ExecuteReader();
                MessageBox.Show("Le groupe suivant a été bien modifié :\nID_groupe : " + id_groupe
                    +"\nTitre : "+titre, "Modification avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //10) Rechercher etudiants par mot cle (Id, nom ou prénom)
        public List<Etudiant> GetRechercheEtudiants(string motCle)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq, id_etiduant, nom, prenom, courriel;
            List<Etudiant> list_etud = new List<Etudiant>();
            Etudiant etud;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "SELECT p.id_personne,p.nom,p.prenom,p.courriel " +
                    "FROM etudiant e JOIN personne p ON(p.id_personne = e.id_etudiant) " +
                    "WHERE (e.id_etudiant LIKE @motCle) || (UPPER(p.nom) LIKE @motCle) || (UPPER(p.prenom) LIKE @motCle)";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("motCle", "%"+motCle.ToUpper()+"%");

                dr = sqlCmd.ExecuteReader();
                while (dr.Read())
                {
                    id_etiduant = (string)dr["id_personne"];
                    nom = (string)dr["nom"];
                    prenom = (string)dr["prenom"];
                    courriel = (string)dr["courriel"];
                    etud = new Etudiant(id_etiduant, nom, prenom, courriel);
                    list_etud.Add(etud);
                    //Ou:
                    //listeProds.Items.Add(dr.Getstring("NUM") + ": " + dr.Getstring("DESIGN"));
                }
                BdConnexion.Fermer();
            }
            return list_etud;
        }

        //11) Verifier si un etudiant est dans un groupe
        public bool IsEtudiantDansGroupe(string id_etudiant, string id_groupe)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq;
            bool flag = false;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "SELECT * FROM affectation WHERE (id_etudiant = @id_etudiant) && (id_groupe = @id_groupe)";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_etudiant", id_etudiant);
                sqlCmd.Parameters.AddWithValue("id_groupe", id_groupe);

                dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                    flag = true;
                BdConnexion.Fermer();
            }
            return flag;
        }

        //12) Ajouter une invitation de joindre un groupe
        public void SetInvitation(Invitation invit)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq = "";
            bool flag = true;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "INSERT INTO `invitation` (`id_enseignant`, `id_etudiant`,`id_groupe`,`date`, `heure`,`commentaire`) VALUES" +
                "(@id_enseignant, @id_etudiant, @id_groupe, @date, @heure, @commentaire);";
                try
                {
                    sqlCmd = (MySqlCommand)cnx.CreateCommand();
                    sqlCmd.CommandText = rq;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("id_enseignant", invit.id_enseignant);
                    sqlCmd.Parameters.AddWithValue("id_etudiant", invit.id_etudiant);
                    sqlCmd.Parameters.AddWithValue("id_groupe", invit.id_groupe);
                    sqlCmd.Parameters.AddWithValue("date", invit.date);
                    sqlCmd.Parameters.AddWithValue("heure", invit.heure);
                    sqlCmd.Parameters.AddWithValue("commentaire", invit.commentaire);

                    dr = sqlCmd.ExecuteReader();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Désolé, vous avec deja envoyé une invitaion à cet etudiant pour joindre ce groupe\n"
                        + e.Message, "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                BdConnexion.Fermer();
                if (flag)
                    MessageBox.Show("L'invitation  suivante a été bien envoyée :\nID_etudiant : " + invit.id_etudiant
                    + "ànID_groupe : " + invit.id_groupe, "Invitation avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //13)Recuperer la liste de sinvitations en cours, pour un enseignant
        public List<Invitation> GetListeInvitations(Personne perso)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq, id_etiduant, id_groupe, titre, nom, prenom, date, heure, commentaire;
            List<Invitation> list_invi = new List<Invitation>();
            Invitation invit;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                if (perso is Enseignant)
                rq = "SELECT * FROM invitation i " +
                    "JOIN personne p ON(i.id_etudiant= p.id_personne) " +
                    "JOIN groupe g ON(i.id_groupe= g.id_groupe) " +
                    "WHERE i.id_enseignant = @id_personne AND i.statut is null";
                else
                    rq = "SELECT * FROM invitation i " +
                    "JOIN personne p ON(i.id_enseignant= p.id_personne) " +
                    "JOIN groupe g ON(i.id_groupe= g.id_groupe) " +
                    "WHERE i.id_etudiant = @id_personne AND i.statut is null";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_personne", perso.id_personne);

                dr = sqlCmd.ExecuteReader();
                while (dr.Read())
                {
                    id_etiduant = (string)dr["id_personne"];
                    id_groupe = (string)dr["id_groupe"];
                    titre = (string)dr["titre"];
                    nom = (string)dr["nom"];
                    prenom = (string)dr["prenom"];
                    date = (string)dr["date"];
                    heure = (string)dr["heure"];
                    commentaire = (string)dr["commentaire"];
                    invit = new Invitation(id_etiduant, id_groupe, titre, nom, prenom, date, heure, commentaire);
                    list_invi.Add(invit);
                    //Ou:
                    //listeProds.Items.Add(dr.Getstring("NUM") + ": " + dr.Getstring("DESIGN"));
                }
                BdConnexion.Fermer();
            }
            return list_invi;
        }


        //14) Annuler une invitation en cours
        public void DeleteInvitation(Invitation invit)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "Delete FROM invitation WHERE id_groupe = @id_groupe AND id_etudiant = @id_etudiant";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_groupe", invit.id_groupe);
                sqlCmd.Parameters.AddWithValue("id_etudiant", invit.id_etudiant);
                dr = sqlCmd.ExecuteReader();
            }
            BdConnexion.Fermer();
            MessageBox.Show("L'invitation suivante a été bien annulée :\nID_etudiant : " + invit.id_etudiant
                    + "ànID_groupe : " + invit.id_groupe, "Annulation invitation avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //15) Recuperer un titre d'un groupe
        public string GetTitreGroupe(string id_groupe)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq, titre = "";
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "SELECT titre FROM groupe WHERE id_groupe = @id_groupe";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_groupe", id_groupe);
                dr = sqlCmd.ExecuteReader();

                if (dr.Read())
                    titre = (string)(dr["titre"]);
            }
            BdConnexion.Fermer();
            return titre;
        }

        //16) Verifier si une invitation est en cours
        public bool IsInvitationExiste(string id_etudiant, string id_groupe)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq;
            bool flag = false;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "SELECT * FROM invitation WHERE (id_etudiant = @id_etudiant) AND (id_groupe = @id_groupe) AND (statut IS NULL)";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_etudiant", id_etudiant);
                sqlCmd.Parameters.AddWithValue("id_groupe", id_groupe);

                dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                    flag = true;
                BdConnexion.Fermer();
            }
            return flag;
        }

        //17) Enregistrer un nouveau mot de passe
        public void SetNouveauPasse(string id_personne, string mot_passe)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "UPDATE personne SET motPasse = @mot_passe WHERE id_personne =@id_personne";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_personne", id_personne);
                sqlCmd.Parameters.AddWithValue("mot_passe", mot_passe);
                dr = sqlCmd.ExecuteReader();
            }
            MessageBox.Show("Le mot de passe est modifié : ", "Modification du mot de passe avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BdConnexion.Fermer();
        }

        //18) Enregistrer des nouvelles infos (personne)
        public void SetInfosPersonne(Personne perso)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "UPDATE personne SET nom = @nom, prenom = @prenom, courriel = @courriel WHERE id_personne =@id_personne";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("nom", perso.nom);
                sqlCmd.Parameters.AddWithValue("prenom", perso.prenom);
                sqlCmd.Parameters.AddWithValue("courriel", perso.courriel);
                sqlCmd.Parameters.AddWithValue("id_personne", perso.id_personne);
                dr = sqlCmd.ExecuteReader();
            }
            MessageBox.Show("Les nouvelles informations sont enregistrées : ", "Modification des informations avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BdConnexion.Fermer();
        }

        //19)Repondre a une invitation
        public void SetReponseInvitation(Invitation invit,string statut)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;
            string rq;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "UPDATE invitation SET statut = @statut WHERE id_etudiant =@id_etudiant AND id_groupe =@id_groupe";
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("statut", statut);
                sqlCmd.Parameters.AddWithValue("id_etudiant", invit.id_etudiant);
                sqlCmd.Parameters.AddWithValue("id_groupe", invit.id_groupe);
                dr = sqlCmd.ExecuteReader();
            }
            BdConnexion.Fermer();
            if (statut.Equals("false"))
                MessageBox.Show("L'invitation pour joindre le groupe : "+invit.id_groupe+", a été bien rejetée.", "Invitation rejetée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                using (MySqlConnection cnx = BdConnexion.GetConnexion())
                {
                    rq = "INSERT INTO `affectation` (`id_etudiant`,`id_groupe`) VALUES (@id_etudiant, @id_groupe);";
                    sqlCmd = (MySqlCommand)cnx.CreateCommand();
                    sqlCmd.CommandText = rq;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("id_etudiant", invit.id_etudiant);
                    sqlCmd.Parameters.AddWithValue("id_groupe", invit.id_groupe);
                    dr = sqlCmd.ExecuteReader();
                    MessageBox.Show("L'invitation pour joindre le groupe : " + invit.id_groupe + ", a été bien acceptée.", "Invitation acceptée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }


        //20)Generer un id_question (min)
        public int GetNewIdQuestion()
        {
            DbCommand cmd;
            DbDataReader dr;
            string rq,id_ques="";
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                rq = "SELECT MAX(CONVERT(id_question,UNSIGNED INTEGER)) as 'max(id_question)' FROM question;";
                cmd = (MySqlCommand)cnx.CreateCommand();
                cmd.CommandText = rq;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    id_ques = dr["max(id_question)"].ToString();
            }
            BdConnexion.Fermer();
            return Int32.Parse(id_ques)+1;
        }

        //21)Ajouter une nouvelle question
        public void SetQuestion(Question ques)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;

            QCM maQCM = null;
            Resultat_execution maResExe = null;
            Erreur_image maErrImg = null;

            string rq = "INSERT INTO `question` (`id_question`,`titre`, `ponderation`,`partage`,`id_enseignant`,`id_matiere`) VALUES" +
                "(@id_question, @titre, @ponderation, @partage, @id_enseignant, @id_matiere);";
            bool flag = true;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                if (ques is QCM)
                {
                    rq += "INSERT INTO qcm (`id_question`,`la_question`) VALUES (@id_question, @la_question);";
                    maQCM = (QCM)ques;
                } else if (ques is Resultat_execution)
                {
                    rq += "INSERT INTO Resultat_execution (`id_question`,`le_code`,`reponse`) VALUES (@id_question, @le_code, @reponse);";
                    maResExe = (Resultat_execution)ques;
                }else
                {
                    rq += "INSERT INTO erreur_image (`id_question`,`url_image`,`num_ligne`,`erreur`,`correction`) VALUES (@id_question,@url_image,@num_ligne,@erreur,@correction);";
                    maErrImg = (Erreur_image)ques;
                }
                try
                {
                    sqlCmd = (MySqlCommand)cnx.CreateCommand();
                    sqlCmd.CommandText = rq;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("id_question", ques.id_question);
                    sqlCmd.Parameters.AddWithValue("titre", ques.titre);
                    sqlCmd.Parameters.AddWithValue("ponderation", ques.ponderation);
                    sqlCmd.Parameters.AddWithValue("partage", ques.partage.ToString().ToLower());
                    sqlCmd.Parameters.AddWithValue("id_enseignant", ques.id_enseignant);
                    sqlCmd.Parameters.AddWithValue("id_matiere", ques.id_matiere);
                    if (ques is QCM)
                        sqlCmd.Parameters.AddWithValue("la_question", maQCM.la_question);
                    else if (ques is Resultat_execution)
                    {
                        sqlCmd.Parameters.AddWithValue("le_code", maResExe.le_code);
                        sqlCmd.Parameters.AddWithValue("reponse", maResExe.reponse);
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("url_image", maErrImg.url_image);
                        sqlCmd.Parameters.AddWithValue("num_ligne", maErrImg.num_ligne);
                        sqlCmd.Parameters.AddWithValue("erreur", maErrImg.erreur);
                        sqlCmd.Parameters.AddWithValue("correction", maErrImg.correction);

                    }
                    dr = sqlCmd.ExecuteReader();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Désolé, la question na pas ete ajoutee\n" +
                        e.Message, "Erreur d,ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            BdConnexion.Fermer();

            if (ques is QCM)
                for (int i = 0; i < maQCM.liste_choix.Count; i++)
                {
                    using (MySqlConnection cnx = BdConnexion.GetConnexion())
                    {
                        rq = "INSERT INTO liste_choix(`id_question`,`choix`,`statut_choix`) VALUES(@id_question, @choix, @statut_choix)";
                        try
                        {
                            sqlCmd = (MySqlCommand)cnx.CreateCommand();
                            sqlCmd.CommandText = rq;
                            sqlCmd.CommandType = CommandType.Text;
                            sqlCmd.Parameters.AddWithValue("id_question", ques.id_question);
                            sqlCmd.Parameters.AddWithValue("choix", maQCM.liste_choix.ElementAt(i).choix);
                            sqlCmd.Parameters.AddWithValue("statut_choix", maQCM.liste_choix.ElementAt(i).statut_choix.ToString().ToLower());
                            dr = sqlCmd.ExecuteReader();
                        }
                        catch (MySqlException e)
                        {
                            MessageBox.Show(e.Message, "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flag = false;
                        }
                    }
                }

                if (flag)
                    MessageBox.Show("La question suivante a été bien ajoutée :\nID_question : " + ques.id_question
                    + "\nTitre : " + ques.titre, "Ajout avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //22) Supprimer ma propre question
        public void DeleteQuestion(Question ques)
        {
            MySqlCommand sqlCmd = null;
            DbDataReader dr;
            string rq;
            if (ques is QCM)
            {
                Console.WriteLine("je suis la ...");
                for (int i = 0; i < ((QCM)ques).liste_choix.Count;i++)
                    using (MySqlConnection cnx = BdConnexion.GetConnexion())
                    {
                        sqlCmd = (MySqlCommand)cnx.CreateCommand();
                        sqlCmd.CommandText = "DELETE FROM liste_choix WHERE id_question = @id_question;";
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.AddWithValue("id_question", ques.id_question);
                        dr = sqlCmd.ExecuteReader();
                    }
                rq = "DELETE FROM qcm WHERE id_question = @id_question;";
            }
            else if (ques is Resultat_execution)
                rq = "DELETE FROM resultat_execution WHERE id_question = @id_question;";
            else
                rq = "DELETE FROM erreur_image WHERE id_question = @id_question;";

            rq = rq + "\nDELETE FROM question WHERE id_question = @id_question";

            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                Console.WriteLine("rq= :" + rq);
                sqlCmd = (MySqlCommand)cnx.CreateCommand();
                sqlCmd.CommandText = rq;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("id_question", ques.id_question);
                dr = sqlCmd.ExecuteReader();
                MessageBox.Show("La question suivantt a été bien supprimé :\nID_question : " + ques.id_question
                    , "Supprission avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //23)Editer ma propre question
        public void EditerQuestion(Question ques)
        {
            MySqlCommand sqlCmd;
            DbDataReader dr;

            QCM maQCM = null;
            Resultat_execution maResExe = null;
            Erreur_image maErrImg = null;
            string rq = "UPDATE `question` SET `ponderation` = @ponderation, `partage` = @partage, " +
                "`id_matiere` =  @id_matiere WHERE `id_question` = @id_question;";
            bool flag = true;
            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {
                if (ques is QCM)
                {
                    rq += "UPDATE  qcm SET `la_question` = @la_question WHERE `id_question` = @id_question;" +
                        "\nDELETE FROM liste_choix WHERE `id_question` = @id_question;";
                    maQCM = (QCM)ques;
                }
                else if (ques is Resultat_execution)
                {
                    rq += "UPDATE resultat_execution SET `le_code` = @le_code, `reponse` = @reponse WHERE `id_question` = @id_question";
                    maResExe = (Resultat_execution)ques;
                }
                else
                {
                    rq += "UPDATE erreur_image SET `url_image` = @url_image, `num_ligne` = @num_ligne, `erreur` = @erreur," +
                        " `correction` = @correction WHERE `id_question` = @id_question;";
                    maErrImg = (Erreur_image)ques;
                }
                try
                {
                    sqlCmd = (MySqlCommand)cnx.CreateCommand();
                    sqlCmd.CommandText = rq;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("id_question", ques.id_question);
                    sqlCmd.Parameters.AddWithValue("ponderation", ques.ponderation);
                    sqlCmd.Parameters.AddWithValue("partage", ques.partage.ToString().ToLower());
                    sqlCmd.Parameters.AddWithValue("id_matiere", ques.id_matiere);
                    if (ques is QCM)
                        sqlCmd.Parameters.AddWithValue("la_question", maQCM.la_question);
                    else if (ques is Resultat_execution)
                    {
                        sqlCmd.Parameters.AddWithValue("le_code", maResExe.le_code);
                        sqlCmd.Parameters.AddWithValue("reponse", maResExe.reponse);
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("url_image", maErrImg.url_image);
                        sqlCmd.Parameters.AddWithValue("num_ligne", maErrImg.num_ligne);
                        sqlCmd.Parameters.AddWithValue("erreur", maErrImg.erreur);
                        sqlCmd.Parameters.AddWithValue("correction", maErrImg.correction);

                    }
                    dr = sqlCmd.ExecuteReader();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Désolé, la question na pas ete ajoutee\n" +
                        e.Message, "Erreur d,ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            BdConnexion.Fermer();

            if (ques is QCM)
                for (int i = 0; i < maQCM.liste_choix.Count; i++)
                {
                    using (MySqlConnection cnx = BdConnexion.GetConnexion())
                    {
                        rq = "INSERT INTO liste_choix(`id_question`,`choix`,`statut_choix`) VALUES(@id_question, @choix, @statut_choix)";
                        try
                        {
                            sqlCmd = (MySqlCommand)cnx.CreateCommand();
                            sqlCmd.CommandText = rq;
                            sqlCmd.CommandType = CommandType.Text;
                            sqlCmd.Parameters.AddWithValue("id_question", ques.id_question);
                            sqlCmd.Parameters.AddWithValue("choix", maQCM.liste_choix.ElementAt(i).choix);
                            sqlCmd.Parameters.AddWithValue("statut_choix", maQCM.liste_choix.ElementAt(i).statut_choix.ToString().ToLower());
                            dr = sqlCmd.ExecuteReader();
                        }
                        catch (MySqlException e)
                        {
                            MessageBox.Show(e.Message, "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flag = false;
                        }
                    }
                }

            if (flag)
                MessageBox.Show("La question suivante a été bien modifée :\nID_question : " + ques.id_question
                + "\nTitre : " + ques.titre, "Ajout avec suceés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //24)Recuperer la liste des matieres
        public List<string> ListeMatiere()
        {
            DbCommand cmd;
            List<string> liste = new List<string>();
            Matiere matiere;

            using (MySqlConnection cnx = BdConnexion.GetConnexion())
            {

                cmd = cnx.CreateCommand();
                cmd.CommandText = "matiere";
                cmd.CommandType = CommandType.TableDirect;

                DbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    matiere = new Matiere();
                    matiere.id_matiere = dr["id_matiere"].ToString();
                    matiere.titre = dr["titre"].ToString();
                    matiere.description = dr["description"].ToString();

                    liste.Add(matiere.ToString());
                }
            }
            return liste;
        }

        //Autre methode

    }
}
