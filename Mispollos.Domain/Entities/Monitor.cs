﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mispollos.Domain.Entities
{
    [Table("Monitor")]
    public class Monitor
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Codigo { get; set; }
        public string Responsable { get; set; }
        public string Marca { get; set; }
        public string Estado { get; set; }
        public string Ubicacion { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
    }
}
