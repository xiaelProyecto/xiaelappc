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
        public const string _URIUSERS_UPDATEDESCRIPTION = "https://localhost:44327/api/User/UpdateUserDesc/";
        //LOGINACCESS
        public const string _URILOGIN_LOGIN = "https://localhost:44327/api/LoginAcces/Login";
        //ANIME
        public const string _URIANIME_GETALLANIMES = "https://localhost:44327/api/Anime/GetAllAnimes";
        public const string _URIANIME_GETANIMEBYID = "https://localhost:44327/api/Anime/GetAnimeById/";
        public const string _URIANIME_GETBYNAME = "https://localhost:44327/api/Anime/SearchService/";

    }
}
