using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU.PlanManeger.ConApp.Models
{
    public class User : IEntity
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
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
        /// Почта
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
        /// Необпределено
        /// </summary>
        Undefined,
        /// <summary>
        /// Мужчина
        /// </summary>
        Men,
        /// <summary>
        /// Женщина
        /// </summary>
        Women
    }
}