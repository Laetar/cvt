using Microsoft.Extensions.Logging;
using Organizer.Server.Models.DataBase.DBContext;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace Organizer.Web.SeedData
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            try
            {
                //Вызов миграции, если были изменения в БД между обновлениями, разкоментировать
                using (var appContext = serviceProvider.GetService<ApplicationContext>())
                {
                    appContext.Database.Migrate();
                }
            }
            catch (Exception e)
            {
                var _logger = serviceProvider.GetService<ILogger<IAsyncResult>>();

                using (_logger.BeginScope("Data seed"))
                {
                    if (_logger != null)
                        _logger.LogError(e.Message, "Ошибка инициализации данных");
                }
            }
        }
        
    }
}
