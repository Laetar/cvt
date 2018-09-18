using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Organizer.Server.DAL.Repositories.Interfaces;
using Organizer.Server.Models.DataBase.Entities;
using Organizer.Web.Models.CalendarViewModels.MeetingViewModels;

namespace Organizer.Web.Controllers
{
    public class MeetingController : Controller
    {
        private readonly IMeetingRepository _repository;

        public MeetingController(IMeetingRepository repository)
        {
            this._repository = repository;
        }

        public ActionResult Index()
        {
            var entities = _repository.GetAll();
            var model = Mapper.Map<IEnumerable<Meeting>, IEnumerable<DetailsMeetingViewModel>>(entities);
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _repository.Get(id);
            var viewModel = Mapper.Map<Meeting, DetailsMeetingViewModel>(model);
            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateMeetingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<CreateMeetingViewModel, Meeting>(model);
                var id = _repository.Create(entity);

                return RedirectToAction("Details", new { id });
            }

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var entity = _repository.Get(id);

            var model = Mapper.Map<Meeting, EditMeetingViewModel>(entity);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditMeetingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<EditMeetingViewModel, Meeting>(model);
                _repository.Update(entity);

                return RedirectToAction("Details", new { id = model.Id });
            }

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var model = _repository.Get(id);
            var viewModel = Mapper.Map<Meeting, DetailsMeetingViewModel>(model);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _repository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}