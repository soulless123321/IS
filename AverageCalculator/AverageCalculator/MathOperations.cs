using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCalculator
{
    public static class MathOperations
    {
        public static void ReplaceWithAverage<T>(ref T a, ref T b, ref T c, ref T d, ref T e)
        {
            try
            {
                dynamic sum = (dynamic)b + (dynamic)c + (dynamic)d + (dynamic)e;
                dynamic average = sum / 4.0;
                a = (T)Convert.ChangeType(average, typeof(T));

                sum = (dynamic)a + (dynamic)c + (dynamic)d + (dynamic)e;
                average = sum / 4.0;
                b = (T)Convert.ChangeType(average, typeof(T));

                sum = (dynamic)a + (dynamic)b + (dynamic)d + (dynamic)e;
                average = sum / 4.0;
                c = (T)Convert.ChangeType(average, typeof(T));

                sum = (dynamic)a + (dynamic)b + (dynamic)c + (dynamic)e;
                average = sum / 4.0;
                d = (T)Convert.ChangeType(average, typeof(T));

                sum = (dynamic)a + (dynamic)b + (dynamic)c + (dynamic)d;
                average = sum / 4.0;
                e = (T)Convert.ChangeType(average, typeof(T));
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка при вычислении среднего значения для типа {typeof(T).Name}: {ex.Message}");
            }
        }
    }
}
