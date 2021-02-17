using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoftPlayer.Api.Domain.Services;
using System;
using System.Threading.Tasks;


namespace SoftPlayer.Api.Controllers
{
    public class GitController : ControllerBase
    {
        private readonly ILogger<GitController> _logger;

        private readonly IGitService _service;

        public GitController(ILogger<GitController> logger, IGitService service){
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [Route("showmethecode")]
        public async Task<ActionResult<string>> ShowGit() =>
         Ok(await _service.ShowGitAsync());
        
    }       
    
}