using System;

namespace IU.PlanManager.ConApp.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User : IEntity
    {
        /// <inheritdoc/>
        public Guid Uid { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Фото
        /// </summary>
        public string Photo { get; set; }
        
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Принимать приглашения
        /// </summary>
        public bool AllowInvites { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Статус пользователя
        /// </summary>
        public UserStatus Status { get; set; }
    }

    /// <summary>
    /// Статус пользователя
    /// </summary>
    public enum UserStatus
    {
        Active,
        Deleted
    }

    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Неопределено
        /// </summary>
        Undefined,
        /// <summary>
        /// Мужской
        /// </summary>
        Man,
        /// <summary>
        /// Женский
        /// </summary>
        Woman,

    }
}
