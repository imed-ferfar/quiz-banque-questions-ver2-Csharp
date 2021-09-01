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

namespace Projet1_questions.ui.enseignant
{
    public partial class PanneauInvitation : UserControl
    {
        private List<Groupe> listGroupe;
        private List<Etudiant> listEtuds;
        private Enseignant enseig;
        private string motCle;
        private string id_etud_selec = "";
        private string id_groupe_selec = "";
        private Invitation invit;
        private List<Invitation> listInvit;
        DialogResult res;

        //constructeur #1
        public PanneauInvitation()
        {
            InitializeComponent();
        }
        //constructeur #2
        public PanneauInvitation(List<Groupe> listGroupe, Enseignant enseig) :this()
        {
            this.listGroupe = listGroupe;
            this.enseig = enseig;
            if (listGroupe.Count > 0)
            {
                CBgroupes.Text = "Choisir un groupe";
                for (int i = 0; i < listGroupe.Count; i++)
                    CBgroupes.Items.Add(listGroupe.ElementAt(i).id_groupe);
                CBgroupes.SelectedIndex = 0;
            }
            listInvit = PresentationServices.ListerInvitation(DGVinvitation,enseig);
            if (listInvit.Count > 0)
                BtnAnnulerInv.Enabled = true;
        }

        //Actionneur zone de recherche
        private void TxtRecherche_TextChanged(object sender, EventArgs e)
        {
            motCle = TxtRecherche.Text;
            if (!motCle.Equals(""))
            {
                listEtuds = QuestionServices.RechercherEtudiant(motCle);
                PresentationServices.ListerEtudiant(listEtuds, DGVEtuds);
                //Console.WriteLine("listEtuds.Count : " + listEtuds.Count);
                if (listEtuds.Count > 0)
                {
                    id_etud_selec = (string)DGVEtuds.CurrentRow.Cells["id_etudiant"].Value;
                    BtnEnvoyerInv.Enabled = true;
                }
                else
                {
                    BtnEnvoyerInv.Enabled = false;
                    id_etud_selec = "";
                }
            }
            else
            {
                DGVEtuds.Rows.Clear();
                BtnEnvoyerInv.Enabled = false;
                id_etud_selec = "";
            }
        }
        //Actionneur bouton envoyer une invitation à un etudiant
        private void BtnEnvoyerInv_Click(object sender, EventArgs e)
        {
            id_etud_selec = (string)DGVEtuds.CurrentRow.Cells["id_etudiant"].Value;
            id_groupe_selec = CBgroupes.SelectedItem.ToString();
            // Etudiant deja dans le groupe, invitation non envoyee
            if (QuestionServices.VerifierEtudiantDansGroupe(id_etud_selec, id_groupe_selec))
                MessageBox.Show("L'etudiant qui a le numero DA :" + id_etud_selec + " est deja dans le groupe N : " + id_groupe_selec,
                    "Invitation non envoyée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Invitation deja envyoee!!!
            else if (QuestionServices.VerifierInvitation(id_etud_selec, id_groupe_selec))
                MessageBox.Show("Désolé, vous avec deja envoyé une invitaion à cet etudiant pour joindre ce groupe\n",
                    "Invitation non envoyée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else  // envoyer l'invitation
            {
                invit = new Invitation(enseig.id_personne, id_etud_selec, id_groupe_selec, "comm");
                FenCommentaire nouveauCM = new FenCommentaire(id_groupe_selec, enseig);
                invit.commentaire = nouveauCM.Commentaire;
                res = nouveauCM.ShowDialog();
                if (res == DialogResult.OK)
                    QuestionServices.EnvoyerInvitation(invit);
                listInvit = PresentationServices.ListerInvitation(DGVinvitation, enseig);
                BtnAnnulerInv.Enabled = true;
            }    
        }
       
        //Actionneur bouton Annuler une invitation
        private void BtnAnnulerInv_Click(object sender, EventArgs e)
        {
            string inv_etud_sel = DGVinvitation.CurrentRow.Cells["id_etud"].Value.ToString();
            string inv_grou_sel = DGVinvitation.CurrentRow.Cells["id_groupe"].Value.ToString();
            invit = new Invitation(enseig.id_personne, inv_etud_sel, inv_grou_sel);
            QuestionServices.AnnulerInvitation(invit);
            listInvit = PresentationServices.ListerInvitation(DGVinvitation, enseig);
            if (listInvit.Count == 0)
                BtnAnnulerInv.Enabled = false;
        }
    }
}
