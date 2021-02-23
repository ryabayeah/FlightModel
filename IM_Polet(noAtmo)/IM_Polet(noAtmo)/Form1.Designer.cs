
namespace IM_Polet_noAtmo_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFlight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nWeight = new System.Windows.Forms.NumericUpDown();
            this.nSize = new System.Windows.Forms.NumericUpDown();
            this.lableTime = new System.Windows.Forms.Label();
            this.btnStopContinue = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nSpeed = new System.Windows.Forms.NumericUpDown();
            this.nAngle = new System.Windows.Forms.NumericUpDown();
            this.nHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartFlight)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFlight
            // 
            this.chartFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Maximum = 20D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartFlight.ChartAreas.Add(chartArea1);
            this.chartFlight.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartFlight.Legends.Add(legend1);
            this.chartFlight.Location = new System.Drawing.Point(13, 173);
            this.chartFlight.Name = "chartFlight";
            this.chartFlight.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.MarkerSize = 10;
            series1.MarkerStep = 10;
            series1.Name = "Flying Object";
            this.chartFlight.Series.Add(series1);
            this.chartFlight.Size = new System.Drawing.Size(716, 385);
            this.chartFlight.TabIndex = 0;
            this.chartFlight.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nWeight);
            this.panel1.Controls.Add(this.nSize);
            this.panel1.Controls.Add(this.lableTime);
            this.panel1.Controls.Add(this.btnStopContinue);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.nSpeed);
            this.panel1.Controls.Add(this.nAngle);
            this.panel1.Controls.Add(this.nHeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 154);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(282, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(282, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Size";
            // 
            // nWeight
            // 
            this.nWeight.Location = new System.Drawing.Point(367, 47);
            this.nWeight.Name = "nWeight";
            this.nWeight.Size = new System.Drawing.Size(120, 20);
            this.nWeight.TabIndex = 10;
            this.nWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nSize
            // 
            this.nSize.DecimalPlaces = 2;
            this.nSize.Location = new System.Drawing.Point(367, 10);
            this.nSize.Name = "nSize";
            this.nSize.Size = new System.Drawing.Size(120, 20);
            this.nSize.TabIndex = 9;
            this.nSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // lableTime
            // 
            this.lableTime.AutoSize = true;
            this.lableTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableTime.Location = new System.Drawing.Point(16, 116);
            this.lableTime.Name = "lableTime";
            this.lableTime.Size = new System.Drawing.Size(69, 24);
            this.lableTime.TabIndex = 8;
            this.lableTime.Text = "Time: ";
            // 
            // btnStopContinue
            // 
            this.btnStopContinue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStopContinue.Location = new System.Drawing.Point(530, 10);
            this.btnStopContinue.Name = "btnStopContinue";
            this.btnStopContinue.Size = new System.Drawing.Size(142, 48);
            this.btnStopContinue.TabIndex = 7;
            this.btnStopContinue.Text = "Stop";
            this.btnStopContinue.UseVisualStyleBackColor = false;
            this.btnStopContinue.Click += new System.EventHandler(this.btnStopContinue_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(530, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Start";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nSpeed
            // 
            this.nSpeed.Location = new System.Drawing.Point(103, 83);
            this.nSpeed.Name = "nSpeed";
            this.nSpeed.Size = new System.Drawing.Size(121, 20);
            this.nSpeed.TabIndex = 5;
            this.nSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nAngle
            // 
            this.nAngle.Location = new System.Drawing.Point(103, 47);
            this.nAngle.Name = "nAngle";
            this.nAngle.Size = new System.Drawing.Size(120, 20);
            this.nAngle.TabIndex = 4;
            this.nAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // nHeight
            // 
            this.nHeight.Location = new System.Drawing.Point(103, 10);
            this.nHeight.Name = "nHeight";
            this.nHeight.Size = new System.Drawing.Size(120, 20);
            this.nHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartFlight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartFlight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nSpeed;
        private System.Windows.Forms.NumericUpDown nAngle;
        private System.Windows.Forms.NumericUpDown nHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStopContinue;
        private System.Windows.Forms.Label lableTime;
        private System.Windows.Forms.NumericUpDown nSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nWeight;
        private System.Windows.Forms.Label label5;
    }
}

