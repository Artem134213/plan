using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IU.PlanManeger.ConApp.Models;

namespace IU.PlanManeger.ConApp
{
    /// <summary>
    /// Интерфейс хранилища
    /// </summary>
    public interface IUserStore : IStore<User>
    {
        /// <summary>
        /// Получить пользователей по имени
        /// </summary>
        /// <param name="username">Имя пользователя</param>
        /// <returns></returns>
        IEnumerable<User> GetByName(string username);
    }
}
