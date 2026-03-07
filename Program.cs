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
            

            // Demonstrating the use of StringArrays class
            StringArrays obj = new StringArrays();
            obj.DisplayNames();
        }

        
    }
    
}