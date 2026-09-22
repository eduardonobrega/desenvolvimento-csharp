namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        int numero = lerInteiro("Insira um número: ");
        int outroNumero = lerInteiro("Insira outro número: ");

        Console.WriteLine("=== Escolha uma opção ===");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");
        Console.Write(": ");
        int op =  lerInteiro("");

        if (op < 1 || op > 4)
        {
            Console.WriteLine("Opção inválida");
        }
        else
        {
            double? resultado = op switch
            {
                1 => numero + outroNumero,
                2 => numero - outroNumero,
                3 => numero * outroNumero,
                4 => outroNumero != 0 ? (double) numero / outroNumero : null
            };

            if (resultado == null)
            {
                Console.WriteLine("Não é possivel dividir por 0!");
            }

            else
            {
                Console.WriteLine("Resultado: " + resultado);
            }
        }
    }
    
    // Função para ler e validar a entrada do usuário
    static int lerInteiro(string msg)
    {
        int numero;

        Console.Write(msg);
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Erro: Isso não é um número válido!");
            Console.Write("Tente novamente :");
        }

        return numero;
    }
}