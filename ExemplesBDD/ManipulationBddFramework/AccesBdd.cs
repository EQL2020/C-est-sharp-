using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ManipulationBddFramework
{
    public class AccesBdd
    {
        SqlConnection cnx;
        public SqlConnection Cnx
        {
            get { return this.cnx; }
        }

        public AccesBdd()
        {
            this.cnx = new SqlConnection();
        }

        public bool OuvreConnection()
        {
            bool ouvertureOk = false;
            
            this.cnx.ConnectionString = ConfigurationManager.ConnectionStrings["baseLocale"]?.ConnectionString;
            // Récupération d'un app setting : ConfigurationSettings.AppSettings["machaine"];
            try
            {
                this.cnx.Open();
                ouvertureOk = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erreur ouverture SQL : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur autre sur l'ouverture : " + e.Message);
            }
            return ouvertureOk;
        }

        public void FermetureBDD()
        {
            this.cnx.Close();
        }

        public string GetPremierClient()
        {
            string nomClient;
            string requeteSQL = "SELECT TOP (1) nom FROM client";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.cnx;
            cmd.CommandText = requeteSQL;
            cmd.CommandType = System.Data.CommandType.Text;
            nomClient = cmd.ExecuteScalar().ToString();
            return nomClient;
        }
    }
}
