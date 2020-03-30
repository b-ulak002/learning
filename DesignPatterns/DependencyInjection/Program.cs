using DependencyInjection.DependencyInversion;
using DependencyInjection.DependencyInversion2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new PostsManager(new MockPostsService());
            //var manager = new PostsManager(new PostsService());

            var filtered = manager.FilterPosts();
        }
    }
}
