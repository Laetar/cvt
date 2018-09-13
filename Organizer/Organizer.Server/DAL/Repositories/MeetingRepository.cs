using Organizer.Server.DAL.Attributes;
using Organizer.Server.DAL.Repositories.Base;
using Organizer.Server.DAL.Repositories.Interfaces;
using Organizer.Server.Models.DataBase.DBContext;
using Organizer.Server.Models.DataBase.Entities;
using Organizer.Server.Models.DataBase.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.DAL.Repositories
{
    [RepositoryService]
    public class MeetingRepository : BaseRepository<IMeeting>, IMeetingRepository
    {
        public MeetingRepository(ApplicationContext db)
            :base(db)
        {
        }
    }
}
