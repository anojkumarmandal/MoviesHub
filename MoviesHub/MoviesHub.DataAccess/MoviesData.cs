using MoviesHub.Datatypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesHub.DataAccess
{
    public class MoviesData
    {
        private string query;
        private QueryDB db;

        public MoviesData(string connStr)
        {
            db = new QueryDB(connStr);
        }
        public List<Movie> GetAllMovies()
        {
            return GetAllMoviesList();
        }
        private List<Movie> GetAllMoviesList()
        {
            Movie movie;
            List<Movie> list = new List<Movie>();
            query = "Select * from dbo.Movie";
            DataTable dt = db.ExecuteAdapter(query);
            foreach(DataRow dr in dt.Rows)
            {
                movie = new Movie();
                movie.MovieId = Convert.ToString(dr["MovieId"]);
                movie.Name = Convert.ToString(dr["MovieName"]);
                list.Add(movie);
            }
            return list;
        }
    }
}
