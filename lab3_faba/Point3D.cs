﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_faba
{
    /// <summary>
    /// Класс - точка, имеющая три координаты типа double.
    /// </summary>
    public class Point3D
    {
        #region поля
        /// <summary>
        /// Задает допустимую погрешность при проверке
        /// двух точек на равенство.
        /// </summary>
        private static double E = 0.001;
        #endregion
        #region свойства
        /// <summary>
        /// Задает или возвращает координату X.
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// Задает или возвращает координату Y.
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// Задает или возвращает координату Z.
        /// </summary>
        public double Z { get; private set; }
        #endregion
        #region конструкторы
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// <param name="z">Координата Z.</param>
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// Копирующий конструктор.
        /// </summary>
        /// <param name="p">Конструктор создаст копию данного значения.</param>
        public Point3D(Point3D p)
        {
            if (p == null)
                throw new ArgumentNullException();
            this.X = p.X;
            this.Y = p.Y;
            this.Z = p.Z;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Point3D()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        #endregion
        #region методы
        public override string ToString()
        {
            return "(" + this.X.ToString() + "; " + this.Y.ToString() + "; " + this.Z.ToString() + ")";
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Point3D p = obj as Point3D;
            if ((this.X - p.X > E) || (this.X - p.X < -E))
                return false;
            if ((this.Y - p.Y > E) || (this.Y - p.Y < -E))
                return false;
            if ((this.Z - p.Z > E) || (this.Z - p.Z < -E))
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return (int)(this.X) * 10201 + (int)(this.Y) * 101 + (int)(this.Z);
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !p1.Equals(p2);
        }

        public static Point3D operator +(Point3D p1, Point3D p2)
        {
            if ((p1 == null) || (p2 == null))
                throw new ArgumentNullException();
            Point3D result = new Point3D(p1);
            result.X += p2.X;
            result.Y += p2.Y;
            result.Z += p2.Z;
            return result;
        }

        public static Point3D operator -(Point3D p1, Point3D p2)
        {
            if ((p1 == null) || (p2 == null))
                throw new ArgumentNullException();
            Point3D result = new Point3D(p1);
            result.X -= p2.X;
            result.Y -= p2.Y;
            result.Z -= p2.Z;
            return result;
        }
        #endregion
    }
}
