using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManipulationBddFramework;
using LibrairieClient;

namespace ConsoleTestBDD
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesBdd testConnexion = new AccesBdd();
      
            string monClient = testConnexion.GetPremierClient();
            Console.WriteLine("Mon 1er client est : " + monClient);
            //testConnexion.LireClients();
            testConnexion.LireUneTable("client");
            Console.WriteLine("insertion en cours...");
            Client monNouveauClient = new Client("Maradona", "1 chemin Argentin", 3);
            testConnexion.InsererNouveauClient(monNouveauClient);
            testConnexion.LireUneTable("client");
            string entree = Console.ReadLine();
        }
    }
}
