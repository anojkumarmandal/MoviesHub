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
        public ActionResult Index()
        {
            if (UtilityMethods.TestConnection(ConfigurationManager.ConnectionStrings["moviesHubConnStr"].ConnectionString))
            {
                MoviesData dal = new MoviesData(ConfigurationManager.ConnectionStrings["moviesHubConnStr"].ConnectionString);
                List<Movie> list = dal.GetAllMovies();
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