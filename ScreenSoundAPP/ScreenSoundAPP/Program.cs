
string welcome = "\nBem vindo ao Screen Sound!";

//List<string> ListaBandas = new List<string> {"Arctic Monkeys","Metallica","AC/DC"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Metallica", new List<int> { 10, 8, 9});
bandasRegistradas.Add("AC/CD", new List<int>());

void ExibirWelcome () {

    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine(welcome);
}

void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string selectMenu = Console.ReadLine()!;
    int selectMenuInt = int.Parse(selectMenu)!;
    if (selectMenuInt == 1) 
    {
        RegistrarBanda();
    } else if (selectMenuInt == 2) 
    {
        ExibirBandas();
    } else if (selectMenuInt == 3) 
    {
        AvaliarBanda();
    } else if (selectMenuInt == 4) 
    {
        ExibirMedia();
    } else if (selectMenuInt == 0) 
    {
        return;
        Environment.Exit(0);
    }
    else 
    { 
        Console.WriteLine("Opcao invalida!"); 
    }
}
void backMenu()
{
    Console.WriteLine("\nDigite qualquer tecla para voltar para o menu");
    Console.ReadKey();
    Console.Clear();
    ExibirWelcome();
    ExibirMenu();
}

void RegistrarBanda() 
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandaNome = Console.ReadLine()!;
    bandasRegistradas.Add(bandaNome, new List<int>());
    Console.WriteLine($"A banda {bandaNome} foi registrada com sucesso");
    backMenu();
}

void ExibirBandas() 
{
    Console.Clear();
    Console.WriteLine("Bandas registradas: ");
    //for (int i = 0; i < ListaBandas.Count; i++) 
    //{
    //    Console.WriteLine($"Banda: {ListaBandas[i]} ");
    //}
    foreach (string bandafor in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {bandafor} ");
    }
    
    backMenu();
}

void AvaliarBanda() 
{
    Console.Clear();
    Console.WriteLine("Avaliar Banda!");
    Console.Write("\nDigite a banda que deseja avaliar: ");
    string bandaNome = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(bandaNome)!)
    {
        Console.Write($"Qual nota que deseja atribuir a banda {bandaNome}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[bandaNome].Add(nota);
        Console.WriteLine($"A nota {nota} foi atribuida com sucesso para a banda {bandaNome}!");
        backMenu();
    } else {
        Console.WriteLine($"\nA banda {bandaNome} nao foi encontrada");
        backMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    Console.WriteLine("Exibir media da banda");
    Console.Write("Digite o nome da banda que deseja ver a media: ");
    string bandaNome = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey (bandaNome))
    {
        List<int> notasDaBanda = bandasRegistradas[bandaNome];
        Console.WriteLine($"A media da banda {bandaNome} é {notasDaBanda.Average()}");
        backMenu();
    } else {
        Console.WriteLine($"\nA banda {bandaNome} nao foi encontrada");
        backMenu();
    }
}

ExibirWelcome();
ExibirMenu();