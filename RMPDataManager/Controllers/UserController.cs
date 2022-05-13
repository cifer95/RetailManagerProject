using System.Collections.Generic;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using RMPDataManager.Library.DataAccess;
using RMPDataManager.Library.Models;

namespace RMPDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        public List<UserModel> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();

            return data.GetUserById(userId);
        }
    }
}