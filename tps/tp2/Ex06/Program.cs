namespace Ex06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("peso: ");
        double peso  = double.Parse(Console.ReadLine());
        Console.Write("altura: ");
        double altura = double.Parse(Console.ReadLine());
        
        double imc = peso / (altura * altura);
        
        Console.WriteLine($"Seu IMC é: {imc:F2}");

        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Baixo peso");
        }
        else if (imc <= 24.9)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (imc <= 29.9)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else if (imc <= 34.9)
        {
            Console.WriteLine("Classificação: Obesidade grau I");
        }
        else if (imc <= 39.9)
        {
            Console.WriteLine("Classificação: Obesidade grau II");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade grau III");
        }
    }
}