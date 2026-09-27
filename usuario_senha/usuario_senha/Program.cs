
Console.WriteLine("---- CADASTRO ----");
Console.Write("Digite seu nome: ");
string usuario = Console.ReadLine().ToUpper();
Console.Write("Crie uma senha: ");
int senha = int.Parse(Console.ReadLine());
Console.WriteLine("---- CADASTRO FINALIZADO ----");

Console.WriteLine();    

Console.WriteLine("---- PARA CONTINUAR ----");
Console.Write("Digite sua senha: ");
int password = int.Parse(Console.ReadLine());

if (password == senha)
{
    Console.WriteLine($"----  {usuario} AUTORIZADO ----");
}
else
{
    Console.WriteLine("---- ACESSO NEGADADO ----");
}




