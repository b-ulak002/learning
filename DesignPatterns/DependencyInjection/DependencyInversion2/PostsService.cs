using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DependencyInversion2
{
    public class PostsService : IPostsService
    {
        public async Task<IEnumerable<Post>> GetPosts()
        {
            using (var http  = new HttpClient())
            {
                var postsJson = await http.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
                return JsonConvert.DeserializeObject<IEnumerable<Post>>(postsJson);
            }
        }
    }
}
