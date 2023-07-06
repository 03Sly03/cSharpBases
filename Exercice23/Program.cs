// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- Accroissement de population ---");

double population = 96809;
double tauxP = 0.89 / 100;
double obj = 120000;
int annees = 0;
/*while (population < obj)
{
    population += population * tauxP;
    annees++;
}*/

for (population = 96809; population < 120000; population += population * tauxP)
{
    annees++;
}

int anneesAtteint = 2015 + annees;
Console.WriteLine($"Il faudra {annees} ans, nous serons en {anneesAtteint}\n Il y aura {Math.Round(population, 0)} habitants en {anneesAtteint}");
