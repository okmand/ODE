using System;

namespace ODE
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.changed = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lambda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.TextBox();
            this._xdash0 = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "n:";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(62, 259);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(43, 20);
            this.N.TabIndex = 75;
            this.N.Text = "5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 54);
            this.button2.TabIndex = 74;
            this.button2.Text = "Фазовый портрет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button6_Click);
            // 
            // changed
            // 
            this.changed.AutoSize = true;
            this.changed.Location = new System.Drawing.Point(704, 43);
            this.changed.Name = "changed";
            this.changed.Size = new System.Drawing.Size(0, 13);
            this.changed.TabIndex = 73;
            this.changed.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 550);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 45);
            this.button4.TabIndex = 72;
            this.button4.Text = "Продолжение траекторий";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 47);
            this.button3.TabIndex = 71;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(361, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(454, 31);
            this.label7.TabIndex = 70;
            this.label7.Text = "Уравнение: x\'\'+δx\'sin(nx)+cos(nx)=0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "δ:";
            // 
            // lambda
            // 
            this.lambda.Location = new System.Drawing.Point(169, 259);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(43, 20);
            this.lambda.TabIndex = 68;
            this.lambda.Text = "5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 47);
            this.button1.TabIndex = 67;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "H:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "X\'(0):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Конец:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Начало:";
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(62, 184);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(43, 20);
            this.begin.TabIndex = 62;
            this.begin.Text = "0";
            // 
            // _xdash0
            // 
            this._xdash0.Location = new System.Drawing.Point(62, 223);
            this._xdash0.Name = "_xdash0";
            this._xdash0.Size = new System.Drawing.Size(43, 20);
            this._xdash0.TabIndex = 61;
            this._xdash0.Text = "1";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(169, 184);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(43, 20);
            this.end.TabIndex = 60;
            this.end.Text = "30";
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(169, 226);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(43, 20);
            this.H.TabIndex = 59;
            this.H.Text = "0,01";
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea3.AxisX.Crossing = 1.7976931348623157E+308D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea3.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea3.AxisX.LabelStyle.Interval = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.LabelStyle.IsStaggered = true;
            chartArea3.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea3.AxisX.LineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.AxisX.MaximumAutoSize = 90F;
            chartArea3.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea3.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.IsMarksNextToAxis = false;
            chartArea3.AxisY.LabelStyle.Interval = 0D;
            chartArea3.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea3.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.LabelStyle.IsStaggered = true;
            chartArea3.AxisY.LabelStyle.TruncatedLabels = true;
            chartArea3.AxisY.LineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.AxisY.MaximumAutoSize = 90F;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(218, 59);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.LabelBorderWidth = 5;
            series3.MarkerBorderColor = System.Drawing.Color.Black;
            series3.MarkerBorderWidth = 2;
            series3.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series3.Name = "Series1";
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series3.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(942, 536);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 607);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.N);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.changed);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lambda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.begin);
            this.Controls.Add(this._xdash0);
            this.Controls.Add(this.end);
            this.Controls.Add(this.H);
            this.Name = "Form1";
            this.Text = "ODE";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label changed;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lambda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox begin;
        private System.Windows.Forms.TextBox _xdash0;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
