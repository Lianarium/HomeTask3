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

		public LinearEq()
		{

			do
			{
				Console.WriteLine("Enter the first coefficent: ");
				this.stringkoef1 = Console.ReadLine();
				if (!(double.TryParse(this.stringkoef1, out koef1)))
				{ Logger.WriteviolationLog(stringkoef1); }

			} while (!(double.TryParse(this.stringkoef1, out koef1)));

			{ this.koef1 = Convert.ToDouble(this.stringkoef1); }


			do
			{
				Console.WriteLine("Enter the second coefficent: ");
				this.stringkoef2 = Console.ReadLine();
				if (!(double.TryParse(this.stringkoef2, out koef1)))
				{ Logger.WriteviolationLog(stringkoef2); }

			} while (!(double.TryParse(this.stringkoef2, out koef2)));

			{ this.koef2 = Convert.ToDouble(this.stringkoef2); }
 
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
			equation.root = (-1) * (equation.koef2 / equation.koef1);
		}

		public static void OutputResult(LinearEq equation)
		{
			Console.WriteLine("root: " + equation.root);
		}

    }
}
