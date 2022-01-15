using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mispollos.Domain.Entities
{
    [Table("Usuario")]//Atributos para que lo mapee en la base de datos
    public class Usuario
    {
        // Primary key || llave primaria
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        // [StringLength(100)]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Cargo { get; set; }
        public string Clave { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        //public Guid Token { get; set; }
        //public DateTime TokenExpiration { get; set; }

        //Update database
    }
}