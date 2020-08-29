using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IS_BartenderAppProject_MV.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [Column(TypeName="nvarchar(100)")]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [DisplayName("Table Number")]
        public int TableNum { get; set; }

        [Required]
        [DisplayName("Drink Name")]
        public string DrinkName { get; set; }

        [Required]
        public int Quantity { get; set; }


    }
}
