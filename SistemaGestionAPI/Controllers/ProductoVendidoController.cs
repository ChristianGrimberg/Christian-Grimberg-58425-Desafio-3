using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionEntities;

namespace Christian_Grimberg_58425_Desafio_3;

[ApiController]
[Route("api/[controller]")]
public class ProductoVendidoController : ControllerBase
{
  [HttpGet(Name = "ObtenerProductosVendidos")]
  public IEnumerable<ProductoVendido> ObtenerProductoVendido()
  {
    return ProductoVendidoBussiness.ListarProductosVendidos(Connection.DatabaseConnection);
  }
}