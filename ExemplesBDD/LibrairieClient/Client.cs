using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieClient
{
    public class Client
    {
        string nom;
        string adresse;
        int numRegion;

        public int NoClient { get; set; }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }
        public int NumRegion
        {
            get { return this.numRegion; }
            set { this.numRegion = value; }
        }
        public Client (string nom, string adresse, int numRegion)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.numRegion = numRegion;
        }

        public Client(int no, string nom, string adr, int reg)
        {
            this.NoClient = no;
            this.nom = nom;
            this.adresse = adr;
            this.numRegion = reg;
        }
    }
}
