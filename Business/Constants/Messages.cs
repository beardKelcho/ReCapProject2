using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public class Messages
    {
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductInvalid = "Ürün geçersiz";
        public static string UserRegistered = "Kayıt oldu";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token Yaratıldı";
        public static string UserAdeded="Kullanıcı Eklendi";
        public static string ClaimsListed="Claimler Listelendi";
        public static string Geted="Listelendi";
    }
}
