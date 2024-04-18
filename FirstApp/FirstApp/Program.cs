using System;

namespace SomeCalculator
{

    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Average Calculator");

            List<double> userEntriesList = new List<double>();
            
            for (int i = 1; i < 4; i++) {
                
                Console.Write($"Digit a Number ({i}): ");
                double userEntries = Convert.ToDouble(Console.ReadLine());
                userEntriesList.Add(userEntries);
            }
            
            
            
        }

    }
    
}

