using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.Models.DataBase.Entities.Interfaces
{
    public interface IMeeting : 
        IEntity, 
        ITemporary
    {
        string Point { get; set; }
    }
}
