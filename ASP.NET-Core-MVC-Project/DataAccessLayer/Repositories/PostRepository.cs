using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PostRepository : IPostDal
    {
        public void AddPost(Post post)
        {
            using var c = new Context();
            c.Add(post);
            c.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            using var c = new Context();
            c.Remove(post);
            c.SaveChanges();
        }

        public Post GetById(int id)
        {
            using var c = new Context();
            return c.Posts.Find(id);
        }
        public List<Post> ListAllPost()
        {
            using var c = new Context();
            return c.Posts.ToList();
        }

        public void UpdatePost(Post post)
        {
            using var c = new Context();
            c.Update(post);
            c.SaveChanges();
        }
    }

       
}

