using System.ComponentModel.DataAnnotations;

namespace UTN.Eventos.Modelos
{
    public class EventoPonente
    {
        [Key] public int Id { get; set; }
        public int EventoId { get; set; }
        public int PonenteId { get; set; }

        public Evento? Evento { get; set; }
        public Ponente? Ponente { get; set; }
    }
}
