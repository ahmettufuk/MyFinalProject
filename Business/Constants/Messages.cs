using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities.concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ProductAdded!";
        public static string ProductNameInvalid = "Product Name is invalid";

        public static string MaintenanceTime = "Maintenance Time!";
        public static string ProductsListed = "Products Listed!";
        public static string ProductCountOfCategoryError = "Bir Kategoride En fazla 10 Ürün Olabilir.";
        public static string AuthorizationDenied = "Authorization Denied";
        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Is not Correct";
        public static string SuccessfulLogin = "Successful!!";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
