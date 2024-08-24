/* Coleção de exercícios 03 */

/* Exercício 01 */
void Exercicio01()
{
    //Dictionary<string, List<double>> alunos = new()
    //{
    //    ["Julio"] = [10, 9.5, 6.8],
    //    ["Lorena"] = [10, 10, 7.1],
    //    ["Davi"] = [8.8, 9.3, 9.9]
    //};

    ////Exemplo de acesso a dicionário
    ////Console.WriteLine(alunos["Julio"][0]);


    //foreach (string aluno in alunos.Keys)
    //{

    //    double soma = 0;
    //    double media = 0;

    //    for (int i = 0; i < alunos[aluno].Count; i++)
    //    {

    //        soma += alunos[aluno][i];

    //    }

    //    media = soma / alunos[aluno].Count;
    //    Console.WriteLine($"Média do aluno {aluno} foi de {media}");

    //}

}



/* Exercício 02 */
void Exercicio02()
{
    //Dictionary<string, int> produtos = new()
    //{

    //    ["CADEIRA PRESIDENTE"] = 7,
    //    ["CADEIRA ESCRITÓRIO FLEX"] = 5,
    //    ["MESA ESCRITÓRIO FLEX"] = 10 

    //};

    //void MenuPrincipal()
    //{

    //    string opcaoMenu;

    //    Console.WriteLine("Digite 1 para adicionar produtos.");
    //    Console.WriteLine("Digite 2 para ver a quantidade em estoque de todos produtos.");
    //    Console.WriteLine("Digite 3 para ver a quantidade em estoque de um produto.");
    //    opcaoMenu = Console.ReadLine()!;

    //    if (int.TryParse(opcaoMenu, out int value))
    //    {

    //        switch (opcaoMenu)
    //        {

    //            case "1":
    //                AdicionarProdutos();
    //                break;

    //            case "2":
    //                ExibirTodosProdutos();
    //                break;

    //            case "3":
    //                ExibirUmProduto();
    //                break;


    //            default:
    //                Console.WriteLine("Opção inválida!");
    //                Thread.Sleep(700);
    //                Console.Clear();
    //                MenuPrincipal();
    //                break;

    //        }

    //    }
    //    else
    //    {

    //        Console.WriteLine("Opção inválida!");
    //        Thread.Sleep(700);
    //        Console.Clear();
    //        MenuPrincipal();

    //    }

    //}

    //void AdicionarProdutos()
    //{

    //    string nomeProduto;
    //    string qtdProdutoString;

    //    Console.Clear();

    //    Console.WriteLine("ADICIONAR PRODUTOS\n\n");

    //    Console.Write("Digite o nome do produto: ");
    //    nomeProduto = Console.ReadLine()!;
    //    nomeProduto = nomeProduto.ToUpper();

    //    while (true)
    //    {

    //        Console.Write("Digite a quantidade em estoque: ");
    //        qtdProdutoString = Console.ReadLine()!;

    //        if (int.TryParse(qtdProdutoString, out int qtdProduto))
    //        {

    //            produtos.Add(nomeProduto, qtdProduto);
    //            Console.WriteLine("\n\nProduto adicionado com sucesso!");
    //            break;

    //        }
    //        else
    //        {
    //            Console.WriteLine("Quantidade inválida!\n");
    //        }

    //    }
    //    Thread.Sleep(1000);
    //    Console.Clear();
    //    MenuPrincipal();

    //}

    //void ExibirTodosProdutos()
    //{

    //    Console.Clear();

    //    Console.WriteLine("EXIBIR TODOS PRODUTOS\n\n");

    //    foreach(string nomeProduto in produtos.Keys)
    //    {

    //        Console.Write($"{nomeProduto} || Quantidade: {produtos[nomeProduto]}\n");

    //    }

    //    Console.WriteLine("\n\nPressione qualquer tecla para voltar.");
    //    Console.ReadKey();
    //    Thread.Sleep(400);
    //    Console.Clear();
    //    MenuPrincipal();

    //}

    //void ExibirUmProduto()
    //{

    //    string nomeProduto;

    //    Console.Clear();

    //    Console.WriteLine("EXIBIR UM PRODUTO\n\n");

    //    Console.WriteLine("Qual produto deseja buscar?");
    //    nomeProduto = Console.ReadLine()!;
    //    nomeProduto = nomeProduto.ToUpper();

    //    if (produtos.ContainsKey(nomeProduto))
    //    {

    //        Console.Write($"\n{nomeProduto} || Quantidade: {produtos[nomeProduto]}");

    //    }
    //    else
    //    {

    //        Console.WriteLine("\nProduto não encontrado!");

    //    }

    //    Console.WriteLine("\n\nPressione qualquer tecla para voltar.");
    //    Console.ReadKey();
    //    Thread.Sleep(400);
    //    Console.Clear();
    //    MenuPrincipal();

    //}

    //MenuPrincipal();

}



