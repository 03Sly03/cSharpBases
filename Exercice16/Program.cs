// See https://aka.ms/new-console-template for more information

Console.Write("--- Quelle sera le montant de mes impots ? ---\n\nEntez le montant net imposable du foyer (en Euros) : ");
double netImpot = double.Parse(Console.ReadLine());
Console.Write("Entrez le nombre d'adultes au foyer : ");
int nbAdult = int.Parse(Console.ReadLine());
Console.Write("Entrez le nombre d'enfants au foyer : ");
int nbEnfant = int.Parse(Console.ReadLine());

double montant = 0;
/*
if (nbAns >= 1 && nbAns < 10)
    indemnite = salaire / 2 * nbAns;
else if (nbAns > 10)
    indemnite = salaire * nbAns;

if (age > 45 && age < 50)
    indemnite += salaire * 2;
else if (age >= 50)
    indemnite += salaire * 5;

Console.WriteLine($"\nVous allez payer : {montant}");
*/
