using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{


    public class Matiere
    {
        public string id_matiere { get; set; }
        public string titre { get; set; }
        public string description { get; set; }


        public Matiere()
        {

        }
        public Matiere(string id_matiere, string titre, string description)
        {
            this.id_matiere = id_matiere;
            this.titre = titre;
            this.description = description;
        }

        public override string ToString()
        {
            return id_matiere +" : "+ titre;
        }

    }


}
