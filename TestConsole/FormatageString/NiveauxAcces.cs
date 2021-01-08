using System;
using System.Collections.Generic;
using System.Text;

namespace FormatageString
{
    public class NiveauxAcces
    {
        public int MonEntierPublic;
        public int Longueur;
        public int Largeur;
        protected int MonEntierProtégé;
        private int MonEntierPrivé;
        internal int MonEntierInterne;

        public NiveauxAcces()
        {
            // mon code de constructeur
            this.MonEntierPublic = 5;
            this.MonEntierProtégé = 3;
            this.MonEntierPrivé = 1;
            this.MonEntierInterne = 0;
        }

        public NiveauxAcces(int entierA, int entierB)
        {
            this.Largeur = entierA;
            this.Longueur = entierB;
        }
    }
}
