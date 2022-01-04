using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mispollos.Domain.Entities
{
    [Table("Laptop")]
    public class Laptop
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Codigo { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public string Cpu { get; set; }
        public string Ranura { get; set; }
        public string Ram { get; set; }
        public string SsdHdd { get; set; }
        public string Responsable { get; set; }
        public string Backup { get; set; }
        public string So { get; set; }
        public string Estado { get; set; }
        public string Modelo { get; set; }
        public string Sn { get; set; }
        public string Ubicacion { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
    }
}
