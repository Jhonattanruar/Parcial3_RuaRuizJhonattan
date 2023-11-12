using System.ComponentModel.DataAnnotations;

namespace Parcial3_RuaRuizJhonattan.DAL.Entities
{
    public class Tickets : Entity
    {

        [Display(Name = "Porteria de ingreso")]
        
        public String? EntranceGate  { get; set; }
       

    }
}
