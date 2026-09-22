namespace Ex06;

public class Aluno
{
    private string Nome;
    private string Matricula;
    private string Curso;
    private double Media;

    public Aluno(string nome, string matricula, string curso, double media)
    {
        Nome = nome;
        Matricula = matricula;
        Curso = curso;
        Media = media;
    }

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Matricula: " + Matricula);
        Console.WriteLine("Curso: " + Curso);
        Console.WriteLine("Media: " + Media);
    }

    public string VerificarAprovacao()
    {
        return Media >= 7 ? "Aprovado" : "Reprovado";
    }
}