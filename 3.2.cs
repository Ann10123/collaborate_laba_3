using System;

class Program
{
    static void ZadaniaMasiva(int line, ref int[][] array)
    {
        Console.WriteLine();
        Console.WriteLine("Введіть елементи масиву: ");
        for (int i = 0; i < line; i++)
        {
            string[] data = Console.ReadLine().Trim().Split();
            array[i] = new int[data.Length];
            for (int j = 0; j < data.Length; j++)
            {
                array[i][j] = int.Parse(data[j]);
            }
        }
    }

    static int MaxElement(int line, int[][] array)
    {
        int max = int.MinValue;
        int maxline = 0;
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] >= max)
                {
                    max = array[i][j];
                    maxline = i;
                }
            }
        }
        return maxline;
    }

    static int[][] Vstavka(int line, ref int[][] array)
    {
        Console.WriteLine("Введіть елементи для вставки: ");
        int max = MaxElement(line, array);
        Array.Resize(ref array, line + 1);

        for (int i = line; i > max; i--)
        {
            array[i] = array[i - 1];
        }

        string[] data = Console.ReadLine().Trim().Split();

        array[max] = new int[data.Length];

        for (int j = 0; j < data.Length; j++)
        {
            array[max][j] = int.Parse(data[j]);
        }
        Console.WriteLine();
        return array;
    }

    static void PrintMasiv(int[][] array, int line)
    {
        ZadaniaMasiva(line, ref array);
        Console.WriteLine();
        Vstavka(line, ref array);
        Console.WriteLine("Отриманий масив: ");
        for (int i = 0; i < line + 1; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Задайте необхідну кількість рядків: ");
        int line = int.Parse(Console.ReadLine());
        int[][] array = new int[line][];

        PrintMasiv(array, line);
    }
}
