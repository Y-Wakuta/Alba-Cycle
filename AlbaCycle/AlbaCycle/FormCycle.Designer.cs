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
            this.chartCadence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWatt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPortCycle = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxSerialConfig = new System.Windows.Forms.GroupBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.bauditemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFTP = new System.Windows.Forms.TabPage();
            this.buttonFreeRun = new System.Windows.Forms.Button();
            this.buttonStartFTP = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelFTP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPhase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.textBoxSerialData = new System.Windows.Forms.TextBox();
            this.buttonGiveUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCadence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWatt)).BeginInit();
            this.groupBoxSerialConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageFTP.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWatt
            // 
            this.labelWatt.AutoSize = true;
            this.labelWatt.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWatt.Location = new System.Drawing.Point(1558, 55);
            this.labelWatt.Name = "labelWatt";
            this.labelWatt.Size = new System.Drawing.Size(259, 72);
            this.labelWatt.TabIndex = 0;
            this.labelWatt.Text = "ワット数 :";
            // 
            // labelCadence
            // 
            this.labelCadence.AutoSize = true;
            this.labelCadence.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCadence.Location = new System.Drawing.Point(24, 59);
            this.labelCadence.Name = "labelCadence";
            this.labelCadence.Size = new System.Drawing.Size(0, 54);
            this.labelCadence.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1067, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "回転数 :";
            // 
            // textBoxCadence
            // 
            this.textBoxCadence.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxCadence.Location = new System.Drawing.Point(1284, 40);
            this.textBoxCadence.Name = "textBoxCadence";
            this.textBoxCadence.ReadOnly = true;
            this.textBoxCadence.Size = new System.Drawing.Size(268, 101);
            this.textBoxCadence.TabIndex = 3;
            // 
            // textBoxWatt
            // 
            this.textBoxWatt.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxWatt.Location = new System.Drawing.Point(1823, 40);
            this.textBoxWatt.Name = "textBoxWatt";
            this.textBoxWatt.ReadOnly = true;
            this.textBoxWatt.Size = new System.Drawing.Size(249, 101);
            this.textBoxWatt.TabIndex = 4;
            // 
            // chartCadence
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCadence.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCadence.Legends.Add(legend1);
            this.chartCadence.Location = new System.Drawing.Point(12, 6);
            this.chartCadence.Name = "chartCadence";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Cadence";
            this.chartCadence.Series.Add(series1);
            this.chartCadence.Size = new System.Drawing.Size(1240, 599);
            this.chartCadence.TabIndex = 5;
            this.chartCadence.Text = "chart1";
            title1.Name = "ケイデンス";
            this.chartCadence.Titles.Add(title1);
            // 
            // chartWatt
            // 
            chartArea2.Name = "ChartArea1";
            this.chartWatt.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWatt.Legends.Add(legend2);
            this.chartWatt.Location = new System.Drawing.Point(12, 611);
            this.chartWatt.Name = "chartWatt";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Watt";
            this.chartWatt.Series.Add(series2);
            this.chartWatt.Size = new System.Drawing.Size(2490, 540);
            this.chartWatt.TabIndex = 6;
            this.chartWatt.Text = "chart";
            title2.Name = "Watt";
            this.chartWatt.Titles.Add(title2);
            // 
            // serialPortCycle
            // 
            this.serialPortCycle.ReadBufferSize = 15000000;
            this.serialPortCycle.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortCycle_DataReceived);
            // 
            // groupBoxSerialConfig
            // 
            this.groupBoxSerialConfig.AutoSize = true;
            this.groupBoxSerialConfig.Controls.Add(this.buttonNext);
            this.groupBoxSerialConfig.Controls.Add(this.buttonClose);
            this.groupBoxSerialConfig.Controls.Add(this.buttonConnect);
            this.groupBoxSerialConfig.Controls.Add(this.comboBoxBaud);
            this.groupBoxSerialConfig.Controls.Add(this.comboBoxPort);
            this.groupBoxSerialConfig.Location = new System.Drawing.Point(13, 12);
            this.groupBoxSerialConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSerialConfig.Name = "groupBoxSerialConfig";
            this.groupBoxSerialConfig.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSerialConfig.Size = new System.Drawing.Size(868, 153);
            this.groupBoxSerialConfig.TabIndex = 35;
            this.groupBoxSerialConfig.TabStop = false;
            this.groupBoxSerialConfig.Text = "シリアル設定";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(701, 47);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(159, 76);
            this.buttonNext.TabIndex = 33;
            this.buttonNext.Text = "Next>>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClose.Location = new System.Drawing.Point(531, 45);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(162, 76);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.Location = new System.Drawing.Point(361, 45);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(162, 76);
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
            this.comboBoxBaud.Location = new System.Drawing.Point(7, 91);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(334, 32);
            this.comboBoxBaud.TabIndex = 3;
            this.comboBoxBaud.ValueMember = "RATE";
            this.comboBoxBaud.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaud_SelectedIndexChanged);
            this.comboBoxBaud.TextChanged += new System.EventHandler(this.comboBoxBaud_TextChanged);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(7, 43);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(334, 32);
            this.comboBoxPort.TabIndex = 2;
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTimer.Location = new System.Drawing.Point(2123, 23);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.ReadOnly = true;
            this.textBoxTimer.Size = new System.Drawing.Size(413, 141);
            this.textBoxTimer.TabIndex = 36;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Font = new System.Drawing.Font("メイリオ", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConfig.Location = new System.Drawing.Point(899, 40);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(162, 113);
            this.buttonConfig.TabIndex = 37;
            this.buttonConfig.Text = "設定";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // chartSpeed
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend3);
            this.chartSpeed.Location = new System.Drawing.Point(1265, 6);
            this.chartSpeed.Name = "chartSpeed";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Chartreuse;
            series3.Legend = "Legend1";
            series3.Name = "Speed";
            this.chartSpeed.Series.Add(series3);
            this.chartSpeed.Size = new System.Drawing.Size(1237, 599);
            this.chartSpeed.TabIndex = 38;
            this.chartSpeed.Text = "chart1";
            title3.Name = "ケイデンス";
            this.chartSpeed.Titles.Add(title3);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFTP);
            this.tabControl1.Controls.Add(this.tabPageGraph);
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Location = new System.Drawing.Point(13, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2533, 1201);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPageFTP
            // 
            this.tabPageFTP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPageFTP.Controls.Add(this.buttonGiveUp);
            this.tabPageFTP.Controls.Add(this.buttonFreeRun);
            this.tabPageFTP.Controls.Add(this.buttonStartFTP);
            this.tabPageFTP.Controls.Add(this.labelTimer);
            this.tabPageFTP.Controls.Add(this.labelFTP);
            this.tabPageFTP.Controls.Add(this.label5);
            this.tabPageFTP.Controls.Add(this.label3);
            this.tabPageFTP.Controls.Add(this.labelPhase);
            this.tabPageFTP.Controls.Add(this.label2);
            this.tabPageFTP.Location = new System.Drawing.Point(8, 39);
            this.tabPageFTP.Name = "tabPageFTP";
            this.tabPageFTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFTP.Size = new System.Drawing.Size(2517, 1154);
            this.tabPageFTP.TabIndex = 1;
            this.tabPageFTP.Text = "FTP";
            // 
            // buttonFreeRun
            // 
            this.buttonFreeRun.Font = new System.Drawing.Font("メイリオ", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonFreeRun.Location = new System.Drawing.Point(824, 668);
            this.buttonFreeRun.Name = "buttonFreeRun";
            this.buttonFreeRun.Size = new System.Drawing.Size(671, 198);
            this.buttonFreeRun.TabIndex = 8;
            this.buttonFreeRun.Text = "FREE RUN";
            this.buttonFreeRun.UseVisualStyleBackColor = true;
            this.buttonFreeRun.Click += new System.EventHandler(this.buttonFreeRun_Click);
            // 
            // buttonStartFTP
            // 
            this.buttonStartFTP.Font = new System.Drawing.Font("メイリオ", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStartFTP.Location = new System.Drawing.Point(83, 668);
            this.buttonStartFTP.Name = "buttonStartFTP";
            this.buttonStartFTP.Size = new System.Drawing.Size(671, 198);
            this.buttonStartFTP.TabIndex = 7;
            this.buttonStartFTP.Text = "START FTP";
            this.buttonStartFTP.UseVisualStyleBackColor = true;
            this.buttonStartFTP.Click += new System.EventHandler(this.buttonStartFTP_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTimer.ForeColor = System.Drawing.Color.Coral;
            this.labelTimer.Location = new System.Drawing.Point(366, 177);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(854, 144);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Waiting For Start";
            // 
            // labelFTP
            // 
            this.labelFTP.AutoSize = true;
            this.labelFTP.Font = new System.Drawing.Font("メイリオ", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFTP.ForeColor = System.Drawing.Color.Coral;
            this.labelFTP.Location = new System.Drawing.Point(389, 358);
            this.labelFTP.Name = "labelFTP";
            this.labelFTP.Size = new System.Drawing.Size(1711, 288);
            this.labelFTP.TabIndex = 5;
            this.labelFTP.Text = "Waiting For Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(51, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 192);
            this.label5.TabIndex = 4;
            this.label5.Text = "FTP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(114, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 113);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIME:";
            // 
            // labelPhase
            // 
            this.labelPhase.AutoSize = true;
            this.labelPhase.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPhase.ForeColor = System.Drawing.Color.Coral;
            this.labelPhase.Location = new System.Drawing.Point(366, 22);
            this.labelPhase.Name = "labelPhase";
            this.labelPhase.Size = new System.Drawing.Size(854, 144);
            this.labelPhase.TabIndex = 1;
            this.labelPhase.Text = "Waiting For Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(54, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 113);
            this.label2.TabIndex = 0;
            this.label2.Text = "PHASE:";
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageGraph.Controls.Add(this.chartCadence);
            this.tabPageGraph.Controls.Add(this.chartSpeed);
            this.tabPageGraph.Controls.Add(this.chartWatt);
            this.tabPageGraph.Location = new System.Drawing.Point(8, 39);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(2517, 1154);
            this.tabPageGraph.TabIndex = 0;
            this.tabPageGraph.Text = "Graphs";
            // 
            // tabPageData
            // 
            this.tabPageData.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageData.Controls.Add(this.textBoxSerialData);
            this.tabPageData.Location = new System.Drawing.Point(8, 39);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Size = new System.Drawing.Size(2517, 1154);
            this.tabPageData.TabIndex = 2;
            this.tabPageData.Text = "Data";
            // 
            // textBoxSerialData
            // 
            this.textBoxSerialData.Location = new System.Drawing.Point(52, 44);
            this.textBoxSerialData.Multiline = true;
            this.textBoxSerialData.Name = "textBoxSerialData";
            this.textBoxSerialData.ReadOnly = true;
            this.textBoxSerialData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSerialData.Size = new System.Drawing.Size(2064, 1063);
            this.textBoxSerialData.TabIndex = 0;
            // 
            // buttonGiveUp
            // 
            this.buttonGiveUp.Font = new System.Drawing.Font("メイリオ", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGiveUp.Location = new System.Drawing.Point(1549, 668);
            this.buttonGiveUp.Name = "buttonGiveUp";
            this.buttonGiveUp.Size = new System.Drawing.Size(671, 198);
            this.buttonGiveUp.TabIndex = 9;
            this.buttonGiveUp.Text = "Give Up";
            this.buttonGiveUp.UseVisualStyleBackColor = true;
            this.buttonGiveUp.Click += new System.EventHandler(this.buttonGiveUp_Click);
            // 
            // FormCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2538, 1373);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.groupBoxSerialConfig);
            this.Controls.Add(this.textBoxWatt);
            this.Controls.Add(this.textBoxCadence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCadence);
            this.Controls.Add(this.labelWatt);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbaCycle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCycle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCadence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWatt)).EndInit();
            this.groupBoxSerialConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFTP.ResumeLayout(false);
            this.tabPageFTP.PerformLayout();
            this.tabPageGraph.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWatt;
        private System.Windows.Forms.Label labelCadence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCadence;
        private System.Windows.Forms.TextBox textBoxWatt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCadence;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWatt;
        private System.IO.Ports.SerialPort serialPortCycle;
        private System.Windows.Forms.GroupBox groupBoxSerialConfig;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.BindingSource bauditemsBindingSource;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.TabPage tabPageFTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPhase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFreeRun;
        private System.Windows.Forms.Button buttonStartFTP;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelFTP;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TextBox textBoxSerialData;
        private System.Windows.Forms.Button buttonGiveUp;
    }
}

