using BondCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondCalculator
{
    /// <summary>
    /// Represents data related to cash flow in a bond calculator.
    /// </summary>
    public class CashFlowData
    {
        public int CouponPeriod { get; set; }
        public double CouponPayment { get; set; }
        public double PresentValueFactor { get; set; }
        public double PresentValueCashFlow { get; set; }
        public CashFlowData()
        {
            // Initialize properties to 0
            CouponPeriod = 0;
            CouponPayment = 0;
            PresentValueFactor = 0;
            PresentValueCashFlow = 0;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashFlowData"/> class with the specified values
        /// </summary>
        /// <param name="couponPeriod"></param>
        /// <param name="couponPayment"></param>
        /// <param name="presentValueFactor"></param>
        /// <param name="presentValueCashFlow"></param>
        public CashFlowData(int couponPeriod, double couponPayment, double presentValueFactor, double presentValueCashFlow)
        {
            CouponPeriod = couponPeriod;
            CouponPayment = couponPayment;
            PresentValueFactor = presentValueFactor;
            PresentValueCashFlow = presentValueCashFlow;
        }
    }
    public class BondParameters
    {
        // Private fields
        private double _coupon;
        private int _years;
        private double _faceValue;
        private double _rate;
        private double _price;

        // Public properties that expose the fields
        public double Coupon { get { return _coupon; } set { _coupon = value; } }
        public int Years { get { return _years; } set { _years = value; } }
        public double FaceValue { get { return _faceValue; } set { _faceValue = value; } }
        public double Rate { get { return _rate; } set { _rate = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public BondParameters() 
        {
            _coupon = 0;
            _years = 0;
            _faceValue = 0;
            _rate = 0;
            _price = 0;
        } 
    }
    public class BondYieldCalculator  
    {
        public IBondYieldCalculator calculator = new TreasuryCalculator(); // Using abstract instead of concrete class prevents loose coupling if I decided to
        //introduce a different calculation method for coorporate bonds would require lazy initialization and a method delegator for dependency injection
        // This approach provides less coupling and more flexibility

        public (double bondPrice, List<CashFlowData> cashFlows) CalculatePrice(BondParameters parameters)
        {
            return calculator.CalcPrice(parameters);
        }
        public (double bondYield, List<CashFlowData> cashFlows) CalculateYield(BondParameters parameters)
        {
            return calculator.CalcYield(parameters);
        }
        
    }
}
