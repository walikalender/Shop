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
    public class MaterialManager : IMaterialService
    {
      private readonly  IMaterialDal _materialDal;
        public MaterialManager(IMaterialDal materialDal)
        {
            _materialDal = materialDal ?? throw new ArgumentNullException(nameof(materialDal));
        }
        public IResult AddMaterial(Material material)
        {
            _materialDal.Add(material);
            return new SuccessResult();
        }

        public IResult DeleteMaterial(Material material)
        {
            _materialDal.Delete(material);
            return new SuccessResult();
        }

        public IDataResult<List<Material>> GetAllMaterials()
        {
            _materialDal.GetAll();
            return new SuccessDataResult<List<Material>>();
        }

        public IResult UpdateMaterial(Material material)
        {
            _materialDal.Update(material);
            return new SuccessResult();
        }
    }
}
