using Shop.Business.Abstract;
using Shop.Core_.Utilities.Results;
using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.Entityframework;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal ?? throw new ArgumentNullException(nameof(categoryDal));
        }
        public IResult AddCategory(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAllCategories()
        {
            _categoryDal.GetAll();
            return new SuccessDataResult<List<Category>>();
        }

        public IResult UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();
        }
    }
}
