using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SoftPlayer.Api.Models;
using SoftPlayer.Api.Extensions;
using System.Net.Http.Headers;

namespace SoftPlayer.Api.Domain.Services
{
    public class GitService : IGitService
    {
        public async Task<string> ShowGitAsync()
        {
            using(HttpClient client = new HttpClient()){
                client.BaseAddress = new Uri("https://api.github.com");
                client.DefaultRequestHeaders.Add("User-Agent", "request");                  
                var server = await client.DoGetAsync<Server>("repos/devmiro/softplan-test-api")
                    .ConfigureAwait(false);                
                return server.Repository;
            }
        }
    }
}