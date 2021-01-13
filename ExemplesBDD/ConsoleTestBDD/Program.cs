using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManipulationBddFramework;

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

            string entree = Console.ReadLine();
        }
    }
}
