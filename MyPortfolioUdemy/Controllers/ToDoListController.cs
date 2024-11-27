using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList todolist)
        {
            todolist.Status = false; //status başlangıçta false olarak atanıyor
            context.ToDoLists.Add(todolist);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList todolist)
        {
            context.ToDoLists.Update(todolist);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}
