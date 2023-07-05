// See https://aka.ms/new-console-template for more information

Console.Write("--- Quelle taille dois-je prendre ? ---\n\nEntrez votre taille (en cm) : ");
float taille = float.Parse(Console.ReadLine());
Console.Write("Entrez votre poids (en kg) : ");
float poids = float.Parse(Console.ReadLine());

int votreTaille = 0;

if ((poids >= 43 && poids <= 47 && taille >= 145 && taille < 172) 
      || (poids >= 43 && poids <= 53 && taille >= 145 && taille < 169)
      || (poids >= 43 && poids <= 59 && taille >= 145 && taille < 166)
      || (poids >= 43 && poids <= 65 && taille >= 145 && taille < 163)
    )
    votreTaille = 1;
else if ((poids >= 48 && poids <= 53 && taille > 166 && taille < 183)
      || (poids >= 54 && poids <= 59 && taille > 163 && taille < 178)
      || (poids >= 60 && poids <= 65 && taille > 160 && taille < 175)
      || (poids >= 66 && poids <= 71 && taille > 157 && taille < 172)
    )
    votreTaille = 2;
else if ((poids >= 54 && poids <= 59 && taille > 175 && taille <= 183)
      || (poids >= 60 && poids <= 65 && taille > 172 && taille <= 183)
      || (poids >= 66 && poids <= 71 && taille > 169 && taille <= 183)
      || (poids >= 72 && poids <= 77 && taille > 160 && taille <= 183)
    )
    votreTaille = 3;
else
    Console.WriteLine($"\nAucune taille ne vous correspond");

Console.WriteLine(votreTaille != 0 ? $"\nPrennez la taille {votreTaille}" : "");
