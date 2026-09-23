namespace Ex12;

public class ContatoFormatter
{
    public virtual void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("Formatador base não possui uma exibição definida.");
    }
}