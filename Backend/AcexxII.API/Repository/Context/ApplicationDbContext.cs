using AcexxII.API.Models;
using Microsoft.EntityFrameworkCore;

// classe de conexão com o banco 

namespace AcexxII.API.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbSet<UserPaciente> Pacientes { get; set; }

    }
}
