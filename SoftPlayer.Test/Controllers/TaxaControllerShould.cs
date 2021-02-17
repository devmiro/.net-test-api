using System.Threading.Tasks;
using SoftPlayer.Api.Domain.Services;
using Xunit;

namespace SoftPlayer.Test.Controllers
{
    public class TaxaControllerShould
    {
        [Fact]
        public async Task CheckTaxa(){
            var service = new TaxaService();
            var taxa = await service.GetTaxaAsync();
            Assert.Equal(0.01M, taxa);
        }
    }
}