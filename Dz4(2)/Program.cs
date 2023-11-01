using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        if (int.TryParse(Console.ReadLine(), out int arraySize) && arraySize > 0)
        {
            int[] array = new int[arraySize];


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    array[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    i--;
                }
            }

            int min = array[0];
            int max = array[0];

            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }
                if (element > max)
                {
                    max = element;
                }
            }

            int difference = max - min;
            Console.WriteLine($"Разность максимума и минимума: {difference}");
        }
        else
        {
            Console.WriteLine("Некорректный размер массива. Введите положительное число.");
        }
    }
}