using Projet1_questions.modele;
using Projet1_questions.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.ui
{
    public partial class PanneauCompte : UserControl
    {
        private FenModifPasse fenPasse;
        public Personne perso { get;set; }

        //constructeur#1
        public PanneauCompte()
        {
            InitializeComponent();
        }

        //constructeur#2
        public PanneauCompte(Personne perso) :this()
        {
            this.perso = perso;
            //this.etat;
            RemplirFormulaire();
        }

        //Le formulaure des informations : nom, prenom et courriel
        private void RemplirFormulaire()
        {
            TxtDA.Text = perso.id_personne;
            TxtNom.Text = perso.nom;
            TxtPrenom.Text = perso.prenom;
            TxtCourriel.Text = perso.courriel;
        }

        //Actionneur bouton Modifier mot de passe
        private void BtnModifMotPasse_Click(object sender, EventArgs e)
        {
            //ouvrir fenetre de modification du mot de passe
            fenPasse = new FenModifPasse(perso);
            DialogResult res = fenPasse.ShowDialog();
        }

        //Valider la saisi des donnees
        public bool ValiderSaisi()
        {
            if ((TxtNom.Text.Equals("")) || (TxtPrenom.Text.Equals("")) || (TxtCourriel.Text.Equals("")))
            {
                MessageBox.Show("Tous les champs sont obligatoire ! \n",
                   "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((!TxtCourriel.Text.Contains("@")) && (!TxtCourriel.Text.Contains(".")))
            {
                MessageBox.Show("Vous devez saisir un courriel valide!\n",
                  "Mot de passe erroné", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
            return true;
        }

        public string Nom()
        {
            return TxtNom.Text;
        }
        public string Prenom()
        {
            return TxtPrenom.Text;
        }
        public string Courriel()
        {
            return TxtCourriel.Text;
        }
    }
}
