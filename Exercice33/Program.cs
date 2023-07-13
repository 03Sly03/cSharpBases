// See https://aka.ms/new-console-template for more information

char[] alphabet = new char[26];
for (int i = 'A'; i <= 'Z'; i++)
{
    alphabet[i - 65] = (char)i;
}

int numbOfSpaces = 0;
for (int i = 0; i < alphabet.Length; i++)
{
    string spaces = string.Concat(Enumerable.Repeat(" ", i + numbOfSpaces));
    Console.WriteLine($"{spaces + alphabet[i]}");
    numbOfSpaces++;
}
