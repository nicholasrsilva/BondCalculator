using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BondCalculator
{
    internal class TreasuryCalculator : IBondYieldCalculator
    {
        /// <summary>
        /// Calculates the bond price and its cash flows based on the parameters.
        /// </summary>
        /// <param name="parameters">Bond parameters.</param>
        /// <returns>A tuple containing the bond price and a list of cash flow data.</returns>
        public (double bondPrice, List<CashFlowData> cashFlows) CalcPrice(BondParameters parameters)
        {
            List<CashFlowData> cashFlows = new List<CashFlowData>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double price = CalculatePriceCashFlows(parameters, ref cashFlows);         // Use present value formula to calculate the price
            stopwatch.Stop();
            MessageBox.Show(string.Format("Elipsed time in ms: {0}", stopwatch.ElapsedMilliseconds.ToString()));
            return (price, cashFlows) ;
        }
        /// <summary>
        /// Recalculates the cashflows.
        /// </summary>
        /// <param name="parameters">Bond parameters.</param>
        /// <returns>A tuple containing the bond price and a list of updated cash flow data.</returns>
        public (double bondPrice, List<CashFlowData> cashFlows) RerunCalcPrice(BondParameters parameters)
        {
            List<CashFlowData> cashFlows = new List<CashFlowData>();
            double price = CalculatePriceCashFlows(parameters, ref cashFlows);         // Use present value formula to re-calculate the price so that cash flows update
            return (price, cashFlows);
        }
        /// <summary>
        /// Calculates the bond yield and its cash flows based on the parameters.
        /// </summary>
        /// <param name="parameters">Bond parameters.</param>
        /// <returns>A tuple containing the bond yield and a list of incorrect cash flow data.</returns>
        public (double bondYield, List<CashFlowData> cashFlows) CalcYield(BondParameters parameters)
        {
            List<CashFlowData> cashFlows = new List<CashFlowData>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double yield = CalculateYield(parameters, ref cashFlows);         // Use newton-raphson method to calculate yield
            stopwatch.Stop();
            MessageBox.Show(string.Format("Elipsed time in ms: {0}", stopwatch.ElapsedMilliseconds.ToString()));
            return (yield, cashFlows);
        }
        private double CalculatePriceCashFlows(BondParameters parameters, ref List<CashFlowData> cashFlows, bool calcYield = false) 
        {
            int time = parameters.Years;
            double couponPayment = parameters.Coupon * parameters.FaceValue;
            double rate = parameters.Rate; // YTM, interest rate, discount rate
            double presentValueOfCashFlows = 0;
 
            // Calculate present value in coupon payments
            for (int i = 1; i <= time; i++)
            {
                double presentValue = couponPayment / Math.Pow(1 + rate, i);
                presentValueOfCashFlows += presentValue;
                // When CalcYield calculates price cash flows, the added cash flow data is incorrect
                if (!calcYield)
                {
                    // Only add cash flow data if you are calculating price
                    cashFlows.Add(new CashFlowData(i, couponPayment, presentValue / 100, couponPayment * presentValue / 100));
                }
            }

            double faceValuePresentValue = parameters.FaceValue / Math.Pow(1 + rate, time); // Present value of the face value of the bond
            if (!calcYield)
            {
                cashFlows[time - 1].CouponPayment += parameters.FaceValue;
                cashFlows[time - 1].PresentValueFactor = faceValuePresentValue / parameters.FaceValue;
                cashFlows[time - 1].PresentValueCashFlow += faceValuePresentValue;
            }
           
            presentValueOfCashFlows += faceValuePresentValue;
            return Math.Round(presentValueOfCashFlows, 7);
        }

        /// <summary>
        /// Approximate the yield of a bond given bond parameters using Newton-Raphson method
        /// </summary>
        /// <param name="parameters">Bond parameters.</param>
        /// <param name="cashFlows">List of cash flow data.</param>
        /// <returns>Yield of a bond.</returns>
        private double CalculateYield(BondParameters parameters, ref List<CashFlowData> cashFlows)
        {
            double estimatedYield = 0.1; // Initial guess for YTM expressed as a rate
            double tolerance = 1e-7; // This accurate
           // Refine estimated yield
            while (true)
            {
                // Update bond rate parameters
                parameters.Rate = estimatedYield;

                double guessPrice = CalculatePriceCashFlows(parameters, ref cashFlows, true);  // Calculate price using guess estimate of yield
                double priceDerivate = CalculatePriceDerivative(parameters);  // Calculate the derivate of the bond price with respect to yield
                    
                double priceError = guessPrice - parameters.Price; // Calculate the difference in the bond price and market price
                // when calculating price error, the goal is to minimize the difference. 

                double delta = (priceError / priceDerivate) * .0001; //  Calculate the change in yield and scale.
                                                                     //  Before scaling, the delta wasn't small enough to update the estimated yield
                // If user enters a price whose maturity rate is negative, then the loop doesn't terminate because the price derivative drops to 0
                if (double.IsInfinity(delta))
                {
                    MessageBox.Show("If your YTM is negative, the price of your bond is much greater than par.");
                    break; //Not converging
                }
                estimatedYield += delta;
                
                // If estimated yield is within tolernace, break out of the loop
                if (Math.Abs(delta) < tolerance)
                {
                    // Calculate cashflows now
                    parameters.Rate = estimatedYield * 100; //Scale back to percentage notation
                    CalculatePriceCashFlows(parameters, ref cashFlows); // Add cashflows but in this iteration, values are not consistent
                    break; // Converges
                }
            }

            return Math.Round(estimatedYield, 7);
            // Refactor Calc Price method to pass a parameter if calculating yield function to omit having to add the cashflows to a list.
            // Maybe within the for loop when calculating the 
            // present values for each period, add an if statement and only add cash flows on the last calculation if the price is within the boundaries of toleranace
        }
        /// <summary>
        /// Calculates the derivate of the bond with respect to the bond yield at each time period 't' and updates the sum of derivative values.
        /// </summary>
        /// <param name="parameters">Bond parameters.</param>
        /// <returns>Cumulative sum 'df' which represents the derivative of the bond price with respect to the bond yield.</returns>
        private double CalculatePriceDerivative(BondParameters parameters)
        {
            double df = 0; // Stores the sum of derivative values
            int years = parameters.Years;
            double coupon = parameters.Coupon; 
            double rate = parameters.Rate;

            for (int t = 1; t <= years; t++)
            {
                df += coupon * t / Math.Pow(1 + rate, t + 1);
            }
            return df;
        }
    }
}
