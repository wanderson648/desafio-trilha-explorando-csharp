using System.Globalization;
using trilha_net_explorando_desafio.Models;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Hospede 1");
        Pessoa p2 = new Pessoa("Hospede 2");

        List<Pessoa> hospedes = new List<Pessoa>();

        hospedes.Add(p1);
        hospedes.Add(p2);

        Reserva reserva = new Reserva(diasReservados: 10);
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);


        Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da diária: " +
            $"{reserva.CalcularValorDiaria().ToString("f2", CultureInfo.InvariantCulture)}");
    }
}