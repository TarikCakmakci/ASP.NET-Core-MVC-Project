using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal: IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        //Sadece ilgili entitye ait metod, dışarıdan başka tabloya bağlı olduğu için bu metodu yazıyoruz.
        List<Blog> GetListWithCategoryByWriter(int id);


    }
}
