// See https://aka.ms/new-console-template for more information

Console.Write("--- Quelle est la nature du triangle ABC ? ---\n\nEntrez la longueur du segment AB : ");
float ab = float.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du segment BC : ");
float bc = float.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du segment CA : ");
float ac = float.Parse(Console.ReadLine());

if (ab == bc && ab == ac)
    Console.WriteLine($"\nLe triangle est équilatéral.");
else if (ab == ac)
    Console.WriteLine($"\nLe triangle est isocèle en A.");
else if (ab == bc)
    Console.WriteLine($"\nLe triangle est isocèle en B.");
else if (ac == bc)
    Console.WriteLine($"\nLe triangle est isocèle en C.");
else
    Console.WriteLine($"\nLe triangle n'est isocèle ni en A, ni en B, ni en C.");
