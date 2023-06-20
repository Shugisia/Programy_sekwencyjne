using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        RysujTrojkat(wysokosc);

        Console.ReadLine();
    }

    static void RysujTrojkat(int wysokosc)
    {
        int szerokosc = 2 * wysokosc - 1;
        int spacje = (szerokosc - 1) / 2;

        for (int i = 0; i < wysokosc; i++)
        {
            for (int j = 0; j < spacje; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("+");
            }

            Console.WriteLine();
            spacje--;
        }
    }
}