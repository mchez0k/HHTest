using HHTest.Interfaces;
using HHTest.Utils;

namespace HHTest.Shapes
{
    public class Triangle : IShape
    {
        #region Fields

        /// <summary>
        /// Три стороны треугольника
        /// </summary>
        public float SideA { get; set; }
        public float SideB { get; set; }
        public float SideC { get; set; }

        #endregion

        #region Consts

        private const float accuracy = 1e-10f; // Точность для вычисления float

        #endregion

        #region Constructor

        public Triangle(float? sideA, float? sideB, float? sideC)
        {
            Validator.IsNullOrNegative(sideA, sideB, sideC);
            Validator.IsValidTriangle(sideA!.Value, sideB!.Value, sideC!.Value);

            SideA = sideA.Value;
            SideB = sideB.Value;
            SideC = sideC.Value;
        }

        #endregion

        public float CalculateArea()
        {
            float s = (SideA + SideB + SideC) / 2;
            return MathF.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRight()
        {
            var sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < accuracy;
        }
    }
}
