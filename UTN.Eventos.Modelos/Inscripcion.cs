using System.ComponentModel.DataAnnotations;

namespace UTN.Eventos.Modelos
{
    public class Inscripcion
    {
        [Key] public int Id { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public string Estado { get; set; }
        public double MontoPagado { get; set; }
        public DateTime FechaPago { get; set; }
        public string MedioPago { get; set; }

        //Foreign Keys
        public int EventoId { get; set; }
        public int ParticipanteId { get; set; }

        //Navigation Properties
        public Evento? Evento { get; set; }
        public Participante? Participante { get; set; }
    }
}
