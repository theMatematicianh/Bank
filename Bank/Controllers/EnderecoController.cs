using Bank.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        public readonly IEnderecoService _enerecoService;

        public EnderecoController(IEnderecoService enerecoService)
        {
            _enerecoService = enerecoService;
        }
    }
}
