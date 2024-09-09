namespace HHTest.Utils
{
    /// <summary>
    /// Производит необходимые проверки, если у нас допустимо хранение в свойстве фигуры NULL,
    /// то можно упростить, но соотвественно и поменять классы фигур
    /// </summary>
    public static class Validator
    {
        public static void IsNullOrNegative(params float?[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (!values[i].HasValue || values[i]!.Value <= 0)
                    throw new Exception("Ошибка валидации параметров");
            }
        }

        public static void IsValidTriangle(float a, float b, float c)
        {
            if (a + b < c || a + c < b || b + c < a)
                throw new Exception("Такого треугольника не существует");
        }
    }
}
