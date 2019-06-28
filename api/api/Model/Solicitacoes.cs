using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Solicitacoes
    {
        [Key]
        public long id { get; set; }
        public long cartao { get; set; }
        public long crm { get; set; }
        public DateTime dtAtendimento { set; get; }
    }
}
