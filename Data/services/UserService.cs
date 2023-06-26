using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace VETAPP.Data.services
{
    internal class UserService
    {

        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = string.Empty;

        public UserService() 
        { 
            _httpClient = new HttpClient();
        }

        

    }
}
