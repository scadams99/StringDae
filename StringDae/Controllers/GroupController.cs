using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringDae;
using StringDae.Models;

namespace StringDae.Controllers
{   
    public class GroupController : Controller
    {
		private readonly IGROUPRepository groupRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public GroupController() : this(new GROUPRepository())
        {
        }

        public GroupController(IGROUPRepository groupRepository)
        {
			this.groupRepository = groupRepository;
        }

        //
        // GET: /Group/

        public ViewResult Index()
        {
            return View(groupRepository.AllIncluding(group => group.ENTITY_INVESTIGATION_ENVIRONMENT, group => group.ENTITY_NOTES, group => group.ENTITY_QUESTIONS, group => group.ENTITY_REFERENCE_SOURCE, group => group.GROUP_EVENT, group => group.LOCATION_GROUP, group => group.OBJECT_GROUP, group => group.PERSON_GROUP));
        }

        //
        // GET: /Group/Details/5

        public ViewResult Details(int id)
        {
            return View(groupRepository.Find(id));
        }

        //
        // GET: /Group/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Group/Create

        [HttpPost]
        public ActionResult Create(GROUP group)
        {
            if (ModelState.IsValid) {
                groupRepository.InsertOrUpdate(group);
                groupRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Group/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(groupRepository.Find(id));
        }

        //
        // POST: /Group/Edit/5

        [HttpPost]
        public ActionResult Edit(GROUP group)
        {
            if (ModelState.IsValid) {
                groupRepository.InsertOrUpdate(group);
                groupRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Group/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(groupRepository.Find(id));
        }

        //
        // POST: /Group/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            groupRepository.Delete(id);
            groupRepository.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                groupRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

