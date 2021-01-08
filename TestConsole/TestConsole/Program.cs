using System;
using FormatageString;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] mesCouleurs = { "blanc", "rouge", "vert" };
            //Exemples.ParcourtTableau(mesCouleurs);
            try
            {
                Exemples.TestParametres();
            }
            catch (Exception e)
            {
                Console.WriteLine("J'ai levé une exception inconnue : " + e.Message);
            }
            Exemples.TestBoucles();
            Exemples monExemple = new Exemples();
            monExemple.Longueur = 12;
            Console.WriteLine("Nombre d'exemples = " + Exemples.nbExemples);
            Exemples monExempleAvecLongueur = new Exemples(14);
            Console.WriteLine("Nombre d'exemples = " + Exemples.nbExemples);

            Console.WriteLine("Ma lognueur est : " + monExemple.Longueur);

            // Accès uniquement aux propriétés PUBLIC
            NiveauxAcces na = new NiveauxAcces(1, 2);
            na.MonEntierPublic = 1;
            SousNiveauAcces sna = new SousNiveauAcces(3, 5 , 6);
            sna.MonEntierPublic = 0;
        }

    }
}
