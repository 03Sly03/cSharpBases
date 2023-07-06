// See https://aka.ms/new-console-template for more information

Console.Write("--- Les suites chaînées de nombres ---\n\nMerci de saisir un nombre : ");
int userInput = int.Parse(Console.ReadLine());
int i = 1;
string answer = $"{userInput} = ";
Console.WriteLine("\nLes sommes consécutives sont : ");
while (i <= userInput / 2 + 1)
{
    int sum = 0;
    int j = i;
    while (j <= userInput / 2 + 1)
    {
        sum += j;
        if (sum == userInput)
        {
            Console.WriteLine(answer += j);
        }
        else if (sum > userInput)
        {
            answer = $"{userInput} = ";
        }
        else
        {
            answer += $"{j} + ";
        }
        j++;
    }
    i++;
}
