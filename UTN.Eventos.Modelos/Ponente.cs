using System.ComponentModel.DataAnnotations;

namespace UTN.Eventos.Modelos
{
    public class Ponente
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        //Navigation Properties
        public List<Evento>? Eventos { get; set; }
        public List<EventoPonente> EventosPonentes { get; set; } = new();
    }
}
