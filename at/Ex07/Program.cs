namespace Ex07;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria c1 =  new ContaBancaria("Eduardo");
        Console.WriteLine("Titular:  " + c1.Titular);
        c1.Depositar(500);
        c1.ExibirSaldo();
        c1.Sacar(700);
        c1.Sacar(200);
        c1.ExibirSaldo();

    }
}