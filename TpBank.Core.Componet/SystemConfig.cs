using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tpbank.Core.Common.Generic;
using Tpbank.Core.Common.System;
using Tpbank.Core.Model;
using Tpbank.Core.Utilities.Configuration;

namespace TpBank.Core.Componet
{
    public class SystemConfig
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public SystemConfig()
        {
            try
            {
                StartupPath = Application.StartupPath;
                Tpbank.Core.Utilities.System.FileAndFolder file = new Tpbank.Core.Utilities.System.FileAndFolder();
                RootDataFolder = Path.Combine(file.GetMaxTotalFreeSpaceDisk(), SystemConst.ROOT_FOLDER_DATA);
                ConfigFileName = Path.Combine(RootDataFolder, SystemConst.CONFIG_FILE_NAME);
                SystemDataFile = Path.Combine(RootDataFolder, SystemConst.SYSTEM_DB_FILE_NAME);
                if (!Directory.Exists(RootDataFolder))
                {
                    Directory.CreateDirectory(RootDataFolder);
                }
                Config = new Xml(ConfigFileName);

                ConfigFileNameByUser = string.Empty;
                ConfigByUser = null;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                throw ex;
            }
        }

        public void SetUserDataFolder(LoginModel login)
        {
            try
            {
                RootDataFolderByUser = Path.Combine(RootDataFolder, login.UserName);
                ConfigFileNameByUser = Path.Combine(RootDataFolderByUser, SystemConst.CONFIG_FILE_NAME);
                UserDataFile = Path.Combine(RootDataFolderByUser, SystemConst.USER_DB_FILE_NAME);
                if (!Directory.Exists(RootDataFolderByUser))
                {
                    Directory.CreateDirectory(RootDataFolderByUser);
                }
                ConfigByUser = new Xml(ConfigFileNameByUser);
                // Lưu lại cấu hình cho User.
                string[] secsion = Config.GetSectionNames();
                string rootFolder = "UserFolder";
                if (Config.GetValue(rootFolder, login.UserName.ToUpper(), null) == null)
                {
                    Config.SetValue(rootFolder, login.UserName.ToUpper(), RootDataFolderByUser);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                throw ex;
            }
        }
        public SystemSqliteDb SystemDb { get; set; }
        public UserSqliteDb UserDb { get; set; }
        public Profile Config { get; set; }
        public Profile ConfigByUser { get; set; }
        public string StartupPath { get; set; }
        public string RootDataFolder { get; set; }
        public string RootDataFolderByUser { get; set; }
        public string ConfigFileName { get; set; }
        public string ConfigFileNameByUser { get; set; }
        public string SystemDataFile { get; set; }
        public string UserDataFile { get; set; }
    }
}
