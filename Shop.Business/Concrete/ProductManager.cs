using Shop.Business.Abstract;
using Shop.Business.Constants;
using Shop.Business.Validations.FluentValidation;
using Shop.Core_.Aspects.Autofac.Validation;
using Shop.Core_.Utilities.Results;
using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.Entityframework;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal ?? throw new ArgumentNullException(nameof(productDal));
        }

        // Yeni bir ürün ekler.
        [ValidationAspect(typeof(ProductValidator))]
        public IResult AddProduct(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        // Tüm ürünleri fiyata göre artan şekilde sıralar ve getirir.
        public IDataResult<List<Product>> GetProductsAscendingOrderByPrice()
        {
            var ascSortedProducts = _productDal.GetAll().OrderBy(product => product.UnitPrice).ToList();
            return new SuccessDataResult<List<Product>>(ascSortedProducts, Messages.ProductsListed);
        }

        // Tüm ürünleri fiyata göre azalan şekilde sıralar ve getirir.
        public IDataResult<List<Product>> GetProductsDescendingOrderByPrice()
        {
            var dscSortedProducts = _productDal.GetAll().OrderByDescending(product => product.UnitPrice).ToList();
            return new SuccessDataResult<List<Product>>(dscSortedProducts, Messages.ProductsListed);
        }

        // Tüm ürünleri getirir.
        public IDataResult<List<Product>> GetAllProducts()
        {
            var products = _productDal.GetAll();
            return new SuccessDataResult<List<Product>>(products, Messages.ProductsListed);
        }

        // En çok satılan ürünleri getirir.
        public IDataResult<List<Product>> GetBestSellingProducts()
        {
            var bestSellingProducts = _productDal.GetAll()
                .OrderByDescending(p => p.OrderDetails?.Sum(od => od.Quantity))
                .Take(10)
                .ToList();

            return new SuccessDataResult<List<Product>>(bestSellingProducts, Messages.ProductsListed);
        }

        // Belirli bir kategoriye ait ürünleri getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<List<Product>> GetProductsByCategoryId(int id)
        {
            var byCategoryProducts = _productDal.GetAll(p => p.CategoryId == id);
            return new SuccessDataResult<List<Product>>(byCategoryProducts, Messages.ProductsListed);
        }

        // Belirli bir ID'ye sahip ürünü getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<Product> GetProductById(int id)
        {
            var byIdProduct = _productDal.Get(p => p.ProductId == id);
            return new SuccessDataResult<Product>(byIdProduct, Messages.ProductReceived);
        }

        // İndirimli ürünleri getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<List<Product>> GetDiscountedProducts()
        {
            var discountedProducts = _productDal.GetAll().Where(p => p.Discount > 0).OrderByDescending(p => p.OrderDetails).ToList();
            return new SuccessDataResult<List<Product>>(discountedProducts, Messages.ProductsListed);
        }

        // Stokta olmayan ürünleri getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<List<Product>> GetOutOfStockProducts()
        {
            var outOfStockProducts = _productDal.GetAll().Where(p => p.UnitsInStock == 0).ToList();
            return new SuccessDataResult<List<Product>>(outOfStockProducts, Messages.ProductsListed);
        }

        // Belirli bir markaya ait ürünleri getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<List<Product>> GetProductsByBrandId(int brandId)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Product>>(Messages.ProductsNotListed);
            }
            var productsByBrand = _productDal.GetAll(p => p.BrandId == brandId);
            return new SuccessDataResult<List<Product>>(productsByBrand, Messages.ProductsListed);
        }

        // Belirli bir renge ait ürünleri getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<List<Product>> GetProductsByColorId(int colorId)
        {
            var productsByColor = _productDal.GetAll(p => p.ColorId == colorId);
            return new SuccessDataResult<List<Product>>(productsByColor, Messages.ProductsListed);
        }

        // Belirli bir ürün ismine göre ürünleri getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<List<Product>> GetProductsByName(string? productName)
        {
            if (productName != null)
            {
                var products = _productDal.GetAll();
                if (products != null)
                {
                    var productsByName = products
                        .Where(p => p.ProductName != null &&
                                    p.ProductName.Contains(productName, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    return new SuccessDataResult<List<Product>>(productsByName, Messages.ProductsListed);
                }
                else
                {
                    return new ErrorDataResult<List<Product>>(null, Messages.ProductNotFound);
                }
            }
            else
            {
                return new ErrorDataResult<List<Product>>(null, Messages.InvalidProductName);
            }
        }

        // Belirli bir fiyat aralığındaki ürünleri getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<List<Product>> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            var productsByPriceRange = _productDal.GetAll().Where(p => p.UnitPrice <= maxPrice && p.UnitPrice >= minPrice).OrderBy(p => p.UnitPrice).ToList();

            return new SuccessDataResult<List<Product>>(productsByPriceRange, Messages.ProductsListed);
        }

        // Belirli bir bedene ait ürünleri getirir.
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<List<Product>> GetProductsBySizeId(int sizeId)
        {
            var productsBySize = _productDal.GetAll(p => p.SizeId == sizeId);
            return new SuccessDataResult<List<Product>>(productsBySize, Messages.ProductsListed);
        }

        // Mevcut bir ürünü günceller.
        public IResult UpdateProduct(Product product)
        {
            if (product == null)
            {
                return new ErrorResult(Messages.ProductNotFound);
            }

            var updatedProduct = _productDal.Get(p => p.ProductId == product.ProductId);

            if (updatedProduct == null)
            {
                return new ErrorResult(Messages.ProductNotFound);
            }

            // Ürün bilgilerini güncelle
            updatedProduct.SupplierId = product.SupplierId;
            updatedProduct.UnitPrice = product.UnitPrice;
            updatedProduct.ProductName = product.ProductName;
            updatedProduct.BrandId = product.BrandId;
            updatedProduct.CategoryId = product.CategoryId;
            updatedProduct.Description = product.Description;
            updatedProduct.ColorId = product.ColorId;
            updatedProduct.SizeId = product.SizeId;
            updatedProduct.Discount = product.Discount;
            updatedProduct.ImageUrl = product.ImageUrl;
            updatedProduct.MaterialId = product.MaterialId;
            updatedProduct.MoldId = product.MoldId;
            updatedProduct.ReorderLevel = product.ReorderLevel;
            updatedProduct.UnitsInStock = product.UnitsInStock;

            _productDal.Update(updatedProduct);

            return new SuccessResult(Messages.ProductUpdated);
        }


        public IResult DeleteProduct(Product product)
        {
            if (product == null)
            {
                return new ErrorResult(Messages.ProductNotFound);
            }

            var deletedProduct = _productDal.Get(p => p.ProductId == product.ProductId);

            if (deletedProduct == null)
            {
                return new ErrorResult(Messages.ProductNotFound);
            }

            _productDal.Delete(deletedProduct);

            return new SuccessResult(Messages.ProductDeleted);
        }

    }
}
