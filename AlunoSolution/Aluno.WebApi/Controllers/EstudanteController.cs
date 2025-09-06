using Estudante.Dominio;
using Estudante.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estudante.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudanteController : ControllerBase
    {
        private readonly IEstudanteServico _servico;

        public EstudanteController(IEstudanteServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _servico.Adicionar(aluno);
            return Ok("aluno cadastrado com sucesso!");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servico.Listar());
        }
    }
}
