using System;
using System.Collections.Generic;
using System.Text;

namespace MiniServer.HTTP.Enums
{
    public static class Enumerators
    {
        public enum  HttpRequestMethod { 
            Get,
            Post,
            Put,
            Delete
        }

        public enum HttpResponseStatusCode { 
            Ok=200,
            Created = 201,
            Found = 302,
            SeeOther = 303,
            BadRequest = 400,
            Unauthorized = 401,
            Forbidden = 403,
            NotFound = 404,
            InternalServerError = 500
        }
    }
}
