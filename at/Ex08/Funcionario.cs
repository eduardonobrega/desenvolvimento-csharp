namespace Ex08;

public class Funcionario
{
    public string Nome  { get;  set; }
    public string Cargo  { get;  set; }
    public decimal SalarioBase  { get;  set; }

    public Funcionario(string nome, string cargo, decimal salarioBase)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioBase = salarioBase;
    }
    
    public virtual decimal CalcularSalario() { return SalarioBase; }
}