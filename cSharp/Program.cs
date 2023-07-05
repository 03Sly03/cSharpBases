﻿// ( A découper dans des fichiers séparés )

// LES VARIABLES

/*
Les identificateurs:
Premier caractère: lettre ou le underscore
Distinction entre minuscule et majuscule (Case Sensitive)
Les caractères accentués sont acceptés (mais pas recommandés)
Un mot réservé du C# peut être utilisé comme identificateur de variable à condition qu'il soit précédé de @
Exemples:
*/

int NbLignes = 15;
string NBEcoles = "M2i Formation";
int @int = 45;
string maVariable = "aha!";
Console.WriteLine(NbLignes + " ", NBEcoles, @int, maVariable);

/*
Les insturctions:
Se terminent obligatoirement par un point virgule ;
Les insturctions délimité par des accolades {} constitue un bloc
- Les blocs définissent les zones de validité des varaibles (portée des variables)
- On les retrouve dans l'utilisation des structures de contrôles, fonctions méthodes, classes, ...

Les mots réservés:
=> Voir support m2i IntroductionCSharp page 14
&
=> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/
*/

/*
Affichage en mode console:
=> https://learn.microsoft.com/fr-fr/dotnet/api/system.console.writeline?view=net-6.0
*/
Console.Write("Hello World!"); // pas de retour à la ligne
Console.WriteLine("Bonjour Monde!"); // avec retour à la ligne
Console.Write("Hello World!\n"); // Ici le retour à la ligne se fait grâce à \n

/*
Saisie en mode console:
=> https://learn.microsoft.com/fr-fr/dotnet/api/system.console.readline?view=net-6.0
le ReadKey pour attendre que l'utilisateur appuie sur une touche de son clavier.
*/
Console.ReadLine(); // lit une chaîne de caractères à partir du flux standard d'entrée. La valeur retournée est null si aucune donnée n'a été saisie sinon elle ne retourne que des chaînes de caractère.
Console.ReadKey();

/*
Les caractères spéciaux dans les chaînes de caractères (string):
On utilise le backslash \ pour échapper un caractère spècial.
=> Voir support m2i IntroductionCSharp page 19 (pour d'autres séquences d'échappement dans les chaînes)
*/

Console.WriteLine(@"c:\repertoire\fichier.cs");

/*
Les catégories de variables:
=> Voir support m2i IntroductionCSharp page 21
*/

/*
Comparaison de valeurs et comparaison de références:
=> Voir support m2i IntroductionCSharp page 22
*/

/*
Les différents types de variables:
=> Voir support m2i IntroductionCSharp page 23 à 25;
var s'utilise à la place du type d'une variable, in ne rend pas cette variable dynamique mais la type implicitement, ainsi son type dépendra de l'instruction d'affectation.
*/
var chaine = 't' + "Blablabla ";
float entier = 120.000F;
Console.WriteLine(chaine + entier);

/*
Les plages d'utilisation des principales variables numérique:
=> Voir support m2i IntroductionCSharp page 26
le type décimal est utilisé pour les opérations financières
- il permet une très grande précision
- Les opérations avec ce type plus lentes que les types double ou float.
*/

/*
La déclaration d'une variable:
Les variables sont déclarées par leur typ suivi de leur nom.
Toute variable doit être déclarée dans un bloc. Elle cesse d'exister en dehors de ce bloc (pas de variable globale)
En l'absence d'une initialisation explicite les vriables sont implicitements initialisées par le compilateur à la valeur par défaut.
numérique à 0, char à '\0', chaîne à "" et objet à null.
pas de défaut pour var puisque c'est pas un type.
*/

int age;
age = 18;

int myAge = 20; // déclarées et affectées en même temps

/*
Les constantes symbolique:
Valeur constante désignée par un symbole dans le code source, qui est remplacé par sa valeur lors de la pré-compilation.
La déclaration des constantes se fait avec le mot-clé "const"
Une constante doit être obligatoirement initialisée.
// const <type> <nom constante> = <valeur>;
Voir => https://learn.microsoft.com/fr-fr/dotnet/csharp/language-reference/keywords/const
*/
const double Pi = 3.14159;

Console.WriteLine(age + " " + myAge + Pi);

/*
 Les opérateurs:
arithmétiques
d'affectation
=> Voir support m2i IntroductionCSharp page 31
 */

double testEntier = 5;
testEntier /= 2;
Console.WriteLine(testEntier);

/*
 Les chaînes de caractère (string):
sont de type "référence".
Lors d'une déclaration d'une string, on déclare une référence à une sorte de tableau de caractères (char). On peut donc interroger ce tableau à un numéro de cellule.
 */

string firstname = "Edwardo";
Console.WriteLine(firstname[2]);

/*
 * Le 04/07/2023
 Le cast de type:
convertir le type d'une variable en un autre type. 2 possibilités:
*/

/*
- soit les types sont compatibles (short en int)
casting implicite (le compilateur le fait pour nous)
*/
short @short = 200;
int @int1 = @short;
Console.WriteLine(@int1); // Affichera 200
// Ici rentrer un petit chiffre dans un grand se fait sons efforts, par contre la réciproque n'est pas vraie. Pour caster untype plus grand dans un plus petit il faudra enmployer un casting explicite
int @int2 = 200;
short @short2 = (short) @int2;
Console.WriteLine(@short2); // Affichera 200. Un casting explicite indique au compilateur que vous savez parfaitement ce que vous faites.

/*
Debuger:

 */

/*
- soit les types sont incompatibles (string en int)
Grâce à la classe Convert
 */

string chaineAge = "20";
int age2 = Convert.ToInt32(chaineAge);
int age3 = int.Parse(chaineAge);
Console.WriteLine($"chaineAge convertie en int :  {age2} et {age3}");

// D'autres méthodes de conversion => https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

// SWITCH CASE

string civilite = "M.";
switch (civilite)
{
    case "M.":
        Console.WriteLine("Bonjour monsieur");
        break;
    case "Mme":
        Console.WriteLine("Bonjour madame");
        break;
    case "Mlle":
        Console.WriteLine("Bonjour mademoiselle");
        break;
}


// un cas particulié :
int anInt = 90;
switch (anInt)
{
    case < 3 or > 120:
        Console.WriteLine("C'est pas entre 3 et 120");
        break;
    case < 18 :
        Console.WriteLine("Bonjour madame");
        break;
}