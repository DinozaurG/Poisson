namespace Poisson
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lambda1Value = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chiSquareLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberValue = new System.Windows.Forms.NumericUpDown();
            this.timeValue = new System.Windows.Forms.NumericUpDown();
            this.lambda2Value = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.lambda1Value)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lambda1Value
            // 
            this.lambda1Value.DecimalPlaces = 3;
            this.lambda1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lambda1Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.lambda1Value.Location = new System.Drawing.Point(39, 14);
            this.lambda1Value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lambda1Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lambda1Value.Name = "lambda1Value";
            this.lambda1Value.Size = new System.Drawing.Size(116, 22);
            this.lambda1Value.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chiSquareLabel);
            this.panel1.Controls.Add(this.varianceLabel);
            this.panel1.Controls.Add(this.averageLabel);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numberValue);
            this.panel1.Controls.Add(this.timeValue);
            this.panel1.Controls.Add(this.lambda2Value);
            this.panel1.Controls.Add(this.lambda1Value);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 91);
            this.panel1.TabIndex = 2;
            // 
            // chiSquareLabel
            // 
            this.chiSquareLabel.AutoSize = true;
            this.chiSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chiSquareLabel.Location = new System.Drawing.Point(533, 64);
            this.chiSquareLabel.Name = "chiSquareLabel";
            this.chiSquareLabel.Size = new System.Drawing.Size(82, 17);
            this.chiSquareLabel.TabIndex = 4;
            this.chiSquareLabel.Text = "ChiSquared";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.varianceLabel.Location = new System.Drawing.Point(533, 33);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(64, 17);
            this.varianceLabel.TabIndex = 4;
            this.varianceLabel.Text = "Variance";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.averageLabel.Location = new System.Drawing.Point(533, 7);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(61, 17);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.Text = "Average";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.startButton.Location = new System.Drawing.Point(341, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(173, 69);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Напуассонить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.Location = new System.Drawing.Point(171, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(171, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "λ2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "λ1";
            // 
            // numberValue
            // 
            this.numberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.numberValue.Location = new System.Drawing.Point(195, 50);
            this.numberValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberValue.Name = "numberValue";
            this.numberValue.Size = new System.Drawing.Size(136, 22);
            this.numberValue.TabIndex = 1;
            this.numberValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // timeValue
            // 
            this.timeValue.DecimalPlaces = 3;
            this.timeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.timeValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.timeValue.Location = new System.Drawing.Point(195, 14);
            this.timeValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeValue.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(116, 22);
            this.timeValue.TabIndex = 1;
            // 
            // lambda2Value
            // 
            this.lambda2Value.DecimalPlaces = 3;
            this.lambda2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lambda2Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.lambda2Value.Location = new System.Drawing.Point(39, 50);
            this.lambda2Value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lambda2Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lambda2Value.Name = "lambda2Value";
            this.lambda2Value.Size = new System.Drawing.Size(116, 22);
            this.lambda2Value.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 97);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(916, 339);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 448);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Poisson stream";
            ((System.ComponentModel.ISupportInitialize)(this.lambda1Value)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown lambda1Value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberValue;
        private System.Windows.Forms.NumericUpDown lambda2Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown timeValue;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label chiSquareLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

