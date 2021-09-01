using Projet1_questions.modele;
using Projet1_questions.services;
using Projet1_questions.ui;
using System;
using System.Windows.Forms;

namespace Projet1_questions
{
    
    public partial class FenSeConnecter : Form
    {
        private Personne perso;
        private Form fen;
        private ListeQuestions listeQues;

        //constructeur#1
        public FenSeConnecter()
        {
            InitializeComponent();
        }

        //constructeur#2 (apres creation nouveau compte)
        public FenSeConnecter(Personne perso) : this()
        {
            this.perso = perso;
            txtUtilisteur.Text = perso.id_personne;
            //txtMotPasse.Text = perso.motPasse;

            if (perso is Enseignant)
                RadioBtnEnsei.Checked = true;
            else
                RadioBtnEtud.Checked = true;
        }

        //Bouton Se connexion
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            perso = null;
            if (ValiderData())
            {
                if (RadioBtnEnsei.Checked == true)
                    perso = new Enseignant(txtUtilisteur.Text, txtMotPasse.Text);
                else
                    perso = new Etudiant(txtUtilisteur.Text, txtMotPasse.Text);

                Console.WriteLine("perso.ToString() " + perso.ToString());
                perso = QuestionServices.AuthentifierPerso(perso);
              //  Console.WriteLine("perso.ToString() "  +  perso.ToString());
                if (perso == null)
                    MessageBox.Show("Désolé, votre No de DA ou votre mot de passe est invalide, veuillez vérifer encore !",
                        "Erreur de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (perso.etat.Equals("true"))
                    {
                        listeQues = QuestionServices.ChargerQuestions("%");
                        listeQues.ListerQuestion();
                        this.Hide();
                        if (perso is Etudiant)
                            fen = new FenEtudiant(perso, listeQues);
                        else
                            fen = new FenEnseignant(perso);
                        fen.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Désolé votre compte est bloqué, veuillez contacter l'administration !",
                            "Compte bloqué", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Aller vers le formulaire du nouveau compte
        private void LinkNouveauUtilisateur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new FenNouveauUtilisateur();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        //mot de paase publié
        private void linkMotPasseOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Désolé, cette option n'est pas encore disponible, veuillez contacter l'administration.", 
                "Mot de passe oublié", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //vaider les donnees saisis
        private bool ValiderData()
        {
            if (txtUtilisteur.Text.Equals("") || (txtMotPasse.Text.Equals("")))
            {
                MessageBox.Show("Vous devez saisir un numèro DA et un mot de passe","Erreur de saisi", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if ((txtUtilisteur.Text.Length != 7)|| (txtMotPasse.Text.Length < 8))
            {
                MessageBox.Show("Vous devez saisir un code et un mot de passe valides ", "Erreur de saisi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                return true;
        }

        // juste le test (acces rapide)
        private void RadioBtnEnsei_Click(object sender, EventArgs e)
        {
          /*  txtUtilisteur.Text = "1111111";
            txtMotPasse.Text = "11111111";*/
        }

    }
}
