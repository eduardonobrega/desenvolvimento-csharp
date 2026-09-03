namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        
        Console.Write("Email: ");
        String email = Console.ReadLine();
        
        Console.WriteLine($"Nome: {nome} | Idade: {idade} anos | Telefone: {telefone} | Email: {email}");
    }
}
