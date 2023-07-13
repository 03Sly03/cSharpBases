// See https://aka.ms/new-console-template for more information

Console.Write("====== Gestion des Contacts ======\nMerci de saisir le nombre de contact : ");
int numbContact = int.Parse(Console.ReadLine());
Console.Clear();

string[] contacts = new string[numbContact];

while (true)
{
    Console.WriteLine("----- Ma liste de contacts -----\n" +
        "1----Saisir des contacts\n" +
        "2----Afficher mes contacts\n" +
        "0----Quitter\n");

    Console.Write("Faites votre choix : ");
    string choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            int i = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- Saisir les contacts -----");
            Console.ResetColor();
            foreach (var item in contacts)
            {
                Console.Write($"Nom et prènom du contact N°{i+1} : ");
                contacts[i] = Console.ReadLine();
                i++;
            }
            Console.Clear();
            break;
        case "2":
            int it = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- Affichage des contacts -----");
            Console.ResetColor();
            foreach (var item in contacts)
            {
                Console.WriteLine($"-Contact N° {it} : {item}");
                it++;
            }
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour revenir au menu");
            Console.ReadKey();
            Console.Clear();
            break;
        case "0":
            Environment.Exit(0);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n!!! Erreur de saisi !!!\n");
            Console.ResetColor();
            break;
    }
}
