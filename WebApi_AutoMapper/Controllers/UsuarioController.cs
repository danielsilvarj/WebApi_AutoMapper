using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_AutoMapper.Models;
using WebApi_AutoMapper.ModelsDTO;

namespace WebApi_AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly Usuario _usuario;

        public UsuarioController(IMapper mapper)
        {
            _mapper = mapper;
            _usuario = new Usuario()
            {
                Nome = "Daniel",
                Sobrenome = "Silva",
                Idade = 30,
                Sexo = "Masculino",
                Endereco = new Endereco()
                {
                    Cidade = "Rio de janeiro",
                    Numero = 10,
                    Estado = "RJ",
                    Cep = "123456"
                }

            };
        }

        [HttpGet]
        [Route("usuario")]
        public ActionResult<UsuarioDTO> GetUsuario()
        {
            return _mapper.Map<UsuarioDTO>(_usuario);
        }
    }
}