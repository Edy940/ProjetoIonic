using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using todo.Model;
using todo.Sever;

//este controlador fornece uma rota para obter a lista de "todos" e utiliza um serviço para acessar esses dados. Ele retorna a lista de "todos" como uma resposta HTTP.
namespace todo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaTodoHomologController : ControllerBase
    {
        [HttpGet]        
        [ProducesResponseType((200), Type = typeof(List<ListaTodoHomologModel>))]
        [ProducesResponseType(203)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<dynamic>> Get()
        {
            try
            {
                var listaTodoHomologServe = new ListaTodoHomologServe();
                return listaTodoHomologServe.ListaTodoHomolog();

            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(List<ListaTodoHomologModel>))]
        [ProducesResponseType(203)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<dynamic>> Get(int id)
        {
            try
            {
                var listaTodoHomologServe = new ListaTodoHomologServe();
                return listaTodoHomologServe.ListaTodoHomolog(id);

            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}