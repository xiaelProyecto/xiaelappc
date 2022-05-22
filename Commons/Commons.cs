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
        public const string _URIMOVIES_GETALLMOVIES = "https://xiaelapi.azurewebsites.net/api/Movie/GetAllMovies";
        public const string _URIMOVIES_GETBYID = "https://xiaelapi.azurewebsites.net/api/Movie/GetMovieById/";
        public const string _URIMOVIES_GETBYNAME = "https://xiaelapi.azurewebsites.net/api/Movie/SearchService/";
        //USERS
        public const string _URIUSERS_GETALLUSERS = "https://xiaelapi.azurewebsites.net/api/User/Get";
        public const string _URIUSERS_GETBYID = "https://xiaelapi.azurewebsites.net/api/User/GetById/";
        public const string _URIUSERS_UPDATEDESCRIPTION = "https://xiaelapi.azurewebsites.net/api/User/UpdateUserDesc/";
        public const string _URIUSERS_UPDATEAGE = "https://xiaelapi.azurewebsites.net/api/User/UpdateUserAge/";
        public const string _URIUSERS_UPDATENICK = "https://xiaelapi.azurewebsites.net/api/User/UpdateUserNick/";
        public const string _URIUSERS_UPDATEMAIL = "https://xiaelapi.azurewebsites.net/api/User/UpdateUserMail/";
        public const string _URIUSERS_UPDATEPASS = "https://xiaelapi.azurewebsites.net/api/User/UpdateUserPass/";
        public const string _URIUSERS_UPDATEFAVM = "https://xiaelapi.azurewebsites.net/api/User/UpdateUserFavm/";
        public const string _URIUSERS_UPDATEFAVA = "https://xiaelapi.azurewebsites.net/api/User/UpdateUserFava/";
        public const string _URIUSERS_CREATEUSER = "https://xiaelapi.azurewebsites.net/api/User/createUser/";
        public const string _URIUSERS_DELETE = "https://xiaelapi.azurewebsites.net/api/User/Delete/";

        //LOGINACCESS
        public const string _URILOGIN_LOGIN = "https://xiaelapi.azurewebsites.net/api/LoginAcces/Login";
        //ANIME
        public const string _URIANIME_GETALLANIMES = "https://xiaelapi.azurewebsites.net/api/Anime/GetAllAnimes";
        public const string _URIANIME_GETANIMEBYID = "https://xiaelapi.azurewebsites.net/api/Anime/GetAnimeById/";
        public const string _URIANIME_GETBYNAME = "https://xiaelapi.azurewebsites.net/api/Anime/SearchService/";

        
    }
}
