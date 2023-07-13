// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- Où est passé mon numéros ? ---\nAffectation des valeures...\n");

int[] numbers = new int[10];

Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    numbers[i] = rnd.Next(1, 51);
}

Console.WriteLine("Affichage avant triage : ");

string tab = "";
foreach (var item in numbers)
{
    Console.WriteLine(tab + item);
    tab += "  ";
}

int firstNumbBefore = numbers[0];
Array.Sort(numbers);

Console.WriteLine("Après : ");

int firstNumbAfter = 0;
int index = 0;
tab = "";
foreach (var item in numbers)
{
    if (item == firstNumbBefore)
    {
        firstNumbAfter = index;
    }
    Console.WriteLine(tab + item);
    tab += "  ";
    index++;
}

Console.WriteLine($"Le nombre {firstNumbBefore + 1} se trouvait en première position\nIl se retrouve à la postion {firstNumbAfter + 1} après tirage.");