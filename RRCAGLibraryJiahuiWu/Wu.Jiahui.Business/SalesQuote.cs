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
    /// Contains functionality that supports the business process 
    /// of determining a quote for the sale of a vehicle.
    /// </summary>
    public class SalesQuote
    {
        private decimal vehicleSalePrice;
        private decimal tradeInAmount;
        private decimal salesTaxRate;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;

        /// <summary>
        /// Gets and sets the sale price of the vehicle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than or equal to 0.
        /// </exception>
        public decimal VehicleSalePrice
        {
            get
            {
                return this.vehicleSalePrice;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than or equal to 0.");
                }

                this.vehicleSalePrice = value;
            }
        }

        /// <summary>
        /// Gets and sets the trade in amount.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0.
        /// </exception>
        public decimal TradeInAmount
        {
            get
            {
                return this.tradeInAmount;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }

                this.tradeInAmount = value;
            }
        }

        /// <summary>
        /// Gets and sets the accessories that were chosen.
        /// </summary>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown when the property is set to an invalid value.
        /// </exception>
        public Accessories AccessoriesChosen
        {
            get
            {
                return this.accessoriesChosen;
            }

            set
            {
                if (!Enum.IsDefined(typeof(Accessories), value))
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value.");
                }

                this.accessoriesChosen = value;
            }
        }

        /// <summary>
        /// Gets and sets the exterior finish that was chosen.
        /// </summary>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown when the property is set to an invalid value.
        /// </exception>
        public ExteriorFinish ExteriorFinishChosen
        {
            get
            {
                return this.exteriorFinishChosen;
            }

            set
            {
                if(!Enum.IsDefined(typeof(ExteriorFinish), value))
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value.");
                }

                this.exteriorFinishChosen = value;
            }
        }

        /// <summary>
        /// Gets the cost of accessories chosen.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                decimal priceStereoSystem = 505.05M;
                decimal priceLeatherInterior = 1010.1M;
                decimal computerNavigation = 1515.15M;
                decimal accessoriesCost = 0;

                switch (this.AccessoriesChosen)
                {
                    case Accessories.StereoSystem:
                        accessoriesCost = priceStereoSystem;
                        break;
                    case Accessories.LeatherInterior:
                        accessoriesCost = priceLeatherInterior;
                        break;
                    case Accessories.StereoAndLeather:
                        accessoriesCost = priceStereoSystem + priceLeatherInterior;
                        break;
                    case Accessories.ComputerNavigation:
                        accessoriesCost = computerNavigation;
                        break;
                    case Accessories.StereoAndNavigation:
                        accessoriesCost = priceStereoSystem + computerNavigation;
                        break;
                    case Accessories.LeatherAndNavigation:
                        accessoriesCost = priceLeatherInterior + computerNavigation;
                        break;
                    case Accessories.All:
                        accessoriesCost = priceStereoSystem + priceLeatherInterior + computerNavigation;
                        break;
                }

                return accessoriesCost;
            }
        }

        /// <summary>
        /// Gets the cost of the exterior finish chosen.
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                decimal priceStandard = 202.02M;
                decimal pricePearlized = 404.04M;
                decimal priceCustom = 606.06M;
                decimal exteriorFinishCost = 0;

                switch (this.ExteriorFinishChosen)
                {
                    case ExteriorFinish.Standard:
                        exteriorFinishCost = priceStandard;
                        break;
                    case ExteriorFinish.Pearlized:
                        exteriorFinishCost = pricePearlized;
                        break;
                    case ExteriorFinish.Custom:
                        exteriorFinishCost = priceCustom;
                        break;
                }

                return exteriorFinishCost;
            }
        }

        /// <summary>
        /// Gets the sum of the cost of the chosen accessories and exterior finish (rounded to two decimal places).
        /// </summary>
        public decimal TotalOptions
        {
            get
            {
                return Math.Round(this.AccessoryCost + this.FinishCost, 2);
            }
        }

        /// <summary>
        /// Gets the sum of the vehicle’s sale price and the Accessory and Finish Cost (rounded to two decimal places).
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                return Math.Round(this.VehicleSalePrice + this.TotalOptions, 2);
            }
        }

        /// <summary>
        /// Gets the amount of tax to charge based on the subtotal (rounded to two decimal places).
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                return Math.Round(this.salesTaxRate * this.SubTotal, 2);
            }
        }

        /// <summary>
        /// Gets the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                return this.SubTotal + this.SalesTax;
            }
        }

        /// <summary>
        /// Gets the result of subtracting the trade-in amount from the total (rounded to two decimal places).
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                return Math.Round(this.Total - this.TradeInAmount, 2);
            }
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in value, sales tax rate, accessories chosen and exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories.</param>
        /// <param name="exteriorFinishChosen">The value of the chosen exterior finish.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the vehicle sale price is less than or equal to 0, or
        /// when the trade in amount is less than 0, or
        /// when the sales tax rate is less than 0, or
        /// when the sales tax rate is greater than 1.
        /// </exception>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown when the accessories chosen is an invalid argument, or
        /// when the exterior finish chosen is an invalid argument.
        /// </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            if(vehicleSalePrice <= 0)
            {
                throw new ArgumentOutOfRangeException("vehicleSalePrice", "The argument cannot be less than or equal to 0.");
            }

            if(tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException("tradeInAmount", "The argument cannot be less than 0.");
            }

            if(salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("salesTaxRate", "The argument cannot be less than 0.");
            }

            if(salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("salesTaxRate", "The argument cannot be greater than 1.");
            }

            if(!Enum.IsDefined(typeof(Accessories), accessoriesChosen))
            {
                throw new System.ComponentModel.InvalidEnumArgumentException("The argument is an invalid enumeration value.");
            }

            if(!Enum.IsDefined(typeof(ExteriorFinish), exteriorFinishChosen))
            {
                throw new System.ComponentModel.InvalidEnumArgumentException("The argument is an invalid enumeration value.");
            }

            this.VehicleSalePrice = vehicleSalePrice;
            this.TradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.AccessoriesChosen = accessoriesChosen;
            this.ExteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in amount, sales tax rate, no accessories chosen and no exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the vehicle sale price is less than or equal to 0, or
        /// when the trade in amount is less than 0, or
        /// when the sales tax rate is less than 0, or
        /// when the sales tax rate is greater than 1.
        /// </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
            : this(vehicleSalePrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None)
        {
            // Invokes the constructor SalesQuote(decimal, decimal, decimal, Accessories, ExteriorFinish)
        }
    }
}