// See https://aka.ms/new-console-template for more information

using System;

string[] baseCandidats = new string[] {"Albert", "Kriss", "Toff", "Camille", "Dominique", "Jean", "Marco", "Victoire", "Winnie", "Orlane"};
string[] candidats = (string[])baseCandidats.Clone();
string[] candidatsTirer = new string[] {};
string resultat = "";
int i = 0;
string? choice = null;

do
{
    Random random = new Random();
    int numb = random.Next(0, candidats.Length);
    Console.Write("--- Le grand tirage au sort ---\n\n" +
        "1---Effectuer un tirage\n" +
        "2---Voir la liste des personnes déjà tirées\n" +
        "3---Voir la liste des personnes restantes\n" +
        "0---Quitter\n\n" +
        "Faites votre choix : ");
    choice = Console.ReadLine();

    switch (choice)
    {
        case "0":
            Console.WriteLine("\nsortie du programme !\n");
            Environment.Exit(0);
            break;
        case "1":
            Console.Clear();
            i = 0;
            if (candidats.Length > 0)
            {
                foreach (string candidat in candidats)
                {
                    if (i == numb)
                    {
                        string res = $"* L'heureux gagnant est : {candidat} *";
                        string frame = string.Concat(Enumerable.Repeat("*", + res.Length));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(frame + "\n" + res + "\n" + frame + "\n");
                        Console.ResetColor();
                        candidats = candidats.Where((source, index) => index != numb).ToArray();
                        if (candidatsTirer.Length == 0)
                        {
                            candidatsTirer = new string[] { candidat };
                        }
                        else
                        {
                            Array.Resize(ref candidatsTirer, candidatsTirer.Length + 1);
                            candidatsTirer[candidatsTirer.Length - 1] = candidat;
                        }
                    }
                    i++;
                }
            } else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Il n'y a plus de candidat. Allez on recommence !\n");
                Console.ResetColor();
                Console.Write("Appuyez sur une touche pour continuer");
                Console.ReadKey();
                candidats = (string[])baseCandidats.Clone();
                candidatsTirer = new string[] { };
                Console.Clear();
            }
            break; 
        case "2":
            Console.Clear();
            resultat = "";
            i = 0;
            foreach (var item in candidatsTirer)
            {
                if (candidatsTirer.Length == 1 || candidatsTirer.Length -1 == i)
                {
                    resultat += item;
                }
                else
                {
                    resultat += item + ", ";
                }
                i++;
            }
            Console.WriteLine(resultat);

            break;
        case "3":
            Console.Clear();
            resultat = "";
            i = 0;
            foreach (var item in candidats)
            {
                if (i == candidats.Length -1 || candidats.Length == 1)
                {
                    resultat += item;
                }
                else
                {
                    resultat += item + ", ";
                }
                i++;
            }
            Console.WriteLine(resultat);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Erreur de saisie. Entrez un numéro entre 0 et 3.");
            break;
    }
} while (true);
