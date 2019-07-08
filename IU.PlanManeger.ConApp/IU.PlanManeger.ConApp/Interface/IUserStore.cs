using System.Collections.Generic;
using IU.PlanManager.ConApp.Models;

namespace IU.PlanManager.ConApp
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
        IEnumerable<User> GetByName(string username);
    }
}
