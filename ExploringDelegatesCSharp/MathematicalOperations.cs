namespace ExploringDelegatesCSharp;

public static class MathematicalOperations
{
    public static double Add(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public static double Subtract(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }

    public static double Multiply(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    public static double Divide(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0 )
        {
            return double.NaN;
        }
        return firstNumber / secondNumber;
    }
}