using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlConnection.Models
{
    public class Usuarios
    {
        [Display(Name = "idUsuarios")]
        [Column("idUsuarios")]
        public int id { get; set; }

        [Display(Name = "nome")]
        [Column("nome")]
        public string nome { get; set; }

        [Display(Name = "sobrenome")]
        [Column("sobrenome")]
        public string sobrenome { get; set; }

        [Display(Name = "email")]
        [Column("email")]
        public string email { get; set; }

        [Display(Name = "senha")]
        [Column("senha")]
        public string senha { get; set; }
    }
}
