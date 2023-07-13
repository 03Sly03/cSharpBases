// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- Gestion des notes ---\n\nVeuillez saisir les notes : \n(999 pour calculer)\n");

double best = 0;
double small = 20;
int i = 1;
double sum = 0;
while (true)
{
    Console.Write($"\t- Merci de saisir la note {i} (sur /20) : ");
    double note = double.Parse(Console.ReadLine());
    if (note == 999)
    {
        i -= 1;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nLa meilleur note est {best}/20");
            Console.ForegroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"La moins bonne note est {small}/20");
            Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"La moyenne des {i} notes est {Math.Round(sum / i, 1)}");
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


