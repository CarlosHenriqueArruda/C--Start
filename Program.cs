string opção;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite sua opção:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Buscar");
    Console.WriteLine("3 - Apagar");
    Console.WriteLine("4 - Encerrar");

    opção = Console.ReadLine();

    switch(opção)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.WriteLine("Busca de Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrarando...");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção Invalida!");
            break;
    }
}