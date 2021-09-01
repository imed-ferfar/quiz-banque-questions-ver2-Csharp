using Projet1_questions.modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions.ui.etudiant
{
    class PanneauQCM : PanneauQuiz
    {

        private QCM questionQCM { get; set; }
        public CheckBox[] tabChoix { get; set; }
        public Label lblQuestion { get; set; }

        public PanneauQCM(QCM questionQCM) : base(questionQCM)
        {
            this.questionQCM = questionQCM;
            ModifierContenuQCM();
        }

        //Afficher une question QCM
        private void ModifierContenuQCM()
        {
            lblQuestion = new Label();
            //lblQuestion.BackColor = Color.LightSkyBlue;
            lblQuestion.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblQuestion.Text = (questionQCM.la_question);
            lblQuestion.Location = new Point(91, 111);
            lblQuestion.Size = new Size(750, 45);
            Controls.Add(lblQuestion);

            int y = 90;
            tabChoix = new CheckBox[questionQCM.liste_choix.Count];

            /*passerSouris = new java.awt.event.MouseMotionAdapter() {
                public void mouseMoved(java.awt.event.MouseEvent evt) {
                    jCheckBox1MouseMoved(evt);
                }
            };
            sortirSouris = new java.awt.event.MouseAdapter() {
                public void mouseExited(java.awt.event.MouseEvent evt) {
                    jCheckBox1MouseExited(evt);
                }
            };*/

            for (int i = 0; i < questionQCM.liste_choix.Count; i++)
            {
                tabChoix[i] = new CheckBox();
                tabChoix[i].Size = new Size(750, 50);
                tabChoix[i].Text = questionQCM.liste_choix.ElementAt(i).choix;
                tabChoix[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                /*tabChoix[i].addMouseMotionListener(passerSouris);
                tabChoix[i].addMouseListener(sortirSouris);
                tabChoix[i].setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));*/
                tabChoix[i].BackColor = Color.Gainsboro;
                tabChoix[i].Location = new Point(73, (y + 69));

                this.Controls.Add(tabChoix[i]);
                y += 59;
            }
        }

        //Vérifier réponse QCM (choisir au moins une réponse)
        public bool VerifierCheckBox()
        {
            for (int i = 0; i < tabChoix.Length; i++)
            {
                if (tabChoix[i].Checked)
                    return true;
            }
            MessageBox.Show("Attention! vous devez choisir au moins une reponse", "Erreur de choix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Valider Réponse QCM
        public override bool ValiderReponse()
        {
            bool flag = true;
            {
                for (int i = 0; i < tabChoix.Length; i++)
                {
                    tabChoix[i].Enabled = false;
                    if (questionQCM.liste_choix.ElementAt(i).statut_choix)
                    {
                        tabChoix[i].BackColor = Color.LimeGreen;
                        if (tabChoix[i].Checked)
                        {
                            tabChoix[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else if (tabChoix[i].Checked)
                    {
                        tabChoix[i].BackColor = Color.Red;
                        flag = false;
                        tabChoix[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    }

                    // listePanneaux.getListing(compteur).getTabChoix()[i].removeMouseMotionListener(listePanneaux.getListing(compteur).getPasserSouris());
                    // listePanneaux.getListing(compteur).getTabChoix()[i].removeMouseListener(listePanneaux.getListing(compteur).getSortirSouris());
                }
                Reponse = flag.ToString();
                AfficherLblresultat(flag);
                return flag;
            }
        }
    }
}
