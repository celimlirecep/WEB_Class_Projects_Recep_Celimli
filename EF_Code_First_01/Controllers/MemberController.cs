using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Code_First_01.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_Code_First_01.Controllers
{
    
    public class MemberController : Controller
    {
        private readonly Library6Context _context;

        public MemberController(Library6Context context){
            _context=context;
        }
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Member member){
                _context.Add(member);
                _context.SaveChanges();
                return RedirectToAction("Index");
        }

        public IActionResult Edit(int id){
            
            var SelectedMember= _context.Members.Find(id);
            return View(SelectedMember);
        }
        [HttpPost]
        public IActionResult Edit(Member member){
            _context.Add(member);
            _context.SaveChanges();
           return RedirectToAction("Index");
        }

        public IActionResult  Delete(int id){
            return View(_context.Members.Find(id));
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int id){
            _context.Remove(_context.Members.Find(id));
            _context.SaveChanges();
           return RedirectToAction("Index");
        }

        public IActionResult Details(int id){

               
                return View( _context.Members.Find(id));
        }

      
    }
}