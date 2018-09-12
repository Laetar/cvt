using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.Models.DataBase.Entities.Interfaces
{
    public interface ITemporary
    {
        DateTime EndDate { get; set; }
    }
}
