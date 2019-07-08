using System.Collections.Generic;
using IU.PlanManeger.Dll.Models;

namespace IU.PlanManeger.Dll
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
