using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CRUD_WebApp
{
    public static class GlobalVariables
    {
        public static HttpClient APIClient = new HttpClient();

        static GlobalVariables()
        {
            APIClient.BaseAddress = new Uri("http://localhost:62774/api/");
            APIClient.DefaultRequestHeaders.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicatiion/json"));
        }
    }
}