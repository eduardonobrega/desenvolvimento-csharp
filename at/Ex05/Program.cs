using System.Globalization;

namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        DateTime dataAtual;
        DateTime dataFormatura = new DateTime(2028, 6, 15);

        Console.Write("Digite a data atual (dd/mm/aaaa): ");
        
        // Caso o idioma padrão seja inglês
        CultureInfo culturaBR = new CultureInfo("pt-BR");

        while (!DateTime.TryParse(Console.ReadLine(), culturaBR, DateTimeStyles.None, out dataAtual))
        {
            Console.WriteLine("Data inválida. Tente novamente no formato dia/mês/ano:");
        }

        if (dataAtual > DateTime.Today) 
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return; 
        }

        if (dataAtual < DateTime.Today)
        {
            Console.WriteLine("Erro: A data informada não pode ser no passado!");
            return;
        }
        
        if (dataFormatura < dataAtual)
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
            return;
        }
        
        int anosFaltando = 0;
        int mesesFaltando = 0;
        int diasFaltando = 0;

        DateTime dataTemporaria = dataAtual;

        while (dataTemporaria.AddYears(1) <= dataFormatura)
        {
            anosFaltando++;
            dataTemporaria = dataTemporaria.AddYears(1);
        }

        while (dataTemporaria.AddMonths(1) <= dataFormatura)
        {
            mesesFaltando++;
            dataTemporaria = dataTemporaria.AddMonths(1);
        }

        diasFaltando = (dataFormatura - dataTemporaria).Days;

        if (diasFaltando == 0 && mesesFaltando < 6)
        {
            Console.WriteLine($"Faltam {mesesFaltando} meses e {diasFaltando} dias para sua formatura!");
        }
        else
        {
            Console.WriteLine($"Faltam {anosFaltando} anos, {mesesFaltando} meses e {diasFaltando} dias para sua formatura!");
        }
        
    }
}