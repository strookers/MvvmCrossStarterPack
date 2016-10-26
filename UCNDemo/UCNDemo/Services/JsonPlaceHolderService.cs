using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UCNDemo.Models;

namespace UCNDemo.Services
{
    public interface IJsonPlaceHolderService
    {
        Task<List<Album>> GetAlbumsAsync();
    }

    public class JsonPlaceHolderService : IJsonPlaceHolderService
    {
        public async Task<List<Album>> GetAlbumsAsync()
        {
            //TODO: Error handling
            var url = "http://jsonplaceholder.typicode.com/photos?_start=0&_end=30";
            var client = new HttpClient();

            var json = await client.GetStringAsync(url);

            var albums = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Album>>(json);
            return albums;
        }
    }
}
