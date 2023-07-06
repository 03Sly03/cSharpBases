// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- Accroissement de population ---");

double objPopulation = 120000;
double population = 96809;
double tauxP = 0.89 / 100;
int annees = 0;

while (population < objPopulation)
{
    population = Math.Round(population + (population * tauxP));
    annees++;
}

int objAtteint = 2015 + annees;
Console.WriteLine($"\nIl faudra {annees} ans, nous serons en {objAtteint}");
Console.WriteLine($"\nIl y aura {population} habitants en {objAtteint}");
