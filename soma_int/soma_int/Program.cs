
int opcao = 0;
while (opcao != 3)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1 - Olá");
    Console.WriteLine("2 - Mostrar Data");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu Olá!");
            break;
        case 2:
            Console.WriteLine("Data atual: " + DateTime.Now);
            break;
        case 3:
            Console.WriteLine("Encerrando o programa.");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}    
 