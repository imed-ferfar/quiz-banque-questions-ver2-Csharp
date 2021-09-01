using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    public class Resultat_execution : Question
    {
        public String le_code { get; set; }
        public String reponse { get; set; }

        public Resultat_execution(int id_question, string titre, int ponderation, bool partage, string id_enseignant, string id_matiere, string le_code, string reponse)
             : base(id_question, titre, ponderation, partage, id_enseignant, id_matiere)
        {
            this.le_code = le_code;
            this.reponse = reponse;
        }

        public Resultat_execution(int id_question, string le_code, string reponse)
        {
            this.id_question = id_question;
            titre = TITRE_RES_EXE;
            this.le_code = le_code;
            this.reponse = reponse;

        }
        public override bool Equals(object obj)
        {
            return obj is Resultat_execution execution &&
                   base.Equals(obj) &&
                   (id_question == execution.id_question ||
                   le_code == execution.le_code);
        }

        public override int GetHashCode()
        {
            int hashCode = -1151297719;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + id_question.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(le_code);
            return hashCode;
        }

        public override string ToString()
        {
            return "ErreurImage {ID : " + id_question + " Titre :" + titre + " Ponderation : " + 
                ponderation + " Enseignant : " + id_enseignant + " Matiere : " + id_matiere +
                " le_code : " + le_code + "reponse :" + reponse + "}";
        }
    }
}
