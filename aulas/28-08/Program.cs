namespace _28_08;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria c1 = new ContaBancaria("Eduardo", 123);
        c1.Depositar(500);
        Console.WriteLine(c1.Saldo);
    }
}