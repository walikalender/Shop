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
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal ?? throw new ArgumentNullException(nameof(colorDal));
        }
        public IResult AddColor(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult DeleteColor(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAllColors()
        {
            _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>();
        }

        public IResult UpdateColor(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}
