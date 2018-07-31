using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tpbank.Core.Model;
using Tpbank.Core.Utilities.Configuration;

namespace TpBank.Core.Componet
{
    public class SystemOption
    {
        public SystemOption()
        {            
            //Profile profile = new Ini(Path.Combine(Application.StartupPath, "login.sys"));
            LoginInfo = new LoginModel();
            LoginInfo = LoginInfo.GetInfo();
        }
        public LoginModel LoginInfo { get; set; }
    }
}
