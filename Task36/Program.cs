int[] randnum = GenerateRandomNumbers(4);

Console.Write("[");
for (int i = 0; i < randnum.Length; i++)
{
    Console.Write($"{randnum[i]}, ");
}
Console.Write("] -> ");

int[] GenerateRandomNumbers(int arSize)
{
    Random rand = new Random();
    int[] randnum = new int[arSize];

    for (int i = 0; i < arSize; i++)
    {
        randnum[i] = rand.Next(-10, 10);
    }

    return randnum;
}
int SumOddPosEl(int[] numbers)
{
    int sum = 0;

    for (int i = 1; i < numbers.Length; i += 2) 
    {
        sum += numbers[i];
    }

    return sum;
}

int oddPosSum = SumOddPosEl(randnum);
Console.WriteLine(oddPosSum);