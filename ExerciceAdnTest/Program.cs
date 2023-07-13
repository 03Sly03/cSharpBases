// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string userInput;
string chain = "";

string SaisieAdn(string title)
{
    bool read = true;
    if (chain == "")
    {
        while (read)
        {
            Console.Write(title);
            userInput = Console.ReadLine()!.Trim().ToLower();
            foreach (char @char in userInput)
            {
                if (!"atcg".Contains(@char))
                    read = false;
            }
            if (read)
                return userInput;
            else
                read = true;
            Console.WriteLine("Erreur de saisie !!!");
        }
    }
    else
    {
        while (true)
        {
            Console.Write(title);
            userInput = Console.ReadLine()!.Trim().ToLower();
            int occurence = Regex.Matches(chain, userInput).Count;
            if (occurence != 0)
                return userInput;
            Console.WriteLine("Erreur de saisie !!!");
        }
    }
    return "Erreur";
}

double Proportion(string val1, string val2)
{
    int count = Regex.Matches(val1, val2).Count;
    double proportion = (double)count * val2.Length / val1.Length;
    return proportion * 100;
}

string chaine = SaisieAdn("Veuillez saisir une chaine adn : ");
string sequence = SaisieAdn("Veuillez saisir une séquence adn : ");

double pct = Proportion(chaine, sequence);
Console.WriteLine("le pct: " + pct);

Console.WriteLine("chaine : " + chaine);
Console.WriteLine("séquence : " + chaine);
Console.WriteLine($"Il y a {Math.Round(pct, 2)}% de \"{sequence}\" dans la chaine \"{chaine}\"");

