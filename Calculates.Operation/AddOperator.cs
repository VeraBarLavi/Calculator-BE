using System;
using System.Collections.Generic;
using System.Text;

namespace Calculates.Operation
{
	public class AddOperator : IOperator
	{
		public double getResult(double num1, double num2)
		{
			return num1 + num2;
		}
	}
}
