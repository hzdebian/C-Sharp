namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--- LOGIN ---");

        //Solicitar o nome de usuário
        Console.WriteLine("Digite seu nome:");
        string name = Console.ReadLine();
        Console.WriteLine($"Olá, {name}!");

        //Solicitar Idade do usuário
        Console.WriteLine("Digite sua idade:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------");

        Console.WriteLine("Seu nome é: " + name);
        Console.WriteLine("Sua idade é: " + age);
        
    }
}