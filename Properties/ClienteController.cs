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
        public async Task<IActionResult> ConsultaProductos()
        {
            return Ok(await _context.Producto.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AgregarProducto(Producto producto)
        {
            _context.Producto.Add(producto);
            await _context.SaveChangesAsync();
            return Ok(producto);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarProducto(Producto producto)
        {
            _context.Update(producto);
            await _context.SaveChangesAsync();
            return Ok(producto);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProducto(Producto producto)
        {
            _context.Remove(producto);
            await _context.SaveChangesAsync();
            return Ok(producto);
        }

    }
}
