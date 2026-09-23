using System.Globalization;

namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        DateTime hoje = DateTime.Today;
        DateTime dataNascimento;

        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        
        // Caso o idioma padrão seja inglês
        CultureInfo culturaBR = new CultureInfo("pt-BR");

        while (!DateTime.TryParse(Console.ReadLine(), culturaBR, DateTimeStyles.None, out dataNascimento))
        {
            Console.WriteLine("Data inválida. Tente novamente no formato dia/mês/ano:");
        }
        
        int anosDeVida = hoje.Year - dataNascimento.Year;
        DateTime proximoNiver = dataNascimento.AddYears(anosDeVida);
        
        if (proximoNiver < hoje)
        {
            proximoNiver = proximoNiver.AddYears(1);
        }
        
        TimeSpan diferenca = proximoNiver - hoje;
        int diasFaltando = diferenca.Days;

        Console.WriteLine($"Faltam {diasFaltando} dias para o seu aniversário!");
        if (diasFaltando < 7)
        {
            Console.WriteLine("Está perto, já podemos comemorar! Feliz aniversário!");
        }
    }
}