// See https://aka.ms/new-console-template for more information

Console.Write("Veulliez saisir un entier supérieur à 0 : ");
int userInput = int.Parse(Console.ReadLine());

Console.WriteLine("\tTables de multiplications:");
Console.WriteLine("=========================================");
Console.WriteLine("| 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |10 |");
Console.WriteLine("=========================================");

for (int i = 1; i <= userInput; i++)
{
    string line = "|";
    for (int j = 1; j <= 10; j++)
    {
        int result = i * j;
        if (result >= 10 && result < 100)
            line += $"{result} |";
        else if (result >= 100)
            line += $"{result}|";
        else
            line += $" {result} |";
    }
    Console.WriteLine(line);
    Console.WriteLine("+---+---+---+---+---+---+---+---+---+---+");
}
