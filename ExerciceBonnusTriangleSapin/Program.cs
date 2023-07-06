// See https://aka.ms/new-console-template for more information

using System.Text;
using static System.Net.Mime.MediaTypeNames;

Console.Write("Saisir la hauteur du triangle : ");
int userInput = int.Parse(Console.ReadLine());
int nbStars = 1;
for (int i = 0; i < userInput; i++)
{
    /*    int test = userInput - i;
        string space = "";
        if (test >= 0)
        {
            space = new StringBuilder(" ".Length * test).Insert(0, " ", test).ToString();
        }
        string star = new StringBuilder("*".Length * i).Insert(0, "*", i).ToString();
        Console.WriteLine(space+star);*/

    string spaces = string.Concat(Enumerable.Repeat(" ", userInput - i));
    string stars = string.Concat(Enumerable.Repeat("*", nbStars));
    Console.WriteLine(spaces + stars);
    nbStars += 2;
}
