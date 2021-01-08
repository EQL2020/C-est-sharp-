using System;

namespace FormatageString
{
    public class Exemples
    {
        // Champs
        private int longueur;
        private DateTime dateCreation;
        public static int nbExemples = 0;

        // Propriétés
        public int Longueur { get => longueur; set => longueur = value; }
        public static int NbExemples { get; set; }

        // constructeurs
        public Exemples()
        {
            this.dateCreation = DateTime.Now;
            nbExemples++;
        }
        public Exemples(int longueurParDefaut) : this()
        {
            this.longueur = longueurParDefaut;
        }
        // Destructeur
        ~Exemples ()
        {
            Console.WriteLine(String.Format("Mon instance créée le {0:G} est détruite !", this.dateCreation));
        }
        public enum Couleur
        {
            blanc,
            rouge,
            vert,
            bleu
        }

        private static bool EstNul(int? monEntier)
        {
            return monEntier.HasValue;
        }

        public static string RecupDate(DateTime dateIndiquee)
        {
            int? monAge;
            monAge = null;
            Couleur maCouleur = Couleur.blanc;

            if (EstNul(monAge))
            {

            }
            return String.Format("{0:D}", dateIndiquee);
        }

        public static void ParcourtTableau(string[] monTableau)
        {
            if (monTableau != null)
            {
                for (int i = 0; i < monTableau.Length; i++)
                {
                    Console.WriteLine("Element n°" + i + ", valeur = " + monTableau[i]);
                }

                Console.WriteLine(String.Format("Mon tableau contient {0} éléments !", monTableau.Length));
                foreach (string element in monTableau)
                {
                    Console.WriteLine("Mon élément trouvé est : " + element);
                }
            }
            // Instanciantion d'une classe d'une même Assembly
            NiveauxAcces na = new NiveauxAcces();
            na.MonEntierInterne = 1;
            na.MonEntierPublic = 2;
        }

        public static void TestAffectation()
        {
            bool a = true;
            bool b = false;
            
            if (a == b)
            {
                Console.WriteLine(String.Format("Vrai : a = b (avec a = {0} et b = {b})", a, b));
            }
            else
            {
                Console.WriteLine(String.Format("Faux : a <> b (avec a = {0} et b = {b})", a, b));
            }

            if (a == b) Console.WriteLine(String.Format("Vrai : a = b (avec a = {0} et b = {b})", a, b));
            else Console.WriteLine(String.Format("Faux : a <> b (avec a = {0} et b = {b})", a, b));
        }

        public static void TestSwitch()
        {
            Couleur maCouleur = Couleur.bleu;
            switch (maCouleur)
            {
                case Couleur.vert:
                    Console.WriteLine("C'est bien la bonne couleur");
                    break;
                case Couleur.rouge:
                case Couleur.blanc:
                    Console.WriteLine("Rouge sur blanc, tout fout le camp !");
                    break;
                default:
                    Console.WriteLine("Je ne connais pas cette couleur...");
                    break;
            }
        }

        public static void AfficherElement(int element)
        {
            Console.WriteLine("Je vois l'élément " + element);
        }

        public static void AfficherElement(string element)
        {
            Console.WriteLine("Je vois l'élément " + element);
        }
        public static void TestBoucles()
        {
            /*
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Je suis au passage n° " + i++);
                if (i == 2)
                {
                    Console.WriteLine("Attention je suis sur 2 !");
                }
            }

            do
            {
                Console.WriteLine("Je suis au passage n° " + i++);
            }
            while (i < 3);
            */
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Passage avec i = " + i);
            }
            int[] tabEntiers = { 1, 3, 5 };
            string[] tabChaines = { "lundi", "mardi" };
            foreach (int element in tabEntiers)
            {
                AfficherElement(element);
            }
            foreach (string element in tabChaines)
            {
                AfficherElement(element);
            }
        }

        static void MaMethodeAvecParametres(ref int monEntier, string maChaine, int[] monTableau)
        {
            monEntier++;
            maChaine = "Au revoir";
            monTableau[0] = 5;
        }

        public static void TestParametres()
        {
            int monInt = 0;
            string monTexte = "Bonjour";
            int[] myTab = { 1, 2, 3 };
            Console.WriteLine("Avant : monInt = " + monInt + " monTexte = " + monTexte + " myTab[0] = " + myTab[0]);
            throw new Exception("Arrêt du traitement !");
            MaMethodeAvecParametres(ref monInt, monTexte, myTab);
            Console.WriteLine("Après : monInt = " + monInt + " monTexte = " + monTexte + " myTab[0] = " + myTab[0]);
        }
    }
}
