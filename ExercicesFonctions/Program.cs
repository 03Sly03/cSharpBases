// See https://aka.ms/new-console-template for more information



// NOM COMPLET
string displayName(string firstname, string lastname)
{
    return $"{firstname} {lastname}";
}
Console.WriteLine(displayName("John", "Doe\n"));


// SOUSTRACTION
double Substract(int a, int b)
{
    Console.WriteLine($"Je soustrait {a} et {b}");
    return a - b ;
}
int a = 2;
int b = 1;
Console.WriteLine($"Résultat: {Substract(a, b)}\n");


// QUELLE HEURE
string QuelleHeure(string heure = "12h00")
{
    return $"Il est {heure}";
}

Console.WriteLine(QuelleHeure());
Console.WriteLine(QuelleHeure("14h00\n"));


// COMPTEUR DE LETTRE
    // avec boucle
int compterLettreAAvecBoucle(string chaine)
{
    int count = 0;
    foreach (char item in chaine)
    {
        if (item == 'a')
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(compterLettreAAvecBoucle("C'est le b-a ba"));
Console.WriteLine(compterLettreAAvecBoucle("mixer"));

    // avec count
int compterLettreASansBoucle(string chaine)
{
    return chaine.Count(@char => @char == 'a');
}

Console.WriteLine(compterLettreASansBoucle("C'est le b-a ba"));
Console.WriteLine(compterLettreASansBoucle("mixer"));