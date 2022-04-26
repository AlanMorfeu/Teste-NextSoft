using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNextSoftMVC.Models
{
    public class Familia
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [ForeignKey("Condominio")]
        [Display(Name = "Condomínio")]
        public int Id_Condominio { get; set; }
        public virtual Condominio Condominio { get; set; }
        public int Apto { get; set; }

        
    }
}
