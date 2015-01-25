﻿namespace Common
{
    public interface IDigitCalculator<T>
    {
        T CalculateDigit(T value, T carry);
        T CalculateCarry(T value);
        T Cast(uint value);
        bool IsDigitGreaterThanZero(T value);
        T CalculateSum(T a, T b, T c);
        T CalculateSum(T a, T b);
        T CalculateProduct(T a, T b, T carry);
        bool IsValidDigit(T a);
    }
}