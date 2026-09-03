namespace Ex12;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int numeroSecreto = random.Next(1, 101);
        int palpite = 0;

        while (palpite != numeroSecreto)
        {
            Console.Write("Digite um número de 1 a 100: ");
            palpite = int.Parse(Console.ReadLine());

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é MAIOR.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é MENOR.");
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou!");
            }
        }
    }
}