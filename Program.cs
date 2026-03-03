namespace DotNetArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Using for loop:");
            for (int i=0; i< numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Using foreach loop:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Array Length: " +numbers.Length);
             
            Console.WriteLine();
            Console.WriteLine("Using foreach loop with string array:");

            string[] technologies = { "C#", "Java", "Python", "JavaScript" };
            foreach (string techs in technologies)
            {
              Console.WriteLine(techs);
            }

            Console.WriteLine();
            Console.WriteLine("String Array Length: " + technologies.Length);
            Console.WriteLine();

            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You entered:");
            foreach (int num in numberArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            int[] arraySum = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int nums in arraySum)
            {
                sum += nums;
            }

            Console.WriteLine("Sum: " + sum);

            int[] arrayAverage = { 10, 20, 30, 40, 50 };
            int sumArray = 0;

            foreach (int num in arrayAverage)
            {
                sumArray += num;
            }

            double average = (double)sumArray / arrayAverage.Length;

            Console.WriteLine("Average: " + average);

            int[] arrayMax = { 10, 25, 5, 40, 15 };

            int max = arrayMax[0];

            foreach (int num in arrayMax)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine("Maximum Number: " + max);

            int[] arrayMin = { 10, 25, 5, 40, 15 };

            int min = arrayMin[0];

            foreach (int num in arrayMin)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine("Minimum Number: " + min);
        }
    }
    
}