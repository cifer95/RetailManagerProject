using System.Threading.Tasks;
using RMPDesktopUI.Models;

namespace RMPDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}