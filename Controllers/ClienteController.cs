#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Data;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class ClienteController : ControllerBase
    {

        private readonly BibliotecaApiContext _context;
        public ClienteController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultaClientes()
        {
            return Ok(await _context.Cliente.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AgregarCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarCliente(Cliente cliente)
        {
            _context.Update(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCliente(Cliente cliente)
        {
            _context.Remove(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

    }
}
