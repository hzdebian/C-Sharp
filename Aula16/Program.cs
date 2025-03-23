using System.Globalization;

namespace Aula16
{
    public class Program
    {
        public static void Main()
        {
            //1. Declaração de Array
            string[] fruits = { "Apple", "Banana", "Orange", "Strawberry" };

            //2. Acessando elementos do Array
            string separator = "-------------------------------";
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            fruits[0] = "Abacaxi";
            Console.WriteLine(separator);
            Console.WriteLine(fruits[0]);

            // Declarar sem inicializar
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            


        }
    }

}