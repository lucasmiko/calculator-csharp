Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Ecolha uma operação digitando o número correspondente: ");
    Console.WriteLine();

    Console.WriteLine("1. Adição");
    Console.WriteLine("2. Subtração");
    Console.WriteLine("3. Divisão");
    Console.WriteLine("4. Multiplicação");
    Console.WriteLine("5. Sair");

    Console.WriteLine();

    Console.Write("Digite o número que corresponde a sua opção: ");
    var choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
        Sum();
        break;

        case "2":
        Subtraction();
        break;

        case "3":
        Division();
        break;

        case "4":
        Multiplication();
        break;

        case "5":
        Exit();
        break;
        
        default: Warning();
        break;
    }
}

static void Warning()
{
    Console.WriteLine("Escolha uma opção válida!");
    Console.ReadKey();
    Menu();
}

static void Exit()
{
    Console.Write("Tem certeza que deseja sair da aplicação? (S/N) ");
    var response = Console.ReadLine().ToUpper();

    if (response == "N")
    {
        Menu();
    }

    System.Environment.Exit(0);
}

static void Sum() 
{
    Console.Write("Primeiro valor: ");
    float firstNumber = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float secondNumber = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float result = firstNumber + secondNumber;
    Console.WriteLine($"O resultado da soma é: {result}");
    Console.ReadKey();
    Menu();
}

static void Subtraction()
{
    Console.Write("Primeiro valor: ");
    float firstNumber = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float secondNumber = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float result = firstNumber - secondNumber;
    Console.WriteLine($"O resultado da subtração é: {result}");
    Console.ReadKey();
    Menu();
}

static void Division()
{
    Console.Write("Primeiro valor: ");
    float firstNumber = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float secondNumber = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float result = firstNumber / secondNumber;
    Console.WriteLine($"O resultado da divisão é: {result}");
    Console.ReadKey();
    Menu();
}

static void Multiplication()
{
    Console.Write("Primeiro valor: ");
    float firstNumber = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float secondNumber = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float result = firstNumber * secondNumber;
    Console.WriteLine($"O resultado da multiplicação é: {result}");
    Console.ReadKey();
    Menu();
}
