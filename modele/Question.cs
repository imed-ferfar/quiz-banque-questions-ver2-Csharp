using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    public class Question
    {
        public const string TITRE_QCM = "Choisir la ou les bonnes réponses";
        protected const string TITRE_IMG_ERR = "Trouver l'erreur dans ce code";
        protected const string TITRE_RES_EXE = "Trouver le resultat d'execution de ce code";
        public int id_question { get; set; }
        public String titre { get; set; }
        public int ponderation { get; set; }
        public bool partage { get; set; }
        public string id_enseignant { get; set; }
        public string id_matiere { get; set; }

        protected Question()
        {
        }

        public Question(int id_question, string titre, int ponderation, bool partage, string id_enseignant, string id_matiere)
        {
            this.id_question = id_question;
            this.titre = titre;
            this.ponderation = ponderation;
            this.partage = partage;
            this.id_enseignant = id_enseignant;
            this.id_matiere = id_matiere;
        }

  

        public override bool Equals(object obj)
        {
            return obj is Question question &&
                   id_question == question.id_question &&
                   titre == question.titre;
        }

        public override int GetHashCode()
        {
            int hashCode = -1563634664;
            hashCode = hashCode * -1521134295 + id_question.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(titre);
            return hashCode;
        }

        public virtual string AfficherQuestion()
        {
           // return base.ToString();
            {
                return "Question {ID : " + id_question + " Titre :" + titre + " Ponderation : " + ponderation + " Enseignant : " + id_enseignant + " Matiere : " + id_matiere + " La question : "+ "}";

            }
        }

    }
}
