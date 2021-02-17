using System.Globalization;
using System;
using Xunit;
using static Xunit.Assert;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Headers;

namespace SoftPlayer.IntegrationTest
{
    public class JurosControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
       private readonly WebApplicationFactory<Startup> factory;
       
       public JurosControllerTest(WebApplicationFactory<Startup> factory){
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

            string response = await client.DoGetAsync<string>("calculaJuros/100/5");
            decimal value = decimal.Parse(response, CultureInfo.InvariantCulture);            
            Equal(105.10M, value);
        }
    }
}
