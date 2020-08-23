using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IS_BartenderAppProject_MV.Models
{
    public class Drink
    {
        [Key]
        public int DrinkId { get; set; }

        [Required (ErrorMessage = "This field is required")]
        [Column(TypeName ="nvarchar(100)")]
        [DisplayName("Drink")]
        public string DrinkName { get; set; }

        
        [DisplayName("Cost")]
        public double DrinkCost { get; set; }

  

    }
}

