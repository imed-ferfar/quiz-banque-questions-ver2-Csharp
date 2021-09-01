using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_questions.services;
using Projet1_questions.singleton;

namespace Projet1_questions.ui.etudiant
{
    public partial class PanneauResultat : UserControl
    {
        private Profil monProfil;
        public PanneauResultat()
        {
            InitializeComponent();
            monProfil = ScenarioServices.GetProfil();

            lblNbQuestion.Text = monProfil.notes.Length.ToString();
            lblBonneRep.Text = monProfil.NbrBonneRep.ToString();
            lblNote.Text = monProfil.CalculerNote().ToString() + " %";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Désolé, option non disponible", "Option non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
