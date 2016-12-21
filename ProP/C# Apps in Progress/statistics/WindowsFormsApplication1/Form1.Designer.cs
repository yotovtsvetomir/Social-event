namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGetStatistics = new System.Windows.Forms.Button();
            this.chartVisits = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelInEvent = new System.Windows.Forms.Label();
            this.ChartMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelMoney = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 199);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Last Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search(not working)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 240);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelMoney);
            this.groupBox3.Controls.Add(this.ChartMoney);
            this.groupBox3.Controls.Add(this.labelInEvent);
            this.groupBox3.Controls.Add(this.chartVisits);
            this.groupBox3.Location = new System.Drawing.Point(254, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 495);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Statistics";
            // 
            // buttonGetStatistics
            // 
            this.buttonGetStatistics.Location = new System.Drawing.Point(563, 514);
            this.buttonGetStatistics.Name = "buttonGetStatistics";
            this.buttonGetStatistics.Size = new System.Drawing.Size(243, 36);
            this.buttonGetStatistics.TabIndex = 5;
            this.buttonGetStatistics.Text = "Get Statistics";
            this.buttonGetStatistics.UseVisualStyleBackColor = true;
            this.buttonGetStatistics.Click += new System.EventHandler(this.buttonGetStatistics_Click);
            // 
            // chartVisits
            // 
            chartArea3.Name = "ChartArea1";
            this.chartVisits.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartVisits.Legends.Add(legend3);
            this.chartVisits.Location = new System.Drawing.Point(6, 59);
            this.chartVisits.Name = "chartVisits";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "visits";
            this.chartVisits.Series.Add(series4);
            this.chartVisits.Size = new System.Drawing.Size(260, 199);
            this.chartVisits.TabIndex = 0;
            this.chartVisits.Text = "Visits";
            // 
            // labelInEvent
            // 
            this.labelInEvent.AutoSize = true;
            this.labelInEvent.Location = new System.Drawing.Point(6, 35);
            this.labelInEvent.Name = "labelInEvent";
            this.labelInEvent.Size = new System.Drawing.Size(0, 13);
            this.labelInEvent.TabIndex = 1;
            // 
            // ChartMoney
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartMoney.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartMoney.Legends.Add(legend4);
            this.ChartMoney.Location = new System.Drawing.Point(286, 59);
            this.ChartMoney.Name = "ChartMoney";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Legend = "Legend1";
            series5.Name = "Money In Accounts";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Money Spent";
            this.ChartMoney.Series.Add(series5);
            this.ChartMoney.Series.Add(series6);
            this.ChartMoney.Size = new System.Drawing.Size(266, 199);
            this.ChartMoney.TabIndex = 2;
            this.ChartMoney.Text = "Money";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(283, 43);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(0, 13);
            this.labelMoney.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 562);
            this.Controls.Add(this.buttonGetStatistics);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGetStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisits;
        private System.Windows.Forms.Label labelInEvent;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMoney;
    }
}

