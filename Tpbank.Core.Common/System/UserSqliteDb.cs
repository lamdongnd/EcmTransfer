using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Tpbank.Core.Model.SystemDb;

namespace Tpbank.Core.Common.System
{
    public class UserSqliteDb
    {
        private SQLiteConnection sql_con;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private string systemDataFile = "";
        private static readonly ILog logFile = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public UserSqliteDb(string systemDataFile)
        {
            this.systemDataFile = systemDataFile;
        }
        private void SetConnection()
        {
            try
            {                    
                    //logFile.Info("location SetConnection: " + location);
                    sql_con = new SQLiteConnection("Data Source=" + systemDataFile + ";Version=3;New=False;Compress=True; datetimeformat=CurrentCulture");
            }
            catch (Exception e)
            {
                logFile.Error("Exception SetConnection: " + e);

            }
        }
        public void createDB()
        {
            try
            {
                if (!File.Exists(systemDataFile))
                {
                    SQLiteConnection.CreateFile(systemDataFile);
                    SetConnection();
                    sql_con.Open();
                    string sql = "CREATE TABLE Batches (ID INTEGER PRIMARY KEY  AUTOINCREMENT,";
                    sql += "DateScan varchar(10), Batch varchar(20), RefNo varchar(20), ScanType varchar(20), Description nvarchar(500))";
                    SQLiteCommand batchesCmd = new SQLiteCommand(sql, sql_con);
                    batchesCmd.ExecuteNonQuery();
                    //sql = "create table Batches_Detail (ID INTEGER PRIMARY KEY   AUTOINCREMENT, Batch varchar(20), RefNo varchar(20), NumberRefPage int)";
                    //command = new SQLiteCommand(sql, sql_con);
                    //command.ExecuteNonQuery();
                    sql = "CREATE TABLE UploadHistory (ID INTEGER PRIMARY KEY  AUTOINCREMENT,";
                    sql += "Batch varchar(20), OrderId INTEGER, Branch varchar(10), ProductType varchar(10), QrCode varchar(100), RefNo varchar(20), FileName varchar(100),";
                    sql += "FolderId varchar(50), Status varchar(50), Description nvarchar(500), CreatedBy varchar(50), CreatedDate datetime default current_timestamp, ModifiedBy varchar(50), ModifiedDate datetime default current_timestamp)";
                    SQLiteCommand uploadHistoryCmd = new SQLiteCommand(sql, sql_con);
                    uploadHistoryCmd.ExecuteNonQuery();

                    sql = "CREATE TABLE ScanHistory (ID INTEGER PRIMARY KEY  AUTOINCREMENT, ";
                    sql += "Batch varchar(20), OrderId INTEGER, Branch varchar(10), ProductType varchar(10), QrCode varchar(100), FolderName varchar(255), ";
                    sql += "FileName varchar(100), Description nvarchar(500), CreatedBy varchar(50), CreatedDate datetime default current_timestamp)";
                    SQLiteCommand scanHistoryCmd = new SQLiteCommand(sql, sql_con);
                    scanHistoryCmd.ExecuteNonQuery();

                    sql_con.Close();
                }
            }
            catch (Exception e)
            {
                logFile.Error("Exception createDB: " + e);
            }
        }
        public void InsertLog(string user, string DateScan, string Batches, string RefNo, string ScanType)
        {
            try
            {
                SetConnection();
                sql_con.Open();
                string txtSQLQuery = "insert into  Batches (DateScan, Batch, RefNo, ScanType)";
                txtSQLQuery += "values ('" + DateScan + "','" + Batches + "','" + RefNo + "', '" + ScanType + "')";
                SQLiteCommand command = new SQLiteCommand(txtSQLQuery, sql_con);
                command.ExecuteNonQuery();
                sql_con.Close();
                //logFile.Info("InsertLog insert Success");
            }
            catch (Exception e)
            {
                logFile.Error("Exception InsertLog: " + e);
            }
        }
        public int InsertScanHistory(string batch, int orderId, string branch, string productType, string qrCode, string folderName, string fileName, string description, string createdBy)
        {
            int res = 0;
            try
            {
                //Insert new Item
                SetConnection();
                sql_con.Open();
                string txtSQLQuery = "INSERT INTO  ScanHistory ";
                txtSQLQuery += "(Batch, Branch, OrderId, ProductType, QrCode, FolderName, FileName, Description, CreatedBy, CreatedDate)";
                txtSQLQuery += "VALUES (@Batch, @Branch, @OrderId, @ProductType, @QrCode, @FolderName, @FileName, @Description, @CreatedBy, @CreatedDate)";
                #region Create SQLiteParameter
                //da.SelectCommand.Parameters.AddWithValue("@search","%" + txtSearch.Text + "%");
                SQLiteParameter[] paramList = new SQLiteParameter[]
                {
                    new SQLiteParameter()
                        {
                            ParameterName = "@Batch",
                            Value = batch, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 20,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@OrderId",
                            Value = orderId, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.Int32,
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@Branch",
                            Value = branch, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 20,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@ProductType",
                            Value = productType, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 20,  // Assuming a 20 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@QrCode",
                            Value = qrCode, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 100,  // Assuming a 50 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@FolderName",
                            Value = folderName, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 255,  // Assuming a 50 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@FileName",
                            Value = fileName, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 100,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@Description",
                            Value = description, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 500,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@CreatedBy",
                            Value = createdBy, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@CreatedDate",
                            Value = DateTime.UtcNow, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.DateTime,

                            IsNullable = true,
                        },
                };
                #endregion
                using (SQLiteCommand command = new SQLiteCommand(txtSQLQuery, sql_con))
                {
                    command.Parameters.AddRange(paramList);
                    res = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                logFile.Error("InsertScanHistory InsertScanHistory: " + e);
            }
            finally
            {
                sql_con.Close();
            }
            return res;
        }
        public void InsertUploadHistory(string batch, int orderId, string branch, string productType, string qrCode, string refNo, string fileName, string folderId, string status, string description, string createdBy)
        {
            try
            {
                List<UploadHistory> uploadHistoryList = GetUploadHistoryBy(batch, qrCode, refNo, productType, fileName, folderId, branch, createdBy);
                //int countItem = Count(qrCode, refNo, productType, fileName, folderId, branch, createdBy);
                if (uploadHistoryList != null && !uploadHistoryList.Any())
                {
                    //Insert new Item
                    SetConnection();
                    sql_con.Open();
                    string txtSQLQuery = "INSERT INTO  UploadHistory ";
                    txtSQLQuery += "(Batch, OrderId, Branch, ProductType, QrCode, RefNo, FileName, FolderId, Status, Description, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)";
                    txtSQLQuery += " VALUES (@Batch, @OrderId, @Branch, @ProductType, @QrCode, @RefNo, @FileName, @FolderId, @Status, @Description, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate)";
                    #region SQLiteParameter
                    SQLiteParameter[] paramList = new SQLiteParameter[]
                    {
                        new SQLiteParameter()
                            {
                                ParameterName = "@Batch",
                                Value = batch, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 20,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@OrderId",
                                Value = orderId, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.Int32,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@ProductType",
                                Value = productType, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 10,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@Branch",
                                Value = branch, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 20,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@QrCode",
                                Value = qrCode, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 100,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@RefNo",
                                Value = refNo, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 20,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@FileName",
                                Value = fileName, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 100,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@FolderId",
                                Value = folderId, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 50,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@Status",
                                Value = status, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 50,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@Description",
                                Value = description, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 500,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@CreatedBy",
                                Value = createdBy, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@CreatedDate",
                                Value = DateTime.UtcNow, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.DateTime,
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@ModifiedBy",
                                Value = createdBy, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.String,
                                Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                                IsNullable = true,
                            },
                        new SQLiteParameter()
                            {
                                ParameterName = "@ModifiedDate",
                                Value = DateTime.UtcNow, // Value = "%" + txtSearch.Text + "%",
                                DbType = DbType.DateTime,
                                IsNullable = true,
                            }
                    };
                    #endregion
                    SQLiteCommand command = new SQLiteCommand(txtSQLQuery, sql_con);
                    command.Parameters.AddRange(paramList);
                    command.ExecuteNonQuery();
                }
                else if (uploadHistoryList != null)
                {
                    if (uploadHistoryList.Count > 1)
                    {
                        logFile.Error(string.Format("Duplicate Items [Have {0} item] with: qrCode={1}, refNo={2}, productType={3}, fileName={4}, folderId={5}, branch={6}, createdBy={7}.\nAll this Item be update", uploadHistoryList.Count, qrCode, refNo, productType, fileName, folderId, branch, createdBy));
                    }
                    foreach (UploadHistory item in uploadHistoryList)
                    {
                        if (item.Status.ToString() != status || item.Description != description)
                        {
                            bool res = UpdateUploadHistoryById(item.ID, qrCode, refNo, productType, fileName, folderId, branch, status, description, createdBy);
                            if (!res)
                            {
                                logFile.Error(string.Format("Update item ERROR with: qrCode={0}, refNo={1}, productType={2}, fileName={3}, folderId={4}, branch={5}, createdBy={6}.\nAll this Item be update", qrCode, refNo, productType, fileName, folderId, branch, createdBy));
                            }
                        }
                    }
                    //int updateItemCount = UpdateUploadHistory(qrCode, refNo, productType, fileName, folderId, branch, status, detailMesage, createdBy);
                }
                else
                {
                    logFile.Error(string.Format("Exception when check exist Items with: qrCode={0}, refNo={1}, productType={2}, fileName={3}, folderId={4}, branch={5}, createdBy={6}.\nAll this Item be update", qrCode, refNo, productType, fileName, folderId, branch, createdBy));
                }
            }
            catch (Exception e)
            {
                logFile.Error("Exception InsertUploadHistory: " + e);
            }
            finally
            {
                sql_con.Close();
            }
        }

        private bool UpdateUploadHistoryById(int id, string qrCode, string refNo, string productType, string fileName, string folderId, string branch, string status, string description, string createdBy)
        {
            int res = 0; ;
            try
            {
                SetConnection();
                sql_con.Open();
                string txtSQLQuery = "UPDATE [UploadHistory]";
                txtSQLQuery += " SET [Status]=@Status,[Description]=@Description, [ModifiedBy]=@ModifiedBy, [ModifiedDate]=@ModifiedDate";
                txtSQLQuery += " WHERE [ID]=@ID";
                #region Create SQLiteParameter
                //da.SelectCommand.Parameters.AddWithValue("@search","%" + txtSearch.Text + "%");
                SQLiteParameter[] paramList = new SQLiteParameter[]
                {
                    new SQLiteParameter()
                        {
                            ParameterName = "@ID",
                            Value = id, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.Int32,
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@Status",
                            Value = status, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@Description",
                            Value = description, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 500,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@ModifiedBy",
                            Value = createdBy, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@ModifiedDate",
                            Value = DateTime.UtcNow, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.DateTime,
                            IsNullable = true,
                        },
                };
                #endregion
                using (SQLiteCommand command = new SQLiteCommand(txtSQLQuery, sql_con))
                {
                    command.Parameters.AddRange(paramList);
                    res = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                logFile.Error("Exception UpdateUploadHistoryById: " + e);
            }
            finally
            {
                sql_con.Close();
            }
            return res > 0;
        }

        private int UpdateUploadHistory(string qrCode, string refNo, string productType, string fileName, string folderId, string branch, string status, string description, string createdBy)
        {
            int res = 0; ;
            try
            {
                SetConnection();
                sql_con.Open();
                string txtSQLQuery = "UPDATE [UploadHistory]";
                txtSQLQuery += " SET [QrCode]=@qrCode, [RefNo]=@RefNo, [ProductType]=@ProductType, [FileName]=@FileName, [FolderId]=@FolderId, [Branch]=@Branch, [Status]=@Status,[Description]=@Description [ModifiedBy]=@ModifiedBy, [ModifiedDate]=@ModifiedDate";
                txtSQLQuery += " WHERE [QrCode]=@QrCode AND [RefNo]=@RefNo AND [ProductType]=@ProductType AND [FileName]=@FileName AND [FolderId]=@FolderId AND [Branch]=@Branch AND [CreatedBy]=@CreatedBy";
                #region Create SQLiteParameter
                //da.SelectCommand.Parameters.AddWithValue("@search","%" + txtSearch.Text + "%");
                SQLiteParameter[] paramList = new SQLiteParameter[]
                {
                    new SQLiteParameter()
                        {
                            ParameterName = "@QrCode",
                            Value = qrCode, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 100,  // Assuming a 50 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@RefNo",
                            Value = refNo, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 20,  // Assuming a 20 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@ProductType",
                            Value = productType, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 20,  // Assuming a 20 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@FileName",
                            Value = fileName, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 100,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@FolderId",
                            Value = folderId, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@Branch",
                            Value = branch, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@Status",
                            Value = status, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@Description",
                            Value = description, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 500,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@ModifiedBy",
                            Value = createdBy, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@ModifiedDate",
                            Value = DateTime.UtcNow, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.DateTime,
                            IsNullable = true,
                        },
                };
                #endregion
                using (SQLiteCommand command = new SQLiteCommand(txtSQLQuery, sql_con))
                {
                    command.Parameters.AddRange(paramList);
                    res = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                logFile.Error("Exception UpdateUploadHistory: " + e);
            }
            finally
            {
                sql_con.Close();
            }
            return res;
        }

        public int UploadHistoryCount(string qrCode, string refNo, string productType, string fileName, string folderId, string branch, string createdBy)
        {
            int countItem = 0; ;
            try
            {
                SetConnection();
                sql_con.Open();
                string txtSQLQuery = "SELECT COUNT(ID) AS total FROM [UploadHistory]";
                txtSQLQuery += " WHERE [QrCode]=@QrCode AND [RefNo]=@RefNo AND [ProductType]=@ProductType AND [FileName]=@FileName AND [FolderId]=@FolderId AND [Branch]=@Branch AND [CreatedBy]=@CreatedBy";
                #region Create SQLiteParameter
                //da.SelectCommand.Parameters.AddWithValue("@search","%" + txtSearch.Text + "%");
                SQLiteParameter[] paramList = new SQLiteParameter[]
                {
                    new SQLiteParameter()
                        {
                            ParameterName = "@QrCode",
                            Value = qrCode, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 100,  // Assuming a 50 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@RefNo",
                            Value = refNo, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 20,  // Assuming a 20 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@ProductType",
                            Value = productType, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 20,  // Assuming a 20 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@FileName",
                            Value = fileName, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 100,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@FolderId",
                            Value = folderId, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@Branch",
                            Value = branch, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                    new SQLiteParameter()
                        {
                            ParameterName = "@CreatedBy",
                            Value = createdBy, // Value = "%" + txtSearch.Text + "%",
                            DbType = DbType.String,
                            Size = 50,  // Assuming a 100 char size of the field annotation (-1 for MAX)
                            IsNullable = true,
                        },
                };
                #endregion
                using (SQLiteCommand command = new SQLiteCommand(txtSQLQuery, sql_con))
                {
                    command.Parameters.AddRange(paramList);
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        /*foreach (DataRow row in dt.Rows)
                        {
                            string rCode = Convert.ToString(row["QrCode"]);
                        }*/
                        if (dt != null)
                        {
                            countItem = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                logFile.Error("Exception Count: " + e);
            }
            finally
            {
                sql_con.Close();
            }
            return countItem;
        }
        public List<UploadHistory> GetUploadHistoryBy(string batch, string qrCode, string refNo, string productType, string fileName, string folderId, string branch, string createdBy)
        {
            List<UploadHistory> results = new List<UploadHistory>();
            try
            {
                SetConnection();
                sql_con.Open();
                string txtSQLQuery = "SELECT * FROM [UploadHistory]";
                txtSQLQuery += " WHERE " + string.Format("[Batch]='{0}' AND [QrCode]='{1}' AND [RefNo]='{2}' AND [ProductType]='{3}' AND [FileName]='{4}' AND [FolderId]='{5}' AND [Branch]='{6}' AND [CreatedBy]='{7}'", batch, qrCode, refNo, productType, fileName, folderId, branch, createdBy);

                /*SQLiteCommand command = sql_con.CreateCommand();                
                command.CommandText = txtSQLQuery;
                command.Parameters.AddWithValue("?a", logMsg);
                command.Parameters.AddWithValue("?b", type);*/


                using (SQLiteCommand command = new SQLiteCommand(txtSQLQuery, sql_con))
                {
                    SQLiteDataReader dataReader = command.ExecuteReader();
                    UploadHistory uHistory;
                    while (dataReader.Read())
                    {
                        uHistory = new UploadHistory();
                        uHistory.ID = Convert.ToInt32(dataReader["ID"]);
                        uHistory.QrCode = Convert.ToString(dataReader["QrCode"]);
                        uHistory.RefNo = Convert.ToString(dataReader["RefNo"]);
                        uHistory.ProductType = Convert.ToString(dataReader["ProductType"]);
                        uHistory.FileName = Convert.ToString(dataReader["FileName"]);
                        uHistory.FolderId = Convert.ToString(dataReader["FolderId"]);
                        uHistory.Branch = Convert.ToString(dataReader["Branch"]);
                        uHistory.Status = Convert.ToInt32(dataReader["Status"]);
                        uHistory.Description = Convert.ToString(dataReader["Description"]);
                        uHistory.CreatedBy = Convert.ToString(dataReader["CreatedBy"]);
                        object dateTime = dataReader["CreatedDate"];
                        uHistory.CreatedDate = Convert.ToDateTime(dateTime);
                        results.Add(uHistory);
                    }
                }
            }
            catch (Exception e)
            {
                logFile.Error("Exception GetUploadHistoryBy: " + e);
                results = null;
            }
            finally
            {
                sql_con.Close();
            }
            return results;
        }
        public DataTable GetBatchInfo(string user, string DateScan)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = new DataSet();
                //SetConnection(user);
                //sql_con.Open();
                string txtSQLQuery = "SELECT DISTINCT Batch, ScanType FROM 'Batches' WHERE DateScan = '" + DateScan + "'";
                dt = GetDataTable(txtSQLQuery, user);
            }
            catch (Exception e)
            {
                logFile.Error("Exception GetBatchInfo: " + e);
            }
            return dt;

        }
        public DataTable Search(string user, string DateScan, string RefNo, string bachesTime)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = new DataSet();
                //SetConnection(user);
                //sql_con.Open();
                string txtSQLQuery = "SELECT Batch, ScanType, RefNo FROM 'Batches' WHERE DateScan = '" + DateScan + "'";
                txtSQLQuery += " AND RefNo LIKE '%" + RefNo + "%' AND Batch LIKE '%" + bachesTime + "%'";
                txtSQLQuery += " GROUP BY Batch";
                dt = GetDataTable(txtSQLQuery, user);
            }
            catch (Exception e)
            {
                logFile.Error("Exception Search: " + e);
            }
            return dt;

        }
        public DataTable GetBatchDetail(string user, string Batches)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = new DataSet();
                //SetConnection(user);
                //sql_con.Open(); 
                string txtSQLQuery = "SELECT [Batch], [RefNo], Count(RefNo) AS Number, [ScanType], [Description]";
                txtSQLQuery += " FROM [Batches] WHERE [Batch]='" + Batches + "' GROUP BY [RefNo]";
                dt = GetDataTable(txtSQLQuery, user);
            }
            catch (Exception e)
            {
                logFile.Error("Exception GetBatchDetail: " + e);
            }
            return dt;

        }
        public DataTable GetDataTable(string sql, string user)
        {
            DataTable dt = new DataTable();
            try
            {
                SetConnection();
                sql_con.Open();
                SQLiteCommand mycommand = new SQLiteCommand(sql_con);
                mycommand.CommandText = sql;
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                sql_con.Close();
            }
            catch (Exception e)
            {
                logFile.Error("Exception GetDataTable: " + e);
            }
            return dt;
        }
    }
}
