using System.Globalization;

namespace trilha_net_explorando_desafio.Models
{
    class Reserva
    {
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public List<Pessoa> Hospedes { get; set; }


        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count() > Suite.Capacidade)
            {
                throw new ArgumentException("A quantidade de hóspedes não pode exceder a capacidade da suite");
            }
            else
            {
                Hospedes = hospedes;
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;
            return (DiasReservados >= 10) ? valorDiaria -= valorDiaria * 0.1M : valorDiaria;
        }
    }
}
