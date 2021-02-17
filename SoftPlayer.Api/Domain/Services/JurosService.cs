using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SoftPlayer.Api.Domain.Services
{
    public class JurosService : IJurosService
    {
        public async Task<decimal> CalculaJurosAsync(decimal valorInicial, decimal tempo)
        {
            var taxa = await GetTaxaJurosAsync();
            return decimal.Round(valorInicial * (decimal)Math.Pow((1 + (double)taxa), (double)tempo), 2);
        }

        static async Task<decimal> GetTaxaJurosAsync()
        {
            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using (HttpClient client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri("https://localhost:5001/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                decimal taxa = 0;
                HttpResponseMessage response = await client.GetAsync(SoftPlayer.Api.Utils.Utils.TaxaPath);

                if (response.IsSuccessStatusCode)
                {
                    taxa = await response.Content.ReadAsAsync<decimal>();
                }
                return taxa;
            }
        }
    }
}