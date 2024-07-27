using AutoMapper;
using Examen_2__Josue_David.DataBase.DTO.Clientes;
using Examen_2__Josue_David.DataBase.DTO.Prestamo;
using Examen_2__Josue_David.Entity;


namespace Proyecto_Poo.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            MapsForClientes();
            MapsForPrestamos();
            
        }


        private void MapsForClientes()
        {
            CreateMap<ClienteEntity, ClienteDto>(); 
            CreateMap<ClienteEntity, ClienteCreate>();
        }

        private void MapsForPrestamos()
        {
            CreateMap<PrestamoEntity, PrestamoDto>();
            CreateMap<PrestamoEntity, PrestamoCreateDto>();
        }
    }

    
}

