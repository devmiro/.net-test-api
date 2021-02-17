using System.Threading.Tasks;

namespace SoftPlayer.Api.Domain.Services
{
    public interface ITaxaService
    {
         Task<decimal> GetTaxaAsync();
    }
}