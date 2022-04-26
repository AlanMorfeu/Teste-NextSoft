using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNextSoftMVC.Models
{
    public class Morador
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Familia")]
        [Display(Name = "Família")]
        public int Id_Familia { get; set; }
        public virtual Familia Familia { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        
    }
}
