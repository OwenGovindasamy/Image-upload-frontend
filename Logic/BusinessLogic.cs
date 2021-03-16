using Newtonsoft.Json;
using Recap_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Recap_App.Interfaces;

namespace Recap_App.Logic
{
    public class BusinessLogic : IBusinessLogic
    {
        public async Task<Photo> photosAsync()
        {
            string apiUrl = "https://localhost:44386/api/photos";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<Photo>(result);

                }

            }
            throw new Exception("Photo List not found");
        }
    }
}
