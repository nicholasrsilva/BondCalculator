using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BondCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitComboBoxes();
            new ToolTip().SetToolTip(annualCouponRateLabel, "The percentage which is multiplied by the principal to arrive at the yearly coupon payment.");
        }

        // Initialize combo boxes for bond type: Treasury and Coorporate
        private void InitComboBoxes()
        {
            bondTypeComboBox.Items.Add("Treasury");
            bondTypeComboBox.Items.Add("Corporate");
            bondTypeComboBox.SelectedIndex = 0;

            calculationComboBox.Items.Add("Price");
            calculationComboBox.Items.Add("Yield");
            calculationComboBox.SelectedIndex = 0;
        }

        // Update parameter labels on calculation type selected
        private void Calculation_IndexChanged(object sender, EventArgs e)
        {
            // ?. operator, null conditional operator, is used to prevent worrying about null reference exception if the object is null, doesn't have a value
            string selectedCalculationType = calculationComboBox.SelectedItem?.ToString();
            if (selectedCalculationType == "Price")
            {
                // Update label for calculating price
                rateOrPriceLabel.Text = "Yield to Maturity (%)";
                txtRateOrPrice.Text = "";
            }
            else
            {
                // Update label for calculating yield
                rateOrPriceLabel.Text = "Price ($)";
                txtRateOrPrice.Text = "";
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //double coupon;
            //int years;
            //double faceValue;
            // If user resets values and clicks calculate button, this prevents program from crashing
            double.TryParse(txtCoupon.Text.Replace("%", ""), out double coupon);
            int.TryParse(txtYears.Text, out int years);
            double.TryParse(txtFaceValue.Text.Replace("$", ""), out double faceValue);
            BondParameters parameters = new BondParameters
            {
                // Get values from user configuration and store in parameters
                Coupon = coupon / 100,
                Years = years,
                FaceValue = faceValue
            };
            string selectedCalculationType = calculationComboBox.SelectedItem?.ToString();
            TreasuryCalculator calc = new TreasuryCalculator();
            if (selectedCalculationType == "Price")
            {
                //(double bondPrice, List<CashFlowData> cashFlows) calculationResult = (0.0, new List<CashFlowData>()); // Assign to avoid compiler not guarante of a code path if no variable is assigned
                //double rate;
                double.TryParse(txtRateOrPrice.Text.Replace("%", ""), out double rate);
                parameters.Rate = rate / 100;

                if (!IsValidBondParameters(parameters))
                {
                    return;
                }

                (double bondPrice, List<CashFlowData> cashFlows) calculationResult = calc.CalcPrice(parameters); //(coupon, years, faceValue, rate);
                textBox1.Text = String.Format("Price of bond is: ${0}", calculationResult.bondPrice);
                PopulateCashFlowDataGridView(calculationResult.cashFlows);
                PopulateGraph(calculationResult.cashFlows);

            }
            else if (selectedCalculationType == "Yield")
            {
                //(double bondYield, List<CashFlowData> cashFlows) calculationResult = (0.0, new List<CashFlowData>()); // Assign to avoid compiler not guarante of a code path if no variable is assigned
                //double price;
                double.TryParse(txtRateOrPrice.Text.Replace("$", ""), out double price);
                parameters.Price = price;

                if (!IsValidBondParameters(parameters))
                {
                    return;
                }
                // I was able to notice the cash flows when calculating yield were incorrect
                // calc yield runs calc price within the method and only the rate was being approximated
                (double bondYield, List<CashFlowData> cashFlows) calculationResult = calc.CalcYield(parameters); //(coupon, years, faceValue, price);
                textBox1.Text = String.Format("YTM of bond is: {0}", calculationResult.bondYield);
                parameters.Rate = calculationResult.bondYield; //PV payments aren't updating correctly, this is one of the last changes to make 
                calculationResult = calc.RerunCalcPrice(parameters); //(coupon, years, faceValue, rate);
                PopulateCashFlowDataGridView(calculationResult.cashFlows); 
                PopulateGraph(calculationResult.cashFlows);

            }
        }
        private void PopulateCashFlowDataGridView(List<CashFlowData> cashFlows)
        {
            dataGridViewCashFlow.Rows.Clear();

            if (cashFlows == null || cashFlows.Count == 0) { return; }

            // Add rows for each cashflow
            for (int i = 0; i < cashFlows.Count; i++)
            {
                int rowIndex = dataGridViewCashFlow.Rows.Add();

                dataGridViewCashFlow.Rows[rowIndex].Cells[0].Value = i + 1;
                dataGridViewCashFlow.Rows[rowIndex].Cells[1].Value = cashFlows[i].CouponPayment;
                dataGridViewCashFlow.Rows[rowIndex].Cells[2].Value = cashFlows[i].PresentValueFactor;
                dataGridViewCashFlow.Rows[rowIndex].Cells[3].Value = cashFlows[i].PresentValueCashFlow;
            }
        }
        private void PopulateGraph(List<CashFlowData> cashFlows)
        {
            //ArrayList payments = new ArrayList();
            paymentChart.Series[0].Points.Clear();
            int year = 1;
            foreach (CashFlowData cashFlow in cashFlows)
            {
                //payments.Add(new PresentValuePayment(year, cashFlow.PresentValueCashFlow));
                paymentChart.Series[0].Points.Add(new DataPoint(year++, cashFlow.PresentValueCashFlow));

            }
        }

        /// <summary>
        /// Validate bond parameters to ensure reasonable values are entered.
        /// </summary>
        /// <param name="parameters">The bond parameters.</param>
        /// <returns>True if values are entered and positive.</returns>
        private bool IsValidBondParameters(BondParameters parameters)
        {
            bool negativeCouppn = parameters.Coupon <= 0;
            bool negativeYears = parameters.Years <= 0;
            bool negativeFV = parameters.FaceValue <= 0;
            bool negativePrice = parameters.Price <= 0;
            bool negativeRate = parameters.Rate <= 0;

            StringBuilder errorMessage = new StringBuilder();
            // MessageBox.Show("Bond parameters are invalid\nFix 1: Enter positive values for calculation\nFix 2: Enter values for each field");
            bool isValid = true;
            if (!(negativePrice || negativeRate))
            {
                isValid = true; // If either price or rate is true, set valid to true and check rest of values
            }
            else if (negativePrice && negativeRate)
            {
                errorMessage.AppendLine("Fix 1: Enter valid price or rate");
                isValid = false;
            }
            if (negativeCouppn || negativeYears || negativeFV)
            {
                errorMessage.AppendLine("Fix 2: Parameter values should be positive and greater than 0");
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show(errorMessage.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }
        private void SecurityType_IndexChanged(object sender, EventArgs e)
        {
            string selectedSecurityType = bondTypeComboBox.SelectedItem?.ToString();
            if (selectedSecurityType == "Corporate")
            {
                bondParamGroupBox.Visible = false;
                groupBox3.Visible = false;
                groupBox2.Visible = false;
                calcBtn.Visible = false;
                resetBtn.Visible = false;
                appInfoLabel.Visible = false;
                notYetImplementedLabel.Visible = true;
            }
            else
            {
                bondParamGroupBox.Visible = true;
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                calcBtn.Visible = true;
                resetBtn.Visible = true;
                appInfoLabel.Visible = true;
                notYetImplementedLabel.Visible = false;
            }

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // Clear values in the instrument configuration groupbox
            txtCoupon.Text = string.Empty;
            txtFaceValue.Text = string.Empty;
            txtRateOrPrice.Text = string.Empty;
            txtYears.Text = string.Empty;

        }
        /*        private bool IsValidBondParameters()
        {
            //Checking groupbox labels instead of bond params

            var labelControls = bondParamGroupBox.Controls;
            foreach (var labelControl in labelControls)
            {
                if (labelControl is TextBox txtBox && string.IsNullOrEmpty(txtBox.Text))
                {
                    int value;
                    bool num = int.TryParse(txtBox.Text.ToString(), out value);
                    if (!num || value < 0)
                    {
                        MessageBox.Show("Bond parameters are invalid\nFix: Enter positive values for calculation");
                        return false;
                    }
                    return false;
                }
            }
            return true;
        }*/
    }
}
