using Projet1_questions.singleton;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_questions
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Server=127.0.0.1;Uid=root;Pwd=root;Database=question;
            BdConnexion.SetUrlBD("Server = 127.0.0.1;");
            BdConnexion.SetUser("Uid=root;");
            BdConnexion.SetPassword("Pwd=root;");
            BdConnexion.SetBdd("Database=question;");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenSeConnecter());
        }
    }
}
