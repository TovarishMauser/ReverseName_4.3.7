using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name;

            name = Console.ReadLine();

            int j = name.Length;
            int i = 0;

            char[] result = new char[name.Length + 1];


            while ((j > 0) & (i < name.Length + 1))
            {

                result[j] = name[i];
                i++;
                j--;
            }

            for (int k = 0; k < name.Length + 1; k++)
            {
                Console.Write(result[k]);
            }
            
        }
    }
}
