namespace AlbaCycle {
    partial class FormCycle {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCycle));
            this.labelWatt = new System.Windows.Forms.Label();
            this.labelCadence = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCadence = new System.Windows.Forms.TextBox();
            this.textBoxWatt = new System.Windows.Forms.TextBox();
            this.serialPortCycle = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxSerialConfig = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectLoad = new System.Windows.Forms.ComboBox();
            this.bindingSourceLoadLevel = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.bauditemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFTP = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.chartCadence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelFtpStatus = new System.Windows.Forms.Label();
            this.chartWatt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFreeRun = new System.Windows.Forms.Button();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.buttonReStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTabata = new System.Windows.Forms.Button();
            this.groupBoxSerialConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoadLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCadence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWatt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWatt
            // 
            this.labelWatt.AutoSize = true;
            this.labelWatt.Font = new System.Drawing.Font("メイリオ", 25F);
            this.labelWatt.Location = new System.Drawing.Point(755, 60);
            this.labelWatt.Name = "labelWatt";
            this.labelWatt.Size = new System.Drawing.Size(319, 89);
            this.labelWatt.TabIndex = 0;
            this.labelWatt.Text = "ワット数 :";
            // 
            // labelCadence
            // 
            this.labelCadence.AutoSize = true;
            this.labelCadence.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCadence.Location = new System.Drawing.Point(20, 52);
            this.labelCadence.Name = "labelCadence";
            this.labelCadence.Size = new System.Drawing.Size(0, 47);
            this.labelCadence.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 25F);
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 89);
            this.label1.TabIndex = 2;
            this.label1.Text = "回転数 :";
            // 
            // textBoxCadence
            // 
            this.textBoxCadence.Font = new System.Drawing.Font("MS UI Gothic", 75F);
            this.textBoxCadence.Location = new System.Drawing.Point(290, 21);
            this.textBoxCadence.Name = "textBoxCadence";
            this.textBoxCadence.ReadOnly = true;
            this.textBoxCadence.Size = new System.Drawing.Size(459, 182);
            this.textBoxCadence.TabIndex = 3;
            // 
            // textBoxWatt
            // 
            this.textBoxWatt.Font = new System.Drawing.Font("MS UI Gothic", 75F);
            this.textBoxWatt.Location = new System.Drawing.Point(1114, 21);
            this.textBoxWatt.Name = "textBoxWatt";
            this.textBoxWatt.ReadOnly = true;
            this.textBoxWatt.Size = new System.Drawing.Size(521, 182);
            this.textBoxWatt.TabIndex = 4;
            // 
            // serialPortCycle
            // 
            this.serialPortCycle.ReadBufferSize = 1500000000;
            this.serialPortCycle.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortCycle_DataReceived);
            // 
            // groupBoxSerialConfig
            // 
            this.groupBoxSerialConfig.AutoSize = true;
            this.groupBoxSerialConfig.Controls.Add(this.comboBoxSelectLoad);
            this.groupBoxSerialConfig.Controls.Add(this.buttonNext);
            this.groupBoxSerialConfig.Controls.Add(this.buttonClose);
            this.groupBoxSerialConfig.Controls.Add(this.buttonConnect);
            this.groupBoxSerialConfig.Controls.Add(this.comboBoxBaud);
            this.groupBoxSerialConfig.Controls.Add(this.comboBoxPort);
            this.groupBoxSerialConfig.Location = new System.Drawing.Point(11, 6);
            this.groupBoxSerialConfig.Name = "groupBoxSerialConfig";
            this.groupBoxSerialConfig.Size = new System.Drawing.Size(691, 199);
            this.groupBoxSerialConfig.TabIndex = 35;
            this.groupBoxSerialConfig.TabStop = false;
            this.groupBoxSerialConfig.Text = "シリアル設定";
            // 
            // comboBoxSelectLoad
            // 
            this.comboBoxSelectLoad.DataSource = this.bindingSourceLoadLevel;
            this.comboBoxSelectLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectLoad.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.comboBoxSelectLoad.FormattingEnabled = true;
            this.comboBoxSelectLoad.Location = new System.Drawing.Point(470, 116);
            this.comboBoxSelectLoad.Name = "comboBoxSelectLoad";
            this.comboBoxSelectLoad.Size = new System.Drawing.Size(188, 43);
            this.comboBoxSelectLoad.TabIndex = 10;
            this.comboBoxSelectLoad.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectLoad_SelectedIndexChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(270, 106);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(181, 66);
            this.buttonNext.TabIndex = 33;
            this.buttonNext.Text = "Next>>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClose.Location = new System.Drawing.Point(470, 26);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(187, 66);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.Location = new System.Drawing.Point(270, 26);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(181, 66);
            this.buttonConnect.TabIndex = 29;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.DataSource = this.bauditemsBindingSource;
            this.comboBoxBaud.DisplayMember = "RATE";
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(5, 106);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(249, 29);
            this.comboBoxBaud.TabIndex = 3;
            this.comboBoxBaud.ValueMember = "RATE";
            this.comboBoxBaud.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaud_SelectedIndexChanged);
            this.comboBoxBaud.TextChanged += new System.EventHandler(this.comboBoxBaud_TextChanged);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DisplayMember = "RATE";
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(5, 60);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(249, 29);
            this.comboBoxPort.TabIndex = 2;
            this.comboBoxPort.ValueMember = "RATE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCadence);
            this.groupBox1.Controls.Add(this.labelWatt);
            this.groupBox1.Controls.Add(this.textBoxWatt);
            this.groupBox1.Location = new System.Drawing.Point(708, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1811, 209);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ローラー情報";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxSerialConfig);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2550, 1201);
            this.panel1.TabIndex = 37;
            // 
            // labelFTP
            // 
            this.labelFTP.AutoSize = true;
            this.labelFTP.Font = new System.Drawing.Font("メイリオ", 83F);
            this.labelFTP.ForeColor = System.Drawing.Color.Coral;
            this.labelFTP.Location = new System.Drawing.Point(221, 168);
            this.labelFTP.Name = "labelFTP";
            this.labelFTP.Size = new System.Drawing.Size(830, 291);
            this.labelFTP.TabIndex = 5;
            this.labelFTP.Text = "Waiting";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("メイリオ", 73F);
            this.labelTimer.ForeColor = System.Drawing.Color.Coral;
            this.labelTimer.Location = new System.Drawing.Point(1467, -22);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(731, 256);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Waiting";
            // 
            // chartCadence
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCadence.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCadence.Legends.Add(legend1);
            this.chartCadence.Location = new System.Drawing.Point(5, 443);
            this.chartCadence.Name = "chartCadence";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Cadence";
            this.chartCadence.Series.Add(series1);
            this.chartCadence.Size = new System.Drawing.Size(1153, 546);
            this.chartCadence.TabIndex = 5;
            this.chartCadence.Text = "chart1";
            title1.Name = "ケイデンス";
            this.chartCadence.Titles.Add(title1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 35F);
            this.label3.Location = new System.Drawing.Point(1200, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 123);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIME:";
            // 
            // chartSpeed
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend2);
            this.chartSpeed.Location = new System.Drawing.Point(1185, 619);
            this.chartSpeed.Name = "chartSpeed";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.Chartreuse;
            series2.Legend = "Legend1";
            series2.Name = "Speed";
            this.chartSpeed.Series.Add(series2);
            this.chartSpeed.Size = new System.Drawing.Size(889, 366);
            this.chartSpeed.TabIndex = 38;
            this.chartSpeed.Text = "chart1";
            title2.Name = "ケイデンス";
            this.chartSpeed.Titles.Add(title2);
            // 
            // labelFtpStatus
            // 
            this.labelFtpStatus.AutoSize = true;
            this.labelFtpStatus.Font = new System.Drawing.Font("メイリオ", 50F);
            this.labelFtpStatus.Location = new System.Drawing.Point(277, 24);
            this.labelFtpStatus.Name = "labelFtpStatus";
            this.labelFtpStatus.Size = new System.Drawing.Size(520, 175);
            this.labelFtpStatus.TabIndex = 12;
            this.labelFtpStatus.Text = "STATUS";
            // 
            // chartWatt
            // 
            chartArea3.Name = "ChartArea1";
            this.chartWatt.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartWatt.Legends.Add(legend3);
            this.chartWatt.Location = new System.Drawing.Point(1185, 237);
            this.chartWatt.Name = "chartWatt";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "Watt";
            this.chartWatt.Series.Add(series3);
            this.chartWatt.Size = new System.Drawing.Size(1343, 370);
            this.chartWatt.TabIndex = 6;
            this.chartWatt.Text = "chart";
            title3.Name = "Watt";
            this.chartWatt.Titles.Add(title3);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 22F);
            this.label4.Location = new System.Drawing.Point(2164, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 78);
            this.label4.TabIndex = 10;
            this.label4.Text = "V:";
            // 
            // buttonFreeRun
            // 
            this.buttonFreeRun.Font = new System.Drawing.Font("メイリオ", 20F);
            this.buttonFreeRun.Location = new System.Drawing.Point(2094, 748);
            this.buttonFreeRun.Name = "buttonFreeRun";
            this.buttonFreeRun.Size = new System.Drawing.Size(200, 115);
            this.buttonFreeRun.TabIndex = 8;
            this.buttonFreeRun.Text = "FR";
            this.buttonFreeRun.UseVisualStyleBackColor = true;
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Font = new System.Drawing.Font("メイリオ", 27F);
            this.labelVoltage.ForeColor = System.Drawing.Color.Coral;
            this.labelVoltage.Location = new System.Drawing.Point(2258, 633);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(270, 95);
            this.labelVoltage.TabIndex = 11;
            this.labelVoltage.Text = "Waiting";
            // 
            // buttonReStart
            // 
            this.buttonReStart.Font = new System.Drawing.Font("メイリオ", 20F);
            this.buttonReStart.Location = new System.Drawing.Point(2094, 886);
            this.buttonReStart.Name = "buttonReStart";
            this.buttonReStart.Size = new System.Drawing.Size(434, 93);
            this.buttonReStart.TabIndex = 9;
            this.buttonReStart.Text = "RESTART";
            this.buttonReStart.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 35F);
            this.label5.Location = new System.Drawing.Point(42, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 123);
            this.label5.TabIndex = 4;
            this.label5.Text = "FTP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTabata);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonReStart);
            this.groupBox2.Controls.Add(this.labelVoltage);
            this.groupBox2.Controls.Add(this.buttonFreeRun);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chartWatt);
            this.groupBox2.Controls.Add(this.labelFtpStatus);
            this.groupBox2.Controls.Add(this.chartSpeed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chartCadence);
            this.groupBox2.Controls.Add(this.labelTimer);
            this.groupBox2.Controls.Add(this.labelFTP);
            this.groupBox2.Location = new System.Drawing.Point(0, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2550, 991);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "データ";
            // 
            // buttonTabata
            // 
            this.buttonTabata.Font = new System.Drawing.Font("メイリオ", 14F);
            this.buttonTabata.Location = new System.Drawing.Point(2313, 748);
            this.buttonTabata.Name = "buttonTabata";
            this.buttonTabata.Size = new System.Drawing.Size(206, 115);
            this.buttonTabata.TabIndex = 39;
            this.buttonTabata.Text = "Tabata";
            this.buttonTabata.UseVisualStyleBackColor = true;
            this.buttonTabata.Click += new System.EventHandler(this.buttonTabata_Click);
            // 
            // FormCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2550, 1201);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCadence);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbaCycle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCycle_Load);
            this.groupBoxSerialConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoadLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCadence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWatt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWatt;
        private System.Windows.Forms.Label labelCadence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCadence;
        private System.Windows.Forms.TextBox textBoxWatt;
        private System.IO.Ports.SerialPort serialPortCycle;
        private System.Windows.Forms.GroupBox groupBoxSerialConfig;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.BindingSource bauditemsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxSelectLoad;
        private System.Windows.Forms.BindingSource bindingSourceLoadLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFTP;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCadence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private System.Windows.Forms.Label labelFtpStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWatt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFreeRun;
        private System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.Button buttonReStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTabata;
    }
}

