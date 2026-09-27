List<string> tarefas = new List<string>();
List<bool> status = new List<bool>();

// Função que adiciona uma nova tarefa na lista
void adicionarTarefa()
{
    Console.Write("Digite uma tarefa: ");
    string tarefa = Console.ReadLine();   // lê a descrição da tarefa digitada pelo usuário
    tarefas.Add(tarefa);                  // adiciona a tarefa na lista de tarefas
    status.Add(false);                    // adiciona 'false' indicando que está pendente
}


// Função que mostra todas as tarefas registradas e o status de cada uma
void listarTarefas()
{
    Console.WriteLine("=== SUAS TAREFAS ===");

    // Se não houver nenhuma tarefa cadastrada
    if (tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada!");
    }
    else
    {
        // Percorre todas as tarefas e mostra uma por uma com seu status
        for (int i = 0; i < tarefas.Count; i++)
        {
            // Usa operador ternário para decidir o texto conforme o status (true = concluída)
            string situacao = status[i] ? "[Concluída]" : "[Pendente]";
            Console.WriteLine($"{i + 1} - {tarefas[i]} {situacao}"); // mostra o número, o nome e o status
        }
    }
}


// Função que marca uma tarefa como concluída
void concluirTarefa(List<bool> status, int indice)
{
    // Verifica se o número informado existe dentro da lista
    if (indice >= 0 && indice < status.Count)
    {
        status[indice] = true; // muda o valor para 'true' (concluída)
        Console.WriteLine("Tarefa concluída com sucesso!");
    }
    else
    {
        // Caso o número não exista
        Console.WriteLine("Número inválido!");
    }
}


// Função que mostra o menu principal e retorna a opção escolhida pelo usuário
int mostrarMenu()
{
    Console.WriteLine("==== GERENCIADOR DE TAREFAS ====");
    Console.WriteLine("1 - Adicionar Tarefa");
    Console.WriteLine("2 - Listar Tarefas");
    Console.WriteLine("3 - Concluir Tarefa");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");

    // Converte o valor digitado em número inteiro
    int opcao = int.Parse(Console.ReadLine());
    return opcao; // retorna a opção escolhida
}


int opcao = 0; // variável de controle do menu

// Laço principal — repete até o usuário escolher sair
do
{

    // Mostra o menu e lê a opção escolhida
    opcao = mostrarMenu();

    // Verifica qual opção o usuário escolheu
    switch (opcao)
    {
        case 1:
            // Adiciona uma nova tarefa
            adicionarTarefa();
            break;

        case 2:
            // Lista todas as tarefas com status
            listarTarefas();
            break;

        case 3:
            // Mostra as tarefas antes de escolher qual concluir
            listarTarefas();

            // Só tenta concluir se existir pelo menos uma tarefa
            if (tarefas.Count > 0)
            {
                Console.Write("Digite o número da tarefa que deseja concluir: ");
                int numero = int.Parse(Console.ReadLine()); // lê o número digitado
                concluirTarefa(status, numero - 1);         // -1 porque o índice começa em 0
            }
            break;

        case 4:
            break;

        default:
            // Caso o usuário digite um número fora das opções válidas
            Console.WriteLine("Opção inválida!");
            break;
    }

    // repete enquanto a opção for diferente de 0 (sair)
} while (opcao != 4);
