using Microsoft.EntityFrameworkCore;


namespace api.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext()
        {

        }
        public SQLContext(DbContextOptions<SQLContext> options) : base (options){}


        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Solicitacoes> Solicitacoes { get; set; }
        public DbSet<Frequencias> Frequencias { get; set; }
    }
}
