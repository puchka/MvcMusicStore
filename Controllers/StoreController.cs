using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreEntities StoreDB { get; set; }
        
        public StoreController(MusicStoreEntities storeDB)
        {
            StoreDB = storeDB;
        }
        
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var genres = StoreDB.Genres.ToList();
            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = StoreDB.Genres.Include(g => g.Albums)
                .Single(g => g.Name == genre);
        
            return View(genreModel);
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var album = StoreDB.Albums.Single(a => a.Id == id);
        
            return View(album);
        }
    }
}
