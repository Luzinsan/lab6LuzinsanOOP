using System.Runtime.InteropServices;
using luMath;

public class Program
{

    static  double func(uint i, uint j) => Convert.ToDouble(i == j);
    
        
    public delegate double Del(uint i , uint j);
    

    static void Main(string[] args)
    {
        Matrix matrix0 = new Matrix();

        double[,] array0 = new double[2, 2] {{4.9, -6.4 }, {456.3, 9.77 }};

        Matrix matrix1 = new Matrix(2, array0);
        Console.WriteLine(matrix1);
        
        Matrix matrix2 = new Matrix(matrix1 + matrix1);
        Console.WriteLine(matrix2);

        Matrix matrix3 = new Matrix(matrix2 - matrix1);
        Console.WriteLine(matrix3);
        
        
        double[,] array1 = new double[2, 1] {{1.0 }, {2.0 }};
        Matrix matrix4 = new Matrix(2, 1, array1);
        
        double[,] array2 = new double[1, 2] {{3.0, -1.0 }};
        Matrix matrix5 = new Matrix(1, 2, array2);
        
        Matrix matrix6 = new Matrix(matrix4 * matrix5);
        Console.WriteLine(matrix6);
        
        Console.WriteLine(Matrix.MaxValue(matrix6));
        Console.WriteLine(Matrix.MinValue(matrix6));

        matrix6[1, 1] = 600.0;
        Console.WriteLine(matrix6);

        Del handler = func;
        Console.WriteLine(new Matrix(5,func));

    }


}
