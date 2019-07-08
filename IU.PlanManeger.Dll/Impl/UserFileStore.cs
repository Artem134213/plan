﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace IU.PlanManeger.Dll.Models
{
    /// <summary>
    /// Хранилище событий <see cref="User"/>
    /// </summary>
    public class UserFileStore : BaseFileStore<User>, IUserStore
    {
        /// <inheritdoc/>
        public IEnumerable<User> GetByName(string username)
        {
            return Entities.Where(
                user =>
                user.Status != UserStatus.Deleted &&
                user.Name.Contains(username)
            );
        }

        /// <inheritdoc/>
        public override User Get(Guid uid)
        {
            var user = base.Get(uid);
            if (user?.Status == UserStatus.Deleted)
            {
                return null;
            }
            return user;
        }

        /// <inheritdoc/>
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
