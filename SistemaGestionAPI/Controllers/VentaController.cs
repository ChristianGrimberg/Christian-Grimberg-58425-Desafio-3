using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionEntities;

namespace Christian_Grimberg_58425_Desafio_3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VentaController : ControllerBase
{
  [HttpPost(Name = "CargarVenta")]
  public void CargarVenta(Venta venta)
  {
    VentaBussiness.CrearVenta(Connection.DatabaseConnection, venta);
  }
}