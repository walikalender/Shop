using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IColorService
    {
        // Yeni bir renk ekler.
        IResult AddColor(Color color);

        // Bir rengi siler.
        IResult DeleteColor(Color color);

        // Mevcut bir rengi günceller.
        IResult UpdateColor(Color color);

        // Tüm renkleri getirir.
        IDataResult<List<Color>> GetAllColors();
    }
}
