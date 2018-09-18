using AutoMapper;
using Organizer.Server.Models.DataBase.Entities;
using Organizer.Server.Models.DataBase.Entities.Interfaces;
using Organizer.Web.Models.CalendarViewModels.MeetingViewModels;
using Organizer.Web.Models.CalendarViewModels.NoteViewModels;
using Organizer.Web.Models.CalendarViewModels.TaskViewModels;

namespace Organizer.Web.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<EditMeetingViewModel, Meeting>().ReverseMap();
                cfg.CreateMap<CreateMeetingViewModel, Meeting>().ReverseMap();

                cfg.CreateMap<EditNoteViewModel, Note>().ReverseMap();
                cfg.CreateMap<CreateNoteViewModel, Note>().ReverseMap();

                cfg.CreateMap<EditTaskViewModel, Task>().ReverseMap();
                cfg.CreateMap<CreateTaskViewModel, Task>().ReverseMap();


                cfg.CreateMap<IEntity, IEntity>();
            });
        }
    }
}
