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
    public class MoldManager : IMoldService
    {
        private readonly IMoldDal _moldDal;
        public MoldManager(IMoldDal moldDal)
        {
            _moldDal = moldDal ?? throw new ArgumentNullException(nameof(moldDal));
        }
        public IResult AddMold(Mold mold)
        {
            _moldDal.Add(mold);
            return new SuccessResult();
        }

        public IResult DeleteMold(Mold mold)
        {
            _moldDal.Delete(mold);
            return new SuccessResult();
        }

        public IDataResult<List<Mold>> GetAllMolds()
        {
            _moldDal.GetAll();
            return new SuccessDataResult<List<Mold>>();
        }

        public IResult UpdateMold(Mold mold)
        {
            _moldDal.Update(mold);
            return new SuccessResult();
        }
    }
}
