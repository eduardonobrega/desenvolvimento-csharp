namespace Ex11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} X {i} = {i * numero}");
        }
    }
}