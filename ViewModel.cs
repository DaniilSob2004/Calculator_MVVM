using System;
using System.ComponentModel;

namespace Lesson5
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Calculator calc;

        public ViewModel()
        {
            calc = new Calculator() { LeftOperand = 0, RightOperand = 0, Operator = "+" };
        }

        public string LOperand
        {
            get => calc.LeftOperand.ToString();
            set
            {
                try
                {
                    calc.LeftOperand = int.Parse(value);
                    OnPropertyChanged("LOperand");
                    Total = calc.Total;
                }
                catch (FormatException) { }
            }
        }
        public string ROperand
        {
            get => calc.RightOperand.ToString();
            set
            {
                try
                {
                    calc.RightOperand = int.Parse(value);
                    OnPropertyChanged("ROperand");
                    Total = calc.Total;
                }
                catch (FormatException) { }
            }
        }
        public string Operation
        {
            get => calc.Operator;
            set
            {
                calc.Operator = value.Substring(value.IndexOf(" ") + 1, 1);
                OnPropertyChanged("Operation");
                Total = calc.Total;
            }
        }
        public int Total
        {
            get => calc.Total;
            set => OnPropertyChanged("Total");
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, e);
            }
        }
    }
}
