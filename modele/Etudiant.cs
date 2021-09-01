using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    [Serializable]
    public class Etudiant : Personne
    {
        //constructeur#1
        public Etudiant(String id_personne, String nom, String prenom, String courriel, String motPasse, String etat)
            : base(id_personne, nom, prenom, courriel, motPasse, etat) // super()
        {
            //this.id_groupe = id_groupe;
        }
        //constructeur#2
        public Etudiant(string id_personne, string motPasse)
           : base(id_personne, motPasse) // super()
        {
        }
        //constructeur#3
        public Etudiant(string id_personne, string nom, string prenom, string courriel)
            : base(id_personne, nom, prenom, courriel) // super()
        {
            //this.id_groupe = id_groupe;
        }
        public Etudiant()  
        {
        }


            public string ToCsv()
        {
            return id_personne +";"+ nom + ";" + prenom + ";" + courriel;
        }
    }

}
