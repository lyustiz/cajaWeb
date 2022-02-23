using AutoMapper;
using Caja.API.DTO;
using Caja.Core.Entidades;

namespace Caja.API.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            var map = CreateMap<Vendedores, UsuarioDTO>().ReverseMap();
            // ingnore all existing binding of property
            //map.ForAllMembers(opt => opt.Ignore());
            // than map property as following
            map.ForMember(dest => dest.IdVendedor, opt => opt.MapFrom(src => src.IdUsuario));
            map.ForMember(dest => dest.FechaIngreso, opt => opt.MapFrom(src => src.FechaIngreso));


            var map2 = CreateMap<CartonJuego, CartonJuegoDTO>().ReverseMap();
        }
    }
}
