using Projet1_questions.modele;
using Projet1_questions.services;
using Projet1_questions.ui.enseignant.affficherQues;
using Projet1_questions.ui.enseignant.modif;
using System;

using System.Linq;
using System.Windows.Forms;

namespace Projet1_questions.ui.enseignant
{
    public partial class PanneauBanqueQuestion : UserControl
    {
        private Enseignant enseig;
        private ListeQuestions listingQues;

        private PanAjoutQCM monPanQCM;
        private PanAjoutQuesRes monPanQuesRes;
        private PanAjoutQuesImg monPanQuesImg;

        private QCM maQCM;
        private Erreur_image maQuesImg;
        private Resultat_execution maQuesRes;


        int id_ques_sele;
        string titre_ques;
        DialogResult res;
        FenetreAfficheQuestion fenQues;

        //constructeur #1
        public PanneauBanqueQuestion()
        {
            InitializeComponent();
        }

        //constructeur #2
        public PanneauBanqueQuestion(Enseignant enseig) :this()
        {
            this.enseig = enseig;
            listingQues = PresentationServices.ListerQuestion(DGVquestion, enseig.id_personne);
            listingQues.ListerQuestion();
            //abPage3.Enabled = false;
            //bPage3.Visible = false;
            (tabCQuestion.TabPages[2] as Control).Enabled = false;
            ComBTypeQues.SelectedIndex = 0;
            //Afficher la liste des groupes de l'etudiant
            string[] listeMat = QuestionServices.ListerMatieres().ToArray();
            ComBmat.Items.AddRange(listeMat);
        }


