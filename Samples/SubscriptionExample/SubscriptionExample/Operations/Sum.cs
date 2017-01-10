using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionExample
{
    public class Sum : IOperation
    {
        public Sum()
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

                decimal result = accumulator.Value + value;


                return result;
            }
            catch (OverflowException oe)
            {
                throw oe;
            }
        }

        
    }
}
