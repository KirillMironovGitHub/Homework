

static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNaturalNumbers(m + 1, n);
        }
    }

    PrintNaturalNumbers(4, 8);



using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main()
    {
        int m = 3;
        int n = 2;
        int result = Ackermann(m, n);

        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }
}


void ReverseArray(int []array, int index)
{
   
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        ReverseArray(array, index -1);
    }
}

ReverseArray([1, 2, 5, 0, 10, 34], 5);