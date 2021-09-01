using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Projet1_questions.modele
{
    [Serializable]
    public class GroupeEtudiants
    {
        public Groupe unGroupe;
        public List<Etudiant> Listing { get; }

        //#1
        public GroupeEtudiants()
        {
            Listing = new List<Etudiant>();
        }

        //#2
        public GroupeEtudiants(Groupe unGroupe)
        {
            this.unGroupe = unGroupe;
            Listing = new List<Etudiant>();
        }

        //pour ajouter un nouveau etudiant
        public bool AjouterEtudiant(Etudiant etd)
        {
            foreach (Etudiant tmp in Listing)
                if (etd.Equals(tmp))
                    return false;
            Listing.Add(etd);
            return true;
        }

        public override string ToString()
        {
            string resultat = null;
            foreach (Etudiant etd in Listing)
                resultat += etd + "\n";
            return resultat;
        }
        public string ToCSV()
        {
            string resultat = unGroupe.ToCsv()+"\n";
            foreach (Etudiant etd in Listing)
                resultat += etd.ToCsv() + "\n";
            return resultat;
        }

        /* public string ToJSON()
         {
             string resultat = null;
             foreach (Etudiant etd in Listing)
                 resultat += JsonConvert.SerializeObject(etd) + "\n";
             return resultat;
         }*/
    }
}
