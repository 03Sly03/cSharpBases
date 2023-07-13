// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enumération du tableau avec un foreach : ");
string[] months = new string[] {"Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"};

string tab = "";
foreach (var item in months)
{
    Console.WriteLine(tab + item);
    tab += "\t";
}

// OU
/*
int i = 0;
foreach (var item in months)
{
    string tab = string.Concat(Enumerable.Repeat("\t", i));
    Console.WriteLine(tab + item);
    i++;
}
*/