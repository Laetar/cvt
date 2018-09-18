using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Organizer.Server.DAL.Repositories.Interfaces;
using Organizer.Server.Models.DataBase.Entities;
using Organizer.Web.Models.CalendarViewModels.NoteViewModels;

namespace Organizer.Web.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteRepository _repository;

        public NoteController(INoteRepository repository)
        {
            this._repository = repository;
        }

        public ActionResult Index()
        {
            var entities = _repository.GetAll();
            var model = Mapper.Map<IEnumerable<Note>, IEnumerable<DetailsNoteViewModel>>(entities);
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _repository.Get(id);
            var viewModel = Mapper.Map<Note, DetailsNoteViewModel>(model);
            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateNoteViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<CreateNoteViewModel, Note>(model);
                var id = _repository.Create(entity);

                return RedirectToAction("Details", new { id });
            }

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var entity = _repository.Get(id);

            var model = Mapper.Map<Note, EditNoteViewModel>(entity);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditNoteViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<EditNoteViewModel, Note>(model);
                _repository.Update(entity);

                return RedirectToAction("Details", new { id = model.Id });
            }

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var model = _repository.Get(id);
            var viewModel = Mapper.Map<Note, DetailsNoteViewModel>(model);

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