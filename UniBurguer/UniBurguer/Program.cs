    List<string> ListaPedidos = new List<string>();
int pagamento = 0;  
int opcao = 0;
double total = 0.00;

{
    do
    {   
        Console.WriteLine("\n---- BEM VINDO A UNIBURGUER ----");
        Console.WriteLine("Faça seu pedido: ");
        Console.WriteLine("1 - X-Burguer (R$ 10,00): ");
        Console.WriteLine("2 - X-Salada (R$ 12,00): ");
        Console.WriteLine("3 - Refrigerente (R$ 5,00): ");
        Console.WriteLine("4 - Finalizar pedido");
        Console.Write("Escolha uma opção: ");

        if (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Opção inválida! Tente novamente.");
            continue;
        }

        switch (opcao)
        {
            case 1:
                Console.WriteLine("X-Burguer adicionado");
                string xburguer = "X-Burguer";
                ListaPedidos.Add(xburguer);
                total += 10.00;
                 break;

            case 2:
                Console.WriteLine("X-Salada adicionado");
                string xsalada = "X-Salada";
                ListaPedidos.Add(xsalada);
                total += 12.00;
                break;

            case 3:
                Console.WriteLine("Refrigerente adicionado");
                string refri = "Refrigerante";
                ListaPedidos.Add(refri);
                total += 5.00;
                break;

            case 4:
                break;

             default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;
        }
    }
    while (opcao != 4);
    Console.WriteLine("Forma de pagamento:");
    Console.WriteLine("1 - Dinheiro (10% de desconto)");
    Console.WriteLine("2 - Cartão");
    Console.Write("Escolha a forma de pagamento: ");
    pagamento = int.Parse(Console.ReadLine());

    Console.WriteLine("\n---- RESUMO DO PEDIDO ----");
    foreach (string item in ListaPedidos)
        Console.WriteLine(item);

    if (pagamento == 1)
    {
        double desconto = total * 0.10;
        total -= desconto;
        Console.WriteLine($"Desconto de R$ {desconto} ,aplicado");
    }
    else if (pagamento == 2) 
    {
        Console.WriteLine("Pagamento em cartão selecionado.");
    }
    else
    {
        Console.WriteLine("Forma de pagamento inválida! Considerando cartão.");
    }

    Console.WriteLine($"Valor total do pedido: R$ {total} ");
    Console.WriteLine("\n---- OBRIGADO PELO PEDIDO ----");
}


