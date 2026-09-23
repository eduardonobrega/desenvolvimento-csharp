namespace Ex12;

public class TabelaFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("| Nome | Telefone | Email |");
        Console.WriteLine("----------------------------------------");

        foreach (Contato c in contatos)
        {
            Console.WriteLine($"| {c.Nome} | {c.Telefone} | {c.Email} |");
        }

        Console.WriteLine("----------------------------------------");
    }
}