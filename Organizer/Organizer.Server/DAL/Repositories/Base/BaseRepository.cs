using Organizer.Server.DAL.Repositories.Interfaces;
using Organizer.Server.Models.DataBase.DBContext;
using Organizer.Server.Models.DataBase.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Organizer.Server.DAL.Repositories.Base
{
    public abstract class BaseRepository<TE> : IRepository<TE>
        where TE : class, IEntity
    {
        protected ApplicationContext _db;

        public BaseRepository(ApplicationContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Создать новую сущность
        /// </summary>
        /// <param name="entity">Новая сущность</param>
        /// <returns>Id новой сущности</returns>
        public virtual int Create(TE entity)
        {
            _db.Add(entity);
            _db.SaveChanges();

            return entity.Id;
        }

        /// <summary>
        /// Удаляет сущность
        /// </summary>
        /// <param name="id">Удаляемая сущность</param>
        /// <returns>Id добавленной сущности сохраняется в dmEntity.Id</returns>
        public virtual void Delete(int id)
        {
            var dbEntry = _db.Find<TE>(id);

            if (dbEntry == null)
            {
                throw new ArgumentNullException(string.Format("{0} with id = {1}", typeof(TE), id));
            }

            _db.Remove(dbEntry);
            _db.SaveChanges();
        }

        /// <summary>
        /// Обновляет сущность
        /// </summary>
        /// <param name="entity">Cущность с новыми данными</param>
        /// <returns></returns>
        public void Update(TE entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }

        /// <summary>
        /// Возвращает сущность предикату
        /// </summary>
        /// <param name="predicate">predicate</param>
        /// <returns></returns>
        public IEnumerable<TE> GetList(Func<TE, bool> predicate)
        {
            var dbentitylist = _db.Set<TE>().Where(predicate);

            return dbentitylist;
        }

        /// <summary>
        /// Возвращает сущность типа T по id
        /// </summary>
        /// <param name="id">id запрашиваемой сущности</param>
        /// <returns></returns>
        public TE Get(int id)
        {
            return _db.Find<TE>(id);
        }
    }
}
