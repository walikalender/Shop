using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Constants
{
    public static class Messages
    {

        // Olumlu Senaryolar
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string ProductsListed = "Ürünler başarıyla listelendi";
        public static string ProductReceived = "Ürün başarıyla getirildi";
        public static string OperationSuccessful = "Operasyon başarıyla tamamlandı";


        // Olumsuz Senaryolar
        public static string ProductNotFound = "Ürün bulunamadı";
        public static string InvalidProductName = "Geçersiz Ürün Adı";
        public static string ProductNotAdded = "Ürün eklenirken bir hata oluştu";
        public static string ProductNotUpdated = "Ürün güncellenirken bir hata oluştu";
        public static string ProductNotDeleted = "Ürün silinirken bir hata oluştu";
        public static string UserNotRegistered = "Kullanıcı kaydedilemedi";
        public static string ProductsNotListed = "Ürünler listelenemedi";
        public static string ProductNotReceived = "Ürün getirilemedi";
        public static string OperationFailed = "Operasyon tamamlanamadı";
        public static string InvalidInput = "Geçersiz giriş";
        public static string UnauthorizedAccess = "Yetkisiz erişim";
        public static string DatabaseError = "Veritabanı hatası oluştu";
        public static string InternalServerError = "İç sunucu hatası oluştu";

    }
}