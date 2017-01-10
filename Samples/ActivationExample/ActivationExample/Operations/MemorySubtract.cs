using System;
using System.Collections.Generic;
using System.Text;

namespace ActivationExample
{
    public class MemorySubtract : IOperation
    {
        public MemorySubtract()
        {
        }
        public OperationType GetOperationType()
        {
            return OperationType.Accumulation;
        }
        public decimal Calc(decimal? memory, decimal value)
        {
            try
            {

                decimal result = memory.HasValue ? memory.Value - value : value;
                return result;
            }
            catch (OverflowException oe)
            {
                throw oe;
            }
        }
    }
}
