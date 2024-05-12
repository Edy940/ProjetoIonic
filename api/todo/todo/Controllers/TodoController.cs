using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todo.Model;
using todo.Sever;

namespace todo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : Controller
    {
        [HttpPost]
        [Route("InsertTodoHomolog")]
        [ProducesResponseType((200), Type = typeof(List<ListaTodoHomologModel>))]
        [ProducesResponseType(203)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<dynamic>> InsertTodoHomolog([FromBody] ListaTodoHomologModel atualizaTemaUsuarioVO)
        {
            try
            {
                var listaTodoHomologServe = new ListaTodoHomologServe();
                var retono = listaTodoHomologServe.InsertTodoHomolog(atualizaTemaUsuarioVO);
                if (retono == "0")
                {
                    return StatusCode(200, "Gravado com Sucesso");
                }
                else
                {
                    return retono;
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpPut]
        [Route("AtualizaTodoHomolog")]
        [ProducesResponseType((200), Type = typeof(List<ListaTodoHomologModel>))]
        [ProducesResponseType(203)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<dynamic>> AtualizaTodoHomolog([FromBody] ListaTodoHomologModel atualizaTemaUsuarioVO)
        {
            try
            {
                var listaTodoHomologServe = new ListaTodoHomologServe();
                var retono = listaTodoHomologServe.AtualizaTodoHomolog(atualizaTemaUsuarioVO);
                if (retono == "0")
                {
                    return StatusCode(200, "Gravado com Sucesso");
                }
                else
                {
                    return retono;
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpDelete("{id}")]
              
        [ProducesResponseType(203)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<dynamic>> DTodoHomolog(int id)
        {
            try
            {
                var listaTodoHomologServe = new ListaTodoHomologServe();
                var retono = listaTodoHomologServe.deleteTodoHomolog(id);
                if (retono == "0")
                {
                    return StatusCode(200, "Deletado com Sucesso");
                }
                else
                {
                    return retono;
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
