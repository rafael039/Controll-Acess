using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control_Acess.Models
{
    [Table("usuario")]
    public class UsuarioModel
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }
        public int idade { get; set; }
    }
}
