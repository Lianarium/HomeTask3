using EqLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqLib
{
	public class ReaderFromConsole
	{
		public static string ChooseActionToPerform()
		{
			string choice;

			do
			{
				Console.WriteLine("Choose action:\n 1.Solve linear equation; \n 2.Solve quadratic equation; \n 3.Multiply two matrixes ");
				choice = Console.ReadLine();

			} while (!((choice.Equals("1")) || (choice.Equals("2")) || (choice.Equals("3"))));

			return choice;
		}

		public static double[] ReadLinearCoefficents()
		{

			string[] stringkoefs = new string[2];
			double[] koefs = new double[2];

			do
			{
				Console.WriteLine("Enter the first coefficent: ");
				stringkoefs[1] = Console.ReadLine();
				if (!(double.TryParse(stringkoefs[1], out koefs[1])))
				{ Logger.WriteviolationLog(stringkoefs[1]); }

			} while (!(double.TryParse(stringkoefs[1], out koefs[1])));

			{ koefs[1] = Convert.ToDouble( stringkoefs[1]); }


			do
			{
				Console.WriteLine("Enter the second coefficent: ");
				stringkoefs[2] = Console.ReadLine();
				if (!(double.TryParse(stringkoefs[2], out koefs[2])))
				{ Logger.WriteviolationLog(stringkoefs[2]); }

			} while (!(double.TryParse(stringkoefs[2], out koefs[2])));

			{koefs[2] = Convert.ToDouble(stringkoefs[2]); }

			return koefs;
		}

	}
}
