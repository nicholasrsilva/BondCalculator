using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondCalculator
{
    /// <summary>
    /// Represents an interface for calculating bond prices and yields. Inherited by TreasuryCalculator but can extend to CoorporateCalculator if required.
    /// </summary>
    public interface IBondYieldCalculator
    {
        /*        double CalcPrice(double coupon, int years, double faceValue, double rate);
                double CalcYield(double coupon, int years, double faceValue, double price);*/
        /// <summary>
        /// Calculates the bond price and its cash flows based on the parameters.
        /// </summary>
        /// <param name="parameters">Bond parameters.</param>
        /// <returns>A tuple containing the bond price and a list of updated cash flow data.</returns>
        (double bondPrice, List<CashFlowData> cashFlows) CalcPrice(BondParameters parameters);  
        /// <summary>
        /// Calculates the bond yield and its cash flows based on the parameters.
        /// </summary>
        /// <param name="parameters">Bond parameters.</param>
        /// <returns>A tuple containing the bond yield and a list of incorrect cash flow data.</returns>
        (double bondYield, List<CashFlowData> cashFlows) CalcYield(BondParameters parameters);  


    }
}
