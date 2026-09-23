namespace Ex02;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();
        
        char[] novoNome = new char[nome.Length];
        
        for (int i = 0; i < nome.Length; i++)
        {
            novoNome[i] = deslocaLetra(nome[i], 2);
        }

        Console.WriteLine(novoNome);
        
    }

    static char deslocaLetra(char c, int posicoes)
    {
        // Maiúsculas
        if (c >= 'A' && c <= 'Z')
        {
            return (char)(((c - 'A' + posicoes) % 26) + 'A');
        }
    
        // Minúsculas
        if (c >= 'a' && c <= 'z')
        {
            return (char)(((c - 'a' + posicoes) % 26) + 'a');
        }
    
        return c;
    }
}