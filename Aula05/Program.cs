namespace Aula05
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Calculadora");

            Console.WriteLine("Digite o primeiro número: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite a operação desejada: \r\n1 - Soma \r\n2 - Subtração \r\n3 - Multiplicação \r\n4 - Divisão");
            int sum = number1 + number2;
            int sub = number1 - number2;
            int mult = number1 * number2;
            int div = number1 / number2;

            Console.WriteLine("Resultado: " + sum);
            Console.WriteLine("Resultado: " + sub);
            Console.WriteLine("Resultado: " + mult);
            Console.WriteLine("Resultado: " + div);





        }
    }

}

