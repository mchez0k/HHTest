using HHTest.Interfaces;
using HHTest.Utils;

namespace HHTest.Shapes
{
    public class Circle : IShape
    {
        #region Fields

        /// <summary>
        /// Радиус круга
        /// </summary>
        public float Radius { get; set; }

        #endregion

        #region Constructor

        public Circle(float? radius)
        {
            Validator.IsNullOrNegative(radius);
            Radius = radius!.Value;
        }

        #endregion

        public float CalculateArea()
        {
            var area = MathF.PI * MathF.Pow(Radius, 2);
            return area;
        }
    }
}
