// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- Trouver le nombre mystère ---\n");

int mysteryNumb = 55;
bool win = false;
while (!win)
{
    Console.Write("\tVeuillez saisir un nombre : ");
    int answer = int.Parse(Console.ReadLine());
    if (answer == mysteryNumb)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nBravo !!!! Vous avez trouvé le nombre mystère !");
        Console.ForegroundColor = ConsoleColor.White;
        win = true;
    }
    else if (answer > mysteryNumb)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tLe nombre mystère est plus petit");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (answer < mysteryNumb)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tLe nombre mystère est plus grand");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
