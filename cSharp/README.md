# introduction au principes de base du langage C#

Ici vous pouvez ajouter ou modifier les infos et par la même occasion à push, pull, merge sur github (utiliser git).

## Le C-Sharp

Ce présente comme la suite des langages C & C++, un peu comme Java.
C'est un langage orienté objet.
Permet l'écriture de programmes plus sûr et plus stable.

## Visual Studio

Logiciel de développement créé par Microsoft, principalement pour l'environnement .NET
Télécharger la version gratuite community => https://visualstudio.microsoft.com/fr/downloads/
(Une alternative ? -> Rider: payante, développé par JetBrains)

## Point d'entrée d'une application

Une application C# comporte obligatoirement une fonction Main, qui doit être obligatoirement membre d'une classe
Depuis le .NET 6, le fichier program.cs, point d'entrée de l'application, a été simplifié: nous y retrouvons désormais uniquement le corps de la méthode Main.

## Appels à des méthodes

Spécification du nom complet

```cs
System.Console.WriteLine("Bonjour");
```

Spécification du nom relatif avec import (using)

```cs
using System;
Console.WriteLine("Bonjour");
```

## Les variables
(voir Program.cs)