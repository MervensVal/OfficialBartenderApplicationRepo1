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
        public DbSet<Order> Orders { get; set; }

    }
}
//----------Notes--------------
/*The DbContext class is an integral part of Entity Framework.An instance of DbContext represents
 * a session with the database which can be used to query and save instances of your entities to a database.
 * DbContext in EF Core allows us to perform following tasks:

Manage database connection
Configure model & relationship
Querying database
Saving data to the database
Configure change tracking
Caching
Transaction management*/

