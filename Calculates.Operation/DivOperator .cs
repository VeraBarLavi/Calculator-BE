using System;
using System.Collections.Generic;
using System.Text;

namespace Calculates.Operation
{
	public class DivOperator : IOperator
	{
		public double getResult(double num1, double num2)
		{
			try
			{
				if (num2 != 0) ;
				return num1 / num2;
			}
			catch (Exception e)
            {
				Console.WriteLine("Division of {0} by zero: ", e.Message);
				return 0;
			}
		}
	}

}
