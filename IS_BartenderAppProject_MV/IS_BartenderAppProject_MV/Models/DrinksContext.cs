using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS_BartenderAppProject_MV.Models
{
    public class DrinksContext : DbContext
    {
        public DrinksContext(DbContextOptions<DrinksContext> options) : base(options)
        {

        }

        public  DbSet<Drink> Drinks{ get; set; }

    }
}
