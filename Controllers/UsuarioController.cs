using Microsoft.AspNetCore.Mvc;

namespace Christian_Grimberg_58425_Desafio_3.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
	[HttpGet(Name = "GetUsuario")]
	public string GetUsuario()
	{
		return "Prueba";
	}
}
