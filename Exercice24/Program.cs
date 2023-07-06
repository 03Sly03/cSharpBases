// See https://aka.ms/new-console-template for more information

Console.Write("--- Les suites chaînées de nombres ---\n\nMerci de saisir un nombre : ");
int userInput = int.Parse(Console.ReadLine());

int result = 0;
string stringResult = $"{userInput} = ";
Console.WriteLine("\nLes chaînes possible sont : ");
for (int i = 1; i <= userInput; i++)
{
    stringResult = $"{userInput} = ";
    result = 0;
    for (int j = i; j <= userInput; j++)
    {
        result += j;
        if (result == userInput && j != userInput)
        {
            stringResult += j;
            break;
        }
        else if (result > userInput)
        {
            stringResult = $"{userInput} = ";
            break;
        }
        else if (j == userInput)
        {
            break;
        }
        else
        {
            stringResult += j + "+";
        }
    }
    Console.Write(stringResult != $"{userInput} = " ? $"{stringResult}\n" : null);
}
