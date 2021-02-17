using System;
using System.Globalization;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Testing;
using SoftPlayer.Api.Models;
using Xunit;
using static Xunit.Assert;

namespace SoftPlayer.IntegrationTest.Controllers
{
    public class GitControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
       private readonly WebApplicationFactory<Startup> factory;
       
       public GitControllerTest(WebApplicationFactory<Startup> factory){
           this.factory = factory;
       }

       [Fact]
       public async void JurosForCalculaJurosIsCorrect()
        {
            var client = factory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
                client.DefaultRequestHeaders.Accept.Clear();                
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.DoGetAsync<string>("showmethecode")
                .ConfigureAwait(false);
            
            Equal("https://github.com/devmiro/softplan-test-api", response);
        }
    }
}