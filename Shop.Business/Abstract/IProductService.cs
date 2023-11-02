using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IProductService
    {
        IResult AddProduct(Product product); // Yeni bir ürün ekler.

        IResult UpdateProduct(Product product); // Mevcut bir ürünü günceller.

        IResult DeleteProduct(Product product); // Belirtilen ürünü siler.

        IDataResult<List<Product>> GetAllProducts(); // Tüm ürünleri getirir.

        IDataResult<Product> GetProductById(int id); // Belirli bir ID'ye sahip ürünü getirir.

        IDataResult<List<Product>> GetProductsByCategoryId(int categoryId); // Belirli bir kategoriye ait ürünleri getirir.

        IDataResult<List<Product>> GetProductsDescendingOrderByPrice(); // Ürünleri fiyata göre azalan şekilde sıralar.

        IDataResult<List<Product>> GetProductsAscendingOrderByPrice(); // Ürünleri fiyata göre artan şekilde sıralar.

        IDataResult<List<Product>> GetBestSellingProducts(); // En çok satılan ürünleri getirir.

        IDataResult<List<Product>> GetProductsByBrandId(int brandId); // Belirli bir markaya ait ürünleri getirir.

        IDataResult<List<Product>> GetProductsBySizeId(int sizeId); // Belirli bir bedene ait ürünleri getirir.

        // IDataResult<List<Product>> GetProductsByGenderId(int genderId); // Belirli bir cinsiyete ait ürünleri getirir.

        IDataResult<List<Product>> GetProductsByColorId(int colorId); // Belirli bir renge ait ürünleri getirir.

        IDataResult<List<Product>> GetProductsByPriceRange(decimal minPrice, decimal maxPrice); // Belirli bir fiyat aralığındaki ürünleri getirir.

        IDataResult<List<Product>> GetDiscountedProducts(); // İndirimli ürünleri getirir.

        //IDataResult<List<Product>> GetDiscountedProductsForUser(int userId); // Belirli bir kullanıcı için indirimli ürünleri getirir.

        IDataResult<List<Product>> GetOutOfStockProducts(); // Stokta olmayan ürünleri getirir.

        IDataResult<List<Product>> GetProductsByName(string productName); // Belirli bir isme göre ürünleri getirir.

        //IDataResult<List<Product>> GetProductsByPage(int pageNumber, int pageSize); // Belirli bir sayfa numarası ve sayfa boyutuna göre ürünleri getirir.
    }
}
