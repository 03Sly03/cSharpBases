// See https://aka.ms/new-console-template for more information

Console.Write("--- Est pair...? Est impair...? ---\nCombiens de nombre contiendra le tableau ? : ");
int userInput = int.Parse(Console.ReadLine());

Console.WriteLine("Affectation automatique des valeurs...\n");
int[] myArray = new int[userInput];


Random rnd = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next();
}


Console.WriteLine("Vérification des valeurs du tableau : ");
for (int i = 0; i < userInput; i++)
{
    if (myArray[i] % 2 == 0)
        Console.WriteLine($"Le nombre {myArray[i]} est pair");
    else
        Console.WriteLine($"Le nombre {myArray[i]} est impair");
}
Console.WriteLine();
