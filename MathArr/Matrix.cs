using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArr
{
    public class Matrix<T> where T:struct,IComparable<T>,IConvertible
    {
        private T[,] matrix;
        private int column ;
        private int rows;


        public Matrix(int r, int c)
        {
            this.column = c;
            this.rows = r;
            matrix = new T[r, c];
        }

        public T this[int row,int col]
        {
            get
            {
                T val=default(T);
                if (row >= rows || col >= column)
                    Console.WriteLine();
                else val = matrix[row, col];
                return val;
            }
            set
            {
                if (row >= rows || col >= column)
                    Console.WriteLine();
                else matrix[row, col] = value;
            }
        }

        private static T Sub(T a, T b)
        {
            switch (typeof(T).Name)
            {
                case "Int32":
                    return (T)(object)((int)(object)a - (int)(object)b);
                default: return default(T);

                    //more cases to implement
            }
        }

        private static T Add(T a,T b)
        {
            switch (typeof(T).Name)
            {
                case "Int32":
                    return (T)(object)((int)(object)a + (int)(object)b);
                default: return default(T);

                    //more cases to implement
            }
        }

        public Matrix<T> AddTo(Matrix<T> mat)
         {
            Matrix<T> addMatrix= new Matrix<T>(rows, column);

            if(rows==mat.rows && column==mat.column)
            {
               
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {

                        addMatrix[i, j] =Add(this.matrix[i, j],mat[i, j]);
                    }
                }
            } 
            else Console.WriteLine();
            return addMatrix;
        }

        public bool ZeroElem()
        {
            int cnt = 0; ;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {

                    if(matrix[i,j].Equals(default(T)))
                    {
                        cnt++;
                    }
                }
            }
            if (cnt == rows * column)
                return true;
            else return false;
        }

        public Matrix<T> SubTo(Matrix<T> mat)
        {
            Matrix<T> addMatrix = new Matrix<T>(rows, column);

            if (rows == mat.rows && column == mat.column)
            {
                addMatrix = new Matrix<T>(rows, column);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        addMatrix[i, j] = Sub(mat[i, j] , this.matrix[i, j]);
                    }
                }
            }
            else Console.WriteLine();
            return addMatrix;
        }

        public  Matrix<T> MultTo(Matrix<T> mat)
        {
            Matrix<T> multMatrix = new Matrix<T>(this.rows, mat.column);
            if(this.rows==mat.column && this.column==mat.rows)
            {
                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < mat.column; j++)
                    {
                        multMatrix[i, j] = default(T);
                        for (int k = 0; k < this.column; k++)
                        {
                            multMatrix[i, j] =(dynamic)multMatrix[i,j] + (dynamic)this.matrix[i, k] * mat[k, j];
                        }
                    }
                }
            }
            else throw new  NotImplementedException("nu se poate realiza inm");
            return multMatrix;
        }

        public static Matrix<T> AddMat(Matrix<T> mat ,Matrix<T> mat2)
        {
            Matrix<T> addMatrix = new Matrix<T>(mat.rows,mat.column);

            if (mat2.rows == mat.rows && mat2.column == mat.column)
            {

                for (int i = 0; i < mat.rows; i++)
                {
                    for (int j = 0; j < mat.column; j++)
                    {

                        addMatrix[i, j] = Add(mat[i, j], mat2[i, j]);
                    }
                }
            }
            else Console.WriteLine();
            return addMatrix;
        }
    }

   
    
}
