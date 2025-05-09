using System.ComponentModel.DataAnnotations;

namespace UTN.Eventos.Modelos
{
    public class Sesion
    {
        [Key] public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Lugar { get; set; }

        //Foreign Key
        public int EventoId { get; set; }

        //Navigation Properties
        public Evento? Evento { get; set; }

    }
}
