using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqLib
{
	public class QuadrEq
	{
		string stringkoef1;
		string stringkoef2;
		string stringkoef3;
		double koef1;
		double koef2;
		double koef3;
		double discriminant;
		double root1;
		double root2;

		public QuadrEq()
		{
     
			
		  do
			{
				Console.WriteLine("Enter the first coefficent: ");
				this.stringkoef1 = Console.ReadLine();
			}   while (!(double.TryParse(this.stringkoef1, out koef1)));

			{ this.koef1 = Convert.ToDouble(this.stringkoef1); }


			do
			{
				Console.WriteLine("Enter the second coefficent: ");
				this.stringkoef2 = Console.ReadLine();
			} while (!(double.TryParse(this.stringkoef2, out koef2)));

			{ this.koef2 = Convert.ToDouble(this.stringkoef2); }

			do
			{
				Console.WriteLine("Enter the third coefficent: ");
				this.stringkoef3 = Console.ReadLine();
			} while (!(double.TryParse(this.stringkoef3, out koef3)));

			{ this.koef3 = Convert.ToDouble(this.stringkoef3); }
		}

		public string getkoef1()
		{
			return stringkoef1;
		}

		public string getkoef2()
		{
			return stringkoef2;
		}

		public string getkoef3()
		{
			return stringkoef3;
		}

		public string getroot1()
		{
			return Convert.ToString(root1);
		}

		public string getroot2()
		{
			return Convert.ToString(root2);
		}

		public static void CountDiscriminant(QuadrEq equation)
		{
			equation.discriminant = Math.Pow(equation.koef2, 2) - 4 * (equation.koef1) * (equation.koef3);
		}


		public static void SolveEquation(QuadrEq equation)
		{
			if (equation.discriminant<0)
			{
				equation.root1 = double.NaN;
				equation.root2 = double.NaN;
			}

			else if (equation.discriminant >=0)
			{
				equation.root1 = ((equation.koef2) * (-1) + Math.Sqrt(equation.discriminant)) / (2 * equation.koef1);
				equation.root2 = ((equation.koef2) * (-1) - Math.Sqrt(equation.discriminant)) / (2 * equation.koef1);
			}
		}




		public static void OutputResult(QuadrEq equation)
		{
			Console.WriteLine("{00:0.##}",equation.root1);
			Console.WriteLine("{00:0.##}",equation.root2);
			Console.WriteLine(equation.root1);
			Console.WriteLine(equation.root2);

		}
	}
}
