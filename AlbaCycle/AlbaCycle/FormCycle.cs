using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;
using System.Diagnostics;

namespace AlbaCycle {

    delegate void Handler(string str0, string str1, string str2);
    delegate void DataHandler(string _sDatas);

    public partial class FormCycle : Form {

        Timer time = new Timer();
        DateTime start = DateTime.Now;
        Stopwatch sw;
        List<string> saveData = new List<string>();
        List<CycleDatas> _cycleDataList = new List<CycleDatas>();
        CycleRoutine Routine = new CycleRoutine();



        public FormCycle() {
            InitializeComponent();
        }

        private void FormCycle_Load(object sender, EventArgs e) {
            MessageBox.Show("フロントディレーラー:インナー\nリアディレーラー:外から5枚目\nローラー負荷:H\nに設定してください。", "設定", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            buttonConnect.Focus();

            string[] Portlist = SerialPort.GetPortNames();

            SerialPort _serialport = new SerialPort();

            comboBoxPort.Items.Clear();

            foreach (var Port in Portlist)
                comboBoxPort.Items.Add(Port);

            if (comboBoxPort.Items.Count == 0)
                comboBoxPort.Items.Add("利用可能なシリアルポートは存在しません。");
            else if (comboBoxPort.Items.Count > 0) {
                comboBoxPort.SelectedIndex = 0;
                try {
                    serialPortCycle.PortName = comboBoxPort.SelectedItem.ToString();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                }

            }
            #region comboBoxBaudの設定
            List<bauditems> baudList = new List<bauditems>();

            bauditems baud1 = new bauditems();
            baud1.NAME = "4800bps";
            baud1.RATE = 4800;
            baudList.Add(baud1);
            bauditems baud2 = new bauditems();
            baud2.NAME = "9600bps";
            baud2.RATE = 9600;
            baudList.Add(baud2);
            bauditems baud3 = new bauditems();
            baud3.NAME = "115200bps";
            baud3.RATE = 115200;
            baudList.Add(baud3);
            comboBoxBaud.SelectedText = "NAME";
            comboBoxBaud.SelectedValue = "RATE";
            comboBoxBaud.DisplayMember = "NAME";
            bauditemsBindingSource.DataSource = baudList;
            comboBoxBaud.SelectedIndex = 2;
            #endregion

            #region グラフ設定

            chartCadence.ChartAreas[0].AxisX.Title = "Time[s]";
            chartCadence.ChartAreas[0].AxisY.Title = "Cadence[/m]";

            chartWatt.ChartAreas[0].AxisX.Title = "Time[s]";
            chartWatt.ChartAreas[0].AxisY.Title = "Watt[W]";

            #endregion
        }

        private void comboBoxBaud_TextChanged(object sender, EventArgs e) {
            if (comboBoxBaud.SelectedIndex != -1)
                serialPortCycle.BaudRate = (int)comboBoxBaud.SelectedValue;
        }

        private void comboBoxBaud_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxBaud.SelectedIndex != -1)
                serialPortCycle.BaudRate = (int)comboBoxBaud.SelectedValue;
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="datas">配列化した受信データ</param>
        /// <param name="i"></param>
        private void showChart(string Cadence, string Watt, string Speed) {
            DateTime end = DateTime.Now;
            TimeSpan time = end - start;
            int xValue = (int)time.TotalSeconds;

            #region グラフ設定
            try {
                chartCadence.Series["Cadence"].Points.AddXY(xValue, double.Parse(Cadence));
                chartWatt.Series["Watt"].Points.AddXY(xValue, double.Parse(Watt));
                chartSpeed.Series["Speed"].Points.AddXY(xValue, double.Parse(Speed));
            } catch (Exception) {
                return;
            }

            chartCadence.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartCadence.ChartAreas[0].AxisX.Minimum = 0;

            chartWatt.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartWatt.ChartAreas[0].AxisX.Minimum = 0;

            chartSpeed.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartSpeed.ChartAreas[0].AxisX.Maximum = 0;

            #endregion

        }

        /// <summary>
        /// Nextボタンを押したときにグラフをクリアします
        /// </summary>
        void ClearChart() {
            chartWatt.Series["Watt"].Points.Clear();
            chartCadence.Series["Cadence"].Points.Clear();
            chartSpeed.Series["Speed"].Points.Clear();
        }

        //設定画面を開く
        private void buttonConfig_Click(object sender, EventArgs e) {
            FormConfig _formConfig = new FormConfig();
            _formConfig.Show();
        }

        private void FormCycle_FormClosing(object sender, FormClosingEventArgs e) {
            serialPortCycle.Dispose();
            serialPortCycle.Close();
        }

        private async void serialPortCycle_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            //    MessageBox.Show("Data Received!");
            CycleDatas _cycleData = new CycleDatas();
            string data = null;
            sw = new Stopwatch();
            sw.Start();
            int data_count;
            int data_num;
            int z_int;
            double z_double;
            await Task.Run(() => {
                try {
                    data = serialPortCycle.ReadExisting();
                } catch (Exception) {
                    return;
                }
                //         sw.Stop();
                //    if (sw.ElapsedMilliseconds > 5000)
                //      serialPortCycle.DiscardInBuffer();
                //   if (data.Count() == 4) {                            //ここで配列の要素数のフィルタを入れる。
                char[] charData = data.ToCharArray();
                for (data_num = 0, data_count = 0; data_count < charData.Count();) {
                    if (data[data_count] == ';') {
                        data_num++;
                    }
                    if (data_num == 6) {
                        _cycleData.Voltage = data[data_count].ToString();
                    }
                    else if (data_num == 14) {
                        _cycleData.Speed = data[data_count].ToString();
                    }
                    else if (data_num == 15) {
                        z_int = (int)data[data_count - 1] + (int)data[data_count - 2] * 10 + (int)data[data_count - 3] * 100;
                        if (data[data_count - 4] != '0') z_int *= -1;
                        z_double = (double)z_int / 6; //角度補正前ふつうに
                        _cycleData.Cadence = z_double.ToString();
                    }
                    data_count++;
                    //       }

                    _cycleDataList.Add(_cycleData);
                    saveData.Add(data);
                }
            });
            BeginInvoke(new DataHandler(ShowSerialDatas), data);
            BeginInvoke(new Handler(showChart), _cycleData.Cadence, _cycleData.Watt, _cycleData.Speed);
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            string path = @"\datas\" + DateTime.Now.ToString("MMddHHmm") + ".csv";
            Routine.writeDatas(_cycleDataList, path);
            ClearChart();
        }

        public void ShowSerialDatas(string _cData) {
            textBoxSerialData.AppendText(_cData + Environment.NewLine);
        }

        private void buttonConnect_Click(object sender, EventArgs e) {
            MessageBox.Show("jfkdsa;l");
            if (serialPortCycle.IsOpen == false) {
                try {
                    serialPortCycle.Open();
                    serialPortCycle.DataReceived += new SerialDataReceivedEventHandler(serialPortCycle_DataReceived);
                } catch (Exception) {
                    MessageBox.Show("利用可能なシリアルポートがありません");
                }
                serialPortCycle.DtrEnable = true;
                serialPortCycle.RtsEnable = true;
            }
            if (serialPortCycle.IsOpen == true) {
                buttonConnect.Enabled = false;
                buttonClose.Enabled = true;
                buttonNext.Enabled = false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            if (serialPortCycle.IsOpen == true) {
                serialPortCycle.DiscardInBuffer();
                serialPortCycle.Close();
                buttonConnect.Enabled = true;
                buttonNext.Enabled = true;
                buttonClose.Enabled = false;
            }
        }
    }
}
