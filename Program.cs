using System.ComponentModel;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.Write("Digite o preço inicial: ");
int preco_inicio = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Agora digite o preço por hora: ");
int preco_hora = int.Parse(Console.ReadLine() ?? "0");

int opcao = 0;
List<string> placas = new List<string>();

while(opcao != 4)
{
    Console.WriteLine("Digite a sua opção: \n 1 - Cadastrar veículo\n 2 - Remover veículo\n 3 - Listar veículos \n 4 - Encerrar");
    opcao = int.Parse(Console.ReadLine() ?? "4");

    if(opcao == 1) 
    {
        Console.Write("Digite a placa do veículo para estacionar: ");
        string placa = Console.ReadLine() ?? "0";
        placas.Add(placa);
    }

    if(opcao == 2) 
    {
        Console.Write("Digite a placa do veículo para remover: ");
        string remover = Console.ReadLine() ?? "0";
        placas.Remove(remover);
        Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
        int horasEstacionado = int.Parse(Console.ReadLine() ?? "0");
        int precoPago = (horasEstacionado*preco_hora) + preco_inicio;
        Console.WriteLine($"\nO veículo {remover} foi removido e o preço total foi de: R$ {precoPago}");

    }

    if(opcao == 3) 
    {
        for(int i = 0; i < placas.Count; i++)
        {
            Console.WriteLine(placas[i]);
        }
    }

    if(opcao == 4) 
    {
        Console.WriteLine("O programa se encerrou");
        Environment.Exit(0);
    }
}
