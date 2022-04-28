using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNextSoftMVC.Models
{
    public class Condominio
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Bairro { get; set; }

        [Display(Name = "Área Total Condomínio")]
        public decimal AreaTotalCondominio { get; set; }

        [Display(Name = "Valor IPTU")]
        public decimal ValorIPTU { get; set; }
    }
}
