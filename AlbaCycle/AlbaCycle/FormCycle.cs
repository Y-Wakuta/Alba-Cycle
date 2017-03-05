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


namespace AlbaCycle
{

    delegate void ChartHandler(CycleDatas cData);

    public partial class FormCycle : Form
    {

        Stopwatch generalTimer;
        List<CycleDatas> _cycleDataList = new List<CycleDatas>();
        CycleDatas chartData = new CycleDatas();
        string data = null;
        bool giveupFlag = false;
        Stopwatch FTPTimer;
        Stopwatch TabataTimer;
        Timer FTPEventTimer;
        Timer TabataEventTimer;
        double FTPSum = 0.0;
        double SumCount = 0.0;
        int _loadLevel = 6;
        string Voltage;
        int IntervalCounter = 0;
        Boolean BeepFlag = true;

        public FormCycle()
        {
            InitializeComponent();
        }

        private void FormCycle_Load(object sender, EventArgs e)
        {
            MessageBox.Show("フロントディレーラー:インナー\nリアディレーラー:外から5枚目\nに設定してください。", "設定", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            buttonConnect.Focus();

            var Portlist = SerialPort.GetPortNames();

            var _serialport = new SerialPort();

            comboBoxPort.Items.Clear();

            foreach (var Port in Portlist)
                comboBoxPort.Items.Add(Port);

            if (comboBoxPort.Items.Count == 0)
                comboBoxPort.Items.Add("利用可能なシリアルポートは存在しません。");
            else if (comboBoxPort.Items.Count > 0)
            {
                comboBoxPort.SelectedIndex = 0;
                try
                {
                    serialPortCycle.PortName = comboBoxPort.SelectedItem.ToString();
                }
                catch (Exception exc)
                {
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

            chartSpeed.ChartAreas[0].AxisX.Title = "Time[s]";
            chartSpeed.ChartAreas[0].AxisY.Title = "Speed[m/s]";

            #endregion

            //負荷を設定
            var levelList = new List<LoadLevel>();
            for (int i = 6; i > 0; i--)
            {
                var level = new LoadLevel(i);
                levelList.Add(level);
            }
            bindingSourceLoadLevel.DataSource = levelList;
            comboBoxSelectLoad.DisplayMember = "loadLevel";
            comboBoxSelectLoad.SelectedIndex = 1;

            buttonFreeRun.Enabled = false;
            buttonReStart.Enabled = false;

        }

        private void comboBoxBaud_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxBaud.SelectedIndex != -1)
                serialPortCycle.BaudRate = (int)(comboBoxBaud.SelectedValue);
        }

        private void comboBoxBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBaud.SelectedIndex != -1)
                serialPortCycle.BaudRate = (int)(comboBoxBaud.SelectedValue);
        }