        private void TxtRecherche_TextChanged(object sender, EventArgs e)
        {
            /*//bs.Filter = "Question LIKE '%" + TxtRecherche.Text + "%'";
            bs.Filter = string.Format("question LIKE '%{0}%'", TxtRecherche.Text);
            DGVquestion.DataSource = bs;*/
        }

    
        //Choisir un type de question
        private void ComBTypeQues_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComBTypeQues.SelectedIndex)
            {
                case 0:
                    PanelCentreAjout.Controls.Clear();
                    monPanQCM = new PanAjoutQCM();
                    PanelCentreAjout.Controls.Add(monPanQCM);
                    break;
                case 1:
                    PanelCentreAjout.Controls.Clear();
                    monPanQuesImg = new PanAjoutQuesImg();
                    PanelCentreAjout.Controls.Add(monPanQuesImg);
                    break;
                case 2:
                    PanelCentreAjout.Controls.Clear();
                    monPanQuesRes = new PanAjoutQuesRes();
                    PanelCentreAjout.Controls.Add(monPanQuesRes);
                    break;
            }
        }

        // filter par checkBox (mes questions)
        private void ChkBMesQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBMesQuestion.Checked)
            {
                listingQues = PresentationServices.ListerQuestion(DGVquestion, enseig.id_personne, '*');
                BtnSupprimer.Enabled = true;
                BtnModifier.Enabled = true;
            }
            else
            {
                listingQues = PresentationServices.ListerQuestion(DGVquestion, enseig.id_personne);
                BtnSupprimer.Enabled = false;
                BtnModifier.Enabled = false;
            }   
        }

        //bouton confirmer ajout question
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValiderComboMatiere())
            {
                switch (ComBTypeQues.SelectedIndex)
                {
                    case 0:
                        if (monPanQCM.ValiderData())
                        {
                            int numQuestion = QuestionServices.NouveauIdQuestion();
                            string laQuestion = monPanQCM.LaQuestion();
                            maQCM = new QCM(numQuestion, laQuestion);
                            Choix choix;
                            int nombreChoix = monPanQCM.listeChoix.Count;
                            for (int i = 0; i < nombreChoix; i++)
                            {
                                choix = new Choix(monPanQCM.listeChoix.ElementAt(i).Text, monPanQCM.listeBonnesReponses.ElementAt(i).Checked);
                                maQCM.AjouterChoix(choix);
                            }
                            maQCM.ponderation = monPanQCM.Ponderation();
                            maQCM.partage = monPanQCM.Partage();
                            maQCM.id_enseignant = enseig.id_personne;
                            maQCM.id_matiere = ComBmat.SelectedItem.ToString();
                            QuestionServices.AjouterQuestion(maQCM);
                            monPanQCM.Reinitialiser();
                        }

                        break;
                    case 1:
                        if (monPanQuesImg.ValiderData())
                        {
                            int numQuestion = monPanQuesImg.id_question;
                            string url_image = monPanQuesImg.url_image;
                            int numLigne = monPanQuesImg.NumLigne();
                            string erreur = monPanQuesImg.Erreur();
                            string correction = monPanQuesImg.Correction();
                            maQuesImg = new Erreur_image(numQuestion, url_image, numLigne, erreur, correction);
                            maQuesImg.ponderation = monPanQuesImg.Ponderation();
                            maQuesImg.partage = monPanQuesImg.Partage();
                            maQuesImg.id_enseignant = enseig.id_personne;
                            maQuesImg.id_matiere = ComBmat.SelectedItem.ToString();
                            QuestionServices.AjouterQuestion(maQuesImg);
                            monPanQuesImg.Reinitialiser();
                        }
                        break;
                    case 2:
                        if (monPanQuesRes.ValiderData())
                        {
                            int numQuestion = QuestionServices.NouveauIdQuestion();
                            string laQuestion = monPanQuesRes.Le_code();
                            string reponse = monPanQuesRes.la_reponse();
                            maQuesRes = new Resultat_execution(numQuestion, laQuestion, reponse);

                            maQuesRes.ponderation = monPanQuesRes.Ponderation();
                            maQuesRes.partage = monPanQuesRes.Partage();
                            maQuesRes.id_enseignant = enseig.id_personne;
                            maQuesRes.id_matiere = ComBmat.SelectedItem.ToString();
                            QuestionServices.AjouterQuestion(maQuesRes);
                            monPanQuesRes.Reinitialiser();
                        }
                        break;
                }
                listingQues = PresentationServices.ListerQuestion(DGVquestion, enseig.id_personne);
            }
        }
        //valider choix matiere
        private bool ValiderComboMatiere()
        {
             if ((ComBmat.SelectedIndex == -1) && (ComBmatModif.SelectedIndex == -1))
            {
                MessageBox.Show("Choisir une matiere !!!", "Saisie de valeurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //actionneur bouton supprimer
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Question ques;
            id_ques_sele = Int32.Parse(DGVquestion.CurrentRow.Cells["id_question"].Value.ToString());
            titre_ques = (string)DGVquestion.CurrentRow.Cells["titre"].Value;
            ques = listingQues.GetQuestionN(id_ques_sele);
            res = MessageBox.Show("Êtes-vous sur de vouloir suuprimer la question N : "+ id_ques_sele+" ?", "Confirmation", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                switch (titre_ques)
                {
                    case "Choisir la ou les bonnes réponses":
                       // maQCM = new QCM(id_ques_sele, titre_ques);
                        QuestionServices.SupprimerQuestion(ques);
                        break;
                    case "Trouver l'erreur dans ce code":
                        //maQuesImg = new Erreur_image(id_ques_sele, titre_ques);
                        QuestionServices.SupprimerQuestion(ques);
                        break;
                    case "Trouver le resultat d'execution de ce code":
                        //maQuesRes = new Resultat_execution(id_ques_sele, titre_ques);
                        QuestionServices.SupprimerQuestion(ques);
                        break;
                }
                
            }
        }
        // Actionneur bouton Reset champs
        private void BtnReset_Click(object sender, EventArgs e)
        {
            switch (ComBTypeQues.SelectedIndex)
            {
                case 0:
                    monPanQCM.Reinitialiser();
                    break;
                case 1:
                    monPanQuesImg.Reinitialiser();
                    break;
                case 2:
                    monPanQuesRes.Reinitialiser();
                    break;
            }
        }

        // Actionneur bouton Modifier une question
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            (tabCQuestion.TabPages[2] as Control).Enabled = true;
            (tabCQuestion.TabPages[1] as Control).Enabled = false;
            tabCQuestion.SelectedIndex = 2;
            id_ques_sele = Int32.Parse(DGVquestion.CurrentRow.Cells["id_question"].Value.ToString());
            titre_ques = DGVquestion.CurrentRow.Cells["titre"].Value.ToString();
            TxtIdQues.Text = id_ques_sele.ToString();
            TxtTitre.Text = titre_ques;
            ComBmatModif.SelectedItem = listingQues.GetQuestionN(id_ques_sele).id_matiere;
            switch (titre_ques)
            {
                case "Choisir la ou les bonnes réponses":
                    PnlCentreModif.Controls.Clear();
                    monPanQCM = new PanAjoutQCM((QCM)listingQues.GetQuestionN(id_ques_sele));
                    PnlCentreModif.Controls.Add(monPanQCM);
                    break;
                case "Trouver l'erreur dans ce code":
                    PnlCentreModif.Controls.Clear();
                    monPanQuesImg = new PanAjoutQuesImg((Erreur_image)listingQues.GetQuestionN(id_ques_sele));
                    PnlCentreModif.Controls.Add(monPanQuesImg);
                    Console.WriteLine("okkkkkkkkkk");
                    break;
                case "Trouver le resultat d'execution de ce code":
                    PnlCentreModif.Controls.Clear();
                    monPanQuesRes = new PanAjoutQuesRes((Resultat_execution)listingQues.GetQuestionN(id_ques_sele));
                    PnlCentreModif.Controls.Add(monPanQuesRes);
                    break;
            }
        }

        private void BtnOKmodif_Click(object sender, EventArgs e)
        {
            if (ValiderComboMatiere())
            {
                id_ques_sele = Int32.Parse(DGVquestion.CurrentRow.Cells["id_question"].Value.ToString());
                switch (titre_ques)
                {
                    case "Choisir la ou les bonnes réponses":
                        if (monPanQCM.ValiderData())
                        {
                            maQCM = (QCM)listingQues.GetQuestionN(id_ques_sele);
                            string laQuestion = monPanQCM.LaQuestion();
                            maQCM.la_question = laQuestion;
                            Choix choix;
                            maQCM.liste_choix.Clear();
                            int nombreChoix = monPanQCM.listeChoix.Count;
                            for (int i = 0; i < nombreChoix; i++)
                            {
                                choix = new Choix(monPanQCM.listeChoix.ElementAt(i).Text, monPanQCM.listeBonnesReponses.ElementAt(i).Checked);
                                maQCM.AjouterChoix(choix);
                            }
                            maQCM.ponderation = monPanQCM.Ponderation();
                            maQCM.partage = monPanQCM.Partage();
                            maQCM.id_matiere = ComBmatModif.SelectedItem.ToString();
                            QuestionServices.ModifierQuestion(maQCM);
                            monPanQCM.Reinitialiser();
                        }
                        break;
                    case "Trouver l'erreur dans ce code":
                        if (monPanQuesImg.ValiderData()) {
                            maQuesImg = (Erreur_image)listingQues.GetQuestionN(id_ques_sele);
                            maQuesImg.url_image = monPanQuesImg.url_image;
                            maQuesImg.num_ligne = monPanQuesImg.NumLigne();
                            maQuesImg.erreur = monPanQuesImg.Erreur();
                            maQuesImg.correction = monPanQuesImg.Correction();

                            maQuesImg.ponderation = monPanQCM.Ponderation();
                            maQuesImg.partage = monPanQCM.Partage();
                            maQuesImg.id_matiere = ComBmatModif.SelectedItem.ToString();
                            QuestionServices.ModifierQuestion(maQuesImg);
                            monPanQuesImg.Reinitialiser();
                        }
                        break;
                    case "Trouver le resultat d'execution de ce code":
                        if (monPanQuesRes.ValiderData())
                        {
                            maQuesRes = (Resultat_execution)listingQues.GetQuestionN(id_ques_sele);
                            maQuesRes.partage = monPanQuesRes.Partage();
                            maQuesRes.le_code = monPanQuesRes.Le_code();
                            maQuesRes.reponse = monPanQuesRes.la_reponse();

                            QuestionServices.ModifierQuestion(maQuesRes);
                            monPanQuesRes.Reinitialiser();
                        }
                        break;
                }
                (tabCQuestion.TabPages[2] as Control).Enabled = false;
                (tabCQuestion.TabPages[1] as Control).Enabled = true;
                tabCQuestion.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_ques_sele = Int32.Parse(DGVquestion.CurrentRow.Cells["id_question"].Value.ToString());
            titre_ques = DGVquestion.CurrentRow.Cells["titre"].Value.ToString();
            switch (titre_ques)
            {
                case "Choisir la ou les bonnes réponses":
                    maQCM = (QCM)listingQues.GetQuestionN(id_ques_sele);
                    fenQues = new FenetreAfficheQuestion(maQCM);
                    break;
                case "Trouver l'erreur dans ce code":
                    maQuesImg = (Erreur_image)listingQues.GetQuestionN(id_ques_sele);
                    fenQues = new FenetreAfficheQuestion(maQuesImg);
                    break;
                case "Trouver le resultat d'execution de ce code":
                    maQuesRes = (Resultat_execution)listingQues.GetQuestionN(id_ques_sele);
                    fenQues = new FenetreAfficheQuestion(maQuesRes);
                    break;
            }
            
            res = fenQues.ShowDialog();
        }
    }
}
