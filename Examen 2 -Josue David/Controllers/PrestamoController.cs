using Examen_2__Josue_David.DataBase.DTO.Clientes;
using Examen_2__Josue_David.DataBase.DTO.Prestamo;
using Examen_2__Josue_David.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Poo.Dtos.Common;

namespace Examen_2__Josue_David.Controllers
{
    [ApiController]
    [Route("/api/prestamos")]
    public class PrestamoController : ControllerBase
    {
        private readonly IPrestamoService _prestamoService;

        public PrestamoController(IPrestamoService prestamoService)
        {
            this._prestamoService = prestamoService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<PrestamoDto>>> GetOneById(Guid id)
        {
            var response = await _prestamoService.GetByIdAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<PrestamoDto>>> Create(PrestamoCreateDto dto)
        {
            var response = await _prestamoService.CreateAsync(dto);
            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
            });
        }
    }
}
