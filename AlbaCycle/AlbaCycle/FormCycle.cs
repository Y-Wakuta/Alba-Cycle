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

using System.Data.SQLite

namespace AlbaCycle {

    delegate void Handler(string str, int i);

    public partial class FormCycle : Form {

        Timer time = new Timer();
        DateTime start = DateTime.Now;
        Stopwatch sw;
        List<string> saveData = new List<string>();

        public FormCycle() {
            InitializeComponent();
        }

        private void FormCycle_Load(object sender, EventArgs e) {
            MessageBox.Show("フロントディレーラー:インナー\nリアディレーラー:外から5枚目\nローラー負荷:H\nに設定してください。", "設定", MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            comboBoxBaud.SelectedIndex = 1;
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
        private void showChart(string data, int i) {
            DateTime end = DateTime.Now;
            TimeSpan time = end - start;
            int xValue = (int)time.TotalSeconds;

            #region グラフ設定
            try {
                chartCadence.Series["Cadence"].Points.AddXY(xValue, double.Parse(data));
                chartWatt.Series["Watt"].Points.AddXY(xValue, double.Parse(data));
            } catch (Exception) {
                return;
            }

            chartCadence.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartCadence.ChartAreas[0].AxisX.Minimum = time.TotalSeconds - 30;

            chartWatt.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartWatt.ChartAreas[0].AxisX.Minimum = time.TotalSeconds - 30;
            #endregion

        }

        /// <summary>
        /// Nextボタンを押したときにグラフをクリアします
        /// </summary>
        void ClearChart() {
            chartWatt.Series["Watt"].Points.Clear();
            chartCadence.Series["Cadence"].Points.Clear();
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

        private void serialPortCycle_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            string data = null;
            sw = new Stopwatch();
            sw.Start();
            try {
                data = serialPortCycle.ReadLine();
            } catch (Exception) {
                return;
            }
            sw.Stop();
            if (sw.ElapsedMilliseconds > 5000)
                serialPortCycle.DiscardInBuffer();

            var temp = DateTime.Now;
            var time = (temp - start).TotalSeconds.ToString();
            saveData.Add(data);
            BeginInvoke(new Handler(showChart),data, 0);
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            ClearChart();
        }
    }
}
