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

        bool OuvreConnection()
        {
            bool ouvertureOk = false;
            
            this.cnx.ConnectionString = ConfigurationManager.ConnectionStrings["baseLocale"]?.ConnectionString;
            // si ConfigurationManager.ConnectionStrings["baseLocale"] est null, alors, je retourne null, sinon je continue et je retourne la valeur de ConnectionString
            // Récupération d'un app setting : ConfigurationManager.ConfigurationSettings.AppSettings["NumeroSalle"];
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

        void FermetureBDD()
        {
            this.cnx.Close();
        }

        public string GetPremierClient()
        {
            string nomClient;
            string requeteSQL = "SELECT TOP (1) nom FROM client";
            requeteSQL = "SELECT COUNT(*) FROM client";
            SqlCommand cmd = new SqlCommand();
            this.OuvreConnection();
            cmd.Connection = this.cnx;
            cmd.CommandText = requeteSQL;
            cmd.CommandType = System.Data.CommandType.Text;
            nomClient = cmd.ExecuteScalar().ToString();
            this.FermetureBDD();
            return nomClient;
        }

        public void LireClients()
        {
            string maRequete = "SELECT nom FROM client";
            SqlCommand cmd = new SqlCommand();
            this.OuvreConnection();
            cmd.Connection = this.cnx;
            cmd.CommandText = maRequete;
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader resultat = cmd.ExecuteReader();
            // traitement resultat... voir méthode LireMaTable()
            this.FermetureBDD();
        }

        public void LireMaTableClient()
        {
            string requete = "SELECT noclient, nom, adresse, noregion FROM client";
            
            SqlCommand cmd = new SqlCommand(requete, this.cnx);
            this.OuvreConnection();
            SqlDataReader resultat = cmd.ExecuteReader();
            if (!resultat.HasRows)
            {
                Console.WriteLine("Pas de résultat à ma requete : " + requete);
            }
            while (resultat.Read())
            {
                Console.WriteLine("Num Client : {0} - Nom : {1} - Adresse : {2} - Région : {3}",
                    resultat.GetInt32(0), resultat.GetString(1), resultat.GetString(2), resultat.GetInt32(3));
            }
            this.FermetureBDD();
        }

        public void LireUneTable(string nomTable)
        {
            string requete = "SELECT * FROM " + nomTable;
            SqlCommand cmd = new SqlCommand(requete, this.cnx);
            this.OuvreConnection();
            SqlDataReader resultat = cmd.ExecuteReader();
            if (!resultat.HasRows)
            {
                Console.WriteLine("La requete sur la table {0} ne retourne rien", nomTable);
            }
            int nbColonnes = resultat.FieldCount;
            for (int c = 0; c < nbColonnes; c++)
            {
                Console.Write("{0}\t", resultat.GetName(c));
            }
            Console.WriteLine("");
            string valeurLue;
            while (resultat.Read())
            {
                for (int c = 0; c < nbColonnes; c++)
                {
                    switch (resultat.GetFieldType(c).ToString())
                    {
                        case "System.String":
                            valeurLue = resultat.GetString(c);
                            break;
                        case "System.Int32":
                            valeurLue = resultat.GetInt32(c).ToString();
                            break;
                        default:
                            valeurLue = "inconnue";
                            break;
                    }
                    Console.Write("{0}\t", valeurLue);
                }
                Console.WriteLine("");
            }
            this.FermetureBDD();
        }

    }
}
