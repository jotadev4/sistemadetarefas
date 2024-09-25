using gerenciamentodetarefas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gerenciamentodetarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet] // buscar os usuarios
        public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return Ok(); // vai retornar pra API
        }
    }
}
