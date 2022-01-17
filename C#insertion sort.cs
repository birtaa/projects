using System;

namespace csarp_kokletturmece
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] array = new int[5] { 13, 6, 50, 4, 31 };


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    int a = i;

                    while (array[a] < array[a - 1])
                    {
                        temp = array[a];
                        array[a] = array[a - 1];
                        array[a - 1] = temp;
                        a--;
                        if (a == 0)
                        {
                            break;
                        }

                    }
                }

            }

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

        }
    }
}
