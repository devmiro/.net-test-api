using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoftPlayer.Api.Domain.Services;

namespace SoftPlayer.Api.Juros
{
    [ApiController]
    [Route("")]
    public class JurosController : ControllerBase
    {
        private readonly ILogger<JurosController> _logger;
        private readonly IJurosService _service;
        private readonly ITaxaService _taxaService;

        public JurosController(ILogger<JurosController> logger, IJurosService service, ITaxaService taxaService)
        {
            _taxaService = taxaService;
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Route("calculaJuros/{valorInicial}/{tempo}")]
        public async Task<ActionResult<decimal>> CalculaJuros(decimal valorInicial, decimal tempo) 
        => Ok(await _service.CalculaJurosAsync(valorInicial, tempo));
    }
}