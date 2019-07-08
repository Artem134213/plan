using System;

namespace IU.PlanManeger.Dll
{
    /// <summary>
    /// Интерфейс сущности
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        Guid Uid { get; set; }
    }
}
