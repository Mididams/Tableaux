using System;

int nombreMax = 50;
double[] tableau1 = new double[50];
double[] tableau2 = new double[50];
double total = 0;
double total2 = 0;

string entreeUtilisateur = "";
string? readResult;

do
{
    Console.Clear();
    Console.WriteLine("Ajouter des nombres dans un tableau");
    Console.WriteLine("1. Ajouter des nombres au tableau 1");
    Console.WriteLine("2. Ajouter des nombres au tableau 2");
    Console.WriteLine("3. Voir les tableau 1 et 2 et la somme des nombres entrés");
    Console.WriteLine("0. Quitter");
    readResult = Console.ReadLine();
    if (readResult != null)
        entreeUtilisateur = readResult;

    switch (entreeUtilisateur)
    {
        //case 0 : Quitter
        case "0":
            break;

        // case 1 : Ajouter des nombres au tableau 1
        case "1":
            Console.Clear();
            Console.WriteLine("Ajouter des nombres au tableau 1:");
            Console.WriteLine("Les nombres décimaux doivent comporter une virgule ',': et pas un point '.'\n");
            Console.WriteLine("Taper Entrée aprés chaque nombre");
            Console.WriteLine("Taper 'ok' pour quitter à la fin de votre saisie\n");

            for (int i = 0; i < nombreMax; i++)
            {
                Console.WriteLine($"Entrer le nombre {i + 1}:");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.ToLower() == "ok")
                        break;

                    if (!double.TryParse(readResult, out tableau1[i]))
                    {
                        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                        i--;
                    }
                }
            }

            Console.WriteLine("\nVoici les nombres entrés:");
            for (int i = 0; i < nombreMax; i++)
            {
                if (tableau1[i] != 0)
                {
                    Console.Write(tableau1[i]);
                    if (i < nombreMax - 1)
                        Console.Write(" | ");
                }
                total += tableau1[i];
            }

            Console.WriteLine();
            Console.WriteLine($"Le total est: {total}");
            Console.WriteLine("\nTaper Entrée");
            readResult = Console.ReadLine();
            break;

        // case 2 : Ajouter des nombres au tableau 2"
        case "2":
            Console.Clear();
            Console.WriteLine("Ajouter des nombres au tableau 2:");
            Console.WriteLine("Les nombres décimaux doivent comporter une virgule ',': et pas un point '.'\n");
            Console.WriteLine("Taper Entrée aprés chaque nombre");
            Console.WriteLine("Taper 'ok' pour quitter à la fin de votre saisie\n");

            for (int i = 0; i < nombreMax; i++)
            {
                Console.WriteLine($"Entrer le nombre {i + 1}:");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.ToLower() == "ok")
                        break;

                    if (!double.TryParse(readResult, out tableau2[i]))
                    {
                        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                        i--;
                    }
                }
            }

            Console.WriteLine("\nVoici les nombres entrés:");
            for (int i = 0; i < nombreMax; i++)
            {
                if (tableau2[i] != 0)
                {
                    Console.Write(tableau2[i]);
                    if (i < nombreMax - 1)
                        Console.Write(" | ");
                }
                total2 += tableau2[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Le total est: {total2}");
            Console.WriteLine("\nTaper Entrée");
            readResult = Console.ReadLine();
            break;

        case "3":
            Console.WriteLine("\nVoici les nombres entrés (tableau 1):");
            for (int i = 0; i < nombreMax; i++)
            {
                if (tableau1[i] != 0)
                {
                    Console.Write(tableau1[i]);
                    if (i < nombreMax - 1)
                        Console.Write(" | ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Le total est: {total}");
            Console.WriteLine();

            Console.WriteLine("\nVoici les nombres entrés (tableau 2):");
            for (int i = 0; i < nombreMax; i++)
            {
                if (tableau2[i] != 0)
                {
                    Console.Write(tableau2[i]);
                    if (i < nombreMax - 1)
                        Console.Write(" | ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Le total est: {total2}");
            Console.WriteLine("\nTaper Entrée");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (entreeUtilisateur != "0");


