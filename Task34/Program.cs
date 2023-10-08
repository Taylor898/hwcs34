
int[] numbers = Generatenumbers(4);

Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}, ");
}
Console.Write("] -> ");

int[] Generatenumbers(int arlength)
{
    Random rnd = new Random();
    int[] numbers = new int[arlength];

    for (int i = 0; i < arlength; i++)
    {
        numbers[i] = rnd.Next(100, 1000);
    }

    return numbers;
}

int CountEvenNumbers(int[] numbers)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int evenCount = CountEvenNumbers(numbers);
Console.WriteLine(evenCount);