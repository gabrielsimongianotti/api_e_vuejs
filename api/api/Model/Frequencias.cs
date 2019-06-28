using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Frequencias
    {
        [Key]
        public long id { get; set; }
        public long solicitacoes { get; set; }
        public DateTime dtVerificacao { set; get; }
        public long batimentoCardiaco { get; set; }
        public long pressaoMaximo { get; set; }
        public long pressaoMinimo { get; set; }
        public string sintoma { set; get; }
        public string medicamento { set; get; }
    }
}
