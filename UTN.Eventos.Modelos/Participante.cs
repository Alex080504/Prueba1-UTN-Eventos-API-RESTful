using System.ComponentModel.DataAnnotations;

namespace UTN.Eventos.Modelos
{
    public class Participante
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Institucion { get; set; }

        //Navigation Properties
        public List<Inscripcion>? Inscripciones { get; set; }
        public List<Certificado>? Certificados { get; set; }
    }
}
