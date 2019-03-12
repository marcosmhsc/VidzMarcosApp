using Microsoft.EntityFrameworkCore;
using VidzMarcos.API.Models;

namespace VidzMarcos.API.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
                                                    
       {
          
       } 
       public DbSet<Value> Values { get; set;}
    }

}