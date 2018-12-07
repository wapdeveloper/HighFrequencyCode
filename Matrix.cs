using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Creat matrix one way
            Matrix<double> m = Matrix<double>.Build.Dense(3,2);
            m[0, 0] = 1;
            m[0, 1] = 2;
            m[1, 0] = 3;
            m[1, 1] = 4;
            m[2, 0] = 5;
            m[2, 1] = 6;
            Console.WriteLine(m.ToString());
            Vector<double> v = Vector<double>.Build.Dense(3);
            v.SetValues(new double[] { 4,5,6 });
            Vector<double> f = v * m;
            Console.WriteLine(f.ToString());

            ///Creat matrix another way
            Vector<double> v1 = Vector<double>.Build.Dense(3);
            v1.SetValues(new double[] { 1,3,5});
            Vector<double> v2 = Vector<double>.Build.Dense(3);
            v2.SetValues(new double[] { 2,4,6});
            Matrix<double> m1 = Matrix<double>.Build.Dense(3, 2);
            m1.SetColumn(0,v1);
            m1.SetColumn(1,v2);
            f = v * m1;
            Console.WriteLine(m1.ToString());
            Console.WriteLine(f.ToString());

        }
    }
}
