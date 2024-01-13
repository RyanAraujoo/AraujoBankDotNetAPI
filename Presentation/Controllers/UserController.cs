using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UserController : ControllerBase
    {
            private readonly IUserService _userServiceSingleton;

            public UserController(IUserService userService)
            {
                _userServiceSingleton = userService;
            }

            [HttpPost]
            public IActionResult AdicionarUsuario([FromBody] string nome)
            {
                try
                {
                    _userServiceSingleton.AddUser(nome);
                    return Ok("Usuário adicionado com sucesso!");
                }
                catch (Exception ex)
                {
                    return BadRequest($"Erro ao adicionar usuário: {ex.Message}");
                }
            }

            // Outros métodos do controlador para consultar, atualizar, deletar usuários, etc.
        }
}
