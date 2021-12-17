namespace AgenciaDeViagens.Models
{
    public class Viagem
    {
        public int Id { get; set; }
        public DateTime EmbarqueIda { get; set; }
        public DateTime DesembarqueIda { get; set; }
        public DateTime? EmbarqueVolta { get; set; }
        public DateTime? DesembarqueVolta { get; set; }
        public int ClienteId { get; set; }
        public int PartidaId { get; set; }
        public int ChegadaId { get; set; }

    }
}
