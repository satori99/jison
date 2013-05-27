using System;
using System.Collections.Generic;
using Jison;

namespace jQuerySheet
{
	static public class FormulaFunctions
	{
        public static ParserValue Call(string fnName)
        {
            return Call(fnName, new ParserValue());
        }

		public static ParserValue Call(string fnName, ParserValue value)
		{
		    ParserValue result = null;
            switch (fnName.ToUpper())
			{
				case "SUM":
                    result = SUM(value);
			        break;
			}

			return result;
		}

		public static ParserValue SUM(ParserValue value)
		{
            return new ParserValue(value.ToDouble());
		}

		public static ParserValue SUM(Stack<ParserValue> values)
		{
			double sum = 0;
			foreach(ParserValue value in values) {
				sum += value.ToDouble();
			}
			return new ParserValue(sum);
		}
	}
}

