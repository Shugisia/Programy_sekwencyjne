using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wartość n:");
        int n = int.Parse(Console.ReadLine());

        int policz = 0;
        int numer = 2;

        while (policz < n)
        {
            if (SprawdzCzyPierwsza(numer))
            {
                Console.WriteLine(numer);
                policz++;
            }
            numer++;
        }
    }

    static bool SprawdzCzyPierwsza(int numer)
    {
        if (numer < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(numer); i++)
        {
            if (numer % i == 0)
                return false;
        }

        return true;
    }
}