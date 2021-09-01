using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    public class Erreur_image : Question
    {
        public string url_image { get; set; }
        public int num_ligne { get; set; }
        public string erreur { get; set; }
        public string correction { get; set; }

        public Erreur_image(int id_question, string titre, int ponderation, bool partage, string id_enseignant, string id_matiere, string url_image,int num_ligne, String erreur, String correction)
            : base(id_question, titre, ponderation, partage, id_enseignant, id_matiere)
        {
            this.url_image = url_image;
            this.num_ligne = num_ligne;
            this.erreur = erreur;
            this.correction = correction;
        }

        public Erreur_image(int id_question,  string url_image, int num_ligne, string erreur, string correction)
        {
            this.id_question = id_question;
            titre = TITRE_IMG_ERR;
            this.url_image = url_image;
            this.num_ligne = num_ligne;
            this.erreur = erreur;
            this.correction = correction;
        }

        public Erreur_image(int id_question)
        {
            this.id_question = id_question;
            titre = TITRE_IMG_ERR;
        }
        public override bool Equals(object obj)
        {
            return obj is Erreur_image image &&
                   base.Equals(obj) &&
                   (id_question == image.id_question ||
                   url_image == image.url_image);
        }

        public override int GetHashCode()
        {
            int hashCode = 598719539;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + id_question.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(url_image);
            return hashCode;
        }

        public override string ToString()
        {
            return "ErreurImage {ID : " + id_question + " Titre :" + titre + " Ponderation : " + ponderation
                + " Enseignant : " + id_enseignant + " Matiere : " + id_matiere + " Url : " + url_image +
                "erreur :" + erreur + "correction :" + correction + "}";
        }
    }
}
