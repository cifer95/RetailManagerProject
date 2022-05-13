using System.Collections.Generic;
using RMPDataManager.Library.Internal.DataAccess;
using RMPDataManager.Library.Models;

namespace RMPDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "RMPData");

            return output;
        }
    }
}