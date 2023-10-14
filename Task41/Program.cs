int N(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int [] Input(int length)
{
    int[] ar = new int[length];
    for (int i = 0; i< ar.Length; i++)
    {
        ar[i] = N($"Enter {i + 1}th element");
    }
    return ar;
}

void PrintAr(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.WriteLine($"[{i}] = {ar[i]}");
    }
}

int CountPosN(int[] ar)
{
    int count = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = N("Enter the amount of number you gonna use");
int[] ar;
ar = Input(length);
PrintAr(ar);
Console.WriteLine($"You have {CountPosN(ar)} positive numbers");