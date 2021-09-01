using Projet1_questions.modele;
using Projet1_questions.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Projet1_questions.ui
{
    public partial class PanneauQuiz : UserControl
    {
        // private MouseMotionAdapter passerSouris;
        // private MouseAdapter sortirSouris;
        // private ScrollPane jScrollPane1;
        public Question question { get; set; }
        public string Reponse { get; set; }
        public RichTextBox txtArea { get; set; }
        public TextBox txtReponse { get; set; }
        public Label lblReponse { get; set; }

        private Label lblResultFinal;
        private Image imageResultat;
        public PanneauQuiz()
        {
            InitializeComponent();
        }

        public PanneauQuiz(Question question) : this()
        {
            this.question = question;
            lblTitre.Text = question.titre;
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
        }

        /* public QCM QuestionQCM
        {
            get => _QuestionQCM;
            set => _QuestionQCM = value;
        }*/

        // Afficher le resultat d'une réponse
        public void AfficherLblresultat(bool flag)
        {
            lblResultFinal = new Label();
            lblResultFinal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblResultFinal.Size = new Size(371, 79);
            lblResultFinal.Location = new Point(673, 431);
            if (flag)
            {
                imageResultat = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/icones/ok-icon.png");
                lblResultFinal.Image = imageResultat;
                lblResultFinal.Text = "Bonne reponse !";
            }
            else
            {
                imageResultat = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/icones/Erreur-icon.png");
                lblResultFinal.Image = imageResultat;
                lblResultFinal.Text = "Mauvaise reponse !";
            }
            Controls.Add(lblResultFinal);
        }

        public virtual bool ValiderReponse()
        {
            return false;
        }

    }
}
