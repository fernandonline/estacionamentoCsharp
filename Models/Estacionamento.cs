public class EstacionamentoCsharp
{
    private const decimal PrecoInicial = 5.00m;
    private const decimal PrecoPorHora = 3.00m;
    private readonly Dictionary<string, DateTime> veiculos = [];
    public decimal PrecoInicialValue => PrecoInicial;
    public decimal PrecoPorHoraValue => PrecoPorHora;

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string? placa = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(placa))
        {
            veiculos[placa] = DateTime.Now;
            Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Placa inválida. Por favor, digite uma placa válida.");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo estacionado.");
            return;
        }

        Console.WriteLine("Veículos estacionados:");
        foreach (var placa in veiculos.Keys)
        {
            Console.WriteLine($"- {placa}");
        }
    }


    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string? placa = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(placa) && veiculos.ContainsKey(placa))
        {
            DateTime horaEntrada = veiculos[placa];
            DateTime horaSaida = DateTime.Now;
            TimeSpan tempoEstacionado = horaSaida - horaEntrada;

            double segundosEstacionados = tempoEstacionado.TotalSeconds;
            double minutosEstacionados = segundosEstacionados * 3;
            
            int horas = (int)minutosEstacionados / 60;
            int minutos = (int)minutosEstacionados % 60;

            decimal valorTotal = PrecoInicial + (decimal)(minutosEstacionados / 60) * PrecoPorHora;

            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido!\nO tempo foi de: {horas}H:{minutos}M, e o preço total é de: R$ {valorTotal:F2}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

}
