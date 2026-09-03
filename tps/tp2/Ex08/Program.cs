namespace Ex08;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma nota de 0 a 10: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida.");
        }
        else if (nota < 6)
        {
            Console.WriteLine("Classificação: Insuficiente");
        }
        else if (nota < 7)
        {
            Console.WriteLine("Classificação: Regular");
        }
        else if (nota < 9)
        {
            Console.WriteLine("Classificação: Bom");
        }
        else
        {
            Console.WriteLine("Classificação: Excelente");
        }
    }
}