/**
 * Programa que mostrará ao usuário que ele estará ou não dentro da faixa de calorias por dia
 * A faixa ideal seria de 1800 a 2500 calorias por dia
**/

 


int calorias = 0; //Variável 


Console.Write("Digite quantas calorias você consumiu hoje: "); //Pede a informação ao usuário
calorias = int.Parse (Console.ReadLine()); //Variavel recebe o valor que o usuário digitar

if (calorias >= 1800 && calorias <= 2500) //Se estiver dentro faixa de 1800 a 2500
{
    Console.WriteLine("Você está dentro da faixa."); //Imprime que o usuário está dentro na faixa
}
else { Console.Write("Você está fora faixa.");} //Se não, imprime que o usuário esta fora da faixa

