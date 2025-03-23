namespace Aula17;
public class Program{
    public static void Main(){
        string separator = "-------------------";
        // Declaração com inicialização de valores
        List<string> frutas = new List<string> {
            "Manga",
            "Uva",
            "Banana",
            "Laranja"
        };
        Console.WriteLine(separator);
    //2. Acessar os valores
    Console.WriteLine(frutas[2]); // Banana
    //3. Adicionar valores
    frutas.Add("Maçã");
    frutas.Add("Pera");
    Console.WriteLine(separator);
    foreach(string fruta in frutas)
    {
        Console.WriteLine(fruta);
    }
    Console.WriteLine(separator);

    //4. Remover valores
    frutas.Remove("Banana");
    foreach(string fruta in frutas)
    {
        Console.WriteLine(fruta);
    }
    Console.WriteLine(separator);
    //5. Remover valores por índice
    frutas.RemoveAt(1);
    foreach(string fruta in frutas)
    {
        Console.WriteLine(fruta);
    }
    Console.WriteLine(separator);
    //6. Contar elementos
    Console.WriteLine("Quantidade de frutas: " + frutas.Count); // 4
    //Limpar a lista
    frutas.Clear();
    foreach(string fruta in frutas)
    {
        Console.WriteLine(fruta);
    }
    
    }
    
    

}