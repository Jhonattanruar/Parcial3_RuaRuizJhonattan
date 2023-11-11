using System.ComponentModel.DataAnnotations;

namespace Parcial3_RuaRuizJhonattan.DAL.Entities
{
    public class Tickets : Entity
    {

        [Display(Name = "Porteria de ingreso")]
        [Required]
        public String EntranceGate { get; set; }

    }
}
