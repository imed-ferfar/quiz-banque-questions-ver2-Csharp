using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.singleton
{
    class BdConnexion
    {

        private static MySqlConnection laConnexion = null;

        private DbDataAdapter dataAdapter = null;
        private DbConnection cnx = null;
        private MySqlCommand sqlCmd = null;
        private DbCommand cmd = null;
        private DataTable tableBd = null;
        
        private static String urlBd = ""; //Server=127.0.0.1;Uid=root;Pwd=root;Database=
        private static String user = "";
        private static String motPasse = "";
        private static String bdd = "";

        //constructeur # 
        private BdConnexion()
        {
            /*cnx = new MySqlConnection();
            cnx.ConnectionString = urlBd + bdd + ";";
            cnx.Open();*/
        }


        public static void SetBdd(String bdd)
        {
            BdConnexion.bdd = bdd;
        }
        public static void SetUrlBD(String urlBd)
        {
            BdConnexion.urlBd = urlBd;
        }

        public static void SetUser(String user)
        {
            BdConnexion.user = user;
        }

        public static void SetPassword(String motPasse)
        {
            BdConnexion.motPasse = motPasse;
        }





        public static MySqlConnection GetConnexion()
        {
            try
            {
                if (laConnexion == null || laConnexion.State != ConnectionState.Open)
                {
                    if ((user.Equals("")) || (motPasse.Equals("")) || (bdd.Equals("")))
                        Console.WriteLine("Erreur des parametres de connextion");
                    else
                        laConnexion  = new MySqlConnection();
                        laConnexion.ConnectionString = urlBd + user + motPasse + bdd;
                        laConnexion.Open();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erreur : "+ ex.Message);
            }
            return laConnexion;
        }

        //fermer la connexion
        public static void Fermer()
        {
            if (laConnexion != null)
                try
                {
                    laConnexion.Close();
                    laConnexion = null;
                }
                catch (SqlException ex)
                {
                    //Logger.getLogger(DbConnexion.class.getName()).log(Level.SEVERE, null, ex);
                    Console.WriteLine("Probleme : " + ex.Message);
                }
        }















        public DbCommand EnvoyerRequeteSql(String rqSql)
        {
            //dbCommand = (MySqlCommand)cnx.CreateCommand();
            //dbCommand.CommandText = "rqSql";

            cmd = cnx.CreateCommand();
            cmd.CommandText = rqSql;
            cmd.CommandType = CommandType.Text;
            return cmd;
        }

        //
        public DataTable ResultatRequete()
        {
            dataAdapter = new MySqlDataAdapter(sqlCmd);

            tableBd = new DataTable();
            dataAdapter.Fill(tableBd);

            return tableBd;
        }

        public MySqlCommand RequeteParametree(String rqPar)
        {
            //sqlCmd = new MySqlCommand(); //Ou : sqlCmd = cnx.CreateCommand();
            sqlCmd = (MySqlCommand)cnx.CreateCommand();
            sqlCmd.CommandText = rqPar;
            sqlCmd.CommandType = CommandType.Text;

            return sqlCmd;
        }

        public MySqlCommand ajouterParametre(String param, String valParam)
        {
            sqlCmd.Parameters.AddWithValue(param, valParam);
            return sqlCmd;
        }
    }
}
