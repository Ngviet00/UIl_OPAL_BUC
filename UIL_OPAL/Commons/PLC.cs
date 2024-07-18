using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using ActUtlTypeLib;
using UnilityCommand.Plc.Mitsubishi;

namespace UIL_OPAL
{
    public class PLC : INotifyPropertyChanged
    {
        public FormMain formMain { get; set; }

        private bool _isStatusPLC;
        public bool IsStatusPLC
        {
            get { return _isStatusPLC; }

            set
            {
                if (_isStatusPLC != value)
                {
                    _isStatusPLC = value;
                    Notify();
                }
                _isStatusPLC = value;
            }
        }

        private bool _isALive;
        public bool IsALive
        {
            get { return _isALive; }

            set
            {
                if (_isALive != value)
                {
                    _isALive = value;
                    Notify();
                }
                _isALive = value;
            }
        }

        private bool _eventInputData1;
        public bool EventInputData1
        {
            get { return _eventInputData1; }

            set
            {
                if (_eventInputData1 != value)
                {
                    _eventInputData1 = value;
                    Notify();
                }
                _eventInputData1 = value;
            }
        }

        private bool _eventOutputData1;
        public bool EventOutputData1
        {
            get { return _eventOutputData1; }

            set
            {
                if (_eventOutputData1 != value)
                {
                    _eventOutputData1 = value;
                    Notify();
                }
                _eventOutputData1 = value;
            }
        }

        private bool _eventInputData2;
        public bool EventInputData2
        {
            get { return _eventInputData2; }

            set
            {
                if (_eventInputData2 != value)
                {
                    _eventInputData2 = value;
                    Notify();
                }
                _eventInputData2 = value;
            }
        }

        private bool _eventOutputData2;
        public bool EventOutputData2
        {
            get { return _eventOutputData2; }

            set
            {
                if (_eventOutputData2 != value)
                {
                    _eventOutputData2 = value;
                    Notify();
                }
                _eventOutputData2 = value;
            }
        }

        private ActUtlType _plc = new ActUtlType();

        private const int plcStation = 2;

        private const int timeSleep = 100;

        //K4B0
        private string REG_READ_APP_IS_ALIVE = "K4B0";

        public event PropertyChangedEventHandler PropertyChanged;

        public void Notify([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public PLC()
        {
            _plc.ActLogicalStationNumber = plcStation;

        }

        public void Connect()
        {
            if (_plc.Open() == 0)
            {
                Thread threadReadStatusPLC = new Thread(async () => await ReadStatusPLC());
                threadReadStatusPLC.Name = "THREAD_READ_STATUS_PLC";
                threadReadStatusPLC.IsBackground = true;
                threadReadStatusPLC.Start();
                formMain?.ShowLog("PLC Connect");
            }
            else
            {
                formMain?.ShowLog("Can not connect to PLC");
                Global.ShowError($"Error can not connect to PLC station number {plcStation}!");
            }
        }

        public void DisconnectPLC()
        {
            _plc.Close();
            _plc.Disconnect();
        }

        private async Task ReadStatusPLC()
        {
            while (true)
            {
                _plc.ReadDeviceRandom2(REG_READ_APP_IS_ALIVE, 1, out short valueReaded);

                BitArray bitArray = new BitArray(BitConverter.GetBytes((short)valueReaded));

                IsALive = bitArray[0];

                IsStatusPLC = bitArray[2];

                EventInputData1 = bitArray[5];

                EventInputData2 = bitArray[6];

                EventOutputData1 = bitArray[9];

                EventOutputData2 = bitArray[10];

                await Task.Delay(20);
            }
        }

        public void SetDevice2(string code, short signal)
        {
            _plc.SetDevice2(code, signal);
        }

        public void WriteWord(string register, short data)
        {
            _plc.WriteDeviceBlock2(register, 1, data);
        }

        public string ReadString(string register, int length)
        {
            try
            {
                short[] res = new short[length];
                _plc.ReadDeviceBlock2($"{register}", length, out res[0]);

                return PLCExtension.ConvertShortArrToString(res);
            }

            catch (Exception ex)
            {
                Global.WriteLog($"Error when get current status, error: {ex.Message}");
                return string.Empty;
            }            
        }

        public short[] ReadWord(string register, int length)
        {
            var data = new short[length];

            if (_plc?.ReadDeviceBlock2(register, length, out data[0]) == 0)
            {
                return data;
            }

            return data;
        }

        public int[] ReadDWord(string register, int length) //32 integer bit
        {
            var data = new int[length];
            var res = new short[length * 2];

            if (_plc?.ReadDeviceBlock2(register, length * 2, out res[0]) == 0)
            {
                for (int i = 0; i < length; i++)
                {
                    var r = PLCExtension.ConvertShortArr2Int(res[i * 2 + 1], res[i * 2]);
                    data[i] = r;
                }

                return data;
            }

            return null;
        }
    }
}
