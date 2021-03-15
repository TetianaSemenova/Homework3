using System;

namespace ArrayOfNaturalNumbers
{

    class Program
    {
        static int ArrayOfNaturalNumbers()
        {
            int firstelement = 0;
            int lastelement = 0;
            int n = 0;

            do
            {

                Console.WriteLine("Введите начало диапазона натуральных чисел: ");
                firstelement = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите конец диапазона натуральных чисел: ");
                lastelement = Convert.ToInt32(Console.ReadLine());

                n = lastelement - firstelement + 1;
                if (n <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Диапазон должен вмещать больше 10 значений");
                    Console.ResetColor();
                }
            }

            while (n <= 10);

            int[] nums = new int[n];
            nums[0] = firstelement;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                nums[i] = firstelement + i;
            }

            for (int i = 0; i < n; i++)
            {

                Console.Write(nums[i]);
                Console.Write(" ");
            }

            for (int i = 0; i < n; i++)
            {
                if ((nums[i] % 3 == 0) && (nums[i] % 5 != 0))


                {
                    sum += nums[i];
                }

            }

            Console.WriteLine();
            Console.WriteLine(sum);





            return 0;

        }
        static void Main(string[] args)
        {
            ArrayOfNaturalNumbers();
        }
    }
}