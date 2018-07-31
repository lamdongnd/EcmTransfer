using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tpbank.Core.Utilities.System
{
    public class FileAndFolder
    {
        public static string StartUpPath {
            get
            {
                return Application.StartupPath;
            }
        }

        public string GetMaxTotalFreeSpaceDisk()
        {
            string result = "";
            long totalFreeSpace = 0;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && string.IsNullOrWhiteSpace(result))
                {
                    result = drive.Name;
                    totalFreeSpace = drive.TotalFreeSpace;
                    continue;
                }
                if (drive.IsReady && !string.IsNullOrWhiteSpace(result) && drive.TotalFreeSpace > totalFreeSpace)
                {
                    result = drive.Name;
                    totalFreeSpace = drive.TotalFreeSpace;
                    continue;
                }
            }
            return result;
        }
        private Dictionary<string, long> GetTotalFreeSpace(string driveName)
        {
            Dictionary<string, long> dicResult = new Dictionary<string, long>();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    dicResult.Add(drive.Name, drive.TotalFreeSpace);
                }
            }
            return dicResult;
        }
    }
}
