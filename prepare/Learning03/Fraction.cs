using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public int GetTop()
    {
        int Top = _numerator;
        return Top;
    }

    public void SetTop(int Top)
    {
        _numerator = Top;
    }

    public int GetBottom()
    {
        int Bottom = _denominator;
        return Bottom;
    }

    public void SetBottom(int Bottom)
    {
        _denominator = Bottom;
    }

    public string GetFractionString()
    {
        string FractionString = $"{_numerator}/{_denominator}";
        return FractionString;
    }

    public double GetDecimalValue()
    {
        double DecimalValue = (double)_numerator / (double)_denominator;
        return DecimalValue;
    }

}