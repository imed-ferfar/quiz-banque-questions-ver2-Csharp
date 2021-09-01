using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    [Serializable]
    public class Personne
    {
        public String id_personne { get; set ; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String courriel { get; set; }
        public String motPasse { get; set; }
        public String etat { get; set; } // bloqué ou non bloqué par l'administrateur
        public List<Groupe> listinGroupe { get; set; }
        public Personne(String id_personne, String nom, String prenom, String courriel, String motPasse, String etat)
        {
            this.id_personne = id_personne;
            this.nom = nom;
            this.prenom = prenom;
            this.courriel = courriel;
            this.motPasse = motPasse;
            this.etat = etat;
            listinGroupe = new List<Groupe>();
        }

        public Personne(String id_personne, String motPasse)
        {
            this.id_personne = id_personne;
            this.motPasse = motPasse;
        }

        public Personne(String id_personne, String nom, String prenom, String courriel)
        {
            this.id_personne = id_personne;
            this.nom = nom;
            this.prenom = prenom;
            this.courriel = courriel;
        }
        public Personne()
        {
        }

        public override string ToString()
        {
            return "Personne {ID : "+id_personne+" Nom :"+nom+" Prenom : "+prenom+" Courriel : "+courriel+"Etat : "+ etat + "MotPasse: " + motPasse + "}";
        }

        public void ListerGroupe()
        {
            foreach (Groupe tmp in listinGroupe)
                Console.WriteLine(tmp.ToString());
        }

       /* public string Name
        {
          get => _name;
            set => _name = value;
        }*/
    }
}
