using System;

namespace FirstApp
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

            double result = CalculateAverageFromList(userEntriesList);
            Console.WriteLine("Average = " + result);

        }


        static double CalculateAverageFromList(List<double> userEntriesList)
        {

            if (userEntriesList.Count == 0) { throw new ArgumentException("No Entries Detected!"); }

            double entriesSum = 0;
            foreach (double numberFromList in userEntriesList)
            {
                entriesSum += numberFromList;
            }

            double average = entriesSum / userEntriesList.Count;

            return average;

        }

    }
    
}

