using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Matrix3
    {
        public float[] m = new float[9];
        public Matrix3()
        {
            m[1] = 1; m[2] = 0; m[3] = 0;
            m[4] = 0; m[5] = 1; m[6] = 0;
            m[7] = 0; m[8] = 0; m[9] = 1;
        }
    }
    public class Matrix4
    {
        public Matrix4()
        {

        }
    }
}
