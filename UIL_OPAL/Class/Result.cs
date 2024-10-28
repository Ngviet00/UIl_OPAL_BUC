using CsvHelper.Configuration.Attributes;
using System;

namespace UIL_OPAL
{
    public class Result
    {
        public string BucCoverQR { get; set; } = string.Empty;
        public string BacketBarCode { get; set; } = string.Empty;
        public double BendingDistanceValue { get; set; } = 0;
        public double PressureTime { get; set; } = 0;
        public short Temp1 { get; set; } = 0;
        public short Temp2 { get; set; } = 0;
        public short Temp3 { get; set; } = 0;
        public short Temp4 { get; set; } = 0;

        [Name("U1")]
        public double X1 { get; set; } = 0;

        [Name("U2")]
        public double Y1 { get; set; } = 0;

        [Name("U3")]
        public double Z1 { get; set; } = 0;

        [Name("L1")]
        public double X2 { get; set; } = 0;

        [Name("L2")]
        public double Y2 { get; set; } = 0;

        [Name("L3")]
        public double Z2 { get; set; } = 0;

        [Name("D1")]
        public double X3 { get; set; } = 0;

        [Name("D2")]
        public double Y3 { get; set; } = 0;

        [Name("D3")]
        public double Z3 { get; set; } = 0;

        [Name("R1")]
        public double X4 { get; set; } = 0;

        [Name("R2")]
        public double Y4 { get; set; } = 0;

        [Name("R3")]
        public double Z4 { get; set; } = 0;
        public string Results { get; set; } = "1";
        public string Date { get; set; } = DateTime.Now.ToString("yyyy/MM/dd");
        public string Time { get; set; } = DateTime.Now.ToString("HH:mm:ss");
    }
}
