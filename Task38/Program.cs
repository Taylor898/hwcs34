
double[] num = GenerateRandomNumbers(4);

Console.Write("[");
for (int i = 0; i < num.Length; i++)
{
    Console.Write($"{num[i]}, ");
}
Console.Write("] => ");

double[] GenerateRandomNumbers(int arraySize)
{
    Random rand = new Random();
    double[] rndNumbers = new double[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        rndNumbers[i] = rand.NextDouble() * 100;
    }

    return rndNumbers;
}

double FindDiff(double[] num)
{
    double min = num[0];
    double max = num[0];

    for (int i = 1; i < num.Length; i++)
    {
        double n = num[i];
        if (n < min)
        {
            min = n;
        }
        if (n > max)
        {
            max = n;
        }
    }
    double diff = max - min;

    return diff;
}

double diff = FindDiff(num);
Console.WriteLine("{0:F2}", diff);
