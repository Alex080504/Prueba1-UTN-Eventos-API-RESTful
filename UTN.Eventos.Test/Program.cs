using UTN.Eventos.APIConsumer;
using UTN.Eventos.Modelos;

namespace UTN.Eventos.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProbarEventos();
            //ProbarSesiones();
            //ProbarParticipantes();
            //ProbarPonentes();
            //ProbarInscripciones();
            //ProbarCertificados();
            Console.ReadLine();
        }
        private static void ProbarEventos()
        {
            Crud<Evento>.EndPoint = "https://localhost:7053/api/Eventos";

            // Crear eventos
            var evento1 = Crud<Evento>.Create(new Evento
            {
                //Id = 1,
                Nombre = "AENIT 2024",
                FechaInicio = DateTime.UtcNow,
                FechaFin = DateTime.UtcNow.AddDays(1),
                Tipo = "Conferencia",
                Lugar = "Lugar del evento de prueba",
                Sesiones = null,
                Certificados = null,
                Ponentes = null,
                Inscripciones = null
            });

            var evento2 = Crud<Evento>.Create(new Evento
            {
                //Id = 2,
                Nombre = "Expo Tecnología",
                FechaInicio = DateTime.UtcNow.AddDays(10),
                FechaFin = DateTime.UtcNow.AddDays(12),
                Tipo = "Exposición",
                Lugar = "Centro de Convenciones",
                Sesiones = null,
                Certificados = null,
                Ponentes = null,
                Inscripciones = null
            });

            var evento3 = Crud<Evento>.Create(new Evento
            {
                //Id = 3,
                Nombre = "Taller de Innovación",
                FechaInicio = DateTime.UtcNow.AddDays(20),
                FechaFin = DateTime.UtcNow.AddDays(21),
                Tipo = "Taller",
                Lugar = "Aula Magna UTN",
                Sesiones = null,
                Certificados = null,
                Ponentes = null,
                Inscripciones = null
            });

            var evento4 = Crud<Evento>.Create(new Evento
            {
                //Id = 4,
                Nombre = "Foro Académico 2025",
                FechaInicio = DateTime.UtcNow.AddDays(30),
                FechaFin = DateTime.UtcNow.AddDays(31),
                Tipo = "Foro",
                Lugar = "Auditorio Central",
                Sesiones = null,
                Certificados = null,
                Ponentes = null,
                Inscripciones = null
            });

            //Modificar eventos
            evento1.Nombre = "AENIT 2025 (Modificado)";  //Cambio de nombre
            Crud<Evento>.Update(evento1.Id, evento1);
            evento2.Lugar = "Auditorio Principal (Modificado)";  //Cambio de lugar
            Crud<Evento>.Update(evento2.Id, evento2);
            // Obtener todos los eventos
            var eventos = Crud<Evento>.GetAll();
            foreach (var evento in eventos)
            {
                Console.WriteLine($"Id: {evento.Id}, Nombre: {evento.Nombre}, Lugar: {evento.Lugar}, Fecha Inicio: {evento.FechaInicio}, Fecha Fin: {evento.FechaFin}");
            }
        }
        private static void ProbarSesiones()
        {
            Crud<Sesion>.EndPoint = "https://localhost:7053/api/Sesiones";

            // Crear sesiones
            var sesion1 = Crud<Sesion>.Create(new Sesion
            {
                //Id = 1,
                Titulo = "Sesión de Introducción a la IA",
                FechaInicio = DateTime.UtcNow.AddDays(1),
                FechaFin = DateTime.UtcNow.AddDays(1).AddHours(2), 
                Lugar = "Sala 1",
                EventoId = 1
            });

            var sesion2 = Crud<Sesion>.Create(new Sesion
            {
                //Id = 2,
                Titulo = "Sesión de Desarrollo Ágil",
                FechaInicio = DateTime.UtcNow.AddDays(2),
                FechaFin = DateTime.UtcNow.AddDays(2).AddHours(3), 
                Lugar = "Sala 2",
                EventoId = 2
            });

            var sesion3 = Crud<Sesion>.Create(new Sesion
            {
                //Id = 3,
                Titulo = "Sesión sobre Blockchain",
                FechaInicio = DateTime.UtcNow.AddDays(3),
                FechaFin = DateTime.UtcNow.AddDays(3).AddHours(2),
                Lugar = "Sala 3",
                EventoId = 3
            });

            var sesion4 = Crud<Sesion>.Create(new Sesion
            {
                //Id = 4,
                Titulo = "Sesión de Ciberseguridad",
                FechaInicio = DateTime.UtcNow.AddDays(4),
                FechaFin = DateTime.UtcNow.AddDays(4).AddHours(3),
                Lugar = "Sala 4",
                EventoId = 4
            });

            // Modificar sesiones
            sesion1.Titulo = "Sesión de IA (Modificada)"; // Cambiar título
            Crud<Sesion>.Update(sesion1.Id, sesion1);
            sesion2.Lugar = "Auditorio (Modificado)"; // Cambiar fecha de fin
            Crud<Sesion>.Update(sesion2.Id, sesion2);
            // Obtener todas las sesiones
            var sesiones = Crud<Sesion>.GetAll();
            foreach (var sesion in sesiones)
            {
                Console.WriteLine($"Id: {sesion.Id}, Nombre: {sesion.Titulo}, Fecha de Inicio: {sesion.FechaInicio}, Fecha de Fin: {sesion.FechaFin}");
            }
        }
        private static void ProbarParticipantes()
        {
            Crud<Participante>.EndPoint = "https://localhost:7053/api/Participantes";

            // Crear participantes
            var participante1 = Crud<Participante>.Create(new Participante
            {
                //Id = 1,
                Nombre = "Carlos",
                Apellido = "Perez",
                Email = "carlos.perez@example.com",
                Institucion = "UTN"
            });

            var participante2 = Crud<Participante>.Create(new Participante
            {
                //Id = 2,
                Nombre = "Ana",
                Apellido = "Lopez",
                Email = "ana.lopez@example.com",
                Institucion = "PUCE-SI"
            });

            var participante3 = Crud<Participante>.Create(new Participante
            {
                //Id = 3,
                Nombre = "Juan",
                Apellido = "Rodriguez",
                Email = "juan.rodriguez@example.com",
                Institucion = "ESPE",
            });

            var participante4 = Crud<Participante>.Create(new Participante
            {
                //Id = 4,
                Nombre = "Marta",
                Apellido = "Gonzalez",
                Email = "marta.gonzalez@example.com",
                Institucion = "UNIANDES"
            });

            // Modificar participantes
            participante1.Nombre = "Carlos Pérez (Modificado)";
            Crud<Participante>.Update(participante1.Id, participante1);
            participante2.Email = "ana.lopez2025@example.com"; // Cambiar correo
            Crud<Participante>.Update(participante2.Id, participante2);
            // Obtener todos los participantes
            var participantes = Crud<Participante>.GetAll();
            foreach (var participante in participantes)
            {
                Console.WriteLine($"Id: {participante.Id}, Nombre: {participante.Nombre}, Apellido: {participante.Apellido}, Correo: {participante.Email}, Institucion: {participante.Institucion}");
            }
        }
        private static void ProbarPonentes()
        {
            Crud<Ponente>.EndPoint = "https://localhost:7053/api/Ponentes";

            // Crear ponentes
            var ponente1 = Crud<Ponente>.Create(new Ponente
            {
                //Id = 1,
                Nombre = "Ana",
                Apellido = "Ramírez",
                Email = "ana.ramirez@utn.edu"
            });

            var ponente2 = Crud<Ponente>.Create(new Ponente
            {
                //Id = 2,
                Nombre = "Luis",
                Apellido = "García",
                Email = "luis.garcia@utn.edu"
            });

            var ponente3 = Crud<Ponente>.Create(new Ponente
            {
                //Id = 3,
                Nombre = "Carmen",
                Apellido = "Mendoza",
                Email = "carmen.mendoza@utn.edu"
            });

            var ponente4 = Crud<Ponente>.Create(new Ponente
            {
                //Id = 4,
                Nombre = "Marco",
                Apellido = "Delgado",
                Email = "marco.delgado@utn.edu"
            });

            // Modificar dos ponentes
            ponente1.Email = "ana.ramirez.actualizado@utn.edu";
            Crud<Ponente>.Update(ponente1.Id, ponente1);

            ponente2.Nombre = "Luis Alberto";
            Crud<Ponente>.Update(ponente2.Id, ponente2);

            // Obtener todos los ponentes
            var ponentes = Crud<Ponente>.GetAll();
            foreach (var ponente in ponentes)
            {
                Console.WriteLine($"Id: {ponente.Id}, Nombre: {ponente.Nombre} {ponente.Apellido}, Email: {ponente.Email}");
            }
        }
        private static void ProbarInscripciones()
        {
            Crud<Inscripcion>.EndPoint = "https://localhost:7053/api/Inscripciones";

            // Crear inscripciones con fechas en UTC
            var inscripcion1 = Crud<Inscripcion>.Create(new Inscripcion
            {
                //Id = 1,
                FechaInscripcion = new DateTime(2025, 5, 9, 12, 0, 0, DateTimeKind.Utc), // Fecha UTC
                Estado = "Confirmada",
                MontoPagado = 100.50,
                FechaPago = new DateTime(2025, 5, 9, 12, 0, 0, DateTimeKind.Utc), // Fecha UTC
                MedioPago = "Tarjeta",
                EventoId = 1,
                ParticipanteId = 1
            });

            var inscripcion2 = Crud<Inscripcion>.Create(new Inscripcion
            {
                //Id = 2,
                FechaInscripcion = new DateTime(2025, 5, 10, 15, 0, 0, DateTimeKind.Utc), // Fecha UTC
                Estado = "Pendiente",
                MontoPagado = 50.75,
                FechaPago = new DateTime(2025, 5, 10, 15, 0, 0, DateTimeKind.Utc), // Fecha UTC
                MedioPago = "Transferencia",
                EventoId = 2,
                ParticipanteId = 2
            });
            var inscripcion3 = Crud<Inscripcion>.Create(new Inscripcion
            {
                //Id = 3,
                FechaInscripcion = new DateTime(2025, 5, 11, 14, 0, 0, DateTimeKind.Utc), // Fecha UTC
                Estado = "Pendiente",
                MontoPagado = 200.00,
                FechaPago = new DateTime(2025, 5, 11, 14, 0, 0, DateTimeKind.Utc), // Fecha UTC
                MedioPago = "Efectivo",
                EventoId = 3,
                ParticipanteId = 3
            });

            var inscripcion4 = Crud<Inscripcion>.Create(new Inscripcion
            {
                //Id = 4,
                FechaInscripcion = new DateTime(2025, 5, 12, 16, 0, 0, DateTimeKind.Utc), // Fecha UTC
                Estado = "Confirmada",
                MontoPagado = 150.30,
                FechaPago = new DateTime(2025, 5, 12, 16, 0, 0, DateTimeKind.Utc), // Fecha UTC
                MedioPago = "Tarjeta",
                EventoId = 4,
                ParticipanteId = 4
            });

            // Modificar inscripciones
            inscripcion1.Estado = "Pagada";
            Crud<Inscripcion>.Update(inscripcion1.Id, inscripcion1);

            inscripcion2.MontoPagado = 60.00; // Cambiar monto
            Crud<Inscripcion>.Update(inscripcion2.Id, inscripcion2);

            // Obtener todas las inscripciones
            var inscripciones = Crud<Inscripcion>.GetAll();
            foreach (var inscripcion in inscripciones)
            {
                Console.WriteLine($"Id: {inscripcion.Id}, Fecha Inscripción: {inscripcion.FechaInscripcion:yyyy-MM-ddTHH:mm:ssZ}, Estado: {inscripcion.Estado}, Monto Pagado: {inscripcion.MontoPagado}, Fecha Pago: {inscripcion.FechaPago:yyyy-MM-ddTHH:mm:ssZ}, Medio de Pago: {inscripcion.MedioPago}");
            }
        }

        private static void ProbarCertificados()
        {
            Crud<Certificado>.EndPoint = "https://localhost:7053/api/Certificados";

            // Crear certificados con fechas en UTC
            var certificado1 = Crud<Certificado>.Create(new Certificado
            {
                //Id = 1,
                FechaEmision = new DateTime(2025, 5, 9, 14, 0, 0, DateTimeKind.Utc), // Fecha UTC
                Codigo = "ABC123456",
                EventoId = 1,
                ParticipanteId = 1
            });

            var certificado2 = Crud<Certificado>.Create(new Certificado
            {
                //Id = 2,
                FechaEmision = new DateTime(2025, 5, 10, 16, 0, 0, DateTimeKind.Utc), // Fecha UTC
                Codigo = "DEF789101",
                EventoId = 2,
                ParticipanteId = 2
            });
            var certificado3 = Crud<Certificado>.Create(new Certificado
            {
                //Id = 3,
                FechaEmision = new DateTime(2025, 5, 11, 13, 0, 0, DateTimeKind.Utc), // Fecha UTC
                Codigo = "GHI112233",
                EventoId = 3,
                ParticipanteId = 3
            });

            var certificado4 = Crud<Certificado>.Create(new Certificado
            {
                //Id = 4,
                FechaEmision = new DateTime(2025, 5, 12, 17, 0, 0, DateTimeKind.Utc), // Fecha UTC
                Codigo = "JKL445566",
                EventoId = 4,
                ParticipanteId = 4
            });

            // Modificar certificado
            certificado1.Codigo = "XYZ654321";
            Crud<Certificado>.Update(certificado1.Id, certificado1);

            // Obtener todos los certificados
            var certificados = Crud<Certificado>.GetAll();
            foreach (var certificado in certificados)
            {
                Console.WriteLine($"Id: {certificado.Id}, Fecha Emisión: {certificado.FechaEmision:yyyy-MM-ddTHH:mm:ssZ}, Código: {certificado.Codigo}");
            }
        }
    }
}
