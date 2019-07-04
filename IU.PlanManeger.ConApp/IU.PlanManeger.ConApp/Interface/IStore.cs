using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU.PlanManeger.ConApp.Models
{
    /// <summary>
    /// Интерфейс хранилища
    /// </summary>
    public interface IStore<T> where T : class, IEntity
    {
        /// <summary>
        /// Список сущностей
        /// </summary>
        IEnumerable<T> Entities { get; }

        /// <summary>
        /// evt событие
        /// </summary>
        /// <param name="entity">Событие</param>
        void Add(T entity);

        /// <summary>
        /// Получить событие
        /// </summary>
        /// <param name="uid">Id события</param>
        T Get(Guid uid);

        /// <summary>
        /// Обновить событие
        /// </summary>
        /// <param name="entity">Сущность</param>
        void Update(T entity);

        /// <summary>
        /// Удалть событие
        /// </summary>
        /// <param name="uid">Id сущности</param>
        void Delete(Guid uid);
    }
}
