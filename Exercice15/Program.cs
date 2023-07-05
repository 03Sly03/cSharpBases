// See https://aka.ms/new-console-template for more information

Console.Write("--- Quelle sera le montant de l'indemnité de licenciement ? ---\n\nMerci de saisir le dernier salaire (en Euros) : ");
float salaire = float.Parse(Console.ReadLine());
Console.Write("Merci de saisir votre âge : ");
int age = int.Parse(Console.ReadLine());
Console.Write("Merci de saisir le nombre d'années d'ancienneté : ");
int nbAns = int.Parse(Console.ReadLine());

float indemnite = 0;
if (nbAns >= 1 && nbAns <= 10)
    indemnite = salaire / 2 * nbAns;
else if (nbAns > 10)
    indemnite = (salaire / 2 * 10) + salaire * (nbAns - 10);

if (age > 45 && age < 50)
    indemnite += salaire * 2;
else if (age >= 50)
    indemnite += salaire * 5;

Console.WriteLine($"Votre indemnité est de : {indemnite}");
