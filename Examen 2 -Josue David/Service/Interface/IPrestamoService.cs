using Examen_2__Josue_David.DataBase.DTO.Prestamo;
using Proyecto_Poo.Dtos.Common;

namespace Examen_2__Josue_David.Service.Interface
{
    public interface IPrestamoService
    {
        Task<ResponseDto<PrestamoDto>> CreateAsync(PrestamoCreateDto dto);
        Task<ResponseDto<PrestamoDto>> GetByIdAsync(Guid id);
    }
}
