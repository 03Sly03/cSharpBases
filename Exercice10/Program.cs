// See https://aka.ms/new-console-template for more information

Console.Write("--- La lettre est-elle une voyelle ? ---\nEntrez une lettre: ");
string demande = Console.ReadLine().ToLower();
int isInt;
if (demande == null || demande.Length > 1 || int.TryParse(demande, out isInt))
{
    Console.WriteLine("\nEntrée nom valide\n");
}
else
{
    if (
        "aeiouy".Contains(demande)
        )
        Console.WriteLine("C'est une voyelle !");
    else
        Console.WriteLine("C'est une consonne !");
}
