using System;
using System.Collections.Generic;
using System.Text;

namespace Calculates.Operation
{
    public class OperationFactory
    {
        public static IOperator createOperation(String operatorName)
        {
            IOperator oper = null;
            switch (operatorName)
            {
                case "+":
                    oper = new AddOperator();
                    break;
                case "-":
                    oper = new SubOperator();
                    break;
                case "*":
                    oper = new MulOperator();
                    break;
                case "/":
                    oper = new DivOperator();
                    break;
            }
            return oper;
        }
    }
}
