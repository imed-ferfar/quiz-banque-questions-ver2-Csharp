using Projet1_questions.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.singleton
{
    class Profil
    {
        // instance unique
        private static Profil monProfil = null;
        public Etudiant etudiant { get; }
        private String laDate;
        private String lHeure;
        private int nombreQuestion;
        private double note;
        public bool[] notes { get; }
        public int NbrBonneRep {get;set;}
        public int duree { get;  set; }

        DateTime date;

        public Profil()
        {
        }
        private Profil(Etudiant etudiant, int nombreQuestion)
        {
            this.etudiant = etudiant;
            this.nombreQuestion = nombreQuestion;
            date = DateTime.Now;
            laDate = date.ToString("MM/dd/yyyy");
            lHeure = date.ToString("HH:mm");
            notes = new bool[nombreQuestion];
            NbrBonneRep = 0;
        }

        public Profil(Etudiant etudiant, String laDate, String lHeure, int nombreQuestion, double note, int duree)
        {
            this.etudiant = etudiant;
            this.laDate = laDate;
            this.lHeure = lHeure;
            this.nombreQuestion = nombreQuestion;
            this.note = note;
            this.duree = duree;
        }
     

        public void AjouterNote(int position)
        {
            notes[position] = true;
            NbrBonneRep++;
        }
        public double CalculerNote()
        {
            double somme = 0;
            for (int i = 0; i < notes.Length; i++)
                if (notes[i])
                    somme++;
            return (int)((somme / notes.Length) * 100);
        }
        public void GetNbrBonneRep(int position)
        {
           
        }


        public override String ToString()
        {
            return etudiant.ToString() + "#" + laDate + "#" + lHeure + "#" + nombreQuestion + "#" + note + "#" + duree;
        }

        // la methode static de creation du Profil
        public static Profil GetProfil(Etudiant etudiant, int nombreQuestion) 
        {
            if (monProfil == null)
                    //lock(monProfil)// equivalent de synchronized en Java
                monProfil = new Profil(etudiant, nombreQuestion);
            return monProfil;
        }
    }
}
