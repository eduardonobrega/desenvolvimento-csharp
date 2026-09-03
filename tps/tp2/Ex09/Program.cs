namespace Ex09;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o seu salário bruto: R$ ");
        double salarioBruto = double.Parse(Console.ReadLine());

        double desconto;
        double salarioLiquido;

        if (salarioBruto <= 2000)
        {
            desconto = 0;
        }
        else if (salarioBruto <= 3000)
        {
            desconto = salarioBruto * 0.08;
        }
        else if (salarioBruto <= 5000)
        {
            desconto = salarioBruto * 0.15;
        }
        else
        {
            desconto = salarioBruto * 0.22;
        }

        salarioLiquido = salarioBruto - desconto;

        Console.WriteLine();
        Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
        Console.WriteLine($"Descontos: R$ {desconto:F2}");
        Console.WriteLine($"Salário líquido: R$ {salarioLiquido:F2}");
    }
}