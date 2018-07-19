using MoviesHub.Common;
using MoviesHub.DataAccess;
using MoviesHub.Datatypes;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace MoviesHub.Controllers
{
    public class HomeController : Controller
    {
        private MoviesData dal;

        public MoviesData Dal
        {
            get
            {
                if (dal == null)
                {
                    dal = new MoviesData();
                }
                return dal;
            }
            
        }

        public ActionResult Index()
        {
            if (UtilityMethods.TestConnection())
            {
                List<Movie> list = Dal.GetAllMovies();
                return View();
            }
            return View("Error");

        }

        public ActionResult Movies()
        {
            return View();
        }

        public ActionResult SubmitAMovie()
        {
            return View();
        }

        

    }
}