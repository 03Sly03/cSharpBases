// See https://aka.ms/new-console-template for more information

Console.WriteLine(@"--- Question à choix multiple ---

Quelle est l'instruction qui permet de sortir d'une boucle en C# ?
    a) quit
    b) continue
    c) break
    d) exit
");

do
{
    Console.Write("\nEntrez votre réponse: ");
    bool wishContinue = false;
    string answer = Console.ReadLine().ToLower();
    if ("abcd".Contains(answer))
    {
        if (answer == "c")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBravo!!! C'est la bonne réponse");
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrecte!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                Console.Write("Un nouvel essai ? Oui / Non : ");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "oui")
                {
                    wishContinue = true;
                    break;
                }
                else if (userInput == "non")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Erreur de saisie\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (true);
            if (!wishContinue)
            {
                break;
            }
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Veuillez choisir une réponse entre a, b, c ou d");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    
} while (true);
