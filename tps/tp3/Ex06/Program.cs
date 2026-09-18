namespace Ex06;

class Program
{
    static void Main(string[] args)
    {
        // usar o construtor facilita a criação do objetos porque torna obrigatório que seja informado os atributos logo ao instanciar, garantindo que o objeto seja criado da forma planejada.
        // evita a criação de objetos incompletos no sistema (ingresso sem nome)
        // e reduz a quantidade de codigo ao instanciar
        
        Ingresso ingresso = new Ingresso("Show da xuxa", 2500.0, 50);
        
        ingresso.ExibirInformacoes();
    }
}