namespace V1;

class Program
{
    static void Main(string[] args)
    {
        
        Produto[] estoque = new Produto[5];
        int totalProdutos = 0;

        while (true)
        {
            Console.WriteLine("\n=== SISTEMA DE ESTOQUE ===");
            Console.WriteLine("1. Inserir Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    if (totalProdutos >= 5)
                    {
                        Console.WriteLine("Erro: Limite de produtos atingido!");
                        break;
                    }
                    estoque[totalProdutos] = criarProduto();
                    totalProdutos++;
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    break;
                    
                case "2":
                    if (totalProdutos == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                        break;
                    }
                    for (int i = 0; i < totalProdutos; i++)
                    {
                        Produto p = estoque[i];
                        
                        Console.WriteLine($"Produto: {p.Nome} | Quantidade: {p.Quantidade} | Preço: R$ {p.Preco:F2}");
                    }
                    break;
                    
                case "3":
                    Console.WriteLine("Encerrando o sistema...");
                    return;
                    
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }

    static Produto criarProduto()
    {
        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();
                    
        Console.Write("Quantidade em estoque: ");
        int qtd = int.Parse(Console.ReadLine());
                    
        Console.Write("Preço unitário: ");
        decimal preco = decimal.Parse(Console.ReadLine());
                    
        return new Produto(nome, qtd, preco);
    }

}