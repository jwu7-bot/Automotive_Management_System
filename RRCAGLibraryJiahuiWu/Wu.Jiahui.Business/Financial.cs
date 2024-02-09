/*
 * Name: JiaHui Wu
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-05-10
 * Updated: 2023-05-11
 */
using System;

namespace Wu.Jiahui.Business
{
    /// <summary>
    /// This static class contains functionality that includes financial functions.
    /// </summary>
    public static class Financial
    {
        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// </summary>
        /// <param name="rate">The interest rate per period.</param>
        /// <param name="numberOfPaymentPeriods">The total number of payment periods in the annuity.</param>
        /// <param name="presentValue">The present value (or lump sum) that a series of payments to be paid in the future is worth now</param>
        /// <returns>The payment amount for an annuity.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the rate is less than 0, or
        /// when the rate is greater than 1, or
        /// when the number of payments is less than or equal to zero, or
        /// when the present value is less than or equal to zero.
        /// </exception>
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods, decimal presentValue)
        {
            if(rate < 0)
            {
                throw new ArgumentOutOfRangeException("rate", "The argument cannot be less than 0.");
            }

            if(rate > 1)
            {
                throw new ArgumentOutOfRangeException("rate", "The argument cannot be greater than 1.");
            }

            if(numberOfPaymentPeriods <= 0)
            {
                throw new ArgumentOutOfRangeException("numberOfPaymentPeriods", "The argument cannot be less than or equal to 0.");
            }

            if(presentValue <= 0)
            {
                throw new ArgumentOutOfRangeException("presentValue", "The argument cannot be less than or equal to 0.");
            }
            
            decimal futureValue = 0;
            decimal type = 0;
            decimal payment = 0;

            if (rate == 0)
                payment = presentValue / numberOfPaymentPeriods;
            else
                payment = rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));

            return Math.Round(payment, 2);
        }
    }
}