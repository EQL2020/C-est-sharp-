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
                // Récup du client
                var req = from cli in dc.client where cli.noclient == noCli select cli;
                client cliBdd = req.FirstOrDefault();
                Nom = cliBdd.nom;
                NoClient = cliBdd.noclient;
                Adresse = cliBdd.adresse;

                // Récup de la région
                var req2 = from reg in dc.region where reg.idregion == cliBdd.noregion select reg;
                region regionBdd = req2.FirstOrDefault();
                Region = regionBdd.nomregion;
            }
        }
}
}