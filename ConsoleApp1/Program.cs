// See https://aka.ms/new-console-template for more information
{
    int a = 2, b = 3;
    Console.WriteLine($"Резултат: {Power(a, b)}");
}

static int Power(int a, int b)
{
    if (b == 0) return 1; 
    return a * Power(a, b - 1); 
}