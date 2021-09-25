using Microsoft.AspNetCore.Http;
using X.PagedList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedeBebidas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeBebidas.Controllers
{
    public class ClientesController : Controller
    {
        private readonly redebebidasContext _context;

        public ClientesController(redebebidasContext context)
        {
            _context = context;
        }

        // GET: ClientesController
        // Clientes Index
        public async Task<IActionResult> Index(int? pagina)
        {
            const int itensPorPagina = 10;
            int numeroPagina = (pagina ?? 1);
            var clientes = await _context.Clientes.ToPagedListAsync(numeroPagina,itensPorPagina);
            return View(clientes);
        }

        // GET: ClientesController/Details/5
        // Clientes Details
        public async Task<IActionResult> Details(int? clienteId)
        {
            if (clienteId == null)
            {
                return NotFound();
            }
            var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.ClienteId == clienteId);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // GET: ClientesController/Create
        //AddOrEdit Get Method
        public async Task<IActionResult> AddOrEdit(int? clienteId)
        {
            ViewBag.PageName = clienteId == null ? "Cadastrar cliente" : "Editar cliente";
            ViewBag.IsEdit = clienteId == null ? false : true;
            if (clienteId == null)
            {
                return View();
            }
            else
            {
                var cliente = await _context.Clientes.FindAsync(clienteId);

                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }
        }

        //AddOrEdit Post Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int clienteId, [Bind("ClienteId,Nome,Email,Cpf," +
                                                                        "TelefoneTipo,TelefoneNumero," +
                                                                        "EnderecoTipo,Cep,Estado,Cidade," +
                                                                        "Bairro,Logradouro,EnderecoNumero")] Cliente clienteData)
        {
            bool ClienteExiste = false;

            Cliente cliente = await _context.Clientes.FindAsync(clienteId);

            if (cliente != null)
            {
                ClienteExiste = true;
            }
            else
            {
                cliente = new Cliente();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cliente.Nome = clienteData.Nome;
                    cliente.Email = clienteData.Email;
                    cliente.Cpf = clienteData.Cpf;
                    cliente.TelefoneTipo = clienteData.TelefoneTipo;
                    cliente.TelefoneNumero = clienteData.TelefoneNumero;
                    cliente.EnderecoTipo = clienteData.EnderecoTipo;
                    cliente.Cep = clienteData.Cep;
                    cliente.Estado = clienteData.Estado;
                    cliente.Cidade = clienteData.Cidade;
                    cliente.Bairro = clienteData.Bairro;
                    cliente.Logradouro = clienteData.Logradouro;
                    cliente.EnderecoNumero = clienteData.EnderecoNumero;

                    if (ClienteExiste)
                    {
                        _context.Update(cliente);
                    }
                    else
                    {
                        _context.Add(cliente);
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(clienteData);
        }

        public async Task<IActionResult> Delete(int? clienteId)
        {
            if (clienteId == null)
            {
                return NotFound();
            }
            var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.ClienteId == clienteId);

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int clienteId)
        {
            var cliente = await _context.Clientes.FindAsync(clienteId);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
