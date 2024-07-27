using Examen_2__Josue_David.Entity;
using Microsoft.EntityFrameworkCore;
using Proyecto_Poo.Service.Interface;

namespace Examen_2__Josue_David.DataBase.Context
{
    public class GestionDeTiendaDbContext : DbContext
    {
        private readonly IAuthService _authService;

        public GestionDeTiendaDbContext(DbContextOptions<GestionDeTiendaDbContext> options, IAuthService authService)
            : base(options)
        {
            _authService = authService;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // Procesar entidades de tipo PrestamoEntity
            var entries = ChangeTracker.Entries().Where(e => e.Entity is PrestamoEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var entity = entry.Entity as PrestamoEntity;
                if (entity != null && entry.State == EntityState.Added)
                {
                    entity.LoanDate = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<PrestamoEntity> PlandePagos { get; set; }
    }
}
