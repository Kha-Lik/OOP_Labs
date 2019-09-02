using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[15];
            double result;
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(-100, 100) * random.NextDouble();
            }

            result = Func(array);
            Console.WriteLine(result);

        }

        static public double Func(double[] array)
        {
            double posSum = 0;
            double negSum = 0;
            double result = 0;
            
            foreach (var x in array)
            {
                if (x < 0)
                    negSum += x;
                else
                    posSum += x;
            }
            
            try
            {
                result = Math.Log(posSum) + 20 / negSum;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}