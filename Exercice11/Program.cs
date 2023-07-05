// See https://aka.ms/new-console-template for more information

Console.Write("--- Le nombre est-il divisible par...? ---\nEntrez un chiffre/nombre entier : ");
int numb = int.Parse(Console.ReadLine());
Console.Write("Entrez le chiffre/nombre diviseur : ");
int diviseur = int.Parse(Console.ReadLine());

bool isChiffre = numb >= 10;
if (numb % diviseur == 0)
    Console.WriteLine($"\nLe {(isChiffre ? "chiffre" : "nombre")} est divisible par {diviseur}");
else
    Console.WriteLine($"\nLe {(isChiffre ? "chiffre" : "nombre")} n'est pas divisible par {diviseur}");
