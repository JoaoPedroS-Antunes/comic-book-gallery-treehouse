using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBookGallery.Data;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            ComicBook[] comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            ComicBook comicBook = null;
            if (id != null) 
                comicBook = _comicBookRepository.GetComicBook((int)id);
            if (comicBook == null) 
                NotFound("Error: The book for the specified ID was not found...");

            return View(comicBook);
        }
    }
}
