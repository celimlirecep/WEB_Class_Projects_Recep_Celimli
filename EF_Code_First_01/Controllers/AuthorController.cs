using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Code_First_01.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers 
{
  
    public class AuthorController : Controller
    {
        private readonly Library6Context _context;

        public AuthorController(Library6Context context){
            _context=context;
        }

        public IActionResult Index()
        {
            return View(_context.Authors.ToList());
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author){
           
                _context.Add(author);
                _context.SaveChanges();
                return RedirectToAction("Index");
        }

        public IActionResult Edit(int id){
            
            Author SelectedItem= _context.Authors.Find(id);
            return View(SelectedItem);


        }

        

      
    }
}