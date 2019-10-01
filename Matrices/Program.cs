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
            Matrix3a matrix = new Matrix3a(2);
        }
    }
    struct Vector3
    {
        float x, y, z;
        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }
    public class Matrix2
    {
        public float w1, w2, w3, w4;
        public Matrix2()
        {
            w1 = 1; w2 = 0;
            w3 = 0; w4 = 1;
        }

    }
    public class Matrix3a
    {
        public float[] o = new float[9];
        public Matrix3a(float l)
        {
            o[1] = 1; o[2] = 2; o[3] = 3;
            o[4] = 4; o[5] = 5; o[6] = 6;
            o[7] = 7; o[8] = 8; o[9] = 9;
        }


    }
    

    public class Matrix3
    {
        public float[] m = new float[9];
        public Matrix3(float v)
        {
            m[1] = 1; m[2] = 0; m[3] = 0;
            m[4] = 0; m[5] = 1; m[6] = 0;
            m[7] = 0; m[8] = 0; m[9] = 1;
        }
        public static Matrix3 operator *(Matrix3 lhs, Matrix3a rhs)
        {
            return new Matrix3(lhs.m[1] * rhs.o[2] + lhs.m[3] * rhs.o[4] + lhs.m[5] * rhs.o[6] + lhs.m[7] * rhs.o[8] + lhs.m[9]);
        }
    }
    public class Matrix4
    {
        public float[] n = new float[16];
        public Matrix4(float rhs)
        {
            n[1] = 1; n[2] = 0; n[3] = 0; n[4] = 0;
            n[5] = 0; n[6] = 1; n[7] = 0; n[8] = 0;
            n[9] = 0; n[10] = 0; n[11] = 1; n[12] = 0;
            n[13] = 0; n[14] = 0; n[15] = 0; n[16] = 1;
        }
        //public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        //{
        //    return new Matrix3((lhs.m[1] * rhs) + (lhs.m[2] * rhs) + (lhs.m[3] * rhs) + (lhs.m[4] * rhs) + (lhs.m[5] * rhs) + (lhs.m[6] * rhs)
        //        + (lhs.m[7] * rhs) + (lhs.m[8] * rhs) + (lhs.m[9] * rhs));
        //}
        
        
        
    }
}
