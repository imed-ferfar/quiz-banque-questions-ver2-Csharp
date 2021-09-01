using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    public class Choix
    {
        public string choix { get; set; }
        public bool statut_choix {get; set;}

        public Choix(string choix, bool statut_choix)
        {
            this.choix = choix;
            this.statut_choix = statut_choix;
        }

        public override bool Equals(object obj)
        {
            return obj is Choix choix &&
                   this.choix == choix.choix;
        }

        public override int GetHashCode()
        {
            return -1669448718 + EqualityComparer<string>.Default.GetHashCode(choix);
        }

 
    }
}
