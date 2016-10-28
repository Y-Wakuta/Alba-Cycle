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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartCadence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWatt)).BeginInit();
            this.groupBoxSerialConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWatt
            // 
            this.labelWatt.AutoSize = true;
            this.labelWatt.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWatt.Location = new System.Drawing.Point(1678, 56);
            this.labelWatt.Name = "labelWatt";
            this.labelWatt.Size = new System.Drawing.Size(267, 67);
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
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1110, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "回転数 :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(1390, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(268, 101);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(1970, 34);
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
            this.chartCadence.Location = new System.Drawing.Point(12, 182);
            this.chartCadence.Name = "chartCadence";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCadence.Series.Add(series1);
            this.chartCadence.Size = new System.Drawing.Size(1239, 1197);
            this.chartCadence.TabIndex = 5;
            this.chartCadence.Text = "chart1";
            // 
            // chartWatt
            // 
            chartArea2.Name = "ChartArea1";
            this.chartWatt.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWatt.Legends.Add(legend2);
            this.chartWatt.Location = new System.Drawing.Point(1273, 182);
            this.chartWatt.Name = "chartWatt";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartWatt.Series.Add(series2);
            this.chartWatt.Size = new System.Drawing.Size(1489, 1197);
            this.chartWatt.TabIndex = 6;
            this.chartWatt.Text = "chart2";
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
            this.groupBoxSerialConfig.Size = new System.Drawing.Size(906, 152);
            this.groupBoxSerialConfig.TabIndex = 35;
            this.groupBoxSerialConfig.TabStop = false;
            this.groupBoxSerialConfig.Text = "シリアル設定";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(725, 52);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(158, 59);
            this.buttonNext.TabIndex = 33;
            this.buttonNext.Text = "Next>>";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClose.Location = new System.Drawing.Point(548, 52);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(158, 59);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.Location = new System.Drawing.Point(383, 52);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(157, 59);
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
            this.comboBoxBaud.Size = new System.Drawing.Size(349, 32);
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
            this.comboBoxPort.Size = new System.Drawing.Size(349, 32);
            this.comboBoxPort.TabIndex = 2;
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTimer.Location = new System.Drawing.Point(2292, 12);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.ReadOnly = true;
            this.textBoxTimer.Size = new System.Drawing.Size(445, 141);
            this.textBoxTimer.TabIndex = 36;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(956, 40);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(148, 113);
            this.buttonConfig.TabIndex = 37;
            this.buttonConfig.Text = "設定";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // FormCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2774, 1629);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.groupBoxSerialConfig);
            this.Controls.Add(this.chartWatt);
            this.Controls.Add(this.chartCadence);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCadence);
            this.Controls.Add(this.labelWatt);
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
    }
}

