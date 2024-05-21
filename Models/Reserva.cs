namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int quantidade = hospedes.Count;
            if (Suite.Capacidade>=quantidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Capacidade ultrapassada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int qtdhospedes = Hospedes.Count;
            return qtdhospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados*Suite.ValorDiaria;

            if (DiasReservados>=10)
            {
                valor = valor-valor*10/100;
            }

            return valor;
        }
    }
}