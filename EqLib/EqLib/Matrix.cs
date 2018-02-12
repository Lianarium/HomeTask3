using System;
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
        private  int num_columns;
        private int num_rows;
        private double[,] array;


        public int GetColumns()
        {
            return num_columns;
        }

        public int GetRows()
        {
            return num_columns;
        }

        public double[,] GetArray()
        {
            return array;
        }

        public Matrix()
        {
            this.num_columns = 2;
            this.num_rows = 4;
            array = new double[num_columns, num_rows];

        }

        public void addMatrix(Matrix obj)
        {
            string config = ConfigurationSettings.AppSettings.Get("config_file_name");

            for (int i = 0; i < obj.num_columns; i++)
            {
                for (int j=0; j < obj.num_rows; j++)
                {
                    foreach (string line in File.ReadLines(config))

                    {
                        char[] lineArray = line.ToCharArray();
                        for (int k = 0; k < lineArray.Length; k++)
                        {
                            double matrix_element;
                            if (double.TryParse(Convert.ToString(lineArray[i]), out matrix_element) && lineArray[i] != ' ')
                            {
                                this.array[i, j] = matrix_element;
                                Console.WriteLine(array[i,j] + "&");
                            }

                        }
                    }
                }
            }   
        }

        public void ArrayOutput(Matrix obj)
        {
            for (int i=0; i< obj.num_columns; i++)
            {
                 

                for (int j=0; j<obj.num_rows; j++)
                {
                    Console.WriteLine(obj.array[i, j] + "*");
                }
            }
        }

        /*public static Matrix umn(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        resMass[i, j] += a[i, k] * b[k, j];

            return resMass;
        }*/
    }
}
