using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqLib
{
	public class Logger
	{


		public static string LOGFILE = "C:/Users/Alina_Apet/Documents/Visual Studio 2015/Projects/EqLib/Log.txt";

		public static void WriteLogLinearEquationAndRoots(LinearEq equation)
		{
			using (StreamWriter w = File.AppendText(LOGFILE))
			{
				Log("Equation: " + "x^"+ equation.getkoef1() + "+" + equation.getkoef2() + " = 0 \n    root: " + equation.getroot(), w );
		    }
		}

		public static void WriteLogQuadrEquationAndRoots(QuadrEq equation)
		{
			using (StreamWriter w = File.AppendText(LOGFILE))
			{
				Log("Equation: " + "x^" + equation.getkoef1() + "+ y^" + equation.getkoef2() + " + " + equation.getkoef3() + " = 0 \n   root1: " + equation.getroot1() + "\n   root2: " + equation.getroot2(), w);
			}
		}

		public static void WriteviolationLog(string violation)
		{
			using (StreamWriter w = File.AppendText(LOGFILE))
			{
				Log("Incorrect data: " + violation, w);
			}
		}


		public static void Log(string logMessage, TextWriter w)
		{
			w.Write("\r\nLog Entry : ");
			w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
				DateTime.Now.ToLongDateString());
			w.WriteLine("  :");
			w.WriteLine("  :{0}", logMessage);
			w.WriteLine("-------------------------------");
		}

	}
}
