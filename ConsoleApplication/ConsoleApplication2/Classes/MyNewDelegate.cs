using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    
    class MyNewDelegate
    {
        private delegate double OperationDelegate(double x, double y);
        private Dictionary<string, OperationDelegate> _operations;
        private double DoDivision(double x, double y) { return x / y; }
        private double DoMultiplication(double x, double y) { return x * y; }
        private double DoSubtraction(double x, double y) { return x - y; }
        private double DoAddition(double x, double y) { return x + y; }
        private double DoModul(double x, double y) { return Math.Abs(x); }
        public void Calculator()
        {
            _operations = new Dictionary<string, OperationDelegate>
                {
                    { "+", DoAddition },
                    { "-", DoSubtraction },
                    { "*", DoMultiplication },
                    { "/", DoDivision },
                    { "|", DoModul }
                };
        }

        public double PerformOperation(string op, double x, double y)
        {
            Calculator();
            if (!_operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op), "op");
            return _operations[op](x, y);
        }
    }
}
