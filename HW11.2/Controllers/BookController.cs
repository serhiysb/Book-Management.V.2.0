using HW11._2.Core.Entities;
using HW11._2.Core.Interfaces;
using HW11._2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW11._2.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly IGenericUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Book> repoBook;

        public BookController(ILogger<BookController> logger, IGenericUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            repoBook = _unitOfWork.Repository<Book>();
        }

        public async Task<IActionResult> Index()
        {
            var books = await repoBook.GetAll();
            return View(books);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {
            await repoBook.AddEntity(book);
            await _unitOfWork.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            repoBook.UpdateEntity(book);
            await _unitOfWork.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> Delete(int id)
        {
            await repoBook.DeleteById(id);
            await _unitOfWork.SaveChangesAsync();
            return RedirectToAction("Index");
        }
 
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}