using System.ComponentModel.DataAnnotations;

namespace UTN.Eventos.Modelos
{
    public class Evento
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Tipo { get; set; }
        public string Lugar { get; set; }

        //Navigation Properties
        public List<Sesion>? Sesiones { get; set; }
        public List<Certificado>? Certificados { get; set; }
        public List<Ponente>? Ponentes { get; set; }
        public List<Inscripcion>? Inscripciones { get; set; }
        public List<EventoPonente> EventosPonentes { get; set; } = new();
    }
}
