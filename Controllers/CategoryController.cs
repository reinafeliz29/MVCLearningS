using Microsoft.AspNetCore.Mvc;
using MVCDemoS.Data;
using MVCDemoS.Interface;
using MVCDemoS.Models;

namespace MVCDemoS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationConnectDb _context;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(ApplicationConnectDb context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> data = _context.Categories;
            return View(data);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display order cannot exactly the Name.");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.CategoryRepository.AddCategory(obj);
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }
            var category = _context.Categories.Find(id);
            if (category == null) { return NotFound(); }
            return View(category);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display order cannot exactly the Name.");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.CategoryRepository.UpdateCategory(obj);
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }
            var category = _context.Categories.Find(id);
            if (category == null) { return NotFound(); }
            return View(category);
        }
        //POST  
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var category = _context.Categories.Find(id);
            if (category == null) { return NotFound(); }
            _unitOfWork.CategoryRepository.DeleteCategory(category);
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
