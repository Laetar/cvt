using Organizer.Server.Models.DataBase.Entities.Interfaces;
using Organizer.Server.Models.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.Models.DataBase.Entities
{
    /// <summary>
    /// Встреча
    /// </summary>
    public class Meeting : IMeeting
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание/Тема
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime? EndDate{ get; set; }

        /// <summary>
        /// Тип заметки
        /// </summary>
        public EntityType Type { get; set; }

        /// <summary>
        /// Место встречи
        /// </summary>
        public string Point { get; set; }

    }
}
