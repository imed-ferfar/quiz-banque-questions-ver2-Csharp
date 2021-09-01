using Projet1_questions.modele;
using Projet1_questions.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.ui
{
    public partial class FenNouveauUtilisateur : Form
    {
        String id_personne;
        private List<String> list_id;
        Personne perso;

        public FenNouveauUtilisateur()
        {
            InitializeComponent();
        }

        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            if (ValiderData())
            {
                //Chercher la lise des id_personne
                list_id = QuestionServices.GetIdPersonnes();
                //Generer un nouveau id_personne
                id_personne = GenererIdPersonne(list_id);
                //Console.WriteLine("Nouveau ID : " + id_personne);

                //Inserer la nouvelle personne dans la table BD
                if (RadioBtnEnsei.Checked == true)
                    perso = new Enseignant(id_personne, txtNom.Text, txtPrenom.Text, txtCourriel.Text, txtMotPasse.Text,"true");
                else
                    perso = new Etudiant(id_personne, txtNom.Text, txtPrenom.Text, txtCourriel.Text, txtMotPasse.Text, "true");

                QuestionServices.AjouterPersonne(perso);
                MessageBox.Show("Bienvenue " + txtPrenom.Text + " " + txtNom.Text + ", voici votre numéro de DA : " + id_personne + ".",
                    "Numéro DA pour votre compte", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                //Fermer le formulaire nouveeel personne et passer a la fenetre de se connexion
                Form f = new FenSeConnecter(perso);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
        private bool ValiderData()
        {
            if (txtNom.Text.Equals("") || txtPrenom.Text.Equals("") || txtCourriel.Text.Equals(""))
            {
                MessageBox.Show("Vous devez completer tous les champs obligatoires");
                return false;
            }
            if (!txtMotPasse.Text.Equals(txtConfirmation.Text))
            {
                MessageBox.Show("La confirmaition du mot de passe nest pas identique");
                return false;
            }
            if (txtMotPasse.Text.Length < 8)
            {
                MessageBox.Show("Le mot de passe doit contenur 8  caracteres au moins");
                return false;
            }
            return true;
        }

        private String GenererIdPersonne(List<String> list_id)
        {
            int id_pers;
            Random rnd = new Random();
            id_pers = rnd.Next(1000000, 9999999); // ex : 94589626   = int

            while(list_id.Contains(id_pers.ToString()))
            {
                id_pers = rnd.Next(100000, 9999999);
            }
            return id_pers.ToString();
        }

        private void ChkBmotPasseConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBmotPasseConfirm.Checked)
            {
                txtMotPasse.PasswordChar = '\0';
                txtConfirmation.PasswordChar = '\0';
            }
            else
            {
                txtMotPasse.PasswordChar = '*';
                txtConfirmation.PasswordChar = '*';
            }
        }
    }
}
