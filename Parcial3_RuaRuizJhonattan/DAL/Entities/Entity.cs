using System.ComponentModel.DataAnnotations;

namespace Parcial3_RuaRuizJhonattan.DAL.Entities
{
    public class Entity
    {
        [Required]
        public Guid Id { get; set; }
        [Display (Name = "Fecha de uso de la boleta")]
        public DateTime UseDate { get; set; }

        [Display(Name = "Boleta en Usada SI/NO")]
        public Boolean IsUsed { get; set; } 

             


    }
}
