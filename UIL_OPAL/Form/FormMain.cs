using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OfficeOpenXml;
using Sunny.UI;

namespace UIL_OPAL
{
    public partial class FormMain : UIForm
    {
        private static readonly object LockThreadReadData = new object();
       
        public FormMain()
        {
            InitializeComponent();

            Global.plc.formMain = this;

            //connect to PLC
            Global.plc.Connect();

            //ignore license epplus excel
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            //userCtrlInfoPC2.Start();

            //event
            Global.plc.PropertyChanged += Plc_PropertyChanged;
            this.FormClosed += FormMainClosed;

            //set font and size of header
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10, FontStyle.Bold);
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            //connect with sqlite and check has table
            SqlLite.Instance.CreateTable();

            Dictionary<string, string> currentData = Global.ReadValueFileTxt(Global.GetFilePathSetting(), new List<string> { "OK", "NG", "Is_Check_NAS", "DiskLocal", "DiskNetwork", "Auto_Delete_CSV", "Day_Delete_CSV" });

            Global.OK = int.Parse(currentData["OK"]);
            Global.NG = int.Parse(currentData["NG"]);
            Global.IsCheckNAS = int.Parse(currentData["Is_Check_NAS"]);
            Global.DiskLocal = currentData[@"DiskLocal"];
            Global.DiskNetwork = currentData[@"DiskNetwork"];
            Global.AutoDeleteCSV = int.Parse(currentData["Auto_Delete_CSV"]);
            Global.DayDeleteCSV = int.Parse(currentData["Day_Delete_CSV"]);

            //data pie chart
            UpdateData(Global.OK, Global.NG);

            Thread threadupdateLineChart = new Thread(async () => await ThreadUpdateLineChart());
            threadupdateLineChart.Name = "THREAD_UPDATE_LINE_CHART";
            threadupdateLineChart.IsBackground = true;
            threadupdateLineChart.Start();

            Thread threadAutoDeleteOldFile = new Thread(async () => await ThreadAutoDeleteOldFile());
            threadAutoDeleteOldFile.Name = "THREAD_AUTO_DELETE_OLD_FILE";
            threadAutoDeleteOldFile.IsBackground = true;
            threadAutoDeleteOldFile.Start();
        }

        private async Task ThreadAutoDeleteOldFile()
        {
            while (true)
            {
                if (Global.AutoDeleteCSV == 1)
                {
                    DateTime now = DateTime.Now;
                    string pathExcel = Global.DiskLocal;
                    DeleteExcel(pathExcel, now, Global.DayDeleteCSV);
                }
                ShowLog("Auto delete file running!");
                await Task.Delay(TimeSpan.FromHours(5));
            }
        }

        private void DeleteExcel(string path, DateTime now, int dayDelete)
        {
            if (!Directory.Exists(path))
            {
                Global.WriteLog($"Not found path to delete excel!");
                return;
            }

            int batchSize = 1000;

            var fileBatch = Directory.EnumerateFiles(path).Take(batchSize);

            while (fileBatch.Any())
            {
                foreach (var file in fileBatch)
                {
                    DateTime creationTime = File.GetCreationTime(file);
                    TimeSpan fileAge = now - creationTime;
                    if (fileAge.TotalDays > dayDelete)
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch (Exception ex)
                        {
                            ShowLog($"Error can not delete file, error: {ex.Message}", true);
                            Global.WriteLog($"Error can not delete file, error: {ex.Message}");
                        }
                    }
                }

                fileBatch = Directory.EnumerateFiles(path).Skip(batchSize).Take(batchSize);
            }

            var directories = Directory.GetDirectories(path);

