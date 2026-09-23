
namespace Ex10;

class Program
{
    static void Main(string[] args)
    {
        Random gerador = new Random();
        int numeroSorteado = gerador.Next(1, 51);
            
        for (int tentativa = 1; tentativa <= 5; tentativa++)
        {
            try
            {
                Console.Write($"Tentativa {tentativa} de 5: ");
                int chute = int.Parse(Console.ReadLine());
                
                if (chute < 1 || chute > 50)
                {
                    Console.WriteLine("Erro: O número deve estar entre 1 e 50!");
                    tentativa--; // para ele não perder a tentativa
                }
                else
                {
                    if (chute == numeroSorteado)
                    {
                        Console.WriteLine("Parábens você acertou!");
                        Console.WriteLine($"O número sorteado foi: {numeroSorteado}!");
                        return;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você deve digitar apenas números inteiros!");
                tentativa--; // para ele não perder a tentaiva
            }
        }

        Console.WriteLine("Infelizmente não foi dessa vez!");
        Console.WriteLine($"O número sorteado foi: {numeroSorteado}!");
    }
}