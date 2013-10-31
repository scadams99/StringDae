using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringDae;
using StringDae.Models;

namespace StringDae.Controllers
{   
    public class PersonController : Controller
    {
		private readonly IPERSONRepository personRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public PersonController() : this(new PERSONRepository())
        {
        }

        public PersonController(IPERSONRepository personRepository)
        {
			this.personRepository = personRepository;
        }

        //
        // GET: /Person/

        public ViewResult Index()
        {
            return View(personRepository.AllIncluding(person => person.ENTITY_INVESTIGATION_ENVIRONMENT, person => person.ENTITY_NOTES, person => person.ENTITY_QUESTIONS, person => person.ENTITY_REFERENCE_SOURCE, person => person.LOCATION_PERSON, person => person.PERSON_ATTRIBUTION, person => person.PERSON_EVENT, person => person.PERSON_GROUP, person => person.PERSON_ID, person => person.PERSON_OBJECT, person => person.PERSON_PERSON, person => person.PERSON_PERSON1));
        }

        //
        // GET: /Person/Details/5

        public ViewResult Details(int id)
        {
            return View(personRepository.Find(id));
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(PERSON person)
        {
            if (ModelState.IsValid) {
                personRepository.InsertOrUpdate(person);
                personRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Person/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(personRepository.Find(id));
        }

        //
        // POST: /Person/Edit/5

        [HttpPost]
        public ActionResult Edit(PERSON person)
        {
            if (ModelState.IsValid) {
                personRepository.InsertOrUpdate(person);
                personRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Person/Delete/5
 
        public ActionResult Delete(int id)
        {
            personRepository.Delete(id);
            personRepository.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                personRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

