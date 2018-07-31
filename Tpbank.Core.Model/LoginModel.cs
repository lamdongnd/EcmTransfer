
using System;
using System.IO;
using Tpbank.Core.Utilities.Configuration;
using Tpbank.Core.Utilities.System;

namespace Tpbank.Core.Model
{
    public class LoginModel
    {
        public LoginModel()
        {
            profile = new Ini(Path.Combine(FileAndFolder.StartUpPath, "Login.sys"));
            Domain = "NOR/";
            UserName = "TXX1";
            Password = "ABC@123*#";
            ProductType = "TCSV";
            RememberInfo = true;
            Authentication = false;
        }

        public string[] GetSectionNames()
        {
            return profile.GetSectionNames();
        }

        private Profile profile { get; set; }
        public static string loginFormText = "loginForm";
        public string Domain { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        // Loại sản phẩm. NVKQ, MSTT, TCSV...
        public string ProductType { get; set; }
        // Lưu lại thông tin
        public bool RememberInfo { get; set; }

        public LoginModel GetInfo()
        {
            try
            {
                var loginInfo = new LoginModel();
                loginInfo.Domain = profile.GetValue(loginFormText, "Domain", loginInfo.Domain);
                loginInfo.UserName = profile.GetValue(loginFormText, "UserName", loginInfo.UserName);
                loginInfo.Password = profile.GetValue(loginFormText, "Password", loginInfo.Password);
                loginInfo.ProductType = profile.GetValue(loginFormText, "ProducType", loginInfo.ProductType);
                loginInfo.RememberInfo = profile.GetValue(loginFormText, "RememberInfo", loginInfo.RememberInfo);
                loginInfo.Authentication = profile.GetValue(loginFormText, "Authentication", loginInfo.Authentication);
                return loginInfo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool SaveInfo()
        {
            try
            { 
                profile.SetValue(loginFormText, "Domain", Domain);
                profile.SetValue(loginFormText, "UserName", UserName);
                profile.SetValue(loginFormText, "Password", Password);
                profile.SetValue(loginFormText, "ProducType", ProductType);
                profile.SetValue(loginFormText, "RememberInfo", RememberInfo);
                profile.SetValue(loginFormText, "Authentication", Authentication);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // = True: Tự động đăng nhập
        public bool Authentication { get; set; }

        public bool SaveInfo(Profile profile)
        {
                this.profile = profile;
                return SaveInfo();
        }
    }
}
