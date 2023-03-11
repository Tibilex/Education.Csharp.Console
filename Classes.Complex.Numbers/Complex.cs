using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Complex.Numbers
{
    internal class Complex
    {
        public double X, Y, i, complex;
        public Complex()
        {
            i = Math.Sqrt(-1);
            Console.Write("\tСоздайте Комплексное Число:\n X = ");
            X = double.Parse(Console.ReadLine());
            Console.Write(" Y = ");
            Y = double.Parse(Console.ReadLine());
            complex = X + Y * i;
            Console.WriteLine($" Комплексное Число ->>\t{X} + {Y} * i = {complex}");
        }
        public Complex(double x, double y)
        {
            i = Math.Sqrt(-1);
            X = x;
            Y = y;
            complex = X + Y * i;
        }
        public override string ToString() { return $"{X} + {Y} * i = {complex}\n"; }
        public override bool Equals(object obj) { return this.ToString() == obj.ToString(); }
        public override int GetHashCode() { return this.ToString().GetHashCode(); }
        public static Complex operator -(Complex comp1, Complex comp2)
        {
            return new Complex((comp1.X - comp2.X), (comp1.Y - comp2.Y));
        }
        public static Complex operator -(Complex comp, double n)
        {
            return new Complex(comp.X - n, comp.Y - n);
        }
        public static Complex operator -(double n, Complex comp)
        {
            return new Complex(n - comp.X, n - comp.Y);
        }
        public static Complex operator +(Complex comp1, Complex comp2)
        {
            return new Complex((comp1.X + comp2.X), (comp1.Y + comp2.Y));
        }
        public static Complex operator *(Complex comp1, Complex comp2)
        {
            return new Complex((comp1.X * comp2.X - comp1.Y * comp2.Y),
                (comp1.Y * comp2.X + comp1.X * comp2.Y));
        }
        public static Complex operator *(Complex comp, double n)
        {
            return new Complex(comp.X * n, comp.Y * n);
        }
        public static Complex operator *(double n, Complex comp) { return comp * n; }
        public static Complex operator /(Complex comp1, Complex comp2)
        {
            return new Complex((comp1.Y * comp2.X - comp1.X * comp2.Y),
            (comp1.Y * comp2.X + comp1.X * comp2.Y));
        }
        public static bool operator ==(Complex comp1, Complex comp2) { return comp1.Equals(comp2); }
        public static bool operator !=(Complex comp1, Complex comp2) { return !(comp1 == comp2); }
    }
}
