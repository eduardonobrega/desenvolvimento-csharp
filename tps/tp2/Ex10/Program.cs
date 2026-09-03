namespace Ex10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero; i > 0; i--)
        {
            Console.Write(i + ", ");
        }
        Console.Write("0");
    }
}