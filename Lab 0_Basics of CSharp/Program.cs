using System;

namespace Lab_0_Basics_of_CSharp
{
    class Program {

        static void Main (string[] args)
        {

            double lowNumber = 0;
            double highNumber = 0;

            while (lowNumber <= 0)
            {
                Console.WriteLine("Enter a positive low number: ");
                lowNumber = Convert.ToDouble(Console.ReadLine());

                if (lowNumber <= 0)
                {
                    Console.WriteLine("Please enter a positive low number: ");
                }
            }

            while (highNumber <= lowNumber)
            {
                Console.WriteLine("Enter a number greater than the low number: ");
                highNumber = Convert.ToDouble(Console.ReadLine());

                if (highNumber <= lowNumber)
                {
                    Console.WriteLine("Please enter a high number greater than the low number.");
                }
            }

            double difference = lowNumber - highNumber;
            Console.WriteLine();
            Console.WriteLine($"The difference between low and high variables is {difference}");

            int arraySize = (int)(highNumber - lowNumber) + 1;
            double[] numbersArray = new double[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                numbersArray[i] = highNumber - i;
            }

            string filePath = "/Users/augustobarros/Desktop/numbers.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = arraySize - 1; i >= 0; i--)
                {
                    writer.WriteLine(numbersArray[i]);
                }
            }
        }
    }

}