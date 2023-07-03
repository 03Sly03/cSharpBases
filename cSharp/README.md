# introduction au principes de base du langage C#

Ici vous pouvez ajouter ou modifier les infos et par la m�me occasion � push, pull, merge sur github (utiliser git).

## Le C-Sharp

Ce pr�sente comme la suite des langages C & C++, un peu comme Java.
C'est un langage orient� objet.
Permet l'�criture de programmes plus s�r et plus stable.

## Visual Studio

Logiciel de d�veloppement cr�� par Microsoft, principalement pour l'environnement .NET
T�l�charger la version gratuite community => https://visualstudio.microsoft.com/fr/downloads/
(Une alternative ? -> Rider: payante, d�velopp� par JetBrains)

## Point d'entr�e d'une application

Une application C# comporte obligatoirement une fonction Main, qui doit �tre obligatoirement membre d'une classe
Depuis le .NET 6, le fichier program.cs, point d'entr�e de l'application, a �t� simplifi�: nous y retrouvons d�sormais uniquement le corps de la m�thode Main.

## Appels � des m�thodes

Sp�cification du nom complet

```cs
System.Console.WriteLine("Bonjour");
```

Sp�cification du nom relatif avec import (using)

```cs
using System;
Console.WriteLine("Bonjour");
```

## Les variables
(voir Program.cs)