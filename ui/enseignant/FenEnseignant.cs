using Projet1_questions.modele;
using Projet1_questions.services;
using Projet1_questions.ui.enseignant;
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
using System.Windows.Forms;

namespace Projet1_questions.ui
{
    public partial class FenEnseignant : Form
    {
        private Enseignant enseig;
        private PanneauGroupe PnlGroupes;
        private PanneauInvitation PnlInviter;
        private Panel panneauBas;
        private Button BtnAnnuler,BtnInviter,BtnRetourGr, BtnConfirmer;
        private PanneauCompte PnlCompte;
        private PanneauBanqueQuestion PnlBanqueQ;

        //constructeur#1
        public FenEnseignant()
        {
            InitializeComponent();
        }

        //constructeur#2
        public FenEnseignant(Personne perso) : this()
        {
            enseig = (Enseignant)perso;
            LinkedLnom.Text = perso.prenom + " " + perso.nom;
            LinkedLid.Text = perso.id_personne;
            try
            {
                Image image = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/icones/prof.png");
                PnlCentre.BackgroundImage = GestionImage.AjusterImage(image, PnlCentre.Width, PnlCentre.Height);
            } catch (OutOfMemoryException exe)
            {
                Console.WriteLine(exe.ToString());
            }
            
        }

        //Actionneur bouton gestion des groupes
        private void BtnGroupes_Click(object sender, EventArgs e)
        {
            PnlGroupes = new PanneauGroupe(enseig);
            Controls.Remove(PnlPrincipal);
            Controls.Add(PnlGroupes);
            AjouterPanneauBas();
        }

        //Ajouter un panneau en bas de fenetre (2 boutons : Annuler & Inviter)
        private void AjouterPanneauBas()
        {
            panneauBas = new Panel();
            panneauBas.BorderStyle = BorderStyle.Fixed3D;
            panneauBas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            panneauBas.Location = new Point(5, 515);
            panneauBas.Size = new Size(875, 37);

            BtnAnnuler = new Button();
            BtnAnnuler.Size = new Size(137, 33);
            BtnAnnuler.Location = new Point(panneauBas.Size.Width - BtnAnnuler.Size.Width - 35, 1);//73  7
            BtnAnnuler.TabIndex = 0;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.Click += new EventHandler(BtnAnnuler_Click);

            BtnInviter = new Button();
            BtnInviter.Size = new Size(137, 33);
            BtnInviter.Location = new Point(panneauBas.Size.Width - BtnAnnuler.Size.Width - BtnInviter.Size.Width - 50, 1);//73  7
            BtnInviter.TabIndex = 0;
            BtnInviter.Text = "Inviter Etudiant";
            BtnInviter.Click += new EventHandler(this.BtnInviter_Click);

            panneauBas.Controls.Add(this.BtnAnnuler);
            panneauBas.Controls.Add(this.BtnInviter);
            Controls.Add(panneauBas);
        }

        // Actionneur boutton Annuler
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Annuler", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Controls.Remove(PnlGroupes);
            // Controls.Remove(panneauBas);
            Controls.Clear();
            Controls.Add(PnlPrincipal);
            Controls.Add(PnlHaut);
        }

        // Actionneur boutton Inviter un etudiant
        private void BtnInviter_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Annuler", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Controls.Remove(PnlGroupes);
            PnlInviter = new PanneauInvitation(PnlGroupes.mesGroupes, enseig);
            Controls.Add(PnlInviter);

            panneauBas.Controls.Remove(BtnInviter);
            BtnRetourGr = new Button();
            BtnRetourGr.Size = new Size(137, 33);
            BtnRetourGr.Location = new Point(BtnInviter.Location.X, 1);//73  7
            BtnRetourGr.TabIndex = 0;
            BtnRetourGr.Text = "Retour";
            BtnRetourGr.UseVisualStyleBackColor = true;
            BtnRetourGr.Click += new EventHandler(this.BtnRetourGr_Click);
            panneauBas.Controls.Add(this.BtnRetourGr);
        }
        //Actionneur bouton Passer un Examen
        private void BtnExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Désolé cette option n'est pas encore disponible !!!", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Actionneur bouton Banque de question
        private void BtnQuestions_Click(object sender, EventArgs e)
        {
            PnlBanqueQ = new PanneauBanqueQuestion (enseig);
            Controls.Remove(PnlPrincipal);
            Controls.Add(PnlBanqueQ);
            AjouterPanneauBas();
            panneauBas.Controls.Remove(BtnInviter);
        }

        // Actionneur boutton Retour au groupes
        private void BtnRetourGr_Click(object sender, EventArgs e)
        {
            panneauBas.Controls.Remove(BtnRetourGr);
            panneauBas.Controls.Add(BtnInviter);
            Controls.Clear();
            Controls.Add(PnlGroupes);
            Controls.Add(panneauBas);
            Controls.Add(PnlHaut);
        }

        //Actionneur bouton Mon compte
        private void BtnMonCompte_Click(object sender, EventArgs e)
        {
            PnlCompte = new PanneauCompte(enseig);
            Controls.Remove(PnlPrincipal);
            Controls.Add(PnlCompte);
            AjouterPanneauBas();
            panneauBas.Controls.Remove(BtnInviter);

            BtnConfirmer = new Button();
            BtnConfirmer.Size = new Size(137, 33);
            BtnConfirmer.Location = new Point(panneauBas.Size.Width - BtnAnnuler.Size.Width - BtnInviter.Size.Width - 50, 1);//73  7
            BtnConfirmer.TabIndex = 0;
            BtnConfirmer.Text = "Confirmer";
            BtnConfirmer.Click += new EventHandler(this.BtnConfirmer_Click);

            panneauBas.Controls.Add(this.BtnConfirmer);
        }

        // Actionneur boutton Confirmer
        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            if (PnlCompte.ValiderSaisi())
            {
                enseig.nom = PnlCompte.Nom();
                enseig.prenom = PnlCompte.Prenom();
                enseig.courriel = PnlCompte.Courriel();
                QuestionServices.ModifierInfos(enseig);
                LinkedLnom.Text = enseig.prenom + " " + enseig.nom;
            }

        }

    }
}
