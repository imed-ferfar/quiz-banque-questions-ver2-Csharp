using Projet1_questions.modele;
using Projet1_questions.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projet1_questions.ui.etudiant
{
    public partial class PanneauProfilEtud : UserControl
    {
        private FenModifPasse fenPasse;
        private Etudiant etud;
        private List<Invitation> listInvit;
        private Invitation invit;
        string decision;
        //Constructeur#1
        public PanneauProfilEtud()
        {
            InitializeComponent();
        }
        //Constructeur#2
        public PanneauProfilEtud(Etudiant etud) :this()
        {
            this.etud = etud;
            RemplirFormulaire();
            PresentationServices.ListerGroupe(DGVgroupe, etud);
            listInvit = PresentationServices.ListerInvitation(DGVinvitation, etud);
            if (listInvit.Count > 0)
            {
                BtnInvit.Enabled = true;
                RBaccepter.Enabled = true;
                RBrejeter.Enabled = true;
            }
        }

        private void RemplirFormulaire()
        {
            TxtDA.Text = etud.id_personne;
            TxtNom.Text = etud.nom;
            TxtPrenom.Text = etud.prenom;
            TxtCourriel.Text = etud.courriel;
        }

        //Actionneur bouton Modifier mot de passe
        private void BtnModifMotPasse_Click(object sender, EventArgs e)
        {
            //ouvrir fenetre de modification du mot de passe
            fenPasse = new FenModifPasse(etud);
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

        private void BtnInvit_Click(object sender, EventArgs e)
        {
            //string inv_etud_sel = DGVinvitation.CurrentRow.Cells["id_etud"].Value.ToString();
            string inv_grou_sel = DGVinvitation.CurrentRow.Cells["id_grou"].Value.ToString();
            string titre_grou = DGVinvitation.CurrentRow.Cells["titr"].Value.ToString();
            invit = new Invitation(etud.id_personne, inv_grou_sel);

            if (!RBaccepter.Checked)
                decision = "false";
            else
            {
                decision = "true";
                etud.listinGroupe.Add(new Groupe(inv_grou_sel, titre_grou));
               
            }

            QuestionServices.RepondreInvitation(invit, decision);
            listInvit = PresentationServices.ListerInvitation(DGVinvitation, etud);
            if (listInvit.Count > 0)
            {
                BtnInvit.Enabled = true;
                RBaccepter.Enabled = true;
                RBrejeter.Enabled = true;
            }
            if (RBaccepter.Checked)
                PresentationServices.ListerGroupe(DGVgroupe, etud);
        }
    }
}
