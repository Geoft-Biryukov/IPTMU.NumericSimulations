using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTMU.MathKernel.OrientationParameters
{
    [SerializableAttribute]
    public struct Quaternion : IEquatable<Quaternion>, IFormattable
    {
        #region fields
        private double x;
        private double y;
        private double z;
        private double w;
        #endregion

        #region ctors and conversion operators

        public Quaternion(double w)
            : this(w, 0, 0, 0)
        { }

        public Quaternion(double w, double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static implicit operator Quaternion(double w)
        {
            return new Quaternion(w);
        }

        public static explicit operator double(Quaternion q)
        {
            return q.W;
        }
        #endregion

        #region properties
        public double W
        {
            get { return w; }
            set { w = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return w;
                    case 1: return x;
                    case 2: return y;
                    case 3: return z;
                    default:
                        throw new IndexOutOfRangeException("index");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: w = value; break;
                    case 1: x = value; break;
                    case 2: y = value; break;
                    case 3: z = value; break;
                    default:
                        throw new IndexOutOfRangeException("index");
                }
            }
        }
        #endregion

        #region operators
        public static Quaternion operator +(Quaternion q)
        {
            return new Quaternion(q.W, q.X, q.Y, q.Z);
        }
        public static Quaternion Plus(Quaternion q)
        {
            return +q;
        }

        public static Quaternion operator -(Quaternion q)
        {
            return new Quaternion(-q.W, -q.X, -q.Y, -q.Z);
        }
        public static Quaternion Negate(Quaternion q)
        {
            return -q;
        }

        public static Quaternion operator +(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.W + q2.W, q1.X + q2.X, q1.Y + q2.Y, q1.Z + q2.Z);
        }
        public static Quaternion Add(Quaternion q1, Quaternion q2)
        {
            return q1 + q2;
        }

        public static Quaternion operator -(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.W - q2.W, q1.X - q2.X, q1.Y - q2.Y, q1.Z - q2.Z);
        }
        public static Quaternion Subtract(Quaternion q1, Quaternion q2)
        {
            return q1 - q2;
        }

        public static Quaternion operator *(Quaternion q1, Quaternion q2)
        {
            double w = q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z;
            double x = q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y;
            double y = q1.w * q2.y + q1.y * q2.w + q1.z * q2.x - q1.x * q2.z;
            double z = q1.w * q2.z + q1.z * q2.w + q1.x * q2.y - q1.y * q2.x;

            return new Quaternion(w, x, y, z);
        }
        public static Quaternion Multiply(Quaternion q1, Quaternion q2)
        {
            return q1 * q2;
        }

        public static Quaternion operator /(Quaternion q, double d)
        {
            double m = 1.0 / d;
            return new Quaternion(q.w * m, q.x * m, q.y * m, q.z * m);
        }
        public static Quaternion Divide(Quaternion q, double d)
        {
            return q / d;
        }

        public static Quaternion operator *(double d, Quaternion q)
        {
            return new Quaternion(d * q[0], d * q[1], d * q[2], d * q[3]);
        }
        public static Quaternion Multiply(double d, Quaternion q)
        {
            return d * q;
        }

        public static Quaternion operator *(Quaternion q, double d)
        {
            return new Quaternion(d * q[0], d * q[1], d * q[2], d * q[3]);
        }
        public static Quaternion Multiply(Quaternion q, double d)
        {
            return q * d;
        }

        public static bool operator ==(Quaternion q1, Quaternion q2)
        {
            return q1.Equals(q2);
        }

        public static bool Equals(Quaternion q1, Quaternion q2)
        {
            return q1 == q2;
        }

        public static bool operator !=(Quaternion q1, Quaternion q2)
        {
            return !q1.Equals(q2);
        }
        #endregion

        #region quaternionic operations
        public double Scal()
        {
            return w;
        }

        public static double Scal(Quaternion q)
        {
            return q.Scal();
        }

        public Quaternion Vect()
        {
            return new Quaternion(0, x, y, z);
        }

        public static Quaternion Vect(Quaternion q)
        {
            return q.Vect();
        }

        public Quaternion Conjugate()
        {
            return new Quaternion(w, -x, -y, -z);
        }

        public static Quaternion Conjugate(Quaternion q)
        {
            return q.Conjugate();
        }

        public double Norm()
        {
            return w * w + x * x + y * y + z * z;
        }

        public static double Norm(Quaternion q)
        {
            return q.Norm();
        }

        public static Quaternion Reproject1(Quaternion q, Quaternion r)
        {
            return q * r * Quaternion.Conjugate(q);
        }

        public static Quaternion Reproject2(Quaternion q, Quaternion r)
        {
            return Conjugate(q) * r * q;
        }

        public static Quaternion I1()
        {
            return new Quaternion(0, 1, 0, 0);
        }

        public static Quaternion I2()
        {
            return new Quaternion(0, 0, 1, 0);
        }

        public static Quaternion I3()
        {
            return new Quaternion(0, 0, 0, 1);
        }

        public static Quaternion Exp(Quaternion q)
        {                   
            double b = Math.Sqrt(Norm(Vect(q)));

            if (b == 0) 
                return Math.Exp(Scal(q)) * CreateIdentity();
            else
                return Math.Exp(Scal(q)) * (Math.Cos(b) + (Vect(q) * Math.Sin(b)) / b);                        
        }
        #endregion

        #region creators and helpers
        public static Quaternion CreateIdentity()
        {
            return new Quaternion(1, 0, 0, 0);
        }

        /// <summary>
        /// Формирует кватернион по углам.
        /// Внимание!!! Углы задаются в радианах!
        /// </summary>
        /// <param name="alpha">Азимут (рад.)</param>
        /// <param name="theta">Зенитный угол (рад.)</param>
        /// <param name="phi">Визир (рад.)</param>
        public static Quaternion CreateFromAngles(double alpha, double theta, double phi)
        {
            // Можно упростить выражения, если использовать формулы тригонометрии
            //double q_0 = Math.Cos(0.5 * alphaRadian) * Math.Cos(0.5 * thetaRadian) * Math.Cos(0.5 * phiRadian) - Math.Sin(0.5 * alphaRadian) * Math.Cos(0.5 * thetaRadian) * Math.Sin(0.5 * phiRadian);
            //double q_1 = Math.Sin(0.5 * alphaRadian) * Math.Sin(0.5 * thetaRadian) * Math.Cos(0.5 * phiRadian) - Math.Cos(0.5 * alphaRadian) * Math.Sin(0.5 * thetaRadian) * Math.Sin(0.5 * phiRadian);
            //double q_2 = Math.Cos(0.5 * alphaRadian) * Math.Sin(0.5 * thetaRadian) * Math.Cos(0.5 * phiRadian) + Math.Sin(0.5 * alphaRadian) * Math.Sin(0.5 * thetaRadian) * Math.Sin(0.5 * phiRadian);
            //double q_3 = Math.Cos(0.5 * alphaRadian) * Math.Cos(0.5 * thetaRadian) * Math.Sin(0.5 * phiRadian) + Math.Sin(0.5 * alphaRadian) * Math.Cos(0.5 * thetaRadian) * Math.Cos(0.5 * phiRadian);

            var q1 = new Quaternion(Math.Cos(alpha * 0.5), 0, 0, Math.Sin(alpha * 0.5));
            var q2 = new Quaternion(Math.Cos(theta * 0.5), 0, Math.Sin(theta * 0.5), 0);
            var q3 = new Quaternion(Math.Cos(phi * 0.5), 0, 0, Math.Sin(phi * 0.5));

            return q1 * q2 * q3;
        }

        public static void ToAngles(Quaternion q, out double alpha, out double theta, out double phi)
        {
            alpha = Math.Atan2(q[2] * q[3] + q[0] * q[1], q[1] * q[3] - q[0] * q[2]);
            if (alpha < 0)
                alpha += 2.0 * Math.PI;

            theta = Math.Acos(2.0 * (q[0] * q[0] + q[3] * q[3]) - 1);
            if (double.IsNaN(theta))
                theta = 0;

            phi = Math.Atan2(q[2] * q[3] - q[0] * q[1], q[1] * q[3] + q[0] * q[2]);
        }

        /// <summary>
        /// Формирует кватернион по углам Крылова.
        /// Внимание!!! Углы задаются в радианах!
        /// </summary>
        /// <param name="psi">Курс (рад.)</param>
        /// <param name="theta">Тангаж (рад.)</param>
        /// <param name="gamma">Крен (рад.)</param>
        public static Quaternion CreateFromKrylovAngles(double psi, double theta, double gamma)
        {

            var q0 = Math.Cos(0.5 * psi) * Math.Cos(0.5 * theta) * Math.Cos(0.5 * gamma) - Math.Sin(0.5 * psi) * Math.Sin(0.5 * theta) * Math.Sin(0.5 * gamma);
            var q1 = Math.Sin(0.5 * psi) * Math.Sin(0.5 * theta) * Math.Cos(0.5 * gamma) + Math.Cos(0.5 * psi) * Math.Cos(0.5 * theta) * Math.Sin(0.5 * gamma);
            var q2 = Math.Sin(0.5 * psi) * Math.Cos(0.5 * theta) * Math.Cos(0.5 * gamma) + Math.Cos(0.5 * psi) * Math.Sin(0.5 * theta) * Math.Sin(0.5 * gamma);
            var q3 = Math.Cos(0.5 * psi) * Math.Sin(0.5 * theta) * Math.Cos(0.5 * gamma) - Math.Sin(0.5 * psi) * Math.Cos(0.5 * theta) * Math.Sin(0.5 * gamma);

            return new Quaternion(q0, q1, q2, q3);
        }

        #endregion

        #region interfaces implementation
        public bool Equals(Quaternion other)
        {
            return w == other.w && x == other.x && y == other.y && z == other.z;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null || format.Equals(string.Empty))
            {
                format = @"({0}, {1}, {2}, {3})";
            }
            return string.Format(format, w.ToString(formatProvider), x.ToString(formatProvider), y.ToString(formatProvider), z.ToString(formatProvider));
        }
        #endregion

        #region Object overriding
        public override bool Equals(object obj)
        {
            if (!(obj is Quaternion q))
                return false;

            return q.W.Equals(W) && q.X.Equals(X) && q.Y.Equals(Y) && q.Z.Equals(Z);
        }

        public override int GetHashCode()
        {
            return W.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        #endregion
    }
}
