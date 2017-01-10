using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionExample
{
    public enum OperationType
    {
        Calculation = 0,
        Accumulation = 1,
        OneTime = 2
    }
    public interface IOperation
    {
        OperationType GetOperationType();
        decimal Calc(decimal? accumulator, decimal value);
    }
}
