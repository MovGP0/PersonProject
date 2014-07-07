using System.Threading.Tasks;
using System.Web.Mvc;
using PersonProject.Model;
using PersonProject.Models;

namespace PersonProject.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public ActionResult All()
        {
            using (var repository = new PersonRepository())
            {
                return View(repository.All());
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
            using (var repository = new PersonRepository())
            {
                repository.Create(person);
            }

            return new RedirectResult("/People");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (var repository = new PersonRepository())
            {
                var person = repository.GetById(id);
                return View(person);
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Person person)
        {
            using (var repository = new PersonRepository())
            {
                repository.Update(person);
            }

            return new RedirectResult("/People");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            using (var repository = new PersonRepository())
            {
                var person = repository.GetById(id);
                return View(person);
            }
        }

        [HttpGet]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            using (var repository = new PersonRepository())
            {
                await repository.DeleteAsync(id);
                return new RedirectResult("/People");
            }
        }
    }
}