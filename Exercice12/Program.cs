// See https://aka.ms/new-console-template for more information

Console.Write("--- Dans quelle catégorie mon enfant est-il...? ---\n\nEntrez l'âge de votre enfant : ");
int childAge = int.Parse(Console.ReadLine());
string childCategory = "";

if (childAge < 18)
{
    if (childAge < 3)
        Console.WriteLine($"\nVotre enfant est trop jeune");
    else if (childAge <= 6)
        childCategory = "Baby";
    else if (childAge <= 8)
        childCategory = "Poussin";
    else if (childAge <= 10)
        childCategory = "Pupille";
    else if (childAge <= 12)
        childCategory = "Minime";
    else
        childCategory = "Cadet";
}
else
    Console.WriteLine($"\nVotre enfant n'est plus un enfant");

Console.WriteLine(childCategory != "" ? $"\nVotre enfant est dans la catégorie \"{childCategory}\"" : "");

