namespace Ex07;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("É par");
        }
        else
        {
            Console.WriteLine("É impar");
        }
    }
}