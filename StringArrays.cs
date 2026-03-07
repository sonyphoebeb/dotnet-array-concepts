using System;

namespace DotNetArrays
{
    public class StringArrays
    {
            public void DisplayTechnologies(params string[] technologies)
            { 
                Console.WriteLine("Displaying string array using foreach loop");
                foreach (string technology in technologies)
                {
                    Console.WriteLine(technology);
                }
            }
    }
}
    
