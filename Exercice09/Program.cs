// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- Calcul des intérêts ---\n");
Console.Write("Entrez le capital de départ (En Euros) : ");
double capital = double.Parse(Console.ReadLine());

Console.Write("Entrez le taux d'intérêt (en %) : ");
double taux = double.Parse(Console.ReadLine());

Console.Write("Entrez la durée de l'épargne (en années) : ");
int annees = int.Parse(Console.ReadLine());

double capitalFinal = capital * Math.Pow(1 + (taux / 100), annees);
/*// Avec la boucle while
double capitalFinal = capital + capital * (taux / 100);
int i = 0;
while (i < annees - 1)
{
    capitalFinal = capitalFinal + capitalFinal * (taux / 100);
    i++;
};
*/
double montantInterets = capitalFinal - capital;
Console.WriteLine($"\nle montant des intérêts sera de {Math.Round(montantInterets, 2)} Euros après {annees} ans\nLe capital final sera de {Math.Round(capitalFinal, 2)} Euros");
