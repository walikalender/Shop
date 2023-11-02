using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface ICategoryService
    {
        // Yeni bir kategori ekler.
        IResult AddCategory(Category category);

        // Bir kategoriyi siler.
        IResult DeleteCategory(Category category);

        // Mevcut bir kategoriyi günceller.
        IResult UpdateCategory(Category category);

        // Tüm kategorileri getirir.
        IDataResult<List<Category>> GetAllCategories();
    }
}
