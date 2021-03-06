﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqLib
{
	public class Matrix
	{
		private int num_columns;
		private int num_rows;
		private double[,] array;


		public int GetColumns()
		{
			return num_columns;
		}

		public int GetRows()
		{
			return num_rows;
		}

		public double[,] GetArray()
		{
			return array;
		}

		public Matrix()
		{
			this.num_columns = 0;
			this.num_rows = 0;
			array = new double[num_rows, num_columns];

		}

		public static string SourceOfMatrixA()
		{
			string config = ConfigurationSettings.AppSettings.Get("config_file_name_A");
			return config;
		}


		public static string SourceOfMatrixB()
		{
			string config = ConfigurationSettings.AppSettings.Get("config_file_name_B");
			return config;
		}

		public static void ReadMatrixFromFile(Matrix obj, string source)
		{

			Queue arr = new Queue();
            foreach (string line in File.ReadLines(source))
            {
                char separator = ' ';
                string[] lineArray = line.Split(separator);
                obj.num_rows++;
                double matrix_element;
				for (int k = 0; k < lineArray.Length; k++)
				{
					if (double.TryParse(Convert.ToString(lineArray[k]), out matrix_element))
						obj.num_columns++;
					    arr.Enqueue(matrix_element);

				}
			}


			obj.num_columns = obj.num_columns / obj.num_rows;
			obj.array = new double[obj.num_rows, obj.num_columns];

			for (int i = 0; i < obj.num_rows; i++)
			{
				for (int j = 0; j < obj.num_columns; j++)
				{
					double el = Convert.ToDouble(arr.Dequeue());
					obj.array[i, j] = el;
				}
			}
			 
		}




		public  static Matrix  MultiplyMatrix(Matrix matrixa, Matrix matrixb)
		{
			Matrix result = new Matrix();

			if (!(matrixa.num_columns == matrixb.num_rows))
			{
				Console.WriteLine("Error!");
				return null;
			}

			else if (matrixa.num_columns == matrixb.num_rows)
			{

				

                result.num_rows = matrixa.num_rows;
                result.num_columns = matrixb.num_columns;
                Console.WriteLine(result.num_columns);
                Console.WriteLine(result.num_rows);


                result.array = new double[matrixa.num_columns, matrixb.num_rows];

				for (int i = 0; i < matrixa.num_rows; i++)
				{
					for (int j = 0; j < matrixb.num_columns; j++)
					{
						for (int k = 0; k < matrixa.num_rows; k++)
						{
							result.array[i, j] += matrixa.array[i, k] * matrixb.array[k, j];
                            
                        }
					}
				}

					 
			}

			return result;
		}
			 
         

		public static void OutputMatrix(Matrix matrix)
		{
			for (int i = 0; i < matrix.num_rows; i++)
			{
				Console.Write("\n");
				for (int j = 0; j < matrix.num_columns; j++)
				{
					Console.Write(matrix.array[i, j]);
				}
			}
			Console.Write("\n");
		}

	}
    }

