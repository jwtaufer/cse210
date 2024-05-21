using System;

class Fraction
{
    private int _numerator;
    private int _denominator;
    private string _fractionString;
    private double _decimal;
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction (int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        _fractionString = _numerator.ToString() + "/" + _denominator.ToString();
        return _fractionString;
    }

    public double GetDecimalValue()
    {
        _decimal = (double)_numerator / (double)_denominator;
        return _decimal;
    }
}