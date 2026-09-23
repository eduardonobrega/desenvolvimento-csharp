namespace Ex12;

class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "contatos.txt";

        while (true)
        {
            Console.WriteLine("\n=== Gerenciador de Contatos ===");
            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos cadastrados");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Contato contato = criarContato();
                    
                    using (StreamWriter sw = File.AppendText(caminhoArquivo))
                    {
                        sw.WriteLine($"{contato.Nome},{contato.Telefone},{contato.Email}");
                    }

                    Console.WriteLine("Contato cadastrado com sucesso!");
                    break;

                case "2":
                    
                    if (!File.Exists(caminhoArquivo))
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                        break;
                    }
                    
                    List<Contato> meusContatos = new List<Contato>();
                    
                    try
                    {
                        using (StreamReader sr = new StreamReader(caminhoArquivo))
                        {
                            string linha = sr.ReadLine();
                            
                            if (linha == null)
                            {
                                Console.WriteLine("Nenhum contato cadastrado.");
                            }
                            
                            while (linha != null)
                            {
                                
                                string[] dados = linha.Split(',');

                                meusContatos.Add(new Contato(dados[0], dados[1], dados[2]));
                                
                                linha = sr.ReadLine();
                            }
                        }
                        
                        Console.WriteLine("\nEscolha o formato de exibição:");
                        Console.WriteLine("1 - Markdown");
                        Console.WriteLine("2 - Tabela");
                        Console.WriteLine("3 - Texto Puro");
                        Console.Write("Opção de formato: ");
                        string opcaoFormato = Console.ReadLine();
                        
                        
                        ContatoFormatter formatador = null; 

                        if (opcaoFormato == "1")
                        {
                            formatador = new MarkdownFormatter();
                        }
                        else if (opcaoFormato == "2")
                        {
                            formatador = new TabelaFormatter();
                        }
                        else if (opcaoFormato == "3")
                        {
                            formatador = new RawTextFormatter();
                        }
                        else
                        {
                            Console.WriteLine("Formato inválido.");
                            break;
                        }
                        Console.WriteLine("\nContatos cadastrados:");
                        
                        Console.WriteLine();
                        formatador.ExibirContatos(meusContatos);
                        

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Erro ao ler o arquivo.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Encerrando programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static Contato criarContato()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();
        
        return new Contato(nome, telefone, email);
    }
}