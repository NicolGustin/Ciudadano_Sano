using System.ComponentModel.DataAnnotations.Schema;

namespace Ciudadano_Sano.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName= "decimal(6,2)")]

        public string Document { get; set; }

        public ICollection<Paciente>? Patientes { get; set; }
    }
}
