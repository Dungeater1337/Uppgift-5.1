using System; 

namespace uppgift5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Hur mår du?", "Godmorgon hur mår du?", "Jag har nyss tvättat bilen.", "Jag ska handla på ICA efter jobbet." };
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] +"\n");    
            }
        }
    }
}