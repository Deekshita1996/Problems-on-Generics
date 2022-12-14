using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnGenerics
{
    public class GenericsMaxUC_1
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && (firstValue.CompareTo(thirdValue) > 0))
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && (secondValue.CompareTo(thirdValue) > 0))
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && (thirdValue.CompareTo(secondValue) > 0))
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber,thirdNumber are same");        
        }
    }
}
