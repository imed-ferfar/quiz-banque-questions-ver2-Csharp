
namespace Projet1_questions.ui
{
    partial class PanneauQuiz
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlTitre = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.PnlTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitre
            // 
            this.PnlTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTitre.Controls.Add(this.lblTitre);
            this.PnlTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTitre.Location = new System.Drawing.Point(136, 31);
            this.PnlTitre.Name = "PnlTitre";
            this.PnlTitre.Size = new System.Drawing.Size(653, 54);
            this.PnlTitre.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(130, 13);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(424, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Titre ...";
            // 
            // PanneauQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PnlTitre);
            this.Location = new System.Drawing.Point(1, 51);
            this.Name = "PanneauQuiz";
            this.Size = new System.Drawing.Size(900, 560);
            this.PnlTitre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitre;
        private System.Windows.Forms.Label lblTitre;
    }
}
