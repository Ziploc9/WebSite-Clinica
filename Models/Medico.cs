using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }
        [Required]
        [StringLength(100)]
        public string Matricula { get; set; }
        [Required]
        [StringLength(100)]
        public string Ciudad { get; set; }
        [Required]
        public string Especialidad { get; set; }
       


    }
}