﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Vector4
    {
        public float x, y, z, w;

        public Vector4(float xVal, float yVal, float zVal, float wVal)
        {
            x = xVal;
            y = yVal;
            z = zVal;
            w = wVal;
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z + w * w);
        }

        public float Distance(Vector4 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            float diffW = w - other.w;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ + diffW * diffW);
        }

        public float DistanceSqr(Vector4 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            float diffW = w - other.w;
            return (diffX * diffX + diffY * diffY + diffZ * diffZ + diffW * diffW);
        }
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
            this.w /= m;
        }
        public float Dot(Vector4 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z + w * rhs.w;
        }
        public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
        {
            return new Vector4(
                (lhs.m1 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m9 * rhs.z) + (lhs.m13 * rhs.w),
                (lhs.m2 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m10 * rhs.z) + (lhs.m14 * rhs.w),
                (lhs.m3 * rhs.x) + (lhs.m7 * rhs.y) + (lhs.m11 * rhs.z) + (lhs.m15 * rhs.w),
                (lhs.m4 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m12 * rhs.z) + (lhs.m16 * rhs.w));
        }
        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(
                y * rhs.z - z * rhs.y,
                z * rhs.x - x * rhs.z,
                x * rhs.y - y * rhs.x,
                0);
        }
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs.x + rhs.x,
                lhs.y + rhs.y,
                lhs.z + rhs.z,
                lhs.w + rhs.w);
        }
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs.x - rhs.x,
                lhs.y - rhs.y,
                lhs.z - rhs.z,
                lhs.w - rhs.w);
        }
        public static Vector4 operator *(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs.x * rhs.x,
                lhs.y * rhs.y,
                lhs.z * rhs.z,
                lhs.w * rhs.w);
        }
        public static Vector4 operator *(Vector4 lhs, float numVal)
        {
            return new Vector4(
                lhs.x * numVal,
                lhs.y * numVal,
                lhs.z * numVal,
                lhs.w * numVal);
        }
        public static Vector4 operator *(float numVal, Vector4 lhs)
        {
            return new Vector4(
                lhs.x * numVal,
                lhs.y * numVal,
                lhs.z * numVal,
                lhs.w * numVal);
        }
    }
}
