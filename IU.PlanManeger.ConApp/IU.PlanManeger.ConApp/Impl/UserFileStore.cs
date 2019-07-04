using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU.PlanManeger.ConApp.Models
{
    /// <summary>
    /// Хранилище событий <see cref="User"/>
    /// </summary>
    public class UserFileStore : BaseFileStore<User>, IUserStore
    {
        public IEnumerable<User> GetByName(string username)
        {
            return Entities.Where(
                user => 
                user.Status != UserStatus.Deleted &&
                user.Name.Contains(username));
        }

        public override User Get(Guid uid)
        {
            var user = base.Get(uid);
            if (user?.Status == UserStatus.Deleted)
            {
                return null;
            }
            return user;
        }

        public override void Delete(Guid uid)
        {
            var user = Get(uid);
            if (user != null)
            {
                user.Status = UserStatus.Deleted;
                Update(user);
            }
        }

    }
}
