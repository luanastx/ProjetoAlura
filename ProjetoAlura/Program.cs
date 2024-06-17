// Screen Sound
string mensagemBoasVindas = "Welcome to the Screen Sound";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());



void ExibirBoasVindas()
{
    Console.WriteLine(@"
     
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\n Digite a opção escolhida: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoNumerica)
    {
        case 1:
            registrarBanda();
            break;
        case 2:
            exibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Bye :)");
            break;
        default:
            Console.WriteLine("opção inválida");
            break;


    }

}

void registrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro da banda");
    Console.Write("digite o nome da banda que deseja registrar: ");
    string NomeBanda = Console.ReadLine();
    Console.Write($"A banda {NomeBanda} foi registrada com sucesso!");
    bandasRegistradas.Add(NomeBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void exibirBandas()
{
    Console.Clear();
    ExibirTitulo("Exibir banda");
    //for (int i = 0; i < listaBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaBandas[i]}");
    //}

    foreach (string Banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {Banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();

}

void ExibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliando bandas");
    Console.WriteLine("Digite a banda que deseja avaliar: ");
    string nomeBandas = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBandas))
    {
        Console.WriteLine($"Qual nota voce avalia essa: {nomeBandas}");
        int nota = int.Parse(Console.ReadLine());
        bandasRegistradas[nomeBandas].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada para a banda {nomeBandas}");
        Thread.Sleep(100);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBandas} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();

    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Media da banda");
    Console.WriteLine("Digite a banda que deseja avaliar: ");
    string nomeBandas = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBandas))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeBandas];
        Console.WriteLine($"\nA media da {nomeBandas} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBandas} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();

    }
}

ExibirOpcoesMenu();