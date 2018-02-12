using EqLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRunner
{
	class Program
	{

		static void Main(string[] args)
		{
			

			string choice;

			do
			{
				Console.WriteLine("Choose the type of equation to solve:\n 1.Linear; \n 2.Quadratic. ");
				choice = Console.ReadLine();

			} while (!((choice.Equals("1")) || (choice.Equals("2"))));

				if (choice.Equals("1"))
			{
				 LinearEq linear_equation = new LinearEq();
				 LinearEq.SolveEquation(linear_equation);
				 LinearEq.OutputResult(linear_equation);
				 Logger.WriteLogLinearEquationAndRoots(linear_equation);

			}

			else if (choice.Equals("2"))
			{
				QuadrEq quadratic_equation = new QuadrEq();
			    QuadrEq.CountDiscriminant(quadratic_equation);
				QuadrEq.SolveEquation(quadratic_equation);
				QuadrEq.OutputResult(quadratic_equation);
				Logger.WriteLogQuadrEquationAndRoots(quadratic_equation);
			}
            

            Matrix matrixA = new Matrix();
			Matrix matrixB = new Matrix();

			Matrix.ReadMatrixFromFile(matrixA, Matrix.SourceOfMatrixA());
			Matrix.ReadMatrixFromFile(matrixB, Matrix.SourceOfMatrixB());
			Matrix.MultiplyMatrix(matrixA, matrixB);

		}

		
	}
}
