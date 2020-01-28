using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyWeb
{
    public static class SD
    {
        public static string APIBaseUrl = "https://localhost:44346/";
        public static string NationalParkAPIPath = APIBaseUrl+ "api/v1/nationalparks/";
        public static string TrailAPIPath = APIBaseUrl+ "api/v1/trails/";
        public static string AccountAPIPath = APIBaseUrl + "api/v1/Users/";

    }
}
