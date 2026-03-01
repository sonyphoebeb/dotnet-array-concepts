namespace DotNetArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            for(int i=0; i< numbers.Length-1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}