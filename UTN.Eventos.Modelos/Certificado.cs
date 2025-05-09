using System.ComponentModel.DataAnnotations;

namespace UTN.Eventos.Modelos
{
    public class Certificado
    {
        [Key] public int Id { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Codigo { get; set; }

        //Foreign Keys
        public int ParticipanteId { get; set; }
        public int EventoId { get; set; }

        //Navigation Properties
        public Participante? Participante { get; set; }
        public Evento? Evento { get; set; }
    }
}
