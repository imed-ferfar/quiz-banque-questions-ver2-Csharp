using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    public class Enseignant : Personne
    {
        public double salaire { get; set; }

        public Enseignant(String id_personne, String nom, String prenom, String courriel, String motPasse, String etat) 
            : base (id_personne, nom, prenom, courriel, motPasse, etat)
        {
        }
        public Enseignant(String id_personne, String motPasse)
            : base(id_personne, motPasse)
        {
        }
    }
}
