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
    class PanneauResExec : PanneauQuiz
    {
        private Resultat_execution questionResExe;
        private TextBox TxtCode;
        private Panel PnlResultExec;
        private TextBox TxtReponse;
        private Label LblResultat;

        public PanneauResExec(Resultat_execution questionResExe) : base (questionResExe)
        {
            this.questionResExe = questionResExe;
            ModifierContenuResExe();
        }

        //Afficher une question Resultat execution
        private void ModifierContenuResExe()
        {

            TxtCode = new TextBox();
            PnlResultExec = new Panel();
            LblResultat = new Label();
            TxtReponse = new TextBox();

            // TxtCode
            // 
            TxtCode.Text = questionResExe.le_code;
            TxtCode.AcceptsReturn = true;
            TxtCode.AcceptsTab = true;
            TxtCode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            TxtCode.Location = new Point(176, 123);
            TxtCode.Multiline = true;
            TxtCode.ReadOnly = true;
            TxtCode.Size = new Size(575, 250);
            TxtCode.TabIndex = 1;
            // 
            // PnlResultExec
            // 
            PnlResultExec.BorderStyle = BorderStyle.Fixed3D;
            PnlResultExec.Controls.Add(this.TxtReponse);
            PnlResultExec.Controls.Add(this.LblResultat);
            PnlResultExec.Location = new Point(241, 394);
            PnlResultExec.Size = new Size(432, 142);
            // 
            // LblResultat
            // 
            LblResultat.AutoSize = true;
            LblResultat.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            LblResultat.Location = new Point(20, 12);
            LblResultat.Size = new Size(80, 18);
            LblResultat.Text = "Resultat :";
            // 
            // TxtReponse
            // 
            TxtReponse.AcceptsReturn = true;
            TxtReponse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            TxtReponse.Location = new Point(106, 13);
            TxtReponse.Multiline = true;
            TxtReponse.Size = new Size(299, 108);
            TxtReponse.TabIndex = 0;

            Controls.Add(this.PnlResultExec);
            Controls.Add(this.TxtCode);
        }

        public override bool ValiderReponse()
        {
            bool flag = false;
            if (TxtReponse.Text.Equals(questionResExe.reponse))
            {
                flag = true;
            }
            TxtReponse.ReadOnly = true; ;
            Reponse = flag.ToString();
            AfficherLblresultat(flag);
            return flag;
        }
    }
}
