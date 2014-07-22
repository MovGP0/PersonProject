using System;
using System.Web.Mvc;
using PersonProject.Cqrs;
using PersonProject.Cqrs.Commands;
using PersonProject.DataView;
using PersonProject.Model;

namespace PersonProject.Controllers
{
    public class PersonController : Controller
    {
        private Func<CqrsRepository> CqrsRepositoryFactory { get; set; }
        private Func<DataViewRepository> DataViewRepositoryFactory { get; set; }

        public PersonController()
        {
            CqrsRepositoryFactory = () => new CqrsRepository();
            DataViewRepositoryFactory = () => new DataViewRepository();
        }

        public PersonController(
            Func<CqrsRepository> cqrsRepositoryFactory, 
            Func<DataViewRepository> dataViewRepositoryFactory)
        {
            CqrsRepositoryFactory = cqrsRepositoryFactory;
            DataViewRepositoryFactory = dataViewRepositoryFactory;
        }

        [HttpGet]
        public ActionResult All()
        {
            using (var repository = DataViewRepositoryFactory())
            {
                return View(repository.GetAll());
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            using (var repository = CqrsRepositoryFactory())
            {
                var command = new CreatePersonCommand(person.FirstName, person.LastName);
                repository.Send(command);
            }

            return new RedirectResult("/People");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (var repository = DataViewRepositoryFactory())
            {
                var person = repository.GetById(id);
                return View(person);
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Person person)
        {
            using (var repository = CqrsRepositoryFactory())
            {
                var command = new UpdatePersonCommand(person.Id, person.FirstName, person.LastName);
                repository.Send(command);
            }

            return new RedirectResult("/People");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            using (var repository = DataViewRepositoryFactory())
            {
                var person = repository.GetById(id);
                return View(person);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (var repository = CqrsRepositoryFactory())
            {
                var command = new DeletePersonCommand(id);
                repository.Send(command);
                return new RedirectResult("/People");
            }
        }
    }
}