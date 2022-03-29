using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPostDal
    {
        List<Post> ListAllPost();
        void AddPost(Post post);
        void DeletePost(Post post);
        void UpdatePost(Post post);
        Post GetById(int id);
    }
}
