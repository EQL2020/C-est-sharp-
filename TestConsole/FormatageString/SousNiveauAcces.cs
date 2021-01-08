using System;
using System.Collections.Generic;
using System.Text;

namespace FormatageString
{
    public class SousNiveauAcces : NiveauxAcces
    {
        public int Hauteur;
        public SousNiveauAcces()
        {

            // Instance de classe fille
            this.MonEntierPublic = 1;
            this.MonEntierProtégé = 2;
            this.MonEntierInterne = 3;
        }

        public SousNiveauAcces(int haut, int largeur, int longueur) : base(largeur, longueur)
        {
            this.Hauteur = haut;
        }
    }
}
