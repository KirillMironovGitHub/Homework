

static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNaturalNumbers(m + 1, n);
        }
    }

    PrintNaturalNumbers(4, 8);
