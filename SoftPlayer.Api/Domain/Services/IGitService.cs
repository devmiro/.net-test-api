using System.Threading.Tasks;

namespace SoftPlayer.Api.Domain.Services
{
    public interface IGitService
    {
         Task<string> ShowGitAsync();
    }
}