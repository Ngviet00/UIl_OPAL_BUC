using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Drawing;

namespace UIL_OPAL
{
    public static class Global
    {
        private static readonly object lockExcel = new object();
        private static readonly object lockFileLog = new object();
        private static readonly object lockCSV = new object();

        public static TextBox txtLogError;

        public static bool isReadEvent1 = false;

        public static bool isReadEvent2 = false;

        public static bool isCheckDuplicateEvent1 = false;
        
        public static bool isCheckDuplicateEvent2 = false;

        public static PLC plc = new PLC();

        public static int OK = 0;

        public static int NG = 0;

        public static int IsCheckNAS = 1;

        public static string DiskLocal = @"D:\MES_AUTOMAINATION_SVC";
        
        public static string DiskNetwork = @"G:\";

        public static int AutoDeleteCSV = 0;

        public static int DayDeleteCSV = 90;

        public static string pathSqlite = @"Data Source=D:\OPAL_BUC\opal_buc.db";

        public static void ShowInfo(string msg)
        {
            MessageBox.Show($"{msg}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        public static void ShowError(string msg)
        {
            MessageBox.Show($"{msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        public static void WriteLog(string msg)
        {
            lock (lockFileLog)
            {
                string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

                string logFormat = DateTime.Now.ToLongDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";

                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }

                try
                {
                    using (StreamWriter writer = File.AppendText(logPath + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"))
                    {
                        writer.WriteLine(logFormat + msg);
                    }
                }
                catch (Exception ex)
                {
                    Global.ShowError($"Error can not save to file log, error: {ex.Message}");
                }
            }
        }

        private static string GetUniqueFilePath(string filePath)
        {
            try
            {
                string directory = Path.GetDirectoryName(filePath);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                string extension = Path.GetExtension(filePath);
                int count = 1;

                while (File.Exists(filePath))
                {
                    string newFileName = string.Empty;
                    newFileName = count == 1 ? $"{fileNameWithoutExtension}_d{extension}" : $"{fileNameWithoutExtension}_d{count}{extension}";
                    filePath = Path.Combine(directory, newFileName);
                    count++;
                }

                return filePath;
            }
            catch (Exception ex)
            {
                Global.WriteLog($"Error can not get unique file path, error: {ex.Message}");
                return filePath;
            }
        }

        public static void SaveCSV(Result rs, string directoryPath, int type, int finalResult) //1 local, 2 NAS
        {
            lock (lockCSV)
            {
                string fileNameCSV = "VNATHSSEM240701-" + (!string.IsNullOrWhiteSpace(rs.BucCoverQR) ? rs.BucCoverQR.Trim() : "Machine_testing") + ".csv";

                directoryPath = Path.Combine(directoryPath, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"));

                //check have folder and type = 1 is local
                if (!Directory.Exists(directoryPath) && type == 1)
                {
                    Directory.CreateDirectory(directoryPath);
                }

                //check if NAS not exist
                if (!Directory.Exists(directoryPath) && type == 2)
                {
                    Global.WriteLog("Not exist file path NAS!");
                    Global.ShowError("Not exist file path NAS!");
                    return;
                }

                //folder local
                string filePath = Path.Combine(directoryPath, fileNameCSV);
                string fileNameCSVLocal = GetUniqueFilePath(filePath);

                try
                {
                    using (var writer = new StreamWriter(fileNameCSVLocal))
                    using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        csv.WriteHeader<Result>();
                        csv.NextRecord();

                        if (finalResult == 1)
                        {
                            rs.Results = "OK";
                        }
                        else
                        {
                            rs.Results = "NG";
                        }

                        csv.WriteRecord(rs);
                        writer.Flush();
                    }

                    //copy file to folder NAS if check save to NAS
                    try
                    {
                        if (Global.IsCheckNAS == 1)
                        {
                            //folder NAS
                            string fileNameCSVFolderNAS = Path.Combine(Global.DiskNetwork, fileNameCSV);
                            fileNameCSVFolderNAS = GetUniqueFilePath(fileNameCSVFolderNAS);

                            File.Copy(fileNameCSVLocal, fileNameCSVFolderNAS, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        Global.WriteLog($"Can not save to file CSV folder NAS: {ex.Message}");
                        Global.ShowError($"Can not save to file CSV folder NAS: {ex.Message}");
                    }
                }
                catch (Exception ex)
                {
                    Global.WriteLog($"Can not save to file CSV: {ex.Message}");
                    Global.ShowError($"Can not save to file CSV: {ex.Message}");
                }
            }
        }

        public static void SaveExcel(Result rs, int finalResult)
        {
            string dateString = DateTime.Now.ToString("yyyy-MM-dd");

            lock (lockExcel)
            {
                try
                {
                    string folderExcel = Path.Combine(Global.DiskLocal, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"));

                    if (!Directory.Exists(folderExcel))
                    {
                        Directory.CreateDirectory(folderExcel);
                    }

                    string fileName = $"{dateString}.xlsx";
                    string filePath = Path.Combine(folderExcel, fileName);

                    using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Count == 0 ? package.Workbook.Worksheets.Add("Sheet1") : package.Workbook.Worksheets[0];

                        int row = worksheet.Dimension?.Rows + 1 ?? 1;

                        if (row == 1)
                        {
                            worksheet.Cells["A1:W1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells["A1:W1"].Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                            worksheet.Cells["A1:B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            worksheet.Cells["A1:B1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                            worksheet.Cells["C1:W1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                            worksheet.Cells["C1:W1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                            worksheet.Cells["A1:B1"].Style.WrapText = true;

                            worksheet.Column(1).Width = 25;
                            worksheet.Column(2).Width = 20;
                            worksheet.Column(3).Width = 15;
                            worksheet.Column(4).Width = 15;

                            worksheet.Column(21).Width = 10;
                            worksheet.Column(22).Width = 10;

                            worksheet.Cells[1, 1].Value = "BUC Cover\r\nQR코드";
                            worksheet.Cells[1, 2].Value = "Backet\r\nbar code";

                            worksheet.Cells[1, 3].Value = "압착 거리값";
                            worksheet.Cells[1, 4].Value = "압력 시간";

                            worksheet.Cells[1, 5].Value = "Temp 1";
                            worksheet.Cells[1, 6].Value = "Temp 2";
                            worksheet.Cells[1, 7].Value = "Temp 3";
                            worksheet.Cells[1, 8].Value = "Temp 4";

                            worksheet.Cells[1, 9].Value = "X1";
                            worksheet.Cells[1, 10].Value = "Y1";
                            worksheet.Cells[1, 11].Value = "Z1";

                            worksheet.Cells[1, 12].Value = "X2";
                            worksheet.Cells[1, 13].Value = "Y2";
                            worksheet.Cells[1, 14].Value = "Z2";

                            worksheet.Cells[1, 15].Value = "X3";
                            worksheet.Cells[1, 16].Value = "Y3";
                            worksheet.Cells[1, 17].Value = "Z3";

                            worksheet.Cells[1, 18].Value = "X4";
                            worksheet.Cells[1, 19].Value = "Y4";
                            worksheet.Cells[1, 20].Value = "Z4";

                            worksheet.Cells[1, 21].Value = "Result";

                            worksheet.Cells[1, 22].Value = "생산일자";
                            worksheet.Cells[1, 23].Value = "생산시간";
                        }

                        if (row == 1)
                        {
                            row += 1;
                        }

                        worksheet.Cells[row, 1].Value = rs.BucCoverQR;
                        worksheet.Cells[row, 2].Value = rs.BacketBarCode;
                        worksheet.Cells[row, 3].Value = rs.BendingDistanceValue.ToString() + "mm";
                        worksheet.Cells[row, 4].Value = rs.PressureTime.ToString() + "sec";

                        worksheet.Cells[row, 5].Value = rs.Temp1.ToString() + "℃";
                        worksheet.Cells[row, 6].Value = rs.Temp2.ToString() + "℃";
                        worksheet.Cells[row, 7].Value = rs.Temp3.ToString() + "℃";
                        worksheet.Cells[row, 8].Value = rs.Temp4.ToString() + "℃";

                        worksheet.Cells[row, 9].Value = rs.X1.ToString() + "mm";
                        worksheet.Cells[row, 10].Value = rs.Y1.ToString() + "mm";
                        worksheet.Cells[row, 11].Value = rs.Z1.ToString() + "mm";

                        worksheet.Cells[row, 12].Value = rs.X2.ToString() + "mm";
                        worksheet.Cells[row, 13].Value = rs.Y2.ToString() + "mm";
                        worksheet.Cells[row, 14].Value = rs.Z2.ToString() + "mm";

                        worksheet.Cells[row, 15].Value = rs.X3.ToString() + "mm";
                        worksheet.Cells[row, 16].Value = rs.Y3.ToString() + "mm";
                        worksheet.Cells[row, 17].Value = rs.Z3.ToString() + "mm";

                        worksheet.Cells[row, 18].Value = rs.X4.ToString() + "mm";
                        worksheet.Cells[row, 19].Value = rs.Y4.ToString() + "mm";
                        worksheet.Cells[row, 20].Value = rs.Z4.ToString() + "mm";

                        worksheet.Cells[row, 21].Value = finalResult == 1 ? "OK" : "NG";

                        worksheet.Cells[row, 22].Value = rs.Date;
                        worksheet.Cells[row, 23].Value = rs.Time;

                        FileInfo fileInfo = new FileInfo(filePath);
                        package.SaveAs(fileInfo);
                    }
                }
                catch (Exception ex)
                {
                    WriteLog($"Error can not save file excel, error: {ex.Message}");
                }
            }
        }


        public static string FormatNumber(int number)
        {
            NumberFormatInfo customNumberFormat = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
                NumberGroupSeparator = "."
            };

            return number.ToString("#,##0", customNumberFormat);
        }

        public static bool IsFormOpen(string formName)
        {
            return Application.OpenForms.Cast<Form>().Any(form => form.Name == formName);
        }

        // For UTC+7
        public static string GetCurrentTimeStampUTC7()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); 
            DateTime utcPlus7Now = TimeZoneInfo.ConvertTimeFromUtc(utcNow, timeZone);

            return utcPlus7Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static void WriteFileToTxt(string filePath, Dictionary<string, string> values)
        {
            try
            {
                var lines = File.ReadAllLines(filePath).ToList();
                var keysToUpdate = values.Keys.ToList();

                var updatedKeys = new HashSet<string>();

                for (int i = 0; i < lines.Count; i++)
                {
                    var parts = lines[i].Split(new[] { '=' }, 2);
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        if (values.ContainsKey(key))
                        {
                            lines[i] = $"{key}= {values[key]}";
                            updatedKeys.Add(key);
                        }
                    }
                }

                foreach (var key in keysToUpdate)
                {
                    if (!updatedKeys.Contains(key))
                    {
                        lines.Add($"{key}= {values[key]}");
                    }
                }

                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                WriteLog($"Error can not write value to file txt: {ex.Message}");
            }
        }

        public static Dictionary<string, string> ReadValueFileTxt(string filePath, List<string> keys)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();

                        if (keys.Contains(key))
                        {
                            values[key] = parts[1].Trim();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog($"Error can not read value from file txt: {ex.Message}");
            }

            return values;
        }

        public static string GetFilePathSetting()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting.txt");
        }
    }
}
