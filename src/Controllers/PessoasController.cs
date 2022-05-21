using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Multitenant.Data;
using Multitenant.Models;

namespace Multitenant.Controllers
{

    [ApiController]
    [Route("{tenant}/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly MultitenantContext _multitenantContext;
        public PessoasController(MultitenantContext multitenantContext)
        {
            _multitenantContext = multitenantContext;
        }


        [HttpGet]

        public async Task<IActionResult> GetPessoas()
        {
            var pessoas = await _multitenantContext.Pessoas.ToListAsync();

            return Ok(new
            {
                Banco = _multitenantContext.Database.GetConnectionString().Split(";")[1].Replace("Database=", ""),
                Pessoas = pessoas
            });
        }
    }
}
