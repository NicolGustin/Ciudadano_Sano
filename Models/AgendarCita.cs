using System.Numerics;

namespace Ciudadano_Sano.Models
{
    public class AgendarCita
    {
        public int Id { get; set; }

        public int Paciente_Id { get; set; }
        public int Medico_Id { get; set; }
        public string Name { get; set; }

        public string Document { get; set; }
        public DateTime Date { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }

        public ICollection<AgendarCita>? AgendarCitas { get; set; }
    }
}
