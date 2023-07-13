// See https://aka.ms/new-console-template for more information

Console.WriteLine("Entrez un nombre : ");
int userInput = int.Parse(Console.ReadLine());
Console.WriteLine(userInput);

if (userInput % 2 == 0 && userInput % 3 == 0 && userInput % 4 == 0 && userInput % 5 == 0)
{
    Console.WriteLine("C'est un nombre premier");
}
else
{
    Console.WriteLine("Ce n'est pas un nombre premier");
}
