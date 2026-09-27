
// Função que lê o nome da pessoa e retorna o texto digitado
string lerNome()
{
    Console.WriteLine("Digite seu nome: ");
    return Console.ReadLine();  // lê o nome e retorna
}

// Função que lê a idade da pessoa e retorna como número inteiro
int lerIdade()
{
    Console.WriteLine("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());  // converte o texto digitado para número inteiro
    return idade;
}

// Função que verifica se a pessoa é maior de idade
bool maiorIdade(int idade)
{
    if (idade >= 18)
        return true;   // se idade for 18 ou mais, retorna verdadeiro
    else
        return false;  // se for menor que 18, retorna falso
}

// Função que mostra os dados de uma pessoa 
void mostrarPessoa(string nome, int idade, bool maiorDeIdade)
{
    Console.WriteLine("=== Dados da Pessoa ===");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine($"Maior de idade: {(maiorDeIdade ? "Sim" : "Não")}");
    Console.WriteLine("========================");
}

// Função que exibe o relatório final com os totais e média
void relatorioFinal(int total, int maiores, int menores, double media)
{
    Console.WriteLine("===== RELATÓRIO FINAL =====");
    Console.WriteLine($"Total de pessoas cadastradas: {total}");
    Console.WriteLine($"Maiores de idade: {maiores}");
    Console.WriteLine($"Menores de idade: {menores}");
    Console.WriteLine($"Média de idade: {media:F1}"); // F1 = mostra 1 casa decimal
    Console.WriteLine("============================");
}

// Variáveis principais do programa
int total = 0;       // total de pessoas cadastradas
int maiores = 0;      // contador de maiores de idade
int menores = 0;      // contador de menores de idade
int somaIdades = 0;   // soma das idades para calcular média
string continuar = "S"; // controle para repetir o cadastro

// Laço principal do programa (repete enquanto o usuário quiser continuar)
while (continuar == "S")
{
    // Lê os dados da pessoa
    string nome = lerNome();
    int idade = lerIdade();
    bool maior = maiorIdade(idade);

    // Mostra as informações dessa pessoa
    mostrarPessoa(nome, idade, maior);

    // Atualiza os contadores
    total++;
    somaIdades += idade;

    if (maior)
        maiores++;   // adiciona no total de maiores de idade
    else
        menores++;   // adiciona no total de menores de idade

    // Pergunta se o usuário quer cadastrar outra pessoa
    Console.Write("Deseja cadastrar outra pessoa? (S/N): ");
    continuar = Console.ReadLine().ToUpper(); // converte pra maiúsculo pra facilitar comparação
}

// Calcula a média de idade
double media = (double)somaIdades / total;

// Mostra o relatório final com os resultados
relatorioFinal(total, maiores, menores, media);