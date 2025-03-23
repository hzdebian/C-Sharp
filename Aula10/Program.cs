namespace Aula10
{
    public class Program
    {
        public static void Main()
        {
            bool continuar = true;
            
            while (continuar != false)
            {
                Console.WriteLine("------ Calculadora ------");

                Console.WriteLine("Digite o primeiro número: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                
                //Operadores
                int sum = number1 + number2;
                int sub = number1 - number2;
                int mult = number1 * number2;
                int div = number1 / number2;

                Console.WriteLine("Escolha uma opção: \n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");
                int choice = Convert.ToInt32(Console.ReadLine());

                    if(choice == 1)
                {
                    Console.WriteLine($"A soma de {number1} e {number2} é {sum}");
                    
                }
                else if(choice == 2)
                {
                    Console.WriteLine($"A subtração de {number1} e {number2} é {sub}");
                        
                }
                else if(choice == 3)
                {
                    Console.WriteLine($"A multiplicação de {number1} e {number2} é {mult}");
                    
                }
                else if(choice == 4)
                {
                    Console.WriteLine($"A divisão de {number1} e {number2} é {div}");
                }
                
                    
                else
                {
                    Console.WriteLine("Opção inválida");

                }
                Console.WriteLine("Deseja continuar? (S/N)");
                    string escolha = Console.ReadLine();
                    if(escolha == "N" || escolha == "n")
                    {
                        continuar = false;

                    }
            }
            Console.WriteLine("Obrigado por usar a calculadora!");
            
        }
    }
}