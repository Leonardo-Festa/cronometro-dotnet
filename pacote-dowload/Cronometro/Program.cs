Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao cronômetro!");
    Console.WriteLine("1 - Progressiva");
    Console.WriteLine("2 - Regressiva");
    Console.WriteLine("Qual será o tipo da contagem?");
    int cont = int.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multi = 1;

    if (type == 'm')
        multi = 60;

    if (time == 0)
        System.Environment.Exit(0);

    if (cont == 1)
        PreStart(time * multi);
    else
        PreRevStart(time * multi);

}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("GO!!!");
    Thread.Sleep(2500);

    Start(time);
}

static void PreRevStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("GO!!!");
    Thread.Sleep(2500);

    RevStart(time);
}

static void Start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Cronômetro finalizado...Retornando para o menu.");
    Thread.Sleep(2500);
    Menu();

}

static void RevStart(int time)
{
    int currentTime = 0;
    while (time > currentTime)
    {
        Console.Clear();
        Console.WriteLine(time);
        Thread.Sleep(1000);
        time--;
    }

    Console.Clear();
    Console.WriteLine("Cronômetro finalizado...Retornando para o menu.");
    Thread.Sleep(2500);
    Menu();
}