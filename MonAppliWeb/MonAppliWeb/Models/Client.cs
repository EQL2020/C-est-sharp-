using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonAppliWeb.Models
{
    public class Client
    {
        public int NoClient { get; set; }

        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Region { get; set; }

        public Client()
        {

        }

        public Client (int noCli)
        {
            this.ChargeClient(noCli);
        }

        void ChargeClient(int noCli)
        {
            using (BddClientDataContext dc = new BddClientDataContext())
            {
                var req = from cli in dc.clientregion where cli.noclient == noCli select cli;
                clientregion cliBdd = req.FirstOrDefault();
                Nom = cliBdd.nom;
                NoClient = cliBdd.noclient;
                Adresse = cliBdd.adresse;
                Region = cliBdd.nomregion;
            }
        }
}
}