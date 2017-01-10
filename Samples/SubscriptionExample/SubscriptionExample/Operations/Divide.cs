using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionExample
{
    public class Divide : IOperation
    {
        public Divide()
        {
        }
        public OperationType GetOperationType()
        {
            return OperationType.Accumulation;
        }
        public decimal Calc(decimal? accumulator, decimal value)
        {
            try
            {
                decimal result = accumulator.Value / value;
                return result;
            }
            catch (DivideByZeroException de)
            {
                throw de;
            }
            catch (OverflowException oe)
            {
                throw oe;
            }
        }
    }
}
