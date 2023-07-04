// See https://aka.ms/new-console-template for more information
/*
Console.Write("Veuilez saisir un 1er nombre : ");
float numb1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Veuillez saisir un 2ème nombre : ");
float numb2 = Convert.ToSingle(Console.ReadLine());
float resultat = numb1 + numb2;
Console.WriteLine($"La somme de ces 2 nombres est : {resultat}");
*/

// avec TryParse :
Console.Write("Veuilez saisir un 1er nombre : ");
float numb1;
float.TryParse(Console.ReadLine(), out numb1);
Console.Write("Veuillez saisir un 2ème nombre : ");
float numb2;
float.TryParse(Console.ReadLine(), out numb2);
float resultat = numb1 + numb2;
Console.WriteLine($"La somme de ces 2 nombres est : {resultat}");