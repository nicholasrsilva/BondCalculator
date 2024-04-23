# Bond Yield Calculator

This repository contains a simple bond yield calculator that determines the present value of future cash flows from a bond, based on compound interest calculations and discount rates.

### Background:
Fixed-income securities, such as bonds, are priced based on the timing and amount of cash flows they provide. Cash received sooner is more valuable than cash received later because it can be reinvested. This calculator utilizes compound interest calculations to discount future cash flows back to their present value, using a discount rate typically based on the prevailing interest rate.

### How to Use:
1. Clone this repository to your local machine.
2. Open the GUI interface and follow the provided images to input the necessary parameters such as cash flow, time until receipt, and the discount rate.

### Code Structure:
The core functionality of the bond yield calculator is implemented in the `TreasuryCalculator` class within the `TreasuryCalculator.cs` file. Here's a summary of its main functionalities:

1. **CalcPrice Method**: Calculates the present value of cash flows and bond price based on the provided bond parameters.

2. **RerunCalcPrice Method**: Recalculates cash flows without updating cash flow data.

3. **CalcYield Method**: Approximates the bond yield (YTM) using the Newton-Raphson method.

4. **CalculatePriceCashFlows Method**: Performs the calculation of present values of cash flows for both price and yield calculations.

5. **CalculateYield Method**: Implements the Newton-Raphson method to approximate the bond yield.

6. **CalculatePriceDerivative Method**: Calculates the derivative of the bond price with respect to the bond yield at each time period.

### Contributions:
Contributions to enhance the functionality or efficiency of the bond yield calculator are welcome. Feel free to fork this repository and submit pull requests with your changes.

### License:
This project is licensed under the MIT License. See the LICENSE file for details.

### Disclaimer:
This calculator provides estimates and should not be used as financial advice. Always consult with a qualified financial advisor before making investment decisions.
