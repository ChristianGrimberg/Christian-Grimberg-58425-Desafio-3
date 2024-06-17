using System.Data.SqlClient;

using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionData;

using SistemaGestionEntities;

namespace Christian_Grimberg_58425_Desafio_3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
  [HttpGet]
  public IEnumerable<Usuario> GetUsuarios()
  {
    return UsuarioBussiness.ListarUsuarios(Connection.DatabaseConnection).ToArray();
  }
}