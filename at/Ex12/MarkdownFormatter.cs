namespace Ex12;

public class MarkdownFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("## Lista de Contatos");
        
        foreach (Contato c in contatos)
        {
            Console.WriteLine($"- **Nome:** {c.Nome}");
            Console.WriteLine($"- Telefone: {c.Telefone}");
            Console.WriteLine($"- Email: {c.Email}");
        }
    }
}