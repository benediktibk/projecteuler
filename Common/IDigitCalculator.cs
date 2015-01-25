namespace Common
{
    public interface IDigitCalculator<T>
    {
        T DigitBase { get; }

        T CalculateDigit(T value, T carry);
        T CalculateCarry(T value);
        T Cast(ulong value);
        bool IsDigitGreaterThanZero(T value);
        T CalculateSum(T a, T b, T c);
        T CalculateSum(T a, T b);
        T CalculateProduct(T a, T b, T carry);
        bool IsValidDigit(T a);
    }
}
