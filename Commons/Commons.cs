using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiaelappc.Commons
{
    public class Commons
    {

        //API CALLS TO LOCALHOST
        //MOVIE
        public const string _URIMOVIES_GETALLMOVIES = "https://localhost:44327/api/Movie/GetAllMovies";
        public const string _URIMOVIES_GETBYID = "https://localhost:44327/api/Movie/GetMovieById/";
        public const string _URIMOVIES_GETBYNAME = "https://localhost:44327/api/Movie/SearchService/";
        //USERS
        public const string _URIUSERS_GETALLUSERS = "https://localhost:44327/api/User/Get";
        public const string _URIUSERS_GETBYID = "https://localhost:44327/api/User/GetById/";
    }
}
