namespace Ex08;

public class Gerente : Funcionario
{
    public Gerente(string nome, decimal salarioBase) : base(nome, "Gerente", salarioBase)
    {
    }
    
    public override decimal CalcularSalario() { return SalarioBase * 1.2m; }
}