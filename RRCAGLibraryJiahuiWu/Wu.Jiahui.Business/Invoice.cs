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
    /// This abstract class contains functionality that supports the business process of creating an invoice.
    /// </summary>
    public abstract class Invoice
    {
        private decimal provincialSalesTaxRate;
        private decimal goodsAndServicesTaxRate;

        /// <summary>
        /// Gets and sets the provincial sales tax rate.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0, or
        /// when the property is set to greater than 1.
        /// </exception>
        public decimal ProvincialSalesTaxRate
        {
            get
            {
                return this.provincialSalesTaxRate;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }

                if(value > 1)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be greater than 1.");
                }

                this.provincialSalesTaxRate = value;
            }
        }

        /// <summary>
        /// Gets and sets the goods and services tax rate.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0, or
        /// when the property is set to greater than 1.
        /// </exception>
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return this.goodsAndServicesTaxRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }

                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be greater than 1.");
                }

                this.goodsAndServicesTaxRate = value;
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer (rounded to two decimal places).
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer (rounded to two decimal places).
        /// </summary>
        public abstract decimal GoodsAndServicesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public abstract decimal SubTotal
        {
            get;
        }

        /// <summary>
        /// Gets the total of the Invoice.
        /// </summary>
        public decimal Total
        {
            get
            {
                return this.SubTotal + this.ProvincialSalesTaxCharged + this.GoodsAndServicesTaxCharged;
            }
        }

        /// <summary>
        /// Initializes an instance of Invoice with a provincial and goods and services tax rates.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the provincial sales tax rate is less than 0, or
        /// when the provincial sales tax rate is greater than 1, or
        /// when the goods and services tax rate is less than 0, or
        /// when the goods and services tax rate is greater than 1.
        /// </exception>
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            if(provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be less than 0.");
            }

            if(provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be greater than 1.");
            }

            if(goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be less than 0.");
            }

            if(goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be greater than 1.");
            }

            this.ProvincialSalesTaxRate = provincialSalesTaxRate;
            this.GoodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }
    }
}