using Microsoft.EntityFrameworkCore;
using ModuloAPI.Models;

namespace ModuloAPI.Context
{
    public class OrganizadorContext : DbContext
    {
                public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
    }




