using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    public class Groupe
    {
        public string id_groupe { get; set; }
        public string titre { get; set; }
        public string id_enseignant { get; set; }

        //Constructeur #1
        public Groupe(string id_groupe, string titre, string id_enseignant)
        {
            this.id_groupe = id_groupe;
            this.titre = titre;
            this.id_enseignant = id_enseignant;
        }

        //Constructeur #2
        public Groupe(string id_groupe, string titre)
        {
            this.id_groupe = id_groupe;
            this.titre = titre;
        }

        //Constructeur #3
        public Groupe(string id_groupe)
        {
            this.id_groupe = id_groupe;
        }


        public override string ToString()
        {
            return "id_groupe : "+id_groupe+" titre : " + titre + "id_enseignant : " + id_enseignant;
        }

        public  string ToCsv()
        {
            return  id_groupe  +"\n"+ titre + "\n" + id_enseignant;
        }

    }
}
