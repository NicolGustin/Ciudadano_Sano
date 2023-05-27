using System.Numerics;

namespace Ciudadano_Sano.Models
{
    public class Historial
    {
        public int Id { get; set; }

        public int Paciente_Id { get; set; }
        public int Medico_Id { get; set; }
        public DateTime Date { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
    }
}