            foreach (var directory in directories)
            {
                DeleteExcel(directory, now, dayDelete);
            }
        }

        private async Task ThreadUpdateLineChart()
        {
            while (true)
            {
                UpdateLineChart();
                await Task.Delay(TimeSpan.FromHours(1));
            }
        }

        public void UpdateLineChart()
        {
            Dictionary<string, string> rs = SqlLite.Instance.GetDataLineChart();
            List<double> value = new List<Double>();
            List<string> days = new List<string>();

            foreach (KeyValuePair<string, string> item in rs)
            {
                days.Add(item.Key);
                value.Add(Convert.ToDouble(item.Value));
            }

            lineChart.Mc1data = value;
            lineChart.Days = days;
            lineChart.UpdateChart();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.Value != null && e.Value.ToString() == "OK")
                {
                    e.CellStyle.ForeColor = Color.Lime;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.OrangeRed;
                }
            }
        }

        private void FormMainClosed(object sender, FormClosedEventArgs e)
        {
            Global.plc.DisconnectPLC();
        }

        private void Plc_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "IsALive" when ((PLC)sender).IsALive:
                    lbPCAlive.CheckBoxColor = Color.Lime;
                    Global.plc.SetDevice2("B100", (short)1);

                    break;

                case "IsALive" when !((PLC)sender).IsALive:
                    lbPCAlive.CheckBoxColor = Color.OrangeRed;
                    Global.plc.SetDevice2("B100", (short)0);

                    break;

                case "IsStatusPLC" when ((PLC)sender).IsStatusPLC == true:
                    Global.plc.SetDevice2("B102", (short)1);
                    break;

                case "IsStatusPLC" when ((PLC)sender).IsStatusPLC == false:
                    Global.plc.SetDevice2("B102", (short)0);

                    break;

                case "EventInputData1" when ((PLC)sender).EventInputData1:

                    if (Global.isCheckDuplicateEvent1 == false)
                    {
                        Global.isCheckDuplicateEvent1 = true;

                        Task.Run(() =>
                        {
                            CheckDuplicateEvent(1);
                        });
                    }

                    break;

                case "EventInputData1" when !((PLC)sender).EventInputData1:
                    Global.plc.SetDevice2("B105", (short)0);

                    break;

                case "EventOutputData1" when ((PLC)sender).EventOutputData1:

                    if (Global.isReadEvent1 == false)
                    {
                        Global.isReadEvent1 = true;

                        Task.Run(() =>
                        {
                            ReadDataEvent(1);
                            UpdateData(Global.OK, Global.NG);
                        });
                    }

                    break;

                case "EventOutputData1" when !((PLC)sender).EventOutputData1:
                    Global.plc.SetDevice2("B109", (short)0);

                    break;

                case "EventInputData2" when ((PLC)sender).EventInputData2:

                    if (Global.isCheckDuplicateEvent2 == false)
                    {
                        Global.isCheckDuplicateEvent2 = true;

                        Task.Run(() =>
                        {
                            CheckDuplicateEvent(2);
                        });
                    }

                    break;

                case "EventInputData2" when !((PLC)sender).EventInputData2:
                    Global.plc.SetDevice2("B106", (short)0);

                    break;

                case "EventOutputData2" when ((PLC)sender).EventOutputData2:

                    if (Global.isReadEvent2 == false)
                    {
                        Global.isReadEvent2 = true;

                        Task.Run(() =>
                        {
                            ReadDataEvent(2);
                            UpdateData(Global.OK, Global.NG);
                        });
                    }

                    break;

                case "EventOutputData2" when !((PLC)sender).EventOutputData2:
                    Global.plc.SetDevice2("B10A", (short)0);

                    break;
            }
        }

        private async void CheckDuplicateEvent(int type)
        {
            try
            {
                string qrCode = Global.plc.ReadString(type == 1 ? "W100" : "W200", 20);
                qrCode = qrCode.Trim();

                bool exist = SqlLite.Instance.CheckDuplicateQrCode(qrCode);

                Global.plc.WriteWord(type == 1 ? "W500" : "W600", exist == true ? (short)2 : (short)1); //2 ng, 1 ok

                PopupShowDuplicate(type, exist, qrCode);

                await Task.Delay(200);
                Global.plc.SetDevice2(type == 1 ? "B105" : "B106", (short)1);
            }
            catch (Exception ex)
            {
                Global.WriteLog($"Error check duplicate event {type}, error: {ex.Message}");
                Global.plc.SetDevice2(type == 1 ? "B105" : "B106", (short)1);
            }
            finally
            {
                if (type == 1)
                {
                    Global.isCheckDuplicateEvent1 = false;
                }

                if (type == 2)
                {
                    Global.isCheckDuplicateEvent2 = false;
                }
            }
        }

        public void PopupShowDuplicate(int type, bool exist, string qrCode)
        {
            string text = exist ? $"QR: {qrCode} DUPLICATE" : "";
            bool visible = exist;

            if (type == 1)
            {
                UpdateLabel(lbDuplicate1, text, visible);
            }
            else
            {
                UpdateLabel(lbDuplicate2, text, visible);
            }
        }

        private void UpdateLabel(Label label, string text, bool visible)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    label.Text = text;
                    label.Visible = visible;
                }));
            }
            else
            {
                label.Text = text;
                label.Visible = visible;
            }
        }

        private void ReadDataEvent(int type)
        {
            try
            {
                DateTime dt = DateTime.Now;

                Result rs = new Result();

                string bucCoverQR = Global.plc.ReadString(type == 1 ? "W300" : "W400", 20);
                bucCoverQR = !string.IsNullOrWhiteSpace(bucCoverQR) ? bucCoverQR.Trim() : string.Empty;
                rs.BucCoverQR = bucCoverQR;

                string backetBarcode = Global.plc.ReadString(type == 1 ? "W3B4" : "W4B4", 20);
                backetBarcode = !string.IsNullOrWhiteSpace(backetBarcode) ? backetBarcode.Trim() : string.Empty;
                rs.BacketBarCode = backetBarcode;

                int[] bendingDistance = Global.plc.ReadDWord(type == 1 ? "W32E" : "W42E", 1);
                rs.BendingDistanceValue = bendingDistance.Length == 0 ? 0 : (double)bendingDistance[0]/1000;

                short[] pressureTime = Global.plc.ReadWord(type == 1 ? "W330" : "W430", 1);
                rs.PressureTime = pressureTime.Length == 0 ? 0 : pressureTime[0];

                short[] temps = Global.plc.ReadWord(type == 1 ? "W338" : "W438", 4);

                rs.Temp1 = temps[0];
                rs.Temp2 = temps[1];
                rs.Temp3 = temps[2];
                rs.Temp4 = temps[3];

                short[] resultVision = Global.plc.ReadWord(type == 1 ? "W38D" : "W48D", 1);
                short[] result = Global.plc.ReadWord(type == 1 ? "W39B" : "W49B", 1);

                if (resultVision[0] == 1 && result[0] == 1)
                {
                    rs.Rs = "1";
                }
                else
                {
                    rs.Rs = "2";
                }

                int[] positions = Global.plc.ReadDWord(type == 1 ? "W360" : "W460", 12);

                rs.X1 = (double)positions[0]/1000;
                rs.Y1 = (double)positions[1]/1000;
                rs.Z1 = (double)positions[2]/1000;

                rs.X2 = (double)positions[3]/1000;
                rs.Y2 = (double)positions[4]/1000;
                rs.Z2 = (double)positions[5]/1000;

                rs.X3 = (double)positions[6]/1000;
                rs.Y3 = (double)positions[7]/1000;
                rs.Z3 = (double)positions[8]/1000;

                rs.X4 = (double)positions[9]/1000;
                rs.Y4 = (double)positions[10]/1000;
                rs.Z4 = (double)positions[11]/1000;

                rs.Date = dt.ToString("yyyy/MM/dd");
                rs.Time = dt.ToString("HH:mm:ss");

                AddRow(rs);

                //ShowLog($"--- event {type}, result vision: {resultVision[0]}, result plc: {result[0]}, result final: {rs.Rs}", true);

                if (rs.Rs == "1")
                {
                    lock (LockThreadReadData)
                    {
                        Global.OK += 1;

                        Global.WriteFileToTxt(Global.GetFilePathSetting(), new Dictionary<string, string>
                        {
                            { "OK", Global.OK.ToString() }
                        });
                    }
                }
                else
                {
                    lock (LockThreadReadData)
                    {
                        Global.NG += 1;

                        Global.WriteFileToTxt(Global.GetFilePathSetting(), new Dictionary<string, string>
                        {
                            { "NG", Global.NG.ToString() }
                        });
                    }
                }

                //if QR not null and content QR is different "20240630_1234567_UIL"
                if (!string.IsNullOrWhiteSpace(rs.BucCoverQR) && rs.BucCoverQR != "20240630_1234567_UIL")
                {
                    Global.SaveExcel(rs);

                    Global.SaveCSV(rs, Global.DiskLocal, 1);

                    if (Global.IsCheckNAS == 1)
                    {
                        Global.SaveCSV(rs, Global.DiskNetwork, 2);
                    }

                    string content = JsonConvert.SerializeObject(FormatDataSaveSqlite(rs));
                    SqlLite.Instance.Insert(string.IsNullOrWhiteSpace(bucCoverQR) ? $"Empty_{type}" : bucCoverQR, content, Global.GetCurrentTimeStampUTC7());
                }

                Global.plc.SetDevice2(type == 1 ? "B109" : "B10A", (short)1);
            }
            catch (Exception ex)
            {
                ShowLog($"Read event {type} errors");

                Global.plc.SetDevice2(type == 1 ? "B109" : "B10A", (short)1);

                Global.WriteLog($"Error can not read data event {type}, error: {ex.Message}");
            }
            finally
            {
                if (type == 1)
                {
                    Global.isReadEvent1 = false;
                }

                if (type == 2)
                {
                    Global.isReadEvent2 = false;
                }
            }
        }

        public string[] FormatDataSaveSqlite(Result rs)
        {
            rs.Rs = rs.Rs == "1" ? "OK" : "NG";

            return new string[]
            {
                rs.BacketBarCode, 
                rs.BendingDistanceValue.ToString(),
                rs.PressureTime.ToString(),
                rs.Rs.ToString(),
                rs.Temp1.ToString(),
                rs.Temp2.ToString(),
                rs.Temp3.ToString(),
                rs.Temp4.ToString(),
                rs.X1.ToString(),
                rs.Y1.ToString(),
                rs.Z1.ToString(),
                rs.X2.ToString(),
                rs.Y2.ToString(),
                rs.Z2.ToString(),
                rs.X3.ToString(),
                rs.Y3.ToString(),
                rs.Z3.ToString(),
                rs.X4.ToString(),
                rs.Y4.ToString(),
                rs.Z4.ToString()
            };
        }

        int numberRowDGV = 0;

        public void AddRow(Result rs)
        {
            Action action = () =>
            {
                StringBuilder upPoint = new StringBuilder();
                StringBuilder leftPoint = new StringBuilder();
                StringBuilder rightPoint = new StringBuilder();
                StringBuilder downPoint = new StringBuilder();

                upPoint.Append(rs.X1).Append(", ").Append(rs.Y1).Append(", ").Append(rs.Z1);
                leftPoint.Append(rs.X2).Append(", ").Append(rs.Y2).Append(", ").Append(rs.Z2);
                rightPoint.Append(rs.X4).Append(", ").Append(rs.Y4).Append(", ").Append(rs.Z4);
                downPoint.Append(rs.X3).Append(", ").Append(rs.Y3);

                numberRowDGV += 1;

                if (numberRowDGV > 15000)
                {
                    numberRowDGV = 1;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                }

                dataGridView1.Rows.Insert(0, new string[] { numberRowDGV.ToString(), rs.BucCoverQR, rs.BacketBarCode, rs.BendingDistanceValue.ToString(), rs.PressureTime.ToString(), rs.Rs == "1" ? "OK" : "NG",
                    rs.Temp1.ToString(), rs.Temp2.ToString(), rs.Temp3.ToString(), rs.Temp4.ToString(), 
                    upPoint.ToString(), leftPoint.ToString(), rightPoint.ToString(), downPoint.ToString(), 
                    DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:ff") });
            };

            if (this.InvokeRequired)
                this.Invoke(action);
            else
                action();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dddd, MMM dd, yyyy | HH:mm:ss");
        }

        private void UpdateData(int OK, int NG)
        {
            Action action = () =>
            {
                int total = OK + NG;
                lbltotal.Text = Global.FormatNumber(total) + " EA";
                pieChart.UpdateChartData(OK, NG);
                lbTotalTray.Text = Global.FormatNumber((int)Math.Floor((double)total / 18));

                double percentOk = total > 0 ? Math.Round(((double)OK / (double)total * 100), 2) : 0;
                double percentNG = total > 0 ? Math.Round((100 - percentOk), 2) : 0;

                lbPercentOK.Text = $"OK: {percentOk}%";
                lbPercentNG.Text = $"NG: {percentNG}%";
            };

            if (this.InvokeRequired)
                this.Invoke(action);
            else
                action();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (!Global.IsFormOpen("FormSetting"))
            {
                FormSetting formSetting = new FormSetting();
                formSetting.clearData += Cleardata;
                formSetting.resetDB += ResetDB;
                formSetting.ShowDialog();
            }
        }

        private void ResetDB()
        {
            UpdateLineChart();
        }

        private void Cleardata()
        {
            Action action = () =>
            {
                Global.OK = 0;
                Global.NG = 0;
                UpdateData(Global.NG, Global.OK);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                richTextBox1.Text = string.Empty;
                Global.WriteFileToTxt(Global.GetFilePathSetting(), new Dictionary<string, string>
                {
                    { "OK", "0" },
                    { "NG", "0" },
                });
            };

            if (this.InvokeRequired)
                this.Invoke(action);
            else
                action();
        }

        public void ShowLog(string msg, bool error = false)
        {
            
            Action action = () =>
            {
                if (error)
                {
                    richTextBox1.SelectionColor = Color.Red;
                }

                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.Now.ToString("yy-MM-dd HH:mm:ss")).Append(" - ").Append(msg).Append(Environment.NewLine);

                richTextBox1.AppendText(sb.ToString());
                richTextBox1.ScrollToCaret();

                richTextBox1.SelectionColor = Color.Black;
            };

            if (this.InvokeRequired)
                this.Invoke(action);
            else
                action();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            Cleardata();
            ShowLog("User clear data!", true);
        }
    }
}
