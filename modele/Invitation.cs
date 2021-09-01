using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    public class Invitation
    {
        public string id_enseignant { get; set; }
        public string id_etudiant { get; set; }
        public string id_groupe { get; set; }
        public string date { get; set; }
        public string heure { get; set; }
        public string commentaire { get; set; }
        public string statut { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string titre { get; set; }

        //constructeur#1
        public Invitation(string id_enseignant, string id_etudiant, string id_groupe, string commentaire)
        {
            this.id_enseignant = id_enseignant;
            this.id_etudiant = id_etudiant;
            this.id_groupe = id_groupe;
            date = DateTime.Now.ToString("dd-MM-yyyy");
            heure = DateTime.Now.ToString("HH:mm");
            this.commentaire = commentaire;
        }
        //constructeur#2
        public Invitation(string id_etudiant, string id_groupe, string titre, string nom, string prenom, string date, string heure, string commentaire)
        {
            this.id_etudiant = id_etudiant;
            this.id_groupe = id_groupe;
            this.titre = titre;
            this.nom = nom;
            this.prenom = prenom;
            this.date = date;
            this.heure = heure;
            this.commentaire = commentaire;
        }

        //constructeur#3
        public Invitation(string id_enseignant,string id_etudiant, string id_groupe)
        {
            this.id_enseignant = id_enseignant;
            this.id_etudiant = id_etudiant;
            this.id_groupe = id_groupe;
        }

        //constructeur#4
        public Invitation(string id_etudiant, string id_groupe)
        {
            this.id_etudiant = id_etudiant;
            this.id_groupe = id_groupe;
        }


        public override string ToString()
        {
            return "id_enseignant : " + id_enseignant + ", id_etudiant : " + id_etudiant + ", id_groupe : " + id_groupe + 
                "\n, Date & Heure : " + date+" " +heure+ ", commentaire : " + commentaire;
        }
    }
}
