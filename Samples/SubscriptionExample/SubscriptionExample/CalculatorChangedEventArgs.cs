using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionExample
{
    
    public class CalculatorChangedEventArgs : EventArgs
    {
        private decimal result;
        private bool hasError;
        private OperationType operationType;

        public OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }
	
        public bool HasError
        {
            get { return hasError; }
            set { hasError = value; }
        }
	
        public decimal Result
        {
            get { return result; }
            set { result = value; }
        }
	
        public CalculatorChangedEventArgs(decimal result, bool hasError, OperationType type)
        {
            this.result = result;
            this.hasError = hasError;
            this.operationType = type;
        }
    }
}
