using System;
using System.Collections.Generic;
using System.Text;

namespace ActivationExample
{
    public class Calculator
    {
        private decimal accumulator;
        private IOperation nextOperation;
        private IOperation lastOperation;
        private decimal? lastValue;
        
        private decimal? memory;

        public decimal? Memory
        {
            get { return memory; }
            set { memory = value; }
        }


        public delegate void CalculatorValueChangedEventHandler(object sender, CalculatorChangedEventArgs e);
        public event CalculatorValueChangedEventHandler CalculatorValueChanged;

        public Calculator()
        {
            this.nextOperation = null;
            this.accumulator = 0;
        }
        private void OnCalculatorValueChanged(CalculatorChangedEventArgs e)
        {
            if (CalculatorValueChanged != null)
            {
                CalculatorValueChanged(this, e);
            }
        }
        public void Calculate(decimal? value)
        {
            if (nextOperation == null)
            {
                if (lastValue.HasValue)
                {
                    nextOperation = lastOperation;
                    ApplyOperation(lastValue.Value,null);
                }
            }
            else
            {
                this.ApplyOperation(value, null);
            }

            this.accumulator = 0;
        }
        public void ApplyOperation(decimal? value, IOperation operation)
        {
            if (value.HasValue)
            {
                bool isValid = true;
                if (nextOperation == null)
                {
                    this.accumulator = value.Value;
                    
                    OnCalculatorValueChanged(new CalculatorChangedEventArgs(this.accumulator, !isValid, OperationType.Accumulation));
                    
                   
                }
                else
                {
                    try
                    {
                        if (!nextOperation.GetType().Name.ToLower().StartsWith("memory"))
                        {
                            this.accumulator = nextOperation.Calc(accumulator, value.Value);
                        }
                        else
                        {
                            this.memory = nextOperation.Calc(this.memory, value.Value);
                        }
                    }
                    catch (Exception ex)
                    {
                        isValid = false;
                    }
                    lastOperation = nextOperation;
                    lastValue = value.Value;
                    OnCalculatorValueChanged(new CalculatorChangedEventArgs(this.accumulator, !isValid, OperationType.Calculation));
                }
            }

            nextOperation = operation;
        }

        public void AllClear()
        {
            Clear();
            accumulator = 0;
            
            memory = null;
        }
      
        public void Clear()
        {
            
            nextOperation = null;
            lastOperation = null;
            lastValue = null;
        }
    }
}
