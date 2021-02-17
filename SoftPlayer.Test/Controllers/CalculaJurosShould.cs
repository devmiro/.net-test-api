using System.Threading.Tasks;
using SoftPlayer.Api.Domain.Services;
using SoftPlayer.Api.Juros;
using Xunit;

namespace SoftPlayer.Test.Controllers
{    
    public class CalculaJurosShould 
    {
        [Fact]
        public async Task ReturnCalculaJurosResult(){
            var service = new JurosService();
            var juros = await service.CalculaJurosAsync(100, 5);
            Assert.Equal(105.10M, juros, 2);            
        }        
    }
}