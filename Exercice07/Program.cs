// See https://aka.ms/new-console-template for more information

Console.Write("--- Calcul du périmètre et de l'hypothénuse ---\nEntrez la longueur du premier coté (en cm) : ");
float longueur = float.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du deuxième coté (en cm) : ");
float largeur = float.Parse(Console.ReadLine());
float hypothenuse = (float)Math.Sqrt(Math.Pow(longueur, 2) + Math.Pow(largeur, 2));
Console.WriteLine($"la longueur de l'hypothénuse est : {hypothenuse}");

