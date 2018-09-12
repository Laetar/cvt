using Organizer.Server.Models.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.Models.DataBase.Entities.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime StartTime { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        EntityType Type { get; set; } 
    }
}
