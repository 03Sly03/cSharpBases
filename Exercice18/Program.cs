// See https://aka.ms/new-console-template for more information

Console.Write("--- Dans quelle catégorie mon enfant est-il...? ---\n\nEntrez l'âge de votre enfant : ");
int childAge = int.Parse(Console.ReadLine());
string childCategory = "";

switch (childAge)
{
    case < 3:
        Console.WriteLine($"\nVotre enfant est trop jeune");
        break;
    case <= 6:
        childCategory = "Baby";
        break;
    case <= 8:
        childCategory = "Poussin";
        break;
    case <= 10:
        childCategory = "Pupille";
        break;
    case <= 12:
        childCategory = "Minime";
        break;
    case < 18:
        childCategory = "Cadet";
        break;
    case > 18:
        Console.WriteLine($"\nVotre enfant n'est plus un enfant");
        break;
}

Console.WriteLine(childCategory != "" ? $"\nVotre enfant est dans la catégorie \"{childCategory}\"" : "");
