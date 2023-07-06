// See https://aka.ms/new-console-template for more information

Console.Write("--- Gestion des notes ---\n\nVeuillez saisir 5 notes : \n\n");

double best = 0;
double small = 20;
double totalNotes = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"\t- Merci de saisir la note {i} (sur /20) : ");
    double note = double.Parse(Console.ReadLine());
    if (note < small)
        small = note;
    if (note > best) 
        best = note;
    totalNotes += note;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nLa meilleur note est {best}/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est {small}/20");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne des notes est {totalNotes / 5}/20");
