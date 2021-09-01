using Projet1_questions.modele;
using Projet1_questions.services;
using System.Windows.Forms;

namespace Projet1_questions.ui.enseignant
{
    public partial class FenCommentaire : Form
    {
        //Constructeur#1
        public FenCommentaire()
        {
            InitializeComponent();
        }

        //Constructeur#2
        public FenCommentaire(string id_groupe_selec, Enseignant enseig) :this()
        {
            string titre = QuestionServices.TitreGroupe(id_groupe_selec);
            TxtCommentaire.Text = "Vous avez recu une invitation de la part de : "+enseig.prenom+" "
                + enseig.nom+" ,pour joindre le groupe "+titre +" (ID: "+ id_groupe_selec + ")";
        }

        public string Commentaire
        {
            get { return TxtCommentaire.Text; }
        }
    }
}
