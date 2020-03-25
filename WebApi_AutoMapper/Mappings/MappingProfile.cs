using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_AutoMapper.Models;
using WebApi_AutoMapper.ModelsDTO;

namespace WebApi_AutoMapper.Mappings
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>()
                .ForMember(dest => dest.Cidade,
                opts => opts.MapFrom(src => src.Endereco.Cidade)).ReverseMap();
        }
    }
}
