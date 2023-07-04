// See https://aka.ms/new-console-template for more information

Console.Write("Entrez le prix HT de l'objet (En Euros) : ");
double prixHT = double.Parse(Console.ReadLine());
Console.Write("Entrez le taux de la TVA (en %) : ");
double tauxTVA = double.Parse(Console.ReadLine());
double montantTVA = prixHT * (tauxTVA / 100);
double prixTTC = montantTVA + prixHT;
Console.WriteLine($"le montant de la T.V.A est de {montantTVA} Euros\nLe prix TTC de l'objet est de {prixTTC} Euros");
