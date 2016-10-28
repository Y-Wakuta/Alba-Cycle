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

namespace AlbaCycle {
    public partial class FormCycle : Form {

        Timer time = new Timer();

        public FormCycle() {
            InitializeComponent();
        }

        private void FormCycle_Load(object sender, EventArgs e) {
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

        private void buttonConfig_Click(object sender, EventArgs e) {
            FormConfig _formConfig = new FormConfig();
            _formConfig.Show();
        }
    }
}
