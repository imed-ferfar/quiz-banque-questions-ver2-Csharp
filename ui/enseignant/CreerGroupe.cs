using System.Windows.Forms;

namespace Projet1_questions.ui.enseignant
{
    public partial class CreerGroupe : Form
    {
        //constructeur #1
        public CreerGroupe()
        {
            InitializeComponent();
        }
        //constructeur #2
        public CreerGroupe(string id_groupe, string titre) :this()
        {
            TxtID.Text = id_groupe;
            TxtTitre.Text = titre;
            TxtID.ReadOnly = true;
            this.Text = "Modifier un groupe";
        }
        public string ID
        {
            get { return TxtID.Text; }
            //set { TxtID.Text = value; }
        }

        public string Titre
        {
            get { return TxtTitre.Text; }
        }

    }
}
