using System;

namespace Task_1._5._ComplexNumber
{
    public class ComplexNumber
    {
        private int real;
        private int imaginary;

        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ComplexNumber;
            if (other == null) return false;

            return (this.real == other.real) &&
                (this.imaginary == other.imaginary);
        }
        #region
        public static bool operator ==(ComplexNumber me,
        ComplexNumber other) => Equals(me, other);

        public static bool operator !=(ComplexNumber me,
            ComplexNumber other) => !Equals(me, other);
        #endregion
        #region
        public static ComplexNumber operator *(ComplexNumber c1, 
            ComplexNumber c2)
        {
            return new ComplexNumber(c1.real *
                c2.real - c1.imaginary * c2.imaginary,
                c1.real * c2.imaginary + c1.imaginary *
                c2.real);
        }
        public static ComplexNumber operator /(ComplexNumber c1,
            ComplexNumber c2)
        {
            return new ComplexNumber((c1.real *
                c2.real + c1.imaginary * c2.imaginary) / 
                (c2.real * c2.real + c2.imaginary * c2.imaginary),
                ( - c1.real * c2.imaginary + c1.imaginary *
                c2.real) / (c2.real * c2.real + 
                c2.imaginary * c2.imaginary));
        }
    }
        #endregion
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            var a = new ComplexNumber(-4, 7);
            var b = new ComplexNumber(1, 2);
            var c = new ComplexNumber(2, 3);

            if (a == b * c)
                Console.WriteLine("(-4, 7) == " +
                    "(1, 2) * (2, 3)");

            if (b != a * c)
                Console.WriteLine("(1, 2) !== " +
                    "(-4, 7) * (2, 3)");

            var d = new ComplexNumber(2, -1);
            var e = new ComplexNumber(1, 2);
            var f = new ComplexNumber(0, 1);

            if (d == e / f)
                Console.WriteLine("(2, -1) == " +
                    @"(1, 2) / (0, 1)");

            if (e != d / f)
                Console.WriteLine("(1, 2) !== " +
                    @"(2, -1) / (0, 1)");

            Console.ReadKey();
        }
    }
}
