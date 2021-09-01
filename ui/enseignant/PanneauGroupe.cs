using Newtonsoft.Json;
using Projet1_questions.modele;
using Projet1_questions.services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DLL_projet;


namespace Projet1_questions.ui.enseignant
{
    public partial class PanneauGroupe : UserControl
    {
        private DLL_projet.GroupeEtudiantsDll grEtdDll;
        private Enseignant enseig;
        private string id_grou_sele = "",titre_sele ="", titre_grou_sele;
        public List<Groupe> mesGroupes { get; set; }
        List<Etudiant> listeEtuds;
       // Etudiant etud;
        DialogResult res;

        Groupe unGroupe;

        public PanneauGroupe()
        {
            InitializeComponent();
        }

        public PanneauGroupe(Enseignant enseig) : this()
        {
            this.enseig = enseig;
            ImportetEtAfficherGroupes();

            //recuperer la liste des etudiants du groupe selectionné
            // listeEtuds = QuestionServices.EtudiantsGroupe(id_grou_sele);
            //afficher la liste des etudiants

            grEtdDll = PresentationServices.ListerEtudiant(DGVEtuds, new DLL_projet.GroupeDll(id_grou_sele));
            LblGroupeCour.Text = id_grou_sele;
        }

        //Actionneur le choix dun groupe 
        private void DGVgroupe_SelectionChanged(object sender, EventArgs e)
        {
            id_grou_sele = (string)DGVgroupe.CurrentRow.Cells["id_groupe"].Value;
            titre_grou_sele = (string)DGVgroupe.CurrentRow.Cells["titre"].Value;
            unGroupe = new Groupe(id_grou_sele, titre_grou_sele, enseig.id_personne);
            grEtdDll = PresentationServices.ListerEtudiant(DGVEtuds,
                new DLL_projet.GroupeDll(id_grou_sele, titre_grou_sele, enseig.id_personne));
            //Console.WriteLine(grEtd.ToJSON());

            LblGroupeCour.Text = id_grou_sele;
        }

        //Actionneur bouton ajouter groupe
        private void BtnAjout_Click(object sender, EventArgs e)
        {
            string id_groupe, titre;
            CreerGroupe nouveauGR = new CreerGroupe();
            res = nouveauGR.ShowDialog();
            if (res == DialogResult.OK)
            {
                id_groupe = nouveauGR.ID;
                titre = nouveauGR.Titre;
                unGroupe = new Groupe(id_groupe, titre, enseig.id_personne);
                QuestionServices.CreerGroupe(unGroupe);
                ImportetEtAfficherGroupes();
            }
        }

        //Actionneur bouton supprimer groupe
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            id_grou_sele = (string)DGVgroupe.CurrentRow.Cells["id_groupe"].Value;
            QuestionServices.SupprimerGroupe(id_grou_sele);
            ImportetEtAfficherGroupes();
        }

        //Actionneur bouton modifier groupe
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            id_grou_sele = (string)DGVgroupe.CurrentRow.Cells["id_groupe"].Value;
            titre_sele = (string)DGVgroupe.CurrentRow.Cells["titre"].Value;
            CreerGroupe nouveauGR = new CreerGroupe(id_grou_sele, titre_sele);
            res = nouveauGR.ShowDialog();
            if (res == DialogResult.OK)
            {
                id_grou_sele = nouveauGR.ID;
                titre_sele = nouveauGR.Titre;
                //unGroupe = new Groupe(id_grou_sele, titre_sele, enseig.id_personne);
                QuestionServices.ModifierGroupe(id_grou_sele, titre_sele);
                ImportetEtAfficherGroupes();
            }
        }

        //importer liste des groupes et afficher dans dataGridView
        private void ImportetEtAfficherGroupes()
        {
            // afficher les groupes
            mesGroupes = PresentationServices.ListerGroupe(DGVgroupe, enseig);
            //récupérer le groupe selectionné
            id_grou_sele = DGVgroupe.Rows[0].Cells[0].Value.ToString();
        }

        /*========================================== TP#2 ======================================*/
        
        // Exporter un groupe d’étudiants vers un fichier texte en format JSON;
        private void BtnExportJSON_Click(object sender, EventArgs e)
        {
            res = SFD.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    string nomFichier = SFD.FileName;
                    DLL_projet.LireEcrire maDll = new LireEcrireImpl();
                    maDll.ExporterJSON(nomFichier, grEtdDll);
                    MessageBox.Show("Exportation terminée avec succès", "Exportation JSON",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Echec d'Exportation\n"+ex.Message, "Exportation JSON",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Actionneur de bouton serialiser un objet GroupeEtudiant
        private void BtnSerialiseGrEtd_Click(object sender, EventArgs e)
        {
            try
            {
                res = SFD.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string nomFichier = SFD.FileName;
                    DLL_projet.Serialisation maDll = new SerialisationImpl();
                    maDll.Serialiser(nomFichier, grEtdDll);
                    MessageBox.Show("Sérialisation terminée avec succès", "Sérialisation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Echec sérialisation\n" + ex.Message, "Sérialisation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Lire un fichier CSV et créer un objet GroupeEtudiant
        private void BtnImporterCsv_Click(object sender, EventArgs e)
        {
            try
            {
                res = OFD.ShowDialog();
            if (res == DialogResult.OK)
            {
                DLL_projet.LireEcrire maDll = new LireEcrireImpl();
                grEtdDll = (DLL_projet.GroupeEtudiantsDll)maDll.ImporterCSV(OFD.FileName);
                    MessageBox.Show("Importation terminée avec succès, voici l'objet :\n"+
                        grEtdDll.ToString(), "Importation",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Echec d'Importation\n" + ex.Message, "Importation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Actionneur de bouton exporter
        private void BtnExporterCsv_Click(object sender, EventArgs e)
        {
            try
            {
                res = SFD.ShowDialog();
                if (res == DialogResult.OK)
                    {
                    string nomFichier = SFD.FileName;
                    // LireEcrire maDll = new LireEcrireImpl();

                    DLL_projet.LireEcrireImpl maDll = new LireEcrireImpl();
                    maDll.ExporterCSV(nomFichier, grEtdDll.ToCSV());

                    Console.WriteLine("allo :"+grEtdDll.ToCSV());
                    MessageBox.Show("Exportation terminée avec succès", "Exportation JSON",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Echec d'Exportation\n" + ex.Message, "Exportation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
