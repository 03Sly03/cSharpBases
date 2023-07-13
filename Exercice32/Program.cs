// See https://aka.ms/new-console-template for more information

Console.WriteLine("Insertion des varleurs du tableau : \n");

string[] myArray = new string[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Saisir la valeur {i + 1} : ");
    myArray[i] = Console.ReadLine();
}
Console.WriteLine("Affichage des valeurs du tableau : ");
/*
for (int i = 0;i < myArray.Length; i++)
{
    string tab = string.Concat(Enumerable.Repeat("\t", i));
    Console.WriteLine(tab + myArray[i]);
}*/

// avec une boucle foreach
int it = 0;
foreach (var item in myArray)
{
    string tab = string.Concat(Enumerable.Repeat("\t", it));
    Console.WriteLine(tab + item);
    it++;
}