
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EqLib
{
	

    public class LinearEq
    {
		string stringkoef1;
		string stringkoef2;
		double koef1;
		double koef2;
		double root;

	 

		public LinearEq()//
		{

			koef1 = ReaderFromConsole.ReadLinearCoefficents()[1];
			koef2 = ReaderFromConsole.ReadLinearCoefficents()[2];
		}

         
		public string getkoef1()
		{
			return stringkoef1;
		}

		public string getkoef2()
		{
			return stringkoef2;
		}

		public string getroot()
		{
			return Convert.ToString(root);
		}

		public static void SolveEquation(LinearEq equation)
		{
			equation.root = ((-1)*equation.koef2 / equation.koef1);
		}

		public static void OutputResult(LinearEq equation)
		{
            Console.WriteLine("root: " + String.Format("{0:F2}", equation.root));
        }

    }
}
