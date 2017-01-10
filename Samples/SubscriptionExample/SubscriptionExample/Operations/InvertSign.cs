using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionExample
{
    public class InvertSign : IOperation
    {
        public InvertSign()
        {
        }
        public OperationType GetOperationType()
        {
            return OperationType.OneTime;
        }
        public decimal Calc(decimal? accumulator, decimal value)
        {
            try
            {
                decimal result = value * -1;
                return result;
            }
            catch (OverflowException oe)
            {
                throw oe;
            }
        }
    }
}
