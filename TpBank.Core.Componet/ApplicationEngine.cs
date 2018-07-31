using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Tpbank.Core.Common.System;

namespace TpBank.Core.Componet
{
    public class ApplicationEngine
    {
        
        static ApplicationEngine()
        {
            Configuration = new SystemConfig();
            Option = new SystemOption();
        }
        public static SystemConfig Configuration { get; set; }
        public static SystemOption Option { get; set; }

        public static void CheckAndCreateDefaultInfo()
        {

            #region Create system Db
            if (Configuration.SystemDb == null)
            {
                Configuration.SystemDb = new SystemSqliteDb(Configuration.SystemDataFile);
            }
            if (!File.Exists(Configuration.SystemDataFile))
            {
                // Create Db
                Configuration.SystemDb.createDB();
            }
            else
            {
                // check upgrade if low version
            }
            #endregion

            #region Create user Db
            if (Configuration.UserDb == null)
            {
                Configuration.UserDb = new UserSqliteDb(Configuration.UserDataFile);
            }
            if (!File.Exists(Configuration.UserDataFile))
            {
                // Create Db
                Configuration.UserDb.createDB();
            }
            else
            {
                // check upgrade if low version
            }
            #endregion

        }
    }
}
