using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoftPlayer.Api.Domain.Services;

namespace SoftPlayer.Api.Taxa
{
    [ApiController]
    [Route("")]
    public class TaxaController : ControllerBase
    {
        private readonly ILogger<TaxaController> _logger;
        private readonly ITaxaService _service;

        public TaxaController(ILogger<TaxaController> logger, ITaxaService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Route("taxaJuros")]
        public async Task<IActionResult> GetTaxa() => Ok(await _service.GetTaxaAsync().ConfigureAwait(false));
    }
}