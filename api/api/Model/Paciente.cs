using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Paciente
    {
        [Key]
        public long cartao { get; set; }
        public string nome { get; set; }
        public DateTime dtNascimento { get; set; }
    }
}
