using BinomialApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Binomial : IBinomial
{
    public double A { get; set; }
    public double B { get; set; }

    // Конструктор по умолчанию
    public Binomial() : this(0, 0) { }

    // Конструктор с параметрами
    public Binomial(double a, double b)
    {
        A = a;
        B = b;
    }

    // Реализация метода Add
    public IBinomial Add(IBinomial other)
    {
        return new Binomial(this.A + other.A, this.B + other.B);
    }

    // Реализация метода Subtract
    public IBinomial Subtract(IBinomial other)
    {
        return new Binomial(this.A - other.A, this.B - other.B);
    }

    // Реализация метода MultiplyBy
    public IBinomial MultiplyBy(double number)
    {
        return new Binomial(this.A * number, this.B * number);
    }

    // Реализация метода AddNumber
    public IBinomial AddNumber(double number)
    {
        return new Binomial(this.A + number, this.B);
    }

    // Реализация метода Calculate
    public double Calculate(double x)
    {
        return A + B * x;
    }

    // Реализация метода SolveEquation
    public double? SolveEquation()
    {
        if (B == 0)
        {
            return A == 0 ? (double?)null : null;
        }
        return -A / B;
    }

    // Переопределение метода Equals
    public override bool Equals(object obj)
    {
        if (obj is Binomial other)
        {
            return A == other.A && B == other.B;
        }
        return false;
    }

    // Переопределение метода GetHashCode
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + A.GetHashCode();
            hash = hash * 23 + B.GetHashCode();
            return hash;
        }
    }

    // Переопределение метода ToString
    public override string ToString()
    {
        return $"{A} + {B}x";
    }
}
