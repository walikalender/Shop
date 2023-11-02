using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IMaterialService
    {
        // Yeni bir malzeme ekler.
        IResult AddMaterial(Material material);

        // Bir malzemeyi siler.
        IResult DeleteMaterial(Material material);

        // Mevcut bir malzemeyi günceller.
        IResult UpdateMaterial(Material material);

        // Tüm malzemeleri getirir.
        IDataResult<List<Material>> GetAllMaterials();
    }
}