        private void comboBoxSelectLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectLoad.SelectedIndex != -1)
                _loadLevel = ((LoadLevel)(comboBoxSelectLoad.SelectedItem)).loadLevel;
        }

        private void FormCycle_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPortCycle.Dispose();
            serialPortCycle.Close();
        }

        private async void serialPortCycle_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            await Task.Run(() =>
            {
                try
                {
                    data += serialPortCycle.ReadExisting();
                }
                catch (Exception)
                {
                    return;
                }
            });

            sw.Stop();

            //受信に時間がかかりすぎた場合はbufferを削除します。（いらないかも）
            if (sw.ElapsedMilliseconds > 500)
                serialPortCycle.DiscardInBuffer();

            //データが短すぎるもしくは長すぎる場合は、returnしてdataの中身を調整します。

            #region filter
            if (data == null)
            {
                return;
            }
            else if (data.Length < Constants.minDataPoolAmount)
            {
                return;
            }
            else if (data.Length > Constants.maxDataPoolAmount)
            {
                data = null;
                return;
            }
            #endregion

            var tempDataLines = data.Trim().Replace(";\r\n;", "\n").Split('\n');
            var dataLines = new List<string>();
            foreach (var dataMem in tempDataLines)
            {

                if (dataMem.Length > 20)
                    dataLines.Add(dataMem);
            }
            try
            {
                foreach (var dataLine in dataLines)
                {
                    var datas = dataLine.Trim().Split(';');
                    foreach (var oneData in datas)
                    {
                        if (String.IsNullOrEmpty(oneData))
                            return;
                    }

                    if (datas.Count() == 14)
                    {
                        var _cycleData = new CycleDatas();
                        _cycleData.Voltage = datas[5];
                        Voltage = datas[5];
                        _cycleData.Watt = CycleRoutine.CadenceToWatt((-double.Parse(datas[13]) / 6.0), _loadLevel).ToString();
                        _cycleData.Speed = (-double.Parse(datas[13])).ToString();
                        _cycleData.Cadence = (-double.Parse(datas[13]) / 6.0).ToString();
                        _cycleData.Timer = generalTimer;
                        _cycleDataList.Add(_cycleData);
                        BeginInvoke((MethodInvoker)(() => ShowCycleData(_cycleData)));
                        BeginInvoke(new ChartHandler(ShowChart), _cycleData);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            if (serialPortCycle.IsOpen == false)
            {
                generalTimer = new Stopwatch();
                generalTimer.Start();
                try
                {
                    serialPortCycle.Open();
                    serialPortCycle.DataReceived += new SerialDataReceivedEventHandler(serialPortCycle_DataReceived);
                }
                catch (Exception)
                {
                    MessageBox.Show("利用可能なシリアルポートがありません");
                }
                serialPortCycle.DtrEnable = true;
                serialPortCycle.RtsEnable = true;
            }
            if (serialPortCycle.IsOpen == true)
            {
                buttonConnect.Enabled = false;
                buttonClose.Enabled = true;
                buttonNext.Enabled = false;
                buttonFreeRun.Enabled = true;
                buttonFreeRun.Focus();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (serialPortCycle.IsOpen == true)
            {
                serialPortCycle.DiscardInBuffer();
                serialPortCycle.Close();
                buttonConnect.Enabled = true;
                buttonNext.Enabled = true;
                buttonClose.Enabled = false;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string path = @"\datas\" + DateTime.Now.ToString("MMddHHmm") + ".csv";
            CycleRoutine.writeDatas(_cycleDataList, path);
            ClearChart();
        }

        private void buttonFreeRun_Click(object sender, EventArgs e)
        {
            giveupFlag = false;
            buttonFreeRun.Enabled = false;
            buttonReStart.Enabled = true;
            FTPTimer = new Stopwatch();
            FTPEventTimer = new Timer();
            FTPTimer.Start();
            FTPInitializeTimer();
            FTPEventTimer.Tick += new EventHandler(this.OnFreeTick_Timer);
        }

        private void buttonTabata_Click(object sender, EventArgs e)
        {
            giveupFlag = false;
            buttonTabata.Enabled = false;
            buttonReStart.Enabled = true;
            TabataTimer = new Stopwatch();
            TabataEventTimer = new Timer();
            TabataTimer.Start();
            TabataInitializeTimer();
            TabataEventTimer.Tick += new EventHandler(this.OnTabataTick_Timer);
        }

        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            giveupFlag = true;
            FTPTimer.Stop();
            buttonFreeRun.Enabled = true;
            FTPEventTimer.Dispose();
            SumCount = 0;
            FTPSum = 0;
            Application.Restart();
        }

        public void OnFreeTick_Timer(object sender, EventArgs e)
        {
            double TimeSecond = FTPTimer.ElapsedMilliseconds / 1000.0;
            if (TimeSecond < 20 * 60 && !giveupFlag)
            {
                labelFtpStatus.Text = "Measuring";
                labelTimer.Text = TimeSecond.ToString();
                labelVoltage.Text = CycleRoutine.ToRoundDown((double.Parse(Voltage) / 1000.0), 7).ToString();
                try
                {
                    FTPSum += double.Parse(textBoxWatt.Text);
                    SumCount = SumCount + 1.0;
                }
                catch (Exception)
                {
                    return;
                }
                labelFTP.Text = CycleRoutine.ToRoundDown(((FTPSum / SumCount) * 0.95), 2).ToString();
            }
            else
            {
                labelFtpStatus.Text = "Confirmed";
            }
        }

        public void OnTabataTick_Timer(object sender, EventArgs e)
        {
            double TimeSecond = TabataTimer.ElapsedMilliseconds / 1000.0;

            if (IntervalCounter > 7)
            {
                IntervalCounter = 0;
                labelFtpStatus.Text = "Completed";

                TabataTimer.Stop();
            }
            if (TimeSecond < 20 + IntervalCounter * 30 && !giveupFlag)
            {
                if (BeepFlag)
                {
                    System.Media.SystemSounds.Beep.Play();
                    BeepFlag = !BeepFlag;
                }
                labelFtpStatus.Text = "Full Power";
                labelTimer.Text = TimeSecond.ToString();
                labelVoltage.Text = CycleRoutine.ToRoundDown((double.Parse(Voltage) / 1000.0), 7).ToString();
                try
                {
                    FTPSum += double.Parse(textBoxWatt.Text);
                    SumCount = SumCount + 1.0;
                }
                catch (Exception)
                {
                    return;
                }
                labelFTP.Text = CycleRoutine.ToRoundDown(((FTPSum / SumCount) * 0.95), 2).ToString();
            }
            else if (TimeSecond < 30 + IntervalCounter * 30 && !giveupFlag)
            {
                if (!BeepFlag)
                {
                    System.Media.SystemSounds.Beep.Play();
                    BeepFlag = !BeepFlag;
                }
                labelFtpStatus.Text = "Rest";
                labelTimer.Text = TimeSecond.ToString();
                labelVoltage.Text = CycleRoutine.ToRoundDown((double.Parse(Voltage) / 1000.0), 7).ToString();
                try
                {
                    FTPSum += double.Parse(textBoxWatt.Text);
                    SumCount = SumCount + 1.0;
                }
                catch (Exception)
                {
                    return;
                }
                labelFTP.Text = CycleRoutine.ToRoundDown(((FTPSum / SumCount) * 0.95), 2).ToString();
            }
            else
                IntervalCounter++;
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="datas">配列化した受信データ</param>
        /// <param name="i"></param>
        private void ShowChart(CycleDatas cDatas)
        {
            var xvalue = generalTimer.ElapsedMilliseconds / 1000.0;

            #region グラフ設定
            try
            {
                chartWatt.Series["Watt"].Points.AddXY(xvalue, double.Parse(cDatas.Watt));
                chartSpeed.Series["Speed"].Points.AddXY(xvalue, double.Parse(cDatas.Speed));
                chartCadence.Series["Cadence"].Points.AddXY(xvalue, double.Parse(cDatas.Cadence));
            }
            catch (Exception)
            {
                return;
            }

            chartCadence.ChartAreas[0].AxisX.Maximum = double.NaN;
            chartCadence.ChartAreas[0].AxisX.Minimum = double.NaN;
            chartCadence.ChartAreas[0].AxisY.Maximum = double.NaN;
            chartCadence.ChartAreas[0].AxisY.Minimum = double.NaN;

            chartWatt.ChartAreas[0].AxisX.Maximum = double.NaN;
            chartWatt.ChartAreas[0].AxisX.Minimum = double.NaN;
            chartWatt.ChartAreas[0].AxisY.Maximum = double.NaN;
            chartWatt.ChartAreas[0].AxisY.Minimum = double.NaN;

            chartSpeed.ChartAreas[0].AxisX.Maximum = double.NaN;
            chartSpeed.ChartAreas[0].AxisX.Minimum = double.NaN;
            chartSpeed.ChartAreas[0].AxisY.Maximum = double.NaN;
            chartSpeed.ChartAreas[0].AxisY.Minimum = double.NaN;
            #endregion
        }

        /// <summary>
        /// Nextボタンを押したときにグラフをクリアします
        /// </summary>
        void ClearChart()
        {
            chartWatt.Series["Watt"].Points.Clear();
            chartCadence.Series["Cadence"].Points.Clear();
            chartSpeed.Series["Speed"].Points.Clear();
        }

        public void FTPInitializeTimer()
        {
            FTPEventTimer = new Timer();
            FTPEventTimer.Interval = 200;
            FTPEventTimer.Start();
        }

        public void TabataInitializeTimer()
        {
            TabataEventTimer = new Timer();
            TabataEventTimer.Interval = 200;
            TabataEventTimer.Start();
        }

        public void ShowCycleData(CycleDatas cData)
        {
            if (cData.Cadence != null && cData.Speed != null && cData.Watt != null && cData.Timer != null)
            {
                textBoxCadence.Text = CycleRoutine.ToRoundDown(double.Parse(cData.Cadence), 1).ToString();
                textBoxWatt.Text = CycleRoutine.ToRoundDown(double.Parse(cData.Watt), 1).ToString();
            }
        }
    }
}
