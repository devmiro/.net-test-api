using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using static Xunit.Assert;

namespace SoftPlayer.IntegrationTest
{
    public class TaxaControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
       private readonly WebApplicationFactory<Startup> factory;      
       
        public TaxaControllerTest(WebApplicationFactory<Startup> factory){
           this.factory = factory;
       }

       [Fact]
       public async void TaxaForGetTaxaIsCorrect()
        {
            var client = factory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
                client.DefaultRequestHeaders.Accept.Clear();               

            var response = await client.DoGetAsync<string>("taxaJuros");
            Equal(0.01M, Decimal.Parse(response, CultureInfo.InvariantCulture));
        }
    }
}