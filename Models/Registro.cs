﻿using System.ComponentModel.DataAnnotations;

namespace Ciudadano_Sano.Models
{
    public class Registro
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public ICollection<Usuario>? Usuarios { get; set; } = default!;
    }
}
