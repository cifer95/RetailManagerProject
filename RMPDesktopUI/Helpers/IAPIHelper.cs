using System.Threading.Tasks;
using RMPDesktopUI.Models;

namespace RMPDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}