using AutoMapper;
using Examen_2__Josue_David.DataBase.Context;
using Examen_2__Josue_David.DataBase.DTO.Prestamo;
using Examen_2__Josue_David.Entity;
using Examen_2__Josue_David.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Proyecto_Poo.Dtos.Common;
using Proyecto_Poo.Service.Interface;

namespace Examen_2__Josue_David.Service
{
    public class PrestamoService : IPrestamoService
    {
        private readonly GestionDeTiendaDbContext _context;
        private readonly ILogger<PrestamoService> _logger;
        private readonly IMapper _mapper;

        public PrestamoService(GestionDeTiendaDbContext context, ILogger<PrestamoService> logger, IMapper mapper)
        {
            this._context = context;
            this._logger = logger;
            this._mapper = mapper;
        }

        public async Task<ResponseDto<PrestamoDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var prestamoEntity = await _context.PlandePagos.FirstOrDefaultAsync(e => e.LoanId == id);
                {
                    if (prestamoEntity == null)
                    {
                        return new ResponseDto<PrestamoDto>
                        {
                            StatusCode = 404,
                            Status = false,
                            Message = $"El prestamo {id} no fue encontrado"

                        };

                    }
                    var prestamoDto = _mapper.Map<PrestamoDto>(prestamoEntity);
                    return new ResponseDto<PrestamoDto>
                    {
                        StatusCode = 200,
                        Status = true,
                        Message = "Prestamo Encontrado",
                        Data = prestamoDto,

                    };
                };
                 

            }
                catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el prestamo");
                return new ResponseDto<PrestamoDto>
                {
                    StatusCode = 500,
                    Status = false,
                    Message = $"Se produjo un error al obtener el prestamo"

                };
            }

    }

        public async Task<ResponseDto<PrestamoDto>> CreateAsync(PrestamoCreateDto dto)
        {
            try
            {
                var clienteExists = await _context.Clientes.AnyAsync(c => c.ClienteId == dto.ClienteId);
                if (!clienteExists)
                {
                    return new ResponseDto<PrestamoDto>
                    {
                        StatusCode = 404,
                        Status = false,
                        Message = "El cliente no está registrado",
                        Data = null
                    };
                }

                var prestamoEntity = _mapper.Map<PrestamoEntity>(dto);

                prestamoEntity.LoanId = Guid.NewGuid();

                _context.PlandePagos.Add(prestamoEntity);

                await _context.SaveChangesAsync();

                var prestamoDto = _mapper.Map<PrestamoDto>(prestamoEntity);

                return new ResponseDto<PrestamoDto>
                {
                    StatusCode = 201,
                    Status = true,
                    Message = "El préstamo ha sido creado correctamente",
                    Data = prestamoDto
                };
            }
            catch (DbUpdateException dbEx)
            {
                _logger.LogError(dbEx, "Error al crear el préstamo en la base de datos");
                return new ResponseDto<PrestamoDto>
                {
                    StatusCode = 500,
                    Status = false,
                    Message = "Error al crear el préstamo en la base de datos"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear el préstamo");
                return new ResponseDto<PrestamoDto>
                {
                    StatusCode = 500,
                    Status = false,
                    Message = "Se produjo un error al crear el préstamo"
                };
            }
        }

    }
}