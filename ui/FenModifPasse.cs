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
    public partial class FenModifPasse : Form
    {
        private Personne perso;

        //constructeur#1
        public FenModifPasse()
        {
            InitializeComponent();
        }

        //constructeur#2
        public FenModifPasse(Personne perso) : this()
        {
                this.perso = perso;
        }

        //Actionneur bouton OK
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValiderSaisi())
            {
                ModifierMotPasse();
                QuestionServices.ModifierMotPasse(perso.id_personne, MotPasse());
                this.Close();
            }
        }

        //Valider la saisi des donnees
        private bool ValiderSaisi()
        {
            if (!TxtPasseActuel.Text.Equals(perso.motPasse))
            {
                MessageBox.Show("Mot de passse actuel est incorrect! \n",
                   "Mot de passe erroné", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtMotPasse.Text.Equals(""))
            {
                MessageBox.Show("Vous devez saisir un nouveau mot de passe.\n",
                  "Mot de passe erroné", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtMotPasse.Text.Length < 8)
            {
                MessageBox.Show("Le nouveau mot de passe doit avoir au moins 8 caractères.\n",
                  "Mot de passe erroné", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!TxtMotPasse.Text.Equals(TxtMotPasseConfirm.Text))
            {
                MessageBox.Show("Le mot de passe n'est pas identique! \n",
                   "Mot de passe erroné", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //BtnOK.DialogResult = DialogResult.OK;
            return true;
        }

        //Modifier le mot de passe
        private void ModifierMotPasse()
        {

        }
        
        //Retourner (getter) le nouveau mot de passe
        public string MotPasse()
        {
            return TxtMotPasse.Text;
        }

        //Actionneur checkBox#1
        private void ChkBmotPasse_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBmotPasse.Checked)
                TxtPasseActuel.PasswordChar = '\0';
            else
                TxtPasseActuel.PasswordChar = '*';
        }
        //Actionneur checkBox#2
        private void ChkBmotPasseConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBmotPasseConfirm.Checked)
            {
                TxtMotPasse.PasswordChar = '\0';
                TxtMotPasseConfirm.PasswordChar = '\0';
            }
            else { 
                TxtMotPasse.PasswordChar = '*';
                TxtMotPasseConfirm.PasswordChar = '*';
            }
        }
        
    }
}
