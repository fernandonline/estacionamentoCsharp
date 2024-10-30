Console.OutputEncoding = System.Text.Encoding.UTF8;
EstacionamentoCsharp es = new EstacionamentoCsharp();

bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine($"Bem vindo ao estacionamento.\nO valor incial é de {es.PrecoInicialValue}, e o valor por hora é de {es.PrecoPorHoraValue}\n5 segundo equivalem 15 minutos no mundo real!");
    Console.WriteLine();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            es.AdicionarVeiculo();
            break;

        case "2":
            Console.Clear();
            es.RemoverVeiculo();
            break;

        case "3":
            Console.Clear();
            es.ListarVeiculos();
            break;

        case "4": 
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");