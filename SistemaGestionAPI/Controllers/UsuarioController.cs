using System.Data.SqlClient;

using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionEntities;

namespace Christian_Grimberg_58425_Desafio_3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
  [HttpGet(Name = "ObtenerUsuarios")]
  public IEnumerable<Usuario> ObtenerUsuarios()
  {
    return UsuarioBussiness.ListarUsuarios(Connection.DatabaseConnection).ToArray();
  }

  [HttpGet("{id}")]
  public IActionResult ObtenerUsuarioPorId(int id)
  {
    return Ok(UsuarioBussiness.ObtenerUsuario(Connection.DatabaseConnection, id));
  }

  [HttpDelete(Name = "EliminarUsuario")]
  public void EliminarUsuario([FromBody] Usuario usuario)
  {
    UsuarioBussiness.EliminarUsuario(Connection.DatabaseConnection, usuario);
  }

  [HttpPut(Name = "ModificarUsuario")]
  public void ModificarUsuario([FromBody] Usuario usuario)
  {
    UsuarioBussiness.ModificarUsuario(Connection.DatabaseConnection, usuario);
  }

  [HttpPost(Name = "NuevoUsuario")]
  public void NuevoUsuario([FromBody] Usuario usuario)
  {
    UsuarioBussiness.CrearUsuario(Connection.DatabaseConnection, usuario);
  }
}