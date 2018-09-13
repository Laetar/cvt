using Organizer.Server.Models.DataBase.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.DAL.Repositories.Interfaces
{
    public interface IRepository<T>
        where T : class, IEntity
    {
        /// <summary>
        /// Создать новую сущность
        /// </summary>
        /// <param name="entity">Новая сущность</param>
        /// <returns>Id новой сущности</returns>
        int Create(T entity);

        /// <summary>
        /// Удаляет сущность
        /// </summary>
        /// <param name="id">Удаляемая сущность</param>
        /// <returns>Id добавленной сущности сохраняется в dmEntity.Id</returns>
        void Delete(int id);

        /// <summary>
        /// Обновляет сущность
        /// </summary>
        /// <param name="entity">Cущность с новыми данными</param>
        /// <returns></returns>
        void Update(T entity);

        /// <summary>
        /// Возвращает сущность предикату
        /// </summary>
        /// <param name="predicate">predicate</param>
        /// <returns></returns>
        IEnumerable<T> GetList(Func<T, bool> predicate);

        /// <summary>
        /// Возвращает сущность типа T по id
        /// </summary>
        /// <param name="id">id запрашиваемой сущности</param>
        /// <returns></returns>
        T Get(int id);
    }
}
