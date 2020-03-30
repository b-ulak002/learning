using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DependencyInversion2
{
    public interface IPostsService
    {
        Task<IEnumerable<Post>> GetPosts();
    }
}
