namespace Ex08;

public class Matricula
{
    public string NomeDoAluno { get; set; }
    public string Curso { get; set; }
    public int NumeroMatricula { get; private set; }
    public string Situacao { get; private set; }  // Ativa", "Trancada", "Concluída"
    public string DataInicial { get; private set; } // data em que a matrícula foi iniciada


    public Matricula(string nomeDoAluno, string curso, int numeroMatricula)
    {
        
        if (string.IsNullOrWhiteSpace(nomeDoAluno))
            throw new ArgumentException("O nome do aluno não pode ser vazio.");

        if (string.IsNullOrWhiteSpace(curso))
            throw new ArgumentException("O curso não pode ser vazio.");

        if (numeroMatricula < 1)
        {
            throw new ArgumentException("Número da matricula inválido.");
        }
        
        NomeDoAluno = nomeDoAluno;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        
        Situacao = "Ativa";
        DataInicial = DateTime.Now.ToString("dd/MM/yyyy");
    }
    
    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {NomeDoAluno} | Curso: {Curso} | Numero Matricula: {NumeroMatricula} | Situacao: {Situacao} | Data Inicial: {DataInicial}");
    }
}