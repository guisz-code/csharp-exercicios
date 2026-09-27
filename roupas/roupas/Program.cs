using System.Numerics;

int opcao = 0;
double valorUni = 25.00;

Console.WriteLine("Fazer pedido.");
Console.WriteLine("Sair.");

switch (opcao)
{
    case 1: 
        Console.WriteLine("Quantas roupas?: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade >= 5)
        {
            Console.WriteLine("Você ganhou 10% de desconto.");
            double Total = quantidade  * valorUni;
            double desconto = Total * 0.10;
            Total -= desconto;
                
        }
        break;

    default:
        break;

}
