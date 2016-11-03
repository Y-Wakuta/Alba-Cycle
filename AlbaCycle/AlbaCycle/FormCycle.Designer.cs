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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.tabPageFTTP = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPhase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCadence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWatt)).BeginInit();
            this.groupBoxSerialConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.tabPageFTTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWatt
            // 
            this.labelWatt.AutoSize = true;
            this.labelWatt.Font = new System.Drawing.Font("メイリオ", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWatt.Location = new System.Drawing.Point(1518, 55);
            this.labelWatt.Name = "labelWatt";
            this.labelWatt.Size = new System.Drawing.Size(319, 89);
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
            this.label1.Font = new System.Drawing.Font("メイリオ", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(992, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 89);
            this.label1.TabIndex = 2;
            this.label1.Text = "回転数 :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(1244, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(268, 101);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(1822, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(268, 101);
            this.textBox2.TabIndex = 4;
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
            this.serialPortCycle.ReadBufferSize = 1500000;
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
            this.groupBoxSerialConfig.Size = new System.Drawing.Size(776, 152);
            this.groupBoxSerialConfig.TabIndex = 35;
            this.groupBoxSerialConfig.TabStop = false;
            this.groupBoxSerialConfig.Text = "シリアル設定";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(629, 54);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(133, 59);
            this.buttonNext.TabIndex = 33;
            this.buttonNext.Text = "Next>>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClose.Location = new System.Drawing.Point(488, 54);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 59);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.Location = new System.Drawing.Point(347, 54);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(133, 59);
            this.buttonConnect.TabIndex = 29;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
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
            this.textBoxTimer.Location = new System.Drawing.Point(2110, 23);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.ReadOnly = true;
            this.textBoxTimer.Size = new System.Drawing.Size(413, 141);
            this.textBoxTimer.TabIndex = 36;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Font = new System.Drawing.Font("メイリオ", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConfig.Location = new System.Drawing.Point(796, 40);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(170, 113);
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
            this.tabControl1.Controls.Add(this.tabPageFTTP);
            this.tabControl1.Controls.Add(this.tabPageGraph);
            this.tabControl1.Location = new System.Drawing.Point(13, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2533, 1201);
            this.tabControl1.TabIndex = 39;
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
            // tabPageFTTP
            // 
            this.tabPageFTTP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPageFTTP.Controls.Add(this.button2);
            this.tabPageFTTP.Controls.Add(this.button1);
            this.tabPageFTTP.Controls.Add(this.label4);
            this.tabPageFTTP.Controls.Add(this.label6);
            this.tabPageFTTP.Controls.Add(this.label5);
            this.tabPageFTTP.Controls.Add(this.label3);
            this.tabPageFTTP.Controls.Add(this.labelPhase);
            this.tabPageFTTP.Controls.Add(this.label2);
            this.tabPageFTTP.Location = new System.Drawing.Point(8, 39);
            this.tabPageFTTP.Name = "tabPageFTTP";
            this.tabPageFTTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFTTP.Size = new System.Drawing.Size(2517, 1154);
            this.tabPageFTTP.TabIndex = 1;
            this.tabPageFTTP.Text = "FTTP";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(37, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 192);
            this.label5.TabIndex = 4;
            this.label5.Text = "FTTP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(493, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1711, 288);
            this.label6.TabIndex = 5;
            this.label6.Text = "Waiting For Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(366, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(854, 144);
            this.label4.TabIndex = 6;
            this.label4.Text = "Waiting For Start";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(83, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(530, 198);
            this.button1.TabIndex = 7;
            this.button1.Text = "START FTTP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("メイリオ", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(681, 668);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(530, 198);
            this.button2.TabIndex = 8;
            this.button2.Text = "FREE RUN";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2548, 1383);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.groupBoxSerialConfig);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.tabPageGraph.ResumeLayout(false);
            this.tabPageFTTP.ResumeLayout(false);
            this.tabPageFTTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWatt;
        private System.Windows.Forms.Label labelCadence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.TabPage tabPageFTTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPhase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

