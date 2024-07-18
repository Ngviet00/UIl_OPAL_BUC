using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UIL_OPAL
{
    public partial class FormSearch : Form
    {
        string lastBarcode = string.Empty;

        public FormSearch()
        {
            InitializeComponent();

            dataGridViewSearch.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            dataGridViewSearch.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10, FontStyle.Bold);

            txtBarcode.Focus();
        }

        private void btnSearchBarcode_Click(object sender, EventArgs e)
        {
            var currentBarcode = txtBarcode.Text;

            if (string.IsNullOrWhiteSpace(currentBarcode))
            {
                Global.ShowError("QR_Code can not empty!");
                txtBarcode.Focus();
                return;
            }

            if (lastBarcode == currentBarcode)
            {
                return;
            }

            lastBarcode = currentBarcode;

            List<ResultSearch> rs = SqlLite.Instance.GetResultSearch(currentBarcode);

            if (rs.Count == 0)
            {
                Global.ShowInfo("Not found QR_Code!");
                return;
            }

            dataGridViewSearch.Rows.Clear();
            dataGridViewSearch.Refresh();

            int idx = 1;

            foreach (var item in rs)
            {
                idx++;
                string[] data = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(item.Content);

                var BacketBarCode = data[0];
                var BendingDistanceValue = data[1];
                var PressureTime = data[2];
                var Rs = data[3];
                var Temp1 = data[4];
                var Temp2 = data[5];
                var Temp3 = data[6];
                var Temp4 = data[7];
                var X1 = data[8];
                var Y1 = data[9];
                var Z1 = data[10];
                var X2 = data[11];
                var Y2 = data[12];
                var Z2 = data[13];
                var X3 = data[14];
                var Y3 = data[15];
                var Z3 = data[16];
                var X4 = data[17];
                var Y4 = data[18];
                var Z4 = data[19];

                StringBuilder upPoint = new StringBuilder();
                StringBuilder leftPoint = new StringBuilder();
                StringBuilder rightPoint = new StringBuilder();
                StringBuilder downPoint = new StringBuilder();

                upPoint.Append(X1).Append(", ").Append(Y1).Append(", ").Append(Z1);
                leftPoint.Append(X2).Append(", ").Append(Y2).Append(", ").Append(Z2);
                rightPoint.Append(X4).Append(", ").Append(Y4).Append(", ").Append(Z4);
                downPoint.Append(X3).Append(", ").Append(Y3);

                dataGridViewSearch.Rows.Insert(0, new string[] { idx.ToString(), item.QrCode, BacketBarCode, BendingDistanceValue, PressureTime, Rs == "1" ? "OK" : "NG", Temp1, Temp2, Temp3, Temp4, upPoint.ToString(), leftPoint.ToString(), rightPoint.ToString(), downPoint.ToString(), item.CreatedAt });
            }   
        }
    }
}
