using System;


namespace Denombrements
{
    /// <summary>
    /// Permet de réaliser 3 opération de dénombrement : permutation, arrangement et combinaison 
    /// </summary>
    class Program
    {
        // Gérer les saisies
        static int saisie(string message)
        {
            bool correct = false;
            int reponse = 0;
            while (!correct)
            {
                try
                {
                    Console.Write(message);
                    reponse = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie");
                }
            }
            return reponse;
        }
        // Multiplication factorielle
        static void Multiplication(int pop, ref double result, int i)
        {
            for (int k = i; k <= pop; k++)
                result *= k;
        }
        static void Main(string[] args)
        {
            const int k = 1;
            int choix = 1;
            while (true)
            {
                // Menu de selection
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                choix = saisie("Choix :                            ");
                
                // Fermer le progamme
                if (choix == 0) { Environment.Exit(0); }

                if (choix == 1)
                {
                    // Permutation
                    int pop = saisie("nombre total d'éléments à gérer = ");
                    double result = 1;
                    Multiplication(pop, ref result, k);
                    Console.WriteLine(pop + "! = " + result);
                }
                else
                {
                    int pop = saisie("nombre total d'éléments à gérer = ");
                    int sub = saisie("nombre d'éléments dans le sous ensemble = ");
                    if (choix == 2)
                    {
                        // Arrangement
                        double result = 1;
                        Multiplication(pop, ref result, (pop - sub + 1));
                        Console.WriteLine("A(" + pop + "/" + sub + ") = " + result);
                    }
                    else
                    {
                        // Combinaison
                        double result1 = 1;
                        Multiplication(pop, ref result1, (pop - sub + 1));

                        double result2 = 1;
                        Multiplication(sub, ref result2, k);
                        Console.WriteLine("C(" + pop + "/" + sub + ") = " + (result1 / result2));
                    }
                }
            }
        }
    }
}
