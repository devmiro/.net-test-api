using System.Threading.Tasks;

namespace SoftPlayer.Api.Domain.Services
{
    public class TaxaService : ITaxaService
    {
        public TaxaService()
        {
        }

        public async Task<decimal> GetTaxaAsync()
        {
            return await Task.Run(() => 0.01M);
        }
    }
}