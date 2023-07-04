// See https://aka.ms/new-console-template for more information

Console.Write("--- Calcul du périmètre et de l'aire d'un carré ---\nEntrez la longueur d'un coté du carré (en cm) : ");
float longueur = float.Parse(Console.ReadLine());
float perimetre = longueur * 4;
float aire = longueur * longueur;
Console.WriteLine($"le périmètre du carré est : {perimetre} cm\nL'aire du carré est : {aire} cm2");

Console.Write("--- Calcul du périmètre et de l'aire d'un rectangle ---\nEntrez la longueur du rectangle (en cm) : ");
float longueurRec = float.Parse(Console.ReadLine());
Console.Write("Entrez la largeur du rectangle (en cm) : ");
float largeurRec = float.Parse(Console.ReadLine());
float perimetreRec = (longueurRec + largeurRec) * 2;
float aireRec = longueurRec * largeurRec;
Console.WriteLine($"le périmètre du rectangle est : {perimetreRec} cm\nL'aire du rectangle est : {aireRec} cm2");