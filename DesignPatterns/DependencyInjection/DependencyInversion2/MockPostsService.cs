using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DependencyInversion2
{
    public class MockPostsService : IPostsService
    {
        public Task<IEnumerable<Post>> GetPosts()
        {
            return new Task<IEnumerable<Post>>(() =>
            {
                return new List<Post>()
                {
                    new Post() {Id = 1, Title = "MockPost 1", Body = "MockBody 1", UserId = 1 },
                    new Post() {Id = 2, Title = "MockPost 2", Body = "MockBody 2", UserId = 1 },
                    new Post() {Id = 3, Title = "MockPost 3", Body = "MockBody 3", UserId = 1 },
                    new Post() {Id = 4, Title = "MockPost 4", Body = "MockBody 4", UserId = 1 },
                };
            });

        }
    
    }
}
