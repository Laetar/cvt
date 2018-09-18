using Organizer.Server.DAL.Attributes;
using Organizer.Server.DAL.Repositories.Base;
using Organizer.Server.DAL.Repositories.Interfaces;
using Organizer.Server.Models.DataBase.DBContext;
using Organizer.Server.Models.DataBase.Entities;

namespace Organizer.Server.DAL.Repositories
{
    [RepositoryService]
    public class TaskRepository : BaseRepository<Task>, ITaskRepository
    {
        public TaskRepository(ApplicationContext db)
            :base(db)
        {
        }
    }
}
