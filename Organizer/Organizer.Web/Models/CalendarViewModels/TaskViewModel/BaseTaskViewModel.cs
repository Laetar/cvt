using Organizer.Web.Models.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Organizer.Web.Models.CalendarViewModels.TaskViewModels
{
    public class BaseTaskViewModel
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "Название")]
        public string Name { get; set; }

        /// <summary>
        /// Описание/Тема
        /// </summary>
        [StringLength(300)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        /// <summary>
        /// Время начала
        /// </summary>
        [Required]
        [Display(Name = "Время записи")]
        [StartTimeAttribute(ErrorMessage = "{0} должно быть между {1} и {2}.")]
        public DateTime StartTime { get; set; }

    }
}
