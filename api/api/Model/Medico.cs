using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Medico
    {
        [Key]
        public long? crm { get; set; }
        public string nome { get; set; }
    }
}
