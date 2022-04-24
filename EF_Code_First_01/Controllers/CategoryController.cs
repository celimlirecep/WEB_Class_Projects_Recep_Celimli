using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using EF_Code_First_01.Models.Entities;

namespace Controllers
{

    public class CategoryController : Controller
    {

        private readonly Library6Context _context;

        public CategoryController(Library6Context context){
            _context=context;
        }
  

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category){
            
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id){

           
            return View( _context.Categories.Find(id));
            
        }

        public IActionResult Delete(int id){
           
            return View( _context.Categories.Find(id));
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteCategory(int id){

            Category silinecekCategori=_context.Categories.Find(id);
         
            silinecekCategori.IsDeleted=true;
            _context.Update(silinecekCategori);
            _context.SaveChanges();
            return RedirectToAction("Index");
            

        }

        public IActionResult Edit(int id){
              return View( _context.Categories.Find(id));

        }

        [HttpPost]
        public IActionResult Edit(Category kategori){
            _context.Update(kategori);
            _context.SaveChanges();
            return RedirectToAction("Index");
           
        }

        

       
    }
}