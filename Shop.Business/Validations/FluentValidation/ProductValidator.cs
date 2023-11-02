using FluentValidation;
using Shop.Business.Constants;
using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Validations.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty(); //Ürün adı boş olamaz.
            RuleFor(p => p.ProductName).MinimumLength(3); // Ürün adı en az 3 karakter uzunluğunda olmalıdır.
            RuleFor(p => p.ProductName).MaximumLength(50);//  Ürün adı en fazla 50 karakter uzunluğunda olabilir.
            RuleFor(p => p.ProductName).Must(ContainValidCharacters);// Ürün adında geçersiz karakterler bulunmaktadır. Sadece harfler ve sayılar kullanabilirsiniz.

            RuleFor(p => p.CategoryId).GreaterThan(0); //Kategori seçilmelidir.
            RuleFor(p => p.BrandId).GreaterThan(0); //Marka seçilmelidir.
            RuleFor(p => p.SizeId).GreaterThan(0); // Beden seçilmelidir.
            RuleFor(p => p.ColorId).GreaterThan(0); // Renk seçilmelidir.

            RuleFor(p => p.UnitPrice).GreaterThan(0); //Ürün fiyatı sıfırdan büyük olmalıdır.
            RuleFor(p => p.UnitPrice)
             .GreaterThan(0)
             .PrecisionScale(5,2,true); // "Fiyat en fazla 5 haneli ve 2 kesir haneli olmalıdır.


             RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0); // Stok adedi negatif olamaz.

            RuleFor(p => p.Discount).GreaterThan(0); //İndirim oranı pozitif olmalı.
            RuleFor(p => p.Discount).LessThanOrEqualTo(100); // İndirim oranı en fazla 100 olabilir.

            RuleFor(p => p.Description).Length(0, 1000);
            RuleFor(p => p.ReorderLevel).GreaterThanOrEqualTo((short)0); // Yeniden sipariş seviyesi negatif olamaz.

            RuleFor(p => p.ImageUrl).NotEmpty(); // İmage Url'si boş geçilemez.
            RuleFor(p => p.ImageUrl).Must(BeAValidUrl).When(p => !string.IsNullOrEmpty(p.ImageUrl)).WithMessage("Geçerli bir resim URL'si girilmelidir.");
        }

        private bool BeAValidUrl(string? url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return true; // Boş URL kabul edilebilir, zaten yukarıda zorunluluk kontrol ediliyor.
            }

            return Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult) &&
                   (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private bool ContainValidCharacters(string? productName)
        {
            if (productName == null)
            {
                return new ErrorResult(Messages.InvalidProductName).IsSuccess;
            }
            return productName.All(char.IsLetterOrDigit);
        }
    }

}
