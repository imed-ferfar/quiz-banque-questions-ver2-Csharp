using Projet1_questions.modele;
using Projet1_questions.services;
using Projet1_questions.singleton;
using Projet1_questions.ui.etudiant;
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
    public partial class FenEtudiant : Form
    {
        private Etudiant etud;
        private Panel panneauBas;
        private Button BtnDebut,BtnRetour;
        private Button BtnConfirmer,BtnAnnuler, BtnConfirmerCompte;
        private Button BtnQuitter, BtnReponses,BtnResultat;
        private Image image,image2;

        private Label LblNumQues, LblSuivant, LblPrecedent;

        private PanneauDebut PanDeb;
       // private PanneauProfilEtud PanProfil;
        private ListePanneaux listePanneaux;

        private ListeQuestions listeQuestions;

        private int nbrQuestion,typeQuestion,compteur = 0;
        private List<String> listeTags;

        private PanneauQuiz monPanneau;
      //  private Profil monProfil;
        private PanneauResultat panResultat;
        private PanneauProfilEtud PnlCompte;

        //Constructeur #1
        public FenEtudiant()
        {
            InitializeComponent();
        }
        //Constructeur #2
        public FenEtudiant(Personne perso, ListeQuestions listeQuestions) : this()
        {
            this.listeQuestions = listeQuestions;
            etud = (Etudiant) perso;
            LinkedLnom.Text =  etud.prenom +" "+perso.nom;
            LinkedLid.Text = etud.id_personne;
            
            //Afficher la liste des groupes de l'etudiant
            foreach (Groupe tmp in etud.listinGroupe)
                cbGroupes.Items.Add(tmp.id_groupe); 
            
            //Afficher une icon si l'etudiant a reçu une invitation pour joindre un groupe
            if (QuestionServices.ChargerInvitation(perso).Count > 0)
                LinkedLntf.Image = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/icones/notification-icon.png");

            //Image de fond
            Image image = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/icones/c-vs-java.jpg");
            pnlPrincipal.BackgroundImage = GestionImage.AjusterImage(image, pnlPrincipal.Width, pnlPrincipal.Height);
        }

        //Boutton  lancer un Quiz
        private void BtnLancerQuiz_Click(object sender, EventArgs e)
        {
            Controls.Remove(pnlPrincipal);
            Controls.Remove(PnlBtns);
            PanDeb = new PanneauDebut();
            Controls.Add(PanDeb);
            AjouterPanneauBas();
        }

        //Boutton passer un Examen
        private void BtnExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Désolé cette option n'est pas encore disponible !!!", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        // Ajout panneau en bas (debut && retour)
        private void AjouterPanneauBas()
        {
            panneauBas = new Panel();
            panneauBas.BorderStyle = BorderStyle.Fixed3D;
            panneauBas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            panneauBas.Location = new Point(1, 611);
            panneauBas.Size = new Size(900, 49);
            panneauBas.TabIndex = 0;
            
            BtnRetour = new Button();
            BtnRetour.Size = new Size(117, 35);
            BtnRetour.Location = new Point(panneauBas.Size.Width- BtnRetour.Size.Width-35, 7);//73  7
            BtnRetour.TabIndex = 0;
            BtnRetour.Text = "Annuler";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += new EventHandler(this.BtnRetour_Click);

            BtnDebut = new Button();
            BtnDebut.Size = new Size(117, 35);
            BtnDebut.Location = new Point(BtnRetour.Location.X - BtnDebut.Size.Width-10, 7); // 693  7
            BtnDebut.TabIndex = 1;
            BtnDebut.Text = "Commencer";
            BtnDebut.UseVisualStyleBackColor = true;
            BtnDebut.Click += new EventHandler(this.BtnDebut_Click);

            panneauBas.Controls.Add(this.BtnRetour);
            panneauBas.Controls.Add(this.BtnDebut);

            Controls.Add(this.panneauBas);
        }

        // Ajout panneau en bas (suivant, precedent & numQuestion)
        private void AjouterPanneauBas2()
        {
            panneauBas.Controls.Clear();
            LblSuivant = new Label();
            image = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName+ "/icones/suivant.png");
            LblSuivant.Image = image;
            LblSuivant.Location = new Point(831, 0);
            LblSuivant.Name = "LblSuivant";
            LblSuivant.Size = new Size(48, 48);
            LblSuivant.TabIndex = 6;
            LblSuivant.Click += new EventHandler(this.LblSuivant_Click);

            LblPrecedent = new Label();
            image2 = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/icones/precedent.png");
            LblPrecedent.Image = image2;
            LblPrecedent.Location = new Point(21, 0);
            LblPrecedent.Name = "LblPrecedent";
            LblPrecedent.Size = new Size(48, 48);
            LblPrecedent.TabIndex = 7;
            LblPrecedent.Click += new EventHandler(this.LblPrecedent_Click);

            LblNumQues = new Label();
            LblNumQues.Location = new Point(400, 11);
            LblNumQues.Name = "LblNumQues";
            LblNumQues.Size = new Size(141, 25);
            LblNumQues.Text = "Question (1/"+ listePanneaux .GetSize()+ ")";

            BtnConfirmer = new Button();
            BtnConfirmer.Location = new Point(673, 7);
            BtnConfirmer.Size = new Size(117, 35);
            BtnConfirmer.TabIndex = 0;
            BtnConfirmer.Text = "Confirmer";
            BtnConfirmer.UseVisualStyleBackColor = true;
            BtnConfirmer.Click += new EventHandler(this.BtnConfirmer_Click);
            
            BtnAnnuler = new Button();
            BtnAnnuler.Location = new Point(113, 7);
            BtnAnnuler.Size = new Size(117, 35);
            BtnAnnuler.TabIndex = 1;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += new EventHandler(this.BtnAnnuler_Click);

            panneauBas.Controls.Add(this.BtnAnnuler);
            panneauBas.Controls.Add(this.BtnConfirmer);
            panneauBas.Controls.Add(this.LblSuivant);
            panneauBas.Controls.Add(this.LblPrecedent);
            panneauBas.Controls.Add(this.LblNumQues);
        }
        private void AjouterPanneauBasResultat()
        {
            panneauBas.Controls.Clear();
            BtnReponses = new Button();
            BtnReponses.Location = new Point(673, 7);
            BtnReponses.Size = new Size(117, 35);
            BtnReponses.TabIndex = 0;
            BtnReponses.Text = "Voir les réponses";
            BtnReponses.UseVisualStyleBackColor = true;
            BtnReponses.Click += new EventHandler(this.BtnReponses_Click);

            BtnQuitter = new Button();
            BtnQuitter.Location = new Point(113, 7);
            BtnQuitter.Size = new Size(117, 35);
            BtnQuitter.TabIndex = 1;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += new EventHandler(this.BtnQuitter_Click);

            panneauBas.Controls.Add(this.BtnReponses);
            panneauBas.Controls.Add(this.BtnQuitter);
        }
        //Actionneur boutton Quitter
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Annuler quiz", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string message = "Voulez - vous vraiment quitter le test en cours ?";
            var rep = MessageBox.Show(message, "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                 this.Controls.Clear();
                 this.Controls.Add(pnlEntete);
                 this.Controls.Add(PnlBtns);
                 this.Controls.Add(pnlPrincipal);
            }
        }
        //Actionneur boutton revenir voir les Reponses
        private void BtnReponses_Click(object sender, EventArgs e)
        {
            Controls.Remove(panResultat); 
            Controls.Add(listePanneaux.GetListing(compteur));

            panneauBas.Controls.Clear();
            panneauBas.Controls.Remove(BtnReponses);
            //panneauBas.Controls.Add(BtnReponses);
            panneauBas.Controls.Add(this.BtnQuitter);
            panneauBas.Controls.Add(this.LblSuivant);
            panneauBas.Controls.Add(this.LblPrecedent);
            panneauBas.Controls.Add(BtnResultat);
        }

        // Actionneur boutton Retour
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Retour", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Controls.Clear();
            Controls.Add(pnlEntete);
            Controls.Add(PnlBtns);
            Controls.Add(pnlPrincipal);
            MettreAjourInfos();
        }

        // Actionneur boutton Mon compte
        private void BtnProfil_Click(object sender, EventArgs e)
        {
            Controls.Remove(pnlPrincipal);
            Controls.Remove(PnlBtns);
            AjouterPanneauBas();
            panneauBas.Controls.Remove(BtnDebut);

            PnlCompte = new PanneauProfilEtud(etud);
            Controls.Add(PnlCompte);

            BtnConfirmerCompte = new Button();
            BtnConfirmerCompte.Size = new Size(137, 35);
            BtnConfirmerCompte.Location = new Point(BtnRetour.Location.X - BtnConfirmerCompte.Size.Width - 15, 7);//73  7
            BtnConfirmerCompte.TabIndex = 0;
            BtnConfirmerCompte.Text = "Confirmer";
            BtnConfirmerCompte.Click += new EventHandler(this.BtnConfirmerCompte_Click);

            panneauBas.Controls.Add(this.BtnConfirmerCompte);

            LinkedLntf.Image = null;
        }


        // Actionneur boutton Confirmer
        private void BtnConfirmerCompte_Click(object sender, EventArgs e)
        {
            if (PnlCompte.ValiderSaisi())
            {
                MettreAjourInfos();
                QuestionServices.ModifierInfos(etud);
            }

        }

        //Actionneur boutton Debut quiz
        private void BtnDebut_Click(object sender, EventArgs e)
        {
            if (PanDeb.ValiderSaisi())
            {
                nbrQuestion = PanDeb.GetNombreQuestions();
                listeTags = PanDeb.GetListeTags();
                typeQuestion = PanDeb.GetTypeQuestion();
                
                listePanneaux = ScenarioServices.lancerScenario(nbrQuestion, listeQuestions, etud, typeQuestion);
                //Console.WriteLine("Mon profil = ");
                this.Controls.Remove(PanDeb);
                this.Controls.Add(listePanneaux.GetListing(compteur));
                AjouterPanneauBas2();
                
                // monProfil = Profil.GetProfil(etud, nbrQuestion);
                // Console.WriteLine("Mon profil = ");
                // Console.WriteLine("Mon profil = "+monProfil.ToString());
            }
        }

        //Actionneur boutton Suivant
        private void LblSuivant_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(listePanneaux.GetListing(compteur));
            compteur++;
            MettreAjourBoutonsEtNum();
            this.Controls.Add(listePanneaux.GetListing(compteur));
        }
        //Actionneur boutton Precedent
        private void LblPrecedent_Click(object sender, EventArgs e)
        {
            Controls.Remove(listePanneaux.GetListing(compteur));
            compteur--;
            MettreAjourBoutonsEtNum();
            Controls.Add(listePanneaux.GetListing(compteur));
        }

        //Mettre à jour Numéro de question
        private void MettreAjourBoutonsEtNum()
        {
            if (compteur < 0)
            {
                compteur = listePanneaux.GetSize()-1;
            }
            else if (compteur >= listePanneaux.GetSize())
            {
                compteur = 0;
            }

            LblNumQues.Text = "(Question " + (compteur + 1) + "/" + listePanneaux.GetSize() + ")";
            if (listePanneaux.GetListing(compteur).Reponse != null)
                BtnConfirmer.Enabled = false;
            else
                BtnConfirmer.Enabled = true;
        }

        //Actionneur boutton Confirmer réponse
        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Confirmer reponse", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //listePanneaux.GetListing(compteur).AfficherLblresultat(false);
            monPanneau = listePanneaux.GetListing(compteur);
            if (monPanneau is PanneauQCM)
            {
                if (((PanneauQCM)monPanneau).VerifierCheckBox())
                {
                    monPanneau.ValiderReponse();
                    BtnConfirmer.Enabled = false;
                }
            }
            else
            {
                monPanneau.ValiderReponse();
                BtnConfirmer.Enabled = false;
                ScenarioServices.Repondre(monPanneau.Reponse,compteur);
            }
            if (listePanneaux.FinReponses())
            {
                TestTermine();
            }
        }

        //Actionneur boutton Annuler_quiz
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Annuler quiz", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string message = "Voulez - vous vraiment quitter le test en cours ?";
            var rep = MessageBox.Show(message, "Attention!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                /* this.Controls.Clear();
                 this.Controls.Add(pnlEntete);
                 this.Controls.Add(PnlBtns);
                 this.Controls.Add(pnlPrincipal);*/
                TestTermine();
            }
        }

        public void TestTermine()
        {
            // MessageBox.Show("test termine", "Non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            panResultat = ScenarioServices.AfficherResultat();
            this.Controls.Remove(listePanneaux.GetListing(compteur));
            this.Controls.Add(panResultat);

            BtnResultat = new Button();
            BtnResultat.Location = new Point(673, 7);
            BtnResultat.Size = new Size(117, 35);
            BtnResultat.Text = "Résultat";
            BtnResultat.Click += new EventHandler(this.BtnResultat_Click);

            AjouterPanneauBasResultat();
        }


        //Actionneur bouton voir le resultat
        private void BtnResultat_Click(object sender, EventArgs e)
        {
            Controls.Remove(listePanneaux.GetListing(compteur));
            Controls.Add(panResultat);
            panneauBas.Controls.Remove(BtnResultat);
            panneauBas.Controls.Remove(LblPrecedent);
            panneauBas.Controls.Remove(LblSuivant);
            panneauBas.Controls.Add(BtnReponses);
        }

            //mettre à jour les infos de l'entete
            private void MettreAjourInfos()
        {
            etud.nom = PnlCompte.Nom();
            etud.prenom = PnlCompte.Prenom();
            etud.courriel = PnlCompte.Courriel();
            LinkedLnom.Text = etud.prenom + " " + etud.nom;
            foreach (Groupe tmp in etud.listinGroupe)
             cbGroupes.Items.Add(tmp.id_groupe);
        }
    }
}
