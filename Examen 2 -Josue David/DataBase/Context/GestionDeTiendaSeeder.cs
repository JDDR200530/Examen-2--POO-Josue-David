using Examen_2__Josue_David.Entity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace Examen_2__Josue_David.DataBase.Context
{
    public class GestionDeTiendaSeeder
    {
        public static async Task LoadDataAsync(GestionDeTiendaDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                await LoadClienteAsync(context, loggerFactory);
                await LoadPrestamoAsync(context, loggerFactory);
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<GestionDeTiendaSeeder>();
                logger.LogError(e, "Error inicializando la data del API.");
            }
        }

        public static async Task LoadClienteAsync(GestionDeTiendaDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                var jsonFilePath = "SeedData/Cliente.json";
                var jsonContent = await File.ReadAllTextAsync(jsonFilePath);
                var clientes = JsonConvert.DeserializeObject<List<ClienteEntity>>(jsonContent);

                if (!await context.Clientes.AnyAsync())
                {
                    if (clientes != null)
                    {
                        await context.Clientes.AddRangeAsync(clientes);
                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<GestionDeTiendaSeeder>();
                logger.LogError(e, "Error al ejecutar el Seed de Clientes.");
            }
        }

        public static async Task LoadPrestamoAsync(GestionDeTiendaDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                var jsonFilePath = "SeedData/Prestamos.json";
                var jsonContent = await File.ReadAllTextAsync(jsonFilePath);
                var prestamos = JsonConvert.DeserializeObject<List<PrestamoEntity>>(jsonContent);

                if (!await context.PlandePagos.AnyAsync())
                {
                    if (prestamos != null)
                    {
                        foreach (var prestamo in prestamos)
                        {
                            prestamo.LoanDate = DateTime.Now;
                        }

                        await context.PlandePagos.AddRangeAsync(prestamos);
                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<GestionDeTiendaSeeder>();
                logger.LogError(e, "Error al ejecutar el Seed de Préstamos.");
            }
        }
    }
}
