using SoftPlayer.Api.Domain.Services;
using Xunit;

namespace SoftPlayer.Test.Controllers
{
    public class GitControllerShould
    {
        [Fact]
        public async void CheckGitRepository(){
            var service = new GitService();
            var repository = await service.ShowGitAsync();
            Assert.Equal("https://github.com/devmiro/softplan-test-api", repository);
        }
    }
}