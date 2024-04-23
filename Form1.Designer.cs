namespace BondCalculator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.calculationComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bondTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bondParamGroupBox = new System.Windows.Forms.GroupBox();
            this.txtFaceValue = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.txtRateOrPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rateOrPriceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.couponFrequencyLabel = new System.Windows.Forms.Label();
            this.annualCouponRateLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cashFlowTabPage = new System.Windows.Forms.TabPage();
            this.dataGridViewCashFlow = new System.Windows.Forms.DataGridView();
            this.CouponPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CouponPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PV_Factor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PV_CF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentValueOfPaymentsTabPage = new System.Windows.Forms.TabPage();
            this.paymentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.appInfoLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.notYetImplementedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bondParamGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.cashFlowTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashFlow)).BeginInit();
            this.presentValueOfPaymentsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculationComboBox
            // 
            this.calculationComboBox.FormattingEnabled = true;
            this.calculationComboBox.Location = new System.Drawing.Point(168, 66);
            this.calculationComboBox.Name = "calculationComboBox";
            this.calculationComboBox.Size = new System.Drawing.Size(121, 21);
            this.calculationComboBox.TabIndex = 0;
            this.calculationComboBox.SelectedIndexChanged += new System.EventHandler(this.Calculation_IndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Security Type";
            // 
            // bondTypeComboBox
            // 
            this.bondTypeComboBox.FormattingEnabled = true;
            this.bondTypeComboBox.Location = new System.Drawing.Point(168, 41);
            this.bondTypeComboBox.Name = "bondTypeComboBox";
            this.bondTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.bondTypeComboBox.TabIndex = 2;
            this.bondTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SecurityType_IndexChanged);
            // 
            // bondParamGroupBox
            // 
            this.bondParamGroupBox.Controls.Add(this.txtFaceValue);
            this.bondParamGroupBox.Controls.Add(this.txtYears);
            this.bondParamGroupBox.Controls.Add(this.txtCoupon);
            this.bondParamGroupBox.Controls.Add(this.txtRateOrPrice);
            this.bondParamGroupBox.Controls.Add(this.label12);
            this.bondParamGroupBox.Controls.Add(this.label10);
            this.bondParamGroupBox.Controls.Add(this.label7);
            this.bondParamGroupBox.Controls.Add(this.label5);
            this.bondParamGroupBox.Controls.Add(this.rateOrPriceLabel);
            this.bondParamGroupBox.Controls.Add(this.label4);
            this.bondParamGroupBox.Controls.Add(this.couponFrequencyLabel);
            this.bondParamGroupBox.Controls.Add(this.annualCouponRateLabel);
            this.bondParamGroupBox.Location = new System.Drawing.Point(35, 94);
            this.bondParamGroupBox.Name = "bondParamGroupBox";
            this.bondParamGroupBox.Size = new System.Drawing.Size(262, 186);
            this.bondParamGroupBox.TabIndex = 4;
            this.bondParamGroupBox.TabStop = false;
            this.bondParamGroupBox.Text = "(1) Debt Instrument Configurations";
            // 
            // txtFaceValue
            // 
            this.txtFaceValue.Location = new System.Drawing.Point(154, 103);
            this.txtFaceValue.Name = "txtFaceValue";
            this.txtFaceValue.Size = new System.Drawing.Size(100, 20);
            this.txtFaceValue.TabIndex = 21;
            this.txtFaceValue.Text = "$1000";
            this.txtFaceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(154, 77);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 20);
            this.txtYears.TabIndex = 20;
            this.txtYears.Text = "5";
            this.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCoupon
            // 
            this.txtCoupon.Location = new System.Drawing.Point(154, 51);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(100, 20);
            this.txtCoupon.TabIndex = 17;
            this.txtCoupon.Text = "10";
            this.txtCoupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateOrPrice
            // 
            this.txtRateOrPrice.Location = new System.Drawing.Point(154, 129);
            this.txtRateOrPrice.Name = "txtRateOrPrice";
            this.txtRateOrPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRateOrPrice.TabIndex = 16;
            this.txtRateOrPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Annual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Years";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // rateOrPriceLabel
            // 
            this.rateOrPriceLabel.AutoSize = true;
            this.rateOrPriceLabel.Location = new System.Drawing.Point(8, 132);
            this.rateOrPriceLabel.Name = "rateOrPriceLabel";
            this.rateOrPriceLabel.Size = new System.Drawing.Size(59, 13);
            this.rateOrPriceLabel.TabIndex = 0;
            this.rateOrPriceLabel.Text = "Price/Yield";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Face (Par) Value";
            // 
            // couponFrequencyLabel
            // 
            this.couponFrequencyLabel.AutoSize = true;
            this.couponFrequencyLabel.Location = new System.Drawing.Point(5, 25);
            this.couponFrequencyLabel.Name = "couponFrequencyLabel";
            this.couponFrequencyLabel.Size = new System.Drawing.Size(97, 13);
            this.couponFrequencyLabel.TabIndex = 2;
            this.couponFrequencyLabel.Text = "Coupon Frequency";
            // 
            // annualCouponRateLabel
            // 
            this.annualCouponRateLabel.AutoSize = true;
            this.annualCouponRateLabel.Location = new System.Drawing.Point(6, 54);
            this.annualCouponRateLabel.Name = "annualCouponRateLabel";
            this.annualCouponRateLabel.Size = new System.Drawing.Size(87, 13);
            this.annualCouponRateLabel.TabIndex = 1;
            this.annualCouponRateLabel.Text = "Coupon Rate (%)";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(35, 295);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(103, 23);
            this.calcBtn.TabIndex = 5;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(181, 295);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(113, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(437, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 485);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Results";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cashFlowTabPage);
            this.tabControl1.Controls.Add(this.presentValueOfPaymentsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 466);
            this.tabControl1.TabIndex = 24;
            // 
            // cashFlowTabPage
            // 
            this.cashFlowTabPage.Controls.Add(this.dataGridViewCashFlow);
            this.cashFlowTabPage.Location = new System.Drawing.Point(4, 22);
            this.cashFlowTabPage.Name = "cashFlowTabPage";
            this.cashFlowTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cashFlowTabPage.Size = new System.Drawing.Size(378, 440);
            this.cashFlowTabPage.TabIndex = 0;
            this.cashFlowTabPage.Text = "Cash Flows";
            this.cashFlowTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCashFlow
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            this.dataGridViewCashFlow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCashFlow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCashFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCashFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CouponPeriod,
            this.CouponPayment,
            this.PV_Factor,
            this.PV_CF});
            this.dataGridViewCashFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCashFlow.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCashFlow.Name = "dataGridViewCashFlow";
            this.dataGridViewCashFlow.ReadOnly = true;
            this.dataGridViewCashFlow.RowHeadersVisible = false;
            this.dataGridViewCashFlow.Size = new System.Drawing.Size(372, 434);
            this.dataGridViewCashFlow.TabIndex = 0;
            // 
            // CouponPeriod
            // 
            this.CouponPeriod.FillWeight = 60.9137F;
            this.CouponPeriod.HeaderText = "Coupon Period";
            this.CouponPeriod.Name = "CouponPeriod";
            this.CouponPeriod.ReadOnly = true;
            this.CouponPeriod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CouponPayment
            // 
            this.CouponPayment.FillWeight = 113.0288F;
            this.CouponPayment.HeaderText = "Coupon Payment";
            this.CouponPayment.Name = "CouponPayment";
            this.CouponPayment.ReadOnly = true;
            // 
            // PV_Factor
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.PV_Factor.DefaultCellStyle = dataGridViewCellStyle2;
            this.PV_Factor.FillWeight = 113.0288F;
            this.PV_Factor.HeaderText = "PV Factor";
            this.PV_Factor.Name = "PV_Factor";
            this.PV_Factor.ReadOnly = true;
            // 
            // PV_CF
            // 
            this.PV_CF.FillWeight = 113.0288F;
            this.PV_CF.HeaderText = "PV CF";
            this.PV_CF.Name = "PV_CF";
            this.PV_CF.ReadOnly = true;
            // 
            // presentValueOfPaymentsTabPage
            // 
            this.presentValueOfPaymentsTabPage.Controls.Add(this.paymentChart);
            this.presentValueOfPaymentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.presentValueOfPaymentsTabPage.Name = "presentValueOfPaymentsTabPage";
            this.presentValueOfPaymentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.presentValueOfPaymentsTabPage.Size = new System.Drawing.Size(378, 440);
            this.presentValueOfPaymentsTabPage.TabIndex = 1;
            this.presentValueOfPaymentsTabPage.Text = "Present Values of Payments (Annually)";
            this.presentValueOfPaymentsTabPage.UseVisualStyleBackColor = true;
            // 
            // paymentChart
            // 
            this.paymentChart.BackColor = System.Drawing.Color.Gainsboro;
            this.paymentChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea1.Name = "ChartArea1";
            this.paymentChart.ChartAreas.Add(chartArea1);
            this.paymentChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.paymentChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.paymentChart.Legends.Add(legend1);
            this.paymentChart.Location = new System.Drawing.Point(3, 3);
            this.paymentChart.Name = "paymentChart";
            this.paymentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Present values of payments";
            this.paymentChart.Series.Add(series1);
            this.paymentChart.Size = new System.Drawing.Size(372, 434);
            this.paymentChart.TabIndex = 0;
            this.paymentChart.Text = "chart1";
            // 
            // appInfoLabel
            // 
            this.appInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.appInfoLabel.Location = new System.Drawing.Point(12, 415);
            this.appInfoLabel.Name = "appInfoLabel";
            this.appInfoLabel.Size = new System.Drawing.Size(181, 61);
            this.appInfoLabel.TabIndex = 8;
            this.appInfoLabel.Text = "(1) Basic information about a bond, (2) Calculate the bond price and its cash flo" +
    "ws, and (3) Generate insights";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(3, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(35, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 56);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2) Bond Price/Yield";
            // 
            // notYetImplementedLabel
            // 
            this.notYetImplementedLabel.AutoSize = true;
            this.notYetImplementedLabel.Location = new System.Drawing.Point(328, 242);
            this.notYetImplementedLabel.Name = "notYetImplementedLabel";
            this.notYetImplementedLabel.Size = new System.Drawing.Size(106, 13);
            this.notYetImplementedLabel.TabIndex = 24;
            this.notYetImplementedLabel.Text = "Not Yet Implemented";
            this.notYetImplementedLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Developed by Nicholas Silva";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notYetImplementedLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.bondParamGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bondTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculationComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.appInfoLabel);
            this.Name = "Form1";
            this.Text = "Bond-Yield Calculator";
            this.bondParamGroupBox.ResumeLayout(false);
            this.bondParamGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.cashFlowTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashFlow)).EndInit();
            this.presentValueOfPaymentsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox calculationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bondTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bondParamGroupBox;
        private System.Windows.Forms.Label rateOrPriceLabel;
        private System.Windows.Forms.Label annualCouponRateLabel;
        private System.Windows.Forms.Label couponFrequencyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.TextBox txtRateOrPrice;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtFaceValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label appInfoLabel;
        private System.Windows.Forms.DataGridView dataGridViewCashFlow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cashFlowTabPage;
        private System.Windows.Forms.TabPage presentValueOfPaymentsTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart paymentChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouponPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouponPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PV_Factor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PV_CF;
        private System.Windows.Forms.Label notYetImplementedLabel;
        private System.Windows.Forms.Label label3;
    }
}

