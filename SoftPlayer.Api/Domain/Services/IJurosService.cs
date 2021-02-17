using System.Threading.Tasks;

namespace SoftPlayer.Api.Domain.Services
{
    public interface IJurosService
    {
         Task<decimal> CalculaJurosAsync(decimal valorInicial, decimal tempo);
    }
}