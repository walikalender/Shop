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
    public class SizeManager : ISizeService
    {
        private readonly ISizeDal _sizeDal;
        public SizeManager(ISizeDal sizeDal)
        {
            _sizeDal = sizeDal ?? throw new ArgumentNullException(nameof(sizeDal));
        }
        public IResult AddSize(Size size)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteSize(int sizeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Size>> GetAllSizes()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Size> GetSizeById(int sizeId)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateSize(Size size)
        {
            throw new NotImplementedException();
        }
    }
}
