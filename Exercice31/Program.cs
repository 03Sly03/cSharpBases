// See https://aka.ms/new-console-template for more information


double? bestNote = null;
double? smallNote = null;
double? averageNotes = null;
string? choice = null;
do
{
    Console.Clear();
    if (choice == "0")
    {
        Environment.Exit(0);
    }
    if (choice == "2" && bestNote != null)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"------ La plus grande note ------\n\nLa note la plus grande est : {bestNote}/20\n");
        Console.ResetColor();
    }
    if (choice == "3" && smallNote != null)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"------ La plus petite note ------\n\nLa note la plus petite est : {smallNote}/20\n");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    if (choice == "4" && averageNotes != null)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"------ La moyenne des notes ------\n\nLa moyenne est de : {averageNotes}/20\n");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.Write("--- Gestion des notes avec menu ---\n\n" +
                "1----Saisir les notes\n" +
                "2----La plus grande note\n" +
                "3----La plus petite note\n" +
                "4----La moyenne des notes\n" +
                "0----Quitter\n");
    Console.Write("\nFaites votre choix: ");
    choice = Console.ReadLine();
    while (!"12340".Contains(choice))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Veuillez saisir une valeur entre 0 et 4");
        Console.ForegroundColor = ConsoleColor.Gray;
        choice = Console.ReadLine();
    }
    if (choice == "1")
    {
        Console.Clear();
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine("------ Saisir les notes ------\n(999 pour stoper la saisie)\n");
        Console.ForegroundColor= ConsoleColor.Gray;

        double best = 0;
        double small = 20;
        int i = 1;
        double sum = 0;
        while (true)
        {
            Console.Write($"Merci de saisir la note {i} (sur /20) : ");
            double note = double.Parse(Console.ReadLine());
            if (note == 999)
            {
                i -= 1;
                bestNote = best;
                smallNote = small;
                averageNotes = Math.Round(sum / i, 1);
                break;
            }
            else
            {
                sum += note;
                if (note > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    sum -= note;
                    i -= 1;
                }
                else if (note < small)
                {
                    small = note;
                }
                else if (note > best)
                {
                    best = note;
                }
            }

            i++;
        }

    }
} while (true);
