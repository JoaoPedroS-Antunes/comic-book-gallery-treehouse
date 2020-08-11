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

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return NotFound("Error: The book for the specified ID was not found...");
            }
            ComicBook comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
        }
    }
}
