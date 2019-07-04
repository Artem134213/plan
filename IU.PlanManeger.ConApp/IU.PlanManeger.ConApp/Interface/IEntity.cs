using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU.PlanManeger.ConApp
{
    /// <summary>
    /// интерфейс сущности
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        Guid Uid { get; set; }
    }
}
