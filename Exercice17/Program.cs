// See https://aka.ms/new-console-template for more information

Console.Write(@"--- Quelle boisson souhaitez vous ? ---
Liste des boissons disponibles : 
    1)Eau Plate
    2)Eau Gazeuse
    3)Coca-cola
    4)Fanta
    5)Sprite
    6)Orangina
    7)7Up
Faites votre choix (1 à 7) : "
);

string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Votre Eau Plate est servi");
        break;
    case "2":
        Console.WriteLine("Votre Eau Gazeuse est servi");
        break;
    case "3":
        Console.WriteLine("Votre Coca-cola est servi");
        break;
    case "4":
        Console.WriteLine("Votre Fanta est servi");
        break;
    case "5":
        Console.WriteLine("Votre Sprite est servi");
        break;
    case "6":
        Console.WriteLine("Votre Orangina est servi");
        break;
    case "7":
        Console.WriteLine("Votre 7Up est servi");
        break;
    default:
        Console.WriteLine("Mauvais choix");
        break;
}
