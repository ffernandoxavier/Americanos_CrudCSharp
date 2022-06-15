using Microsoft.EntityFrameworkCore;
using WebMvcMysql.Models;

namespace WebCrudEst.Data
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
            : base(options) 
        { }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
