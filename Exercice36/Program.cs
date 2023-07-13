// See https://aka.ms/new-console-template for more information

int nbNotes;
Console.Write("***** Tableaux de notes *****\nCombien de notes comportera le tableaux : ");
while (!(int.TryParse(Console.ReadLine(), out nbNotes)))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\tErreur de saisie, merci de saisir un chiffre/nombre : ");
    Console.ResetColor();
}
double[] notes = new double[nbNotes];

Console.WriteLine($"\nMerci de saisir les {notes.Length} notes\n");
for (int i = 0; i < notes.Length; i++)
{
    int note;
    Console.Write($"-Note {i+1} : ");
    while (!(int.TryParse(Console.ReadLine(), out note) && note >= 0 && note <= 20))
    {
        Console.Write($"\tErreur, merci de saisir un chiffre/nombre entre 0 et 20 pour la note {i + 1} : ");
    }
    notes[i] = note;
}

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--- Liste des notes ---");
Console.ResetColor();
int iteration = 0;
foreach (var item in notes)
{
    Console.WriteLine($"La note {iteration+1} est de : {item}");
    iteration++;
}

Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine($"\n--- La note max est : {notes.Max()}/20");
Console.ForegroundColor= ConsoleColor.Red;
Console.WriteLine($"--- La note min est : {notes.Min()}/20");
Console.ForegroundColor= ConsoleColor.Blue;
Console.WriteLine($"--- La moyenne est de : {Math.Round(notes.Average(), 2)}/20");
Console.ResetColor();