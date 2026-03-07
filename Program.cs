namespace DotNetArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {10, 20, 30, 40, 50};

            // Displaying array numbers using foreach loop
            Console.WriteLine("Displaying array numbers using for loop");
            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            // Displaying array numbers using foreach loop
            Console.WriteLine("Displaying array numbers using foreach loop");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();


            // Demonstrating the use of StringArrays class
            StringArrays objStringArrays = new StringArrays();
            objStringArrays.DisplayTechnologies("HTML", "CSS", "JavaScript", "TypeScript", "Angular", "Node");

            Console.WriteLine();

            // Displaying all the even numbers between start and end number 
            EvenNumbers objEvenNumbers = new EvenNumbers();
            objEvenNumbers.DisplayEvenNumbers();
        }

        
    }
    
}