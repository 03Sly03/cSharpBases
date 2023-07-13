// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using System.Threading.Channels;

string chain1 = "";
string sequence = "";
string userInput;

bool IsAdnChain(string chain)
{
    foreach (var item in chain)
    {
        if (!"atcg".Contains(item))
            return false;
    }
    return true; 
}
bool IsSequence(string chain, string sequence)
{
    Console.WriteLine($"le chain : {chain} et la séquence : {sequence}");
    int test = Regex.Matches(chain, sequence).Count;
    Console.WriteLine("le test : " + test);
    if (test == 0)
        return false;
    return true;
}
void DisplayResult(string chain, string sequence)
{
    double proportion = Math.Round((NbOccurence(chain, sequence) * sequence.Length / chain.Length) * 100, 2);
    Console.WriteLine($"chaine : {chain}\nséquence : {sequence}\nIl y a {proportion}% de \"{sequence}\" dans la chaine \"{chain}\"");
}

double NbOccurence(string chain1, string sequence)
{
    return Regex.Matches(chain1, sequence).Count;
}


Console.Write("Veuillez saisir une chaine adn : ");
userInput = Console.ReadLine()!.ToLower();
if (IsAdnChain(userInput))
    chain1 = userInput;


while (!IsAdnChain(userInput))
{
    Console.WriteLine("Erreur de saisie !!!");
    Console.Write("Veuillez saisir une chaine adn : ");
    userInput = Console.ReadLine()!.ToLower();
    if (IsAdnChain(userInput))
        chain1 = userInput;
}

Console.Write("Veuillez saisir une séquence adn : ");
userInput = Console.ReadLine()!.ToLower();
if (IsSequence(chain1, userInput))
    sequence = userInput;

Console.WriteLine("le chain1 après: " + chain1);
while (!IsSequence(chain1, userInput))
{
    Console.WriteLine("Erreur de saisie !!!");
    Console.Write("Veuillez saisir une séquence adn : ");
    userInput = Console.ReadLine()!.ToLower();
    if (IsSequence(chain1, userInput))
        sequence = userInput;
}

DisplayResult(chain1, sequence);