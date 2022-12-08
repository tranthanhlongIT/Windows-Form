
namespace Project2.UserControls
{
    partial class DashboardForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnlChartContainer = new System.Windows.Forms.Panel();
            this.btnApply = new Project2.Utils.RoundedButton();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.chartCustomer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlReportContainer = new System.Windows.Forms.Panel();
            this.pnlChartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlReportContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChartContainer
            // 
            this.pnlChartContainer.Controls.Add(this.btnApply);
            this.pnlChartContainer.Controls.Add(this.dtpMonth);
            this.pnlChartContainer.Controls.Add(this.lblStatistic);
            this.pnlChartContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChartContainer.Location = new System.Drawing.Point(10, 290);
            this.pnlChartContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChartContainer.Name = "pnlChartContainer";
            this.pnlChartContainer.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.pnlChartContainer.Size = new System.Drawing.Size(1260, 50);
            this.pnlChartContainer.TabIndex = 18;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnApply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnApply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnApply.BorderRadius = 3;
            this.btnApply.BorderSize = 1;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Image = global::Project2.Properties.Resources.check_2_icon;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(351, 10);
            this.btnApply.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.btnApply.Name = "btnApply";
            this.btnApply.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnApply.Size = new System.Drawing.Size(90, 25);
            this.btnApply.TabIndex = 16;
            this.btnApply.Text = "        Apply";
            this.btnApply.TextColor = System.Drawing.Color.White;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dtpMonth
            // 
            this.dtpMonth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpMonth.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(166, 10);
            this.dtpMonth.Margin = new System.Windows.Forms.Padding(0);
            this.dtpMonth.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpMonth.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.ShowUpDown = true;
            this.dtpMonth.Size = new System.Drawing.Size(180, 25);
            this.dtpMonth.TabIndex = 15;
            this.dtpMonth.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            this.dtpMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpMonth_KeyDown);
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatistic.ForeColor = System.Drawing.Color.Black;
            this.lblStatistic.Location = new System.Drawing.Point(5, 10);
            this.lblStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(161, 21);
            this.lblStatistic.TabIndex = 14;
            this.lblStatistic.Text = "Statistics by month:";
            this.lblStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartCustomer
            // 
            this.chartCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea11.AxisX.IsLabelAutoFit = false;
            chartArea11.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea11.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea11.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisX.Title = "Day in month";
            chartArea11.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea11.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea11.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea11.AxisY.IsLabelAutoFit = false;
            chartArea11.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea11.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea11.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea11.AxisY.Title = "Total customers";
            chartArea11.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea11.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea11.BorderColor = System.Drawing.Color.Silver;
            chartArea11.Name = "ChartArea1";
            this.chartCustomer.ChartAreas.Add(chartArea11);
            legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend11.IsTextAutoFit = false;
            legend11.Name = "Legend1";
            legend11.TitleFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartCustomer.Legends.Add(legend11);
            this.chartCustomer.Location = new System.Drawing.Point(10, 343);
            this.chartCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.chartCustomer.Name = "chartCustomer";
            series11.ChartArea = "ChartArea1";
            series11.IsXValueIndexed = true;
            series11.Legend = "Legend1";
            series11.Name = "Customer";
            this.chartCustomer.Series.Add(series11);
            this.chartCustomer.Size = new System.Drawing.Size(867, 277);
            this.chartCustomer.TabIndex = 19;
            this.chartCustomer.TabStop = false;
            title11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            title11.Name = "Title1";
            title11.Text = "Customer Chart";
            this.chartCustomer.Titles.Add(title11);
            // 
            // chartProduct
            // 
            this.chartProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea12.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea12);
            legend12.Font = new System.Drawing.Font("Century Gothic", 10F);
            legend12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend12.IsTextAutoFit = false;
            legend12.Name = "Legend1";
            this.chartProduct.Legends.Add(legend12);
            this.chartProduct.Location = new System.Drawing.Point(887, 343);
            this.chartProduct.Margin = new System.Windows.Forms.Padding(0);
            this.chartProduct.Name = "chartProduct";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.IsValueShownAsLabel = true;
            series12.Legend = "Legend1";
            series12.Name = "Product";
            this.chartProduct.Series.Add(series12);
            this.chartProduct.Size = new System.Drawing.Size(383, 277);
            this.chartProduct.TabIndex = 20;
            this.chartProduct.TabStop = false;
            title12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            title12.Name = "Title1";
            title12.Text = "Product Sales Chart";
            this.chartProduct.Titles.Add(title12);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.lbl);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(577, 280);
            this.pnlLeft.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Best seller:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cars sold: 200,000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Customers: 20000";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(20, 38);
            this.lbl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(217, 25);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Revenues: $100,100";
            // 
            // pnlRight
            // 
            this.pnlRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRight.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRight.Controls.Add(this.lblInfo);
            this.pnlRight.Location = new System.Drawing.Point(587, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(673, 280);
            this.pnlRight.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(195, 120);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(291, 25);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Project under construction";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlReportContainer
            // 
            this.pnlReportContainer.Controls.Add(this.pnlRight);
            this.pnlReportContainer.Controls.Add(this.pnlLeft);
            this.pnlReportContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportContainer.Location = new System.Drawing.Point(10, 10);
            this.pnlReportContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReportContainer.Name = "pnlReportContainer";
            this.pnlReportContainer.Size = new System.Drawing.Size(1260, 280);
            this.pnlReportContainer.TabIndex = 17;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartProduct);
            this.Controls.Add(this.chartCustomer);
            this.Controls.Add(this.pnlChartContainer);
            this.Controls.Add(this.pnlReportContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1280, 630);
            this.pnlChartContainer.ResumeLayout(false);
            this.pnlChartContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlReportContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlChartContainer;
        private Utils.RoundedButton btnApply;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlReportContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblInfo;
    }
}
