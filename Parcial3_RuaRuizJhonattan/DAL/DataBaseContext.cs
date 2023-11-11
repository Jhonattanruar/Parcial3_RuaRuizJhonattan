using Microsoft.EntityFrameworkCore;
using Parcial3_RuaRuizJhonattan.DAL.Entities;

namespace Parcial3_RuaRuizJhonattan.DAL
{
    public class DataBaseContext : DbContext

    {
        public DataBaseContext(DbContextOptions<DataBaseContext> option) : base(option) 
        {
            
        }

        public DbSet<Tickets> Tickets { get; set; } 
    }
}
