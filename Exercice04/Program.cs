// See https://aka.ms/new-console-template for more information

Console.Write("Veuilez saisir votre nom : ");
string name = Console.ReadLine();
Console.Write("Veuillez saisir votre prénom : ");
string firstname = Console.ReadLine();
Console.Write("Veuillez saisir votre âge : ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Bonjour {firstname} {name}, vous avez {age} ans");
