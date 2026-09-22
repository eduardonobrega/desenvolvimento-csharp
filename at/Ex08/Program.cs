namespace Ex08;

class Program
{
    static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario("Juan", "Desenvolvedor Junior", 3000);
        Gerente g1 = new Gerente("Eduardo", 5000);

        Console.WriteLine($"Salario do funcionário: R$ {f1.CalcularSalario():F2}");
        Console.WriteLine($"Salario do Gerente: R$ {g1.CalcularSalario():F2}");
                
    }
}