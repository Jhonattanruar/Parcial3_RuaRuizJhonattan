using Microsoft.EntityFrameworkCore;
using Parcial3_RuaRuizJhonattan.DAL.Entities;

namespace Parcial3_RuaRuizJhonattan.DAL
{
    public class DataBaseContex : DbContext

    {
        public DataBaseContex(DbContextOptions<DataBaseContex> option) : base(option) 
        {
            
        }

        public DbSet<Tickets> Tickets { get; set; } 
    }
}