/* Exercício 03 */
void Exercicio03()
{
    Dictionary<string, string> quiz = new()
    {

        ["Qual o nome do estado mais ao sul do Brasil?"] = "RIO GRANDE DO SUL",
        ["Qual o nome da maior floresta do mundo?"] = "FLORESTA AMAZÔNICA",
        ["Qual a menor cidade do Brasil?"] = "SERRA DA SAUDADE"

    };
    int pontuacao = 0;

    Console.WriteLine("Se prepare! O quiz vai começar.");
    Carregando(50);
    Console.Clear();

    //foreach (string pergunta in quiz.Keys)
    for (int i = 0; i < quiz.Count; i++)
    {

        string pergunta = quiz.Keys.ElementAt(i);
        string resposta;

        Console.WriteLine(pergunta);
        resposta = Console.ReadLine()!;

        if(resposta.ToUpper() == quiz[pergunta])
        {

            pontuacao++;
            Console.WriteLine($"\nParabéns! Você acertou.\nPontuação: {pontuacao}/3.");

        }
        else
        {

            Console.WriteLine($"\nResposta incorreta! O certo era: {quiz[pergunta]}.\nPontuação: {pontuacao}/3.");

        }

        if (i < (quiz.Count-1))
        {

            Console.WriteLine("\n\nSe prepare para a próxima pergunta.");
            Carregando(50);
            Console.Clear();
        }
        else
        {

            Carregando(50);
            Console.Clear();
            Console.WriteLine($"Fim do quiz, obrigado por jogar!\nPontuação: {pontuacao}/3.");
            Thread.Sleep(4000);

        }

    }
}



/* Exercício 04 */
void Exercicio04()
{
    Dictionary<string, string> usuario = new()
    {

        ["tonystark"] = "pepper"

    };

    string login, senha;

    Console.WriteLine("ACESSO AO SERVIÇO DE INTELIGÊNCIA COMPARTILHADA OTAN: ");
    Carregando(50);
    Console.Clear();

    Console.Write("Digite o login: ");
    login = Console.ReadLine()!;
    Console.Write("Digite a senha: ");
    senha = Console.ReadLine()!;

    if(usuario.Keys.Contains(login) && usuario.Values.Contains(senha))
    {

        Carregando(50);
        Console.Clear();
        Console.WriteLine("ACESSO CONCEDIDO!");

    }
    else
    {

        Console.Clear();
        Console.WriteLine("ACESSO NEGADO!");

    }
}



/* Exercício 05 */
void Exercicio05()
{
    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> 
    {
        { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
        { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
        { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
        { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
        { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
    };

    string carro;

    double soma = 0;
    double media = 0;

    Console.WriteLine("Carros vendidos: ");

    foreach (string nomeCarro in vendasCarros.Keys)
    {

        Console.WriteLine($"|| {nomeCarro} ||");

    }

    Console.Write("\n\nDigite o modelo escolhido para ter a média de vendas: ");
    carro = Console.ReadLine()!;

    if (vendasCarros.ContainsKey(carro))
    {

        /* Lógica com cálculos próprios */
        //for (int i = 0; i < vendasCarros[carro].Count; i++)
        //{

        //    soma += vendasCarros[carro][i];

        //}

        //media = soma / vendasCarros[carro].Count;

        media = vendasCarros[carro].Average(); // Maneira simplificada

        Console.WriteLine($"\nMédia de vendas: {media}");
        Carregando(30);
        Console.Clear();
        Exercicio05();

    }
    else
    {

        Console.WriteLine("\nModelo não cadastrado!");
        Carregando(13);
        Console.Clear();
        Exercicio05();

    }
}

Exercicio05();



/* Utilitário de carregamento */
void Carregando(int qtd)
{

    for (int i = 0; i < qtd; i++)
    {

        Console.Write(".");
        Thread.Sleep(100);

    }

}