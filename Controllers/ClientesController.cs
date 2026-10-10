using Microsoft.AspNetCore.Mvc;
using PrimerAPI.Models;

namespace PrimerAPI.Controllers
    //Junior Barrios - 7690-25-16187
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : Controller
    {
        private readonly apiContext _context;
        public ClientesController(apiContext ctx)
        {
            _context = ctx;
        }

        [HttpGet("ListarUsuarios")]
        public ActionResult<List<Cliente>> ListarClientes()
        {
            return _context.Clientes.ToList();
        }

        [HttpGet("ObtenerUsuario/{id}")]
        public ActionResult<Cliente> ObtenerUsuario(int id)
        {
            return _context.Clientes.FirstOrDefault(e => e.IdClientes == id);
        }
    }
}
