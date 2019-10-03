namespace HW.Net
{
    public class ComplexNumberTask5
    {
        #region Properties
        public double Real { get; set; }

        public double Imaginary { get; set; }
        #endregion

        #region Constructors
        public ComplexNumberTask5()
        {
        }

        public ComplexNumberTask5(double Real, double Imaginary)
        {
            this.Real = Real;
            this.Imaginary = Imaginary;
        }
        #endregion

        #region Override operators
        public static ComplexNumberTask5 operator *(ComplexNumberTask5 first, ComplexNumberTask5 second)
        {
            return new ComplexNumberTask5(first.Real * second.Real - first.Imaginary * second.Imaginary, first.Real * second.Imaginary + first.Imaginary * second.Real);
        }

        public static ComplexNumberTask5 operator /(ComplexNumberTask5 first, ComplexNumberTask5 second)
        {
            double real = (first.Real * second.Real) + (first.Imaginary * second.Real) / (second.Real * second.Real) + (second.Imaginary * second.Imaginary);
            double imaginary = (second.Real * first.Imaginary) - (first.Real * second.Imaginary) / (second.Real * second.Real) + (second.Imaginary * second.Imaginary);

            return new ComplexNumberTask5(real, imaginary);
        }
        #endregion
    }
}