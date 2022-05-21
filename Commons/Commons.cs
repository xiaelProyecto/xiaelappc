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
        public const string _URIUSERS_UPDATEAGE = "https://localhost:44327/api/User/UpdateUserAge/";
        public const string _URIUSERS_UPDATENICK = "https://localhost:44327/api/User/UpdateUserNick/";
        public const string _URIUSERS_UPDATEMAIL = "https://localhost:44327/api/User/UpdateUserMail/";
        public const string _URIUSERS_UPDATEPASS = "https://localhost:44327/api/User/UpdateUserPass/";
        public const string _URIUSERS_UPDATEFAVM = "https://localhost:44327/api/User/UpdateUserFavm/";
        public const string _URIUSERS_UPDATEFAVA = "https://localhost:44327/api/User/UpdateUserFava/";
        public const string _URIUSERS_CREATEUSER = "https://localhost:44327/api/User/createUser/";

        //LOGINACCESS
        public const string _URILOGIN_LOGIN = "https://localhost:44327/api/LoginAcces/Login";
        //ANIME
        public const string _URIANIME_GETALLANIMES = "https://localhost:44327/api/Anime/GetAllAnimes";
        public const string _URIANIME_GETANIMEBYID = "https://localhost:44327/api/Anime/GetAnimeById/";
        public const string _URIANIME_GETBYNAME = "https://localhost:44327/api/Anime/SearchService/";

    }
}
