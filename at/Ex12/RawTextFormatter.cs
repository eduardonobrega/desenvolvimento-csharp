namespace Ex12;

public class RawTextFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        foreach (Contato c in contatos)
        {
            Console.WriteLine($"Nome: {c.Nome} | Telefone: {c.Telefone} | Email: {c.Email}");
        }
    }
}