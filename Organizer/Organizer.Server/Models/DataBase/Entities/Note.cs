using Organizer.Server.Models.DataBase.Entities.Interfaces;
using Organizer.Server.Models.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.Models.DataBase.Entities
{
    /// <summary>
    /// Заметка
    /// </summary>
    public class Note : INote
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
        /// Тип
        /// </summary>
        public EntityType Type { get; set; }

    }
}
