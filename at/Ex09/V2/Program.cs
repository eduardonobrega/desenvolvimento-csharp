namespace V2;

class Program
{
    static void Main(string[] args)
    {
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
                    Produto produto = criarProduto();
                        
                    using (StreamWriter sw = File.AppendText("estoque.txt"))
                    {
                        string precoFormatado = produto.Preco.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        
                        sw.WriteLine($"{produto.Nome},{produto.Quantidade},{precoFormatado}");
                    }

                    Console.WriteLine("Produto salvo no arquivo com sucesso!");
                    break;
                    
                case "2":
                    if (!File.Exists("estoque.txt"))
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                        break;
                    }
                    
                    try
                    {
                        using (StreamReader sr = new StreamReader("estoque.txt"))
                        {
                            string linha = sr.ReadLine();
                            
                            if (linha == null)
                            {
                                Console.WriteLine("Nenhum produto cadastrado.");
                            }
                            
                            while (linha != null)
                            {
                                
                                string[] dados = linha.Split(',');

                                string nomeArquivo = dados[0];
                                string qtdArquivo = dados[1];
                                
                                decimal precoArquivo = decimal.Parse(dados[2], System.Globalization.CultureInfo.InvariantCulture);

                                Console.WriteLine($"Produto: {nomeArquivo} | Quantidade: {qtdArquivo} | Preço: R$ {precoArquivo:F2}");
                                
                                linha = sr.ReadLine();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Erro ao ler o arquivo.");
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