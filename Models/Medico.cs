using System.Numerics;

namespace Ciudadano_Sano.Models
{
    public class Medico
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Document { get; set; }

        public ICollection<Medico>? Medicos { get; set; }
    }
}
