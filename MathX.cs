namespace MathUtils
{
    public class MathX
    {
        #region Sum
        public static double[] Sum(double[] x, double[] y)
        {
            double[] result = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] + y[i];
            }

            return result;
        }



        public static double[] Sum(List<double[]> arr)
        {

            double[] result = new double[arr.Count()];

            for (int i = 0; i < arr.Count(); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    result[i] += arr[i][j];
                }
                    
            }

            return result;
        }


        #endregion Sum


        #region Multiply
        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double[] Multiply(double[] x, double[] y)
        {
            double[] result = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    result[i] = x[i] * y[j];
                }
            }


            return result;
        }


        public static double[] Multiply(double x, double[] y)
        {
            double[] result = new double[y.Length];

            for (int i = 0; i < y.Length; i++)
            {
                result[i] = y[i] * x;
            }

            return result;
        }


        public static double[,] Multiply(double x, double[,] y)
        {
            int lines = y.GetLength(0);
            int rows = y.GetLength(1);

            double[,] result = new double[lines, rows];

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    result[i, j] = y[i, j] * x;
                }
            }

            return result;
        }


        public static double[,] Multiply(double[,] x, double[,] y)
        {
            int linesX = x.GetLength(0);
            int rowsX = x.GetLength(1);
            int linesY = y.GetLength(0);
            int rowsY = y.GetLength(1);

            double[,] result = new double[linesX, rowsY];

            for (int i = 0; i < linesX; i++)
            {
                for (int j = 0; j < rowsY; j++)
                {
                    result[i, j] = 0;

                    for (int k = 0; k < rowsX; k++)
                    {
                        result[i, j] += x[i, k] * y[k, j];
                    }
                }
            }

            return result;
        }



        public static double[] Multiply(double[] x, double[,] y)
        {
            int linhasMatriz = y.GetLength(0);
            int colunasMatriz = y.GetLength(1);
            

            double[] resultado = new double[colunasMatriz];

            for (int j = 0; j < colunasMatriz; j++)
            {
                double soma = 0.0;

                for (int i = 0; i < colunasMatriz; i++)
                {
                    soma += y[i, j] * x[i];
                }

                resultado[j] = soma;
            }

            return resultado;
        }
        #endregion Multiply


        #region Dot
        public static double Dot(double[] x, double[] y)
        {
            double resultado = 0.0;

            for (int i = 0; i < x.Length; i++)
            {
                resultado += x[i] * y[i];
            }

            return resultado;
        }
        #endregion Dot


        #region Softmax
        public static double[] Softmax(double[] input)
        {
            double[] expValues = input.Select(Math.Exp).ToArray();
            double sumExpValues = expValues.Sum();

            return expValues.Select(v => v / sumExpValues).ToArray();
        }
        #endregion Softmax

    }
}

