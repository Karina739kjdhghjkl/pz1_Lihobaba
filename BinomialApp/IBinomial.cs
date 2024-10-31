using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinomialApp
{
    public interface IBinomial
    {
        // Свойства коэффициентов
        double A { get; set; }
        double B { get; set; }

        // Методы для работы с двочленом
        IBinomial Add(IBinomial other);           // Сложение с другим двочленом
        IBinomial Subtract(IBinomial other);      // Вычитание другого двочлена
        IBinomial MultiplyBy(double number);      // Умножение на число
        IBinomial AddNumber(double number);       // Добавление числа к двочлену
        double Calculate(double x);               // Вычисление значения двочлена при x
        double? SolveEquation();                  // Решение уравнения

        // Переопределение методов
        bool Equals(object obj);                  // Проверка на равенство
        int GetHashCode();                        // Получение хэш-кода
        string ToString();                        // Преобразование в строку
    }

}
