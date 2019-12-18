using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathArr;
using StringOp;
using System.Threading.Tasks;

namespace w10tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix1 = new Matrix<int>(3, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;
            matrix1[2, 0] = 5;
            matrix1[2, 1] = 5;

            Matrix<int> matrix3 = new Matrix<int>(3, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;
            matrix1[2, 0] = 5;
            matrix1[2, 1] = 5;

           
            //Matrix<int> matrix2 = new Matrix<int>(2, 3);
            //matrix1[0, 0] = 1;
            //matrix1[0, 1] = 2;
            //matrix1[0, 2] = 3;
            //matrix1[1, 0] = 4;
            //matrix1[1, 1] = 5;
            //matrix1[1, 2] = 5;

            Matrix<int> addmatrix = matrix1.AddTo(matrix3);
            //addmatrix=Matrix<int>.AddMat(matrix1, matrix3);
            

            //ReversedString reversedString = new ReversedString("Test1ng-Leet=code-Q!");
            //string s=reversedString.ReversedIgnore();

        }


        public static int[,] AddMat(int[,] mat, int[,] mat2)
        {
           int[,] addMatrix = new int[5,2];

            

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {

                        addMatrix[i, j] = mat[i, j]+ mat2[i, j];
                    }
                }
            
            
            return addMatrix;
        }
    }
}
