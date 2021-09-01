using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
     public class QCM : Question
    {
        public string la_question { get; set; }
        public List<Choix> liste_choix { get; set; }
        public QCM(int id_question, string titre, int ponderation, bool partage, string id_enseignant, string id_matiere, string la_question) 
            : base ( id_question,  titre,  ponderation,  partage,  id_enseignant,  id_matiere)
        {
            this.la_question = la_question;
            liste_choix = new List<Choix>();
        }

        public QCM(int id_question, string la_question) 
        {
            this.id_question = id_question;
            titre = TITRE_QCM;
            this.la_question = la_question;
            liste_choix = new List<Choix>();
        }

        private string Titre
        {
            get => titre;
            set => titre = value;
        }

       /* public List<Choix> Liste_choix
        {
            get => _Liste_choix;
            set => _Liste_choix = value;
        }*/

        public void AjouterChoix(Choix choix)
        {
            if (VerifierChoix(choix))
            {
                liste_choix.Add(choix);
            }
        }

        private bool VerifierChoix(Choix choix)
        {
            foreach (Choix tmp in liste_choix)
            {
                if (choix.Equals(tmp))
                    return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is QCM qCM &&
                   base.Equals(obj) &&
                   (id_question == qCM.id_question ||
                   la_question == qCM.la_question);
        }

        public override int GetHashCode()
        {
            int hashCode = 1422370002;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + id_question.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(la_question);
            return hashCode;
        }

        private String ListerChoix()
        {
            String message = "";
            int i = 1;
            foreach (Choix tmp in liste_choix)
            {
                message += "choix" + i + ": " + tmp.choix+"_"+tmp.statut_choix+" ";
            }
            return message;
   
        }
       public override String ToString()
        {
            return "QCM {ID : " + id_question + " Titre :" + titre + " Ponderation : " + ponderation + " Enseignant : " + id_enseignant + " Matiere : " + id_matiere + " La question : " + la_question + "choix:" + ListerChoix() + "}";
        }
        public String ListerQCM()
        {
            return "QCM {ID : " + id_question + " Titre :" + titre + " Ponderation : " + ponderation + " Enseignant : " + id_enseignant + " Matiere : " + id_matiere + " La question : " + la_question + "choix:"+ListerChoix()+"}";
        }
        public String GetTexte(int i)
        {
            return liste_choix.ElementAt(i).choix;
        }
    }
}
