using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VETAPP.Data.services.Interfaces;
using VETAPP.Models;
using VETAPP.ViewModels;

namespace VETAPP.Data.services
{
    public class UserService : IUserService
    {
        private string _baseUrl = "https://localhost:7258/";

        public async Task<List<ViewModels.Models.User>> GetAllUsersList()
        {
            var returnResponse = new List<ViewModels.Models.User>();
            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}/api/userController";
                var apiResponse = await client.GetAsync(url);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    var deserilizeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                    if (deserilizeResponse.IsSuccess)
                    {
                        returnResponse = JsonConvert.DeserializeObject<List<ViewModels.Models.User>>(deserilizeResponse.Content.ToString());
                    }
                }
            }
            return returnResponse;
        }
    }
}
