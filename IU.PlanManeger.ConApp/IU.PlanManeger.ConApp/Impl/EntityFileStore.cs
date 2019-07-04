using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace IU.PlanManeger.ConApp.Models
{
    /// <summary>
    /// Хранилище событий <see cref="T"/>
    /// </summary>
    public class BaseFileStore<T> : IStore<T> where T : class, IEntity
    {
        private string fileName = "C:\\{0}.json";

        /// <summary>
        /// ctor
        /// </summary>
        public BaseFileStore()
        {
            entitys = new List<T>();
        }

        public virtual void Init()
        {
            fileName = string.Format(fileName, typeof(T).Name.ToLower());
        }

        /// <summary>
        /// Список событий
        /// </summary>
        private List<T> entitys { get; }

        public IEnumerable<T> Entities => entitys;

        /// <summary>
        /// Добавить событие
        /// </summary>
        /// <param name="evt">Событие</param>
        public virtual void Add(T evt)
        {
            if(evt != null)
            {
                entitys.Add(evt);
            }

        }

        /// <summary>
        /// Получить событие
        /// </summary>
        /// <param name="uid">Id события</param>
        public virtual T Get(Guid uid)
        {
            return entitys.FirstOrDefault(evt => evt.Uid == uid);
        }

        /// <summary>
        /// Обновить событие
        /// </summary>
        /// <param name="evt"></param>
        public virtual void Update(T evt)
        {
            Delete(evt.Uid);
            Add(evt);
        }

        /// <summary>
        /// Удалть событие
        /// </summary>
        /// <param name="evt"></param>
        public virtual void Delete(Guid uid)
        {
            var elem = Get(uid);
            if (elem != null)
            {
                entitys.Remove(elem);
            }
        }
    }
}
