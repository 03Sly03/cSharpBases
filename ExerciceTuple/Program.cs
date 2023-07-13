// See https://aka.ms/new-console-template for more information

(float, float, float, float) Operation(float x, float y)
{
    float add = x + y;
    float sub = x - y;
    float mul = x - y;
    float div = x / y;

    (float, float, float, float) tuple = (add, sub, mul, div);

    return tuple;
}

Console.WriteLine(Operation(10, 2));

// Ou plus simplement 

(float, float, float, float) OperationSimple(float x, float y)
{
    float add = x + y;
    float sub = x - y;
    float mul = x - y;
    float div = x / y;

    return (x + y, x - y, x - y, x / y);
}

Console.WriteLine(OperationSimple(20, 4));