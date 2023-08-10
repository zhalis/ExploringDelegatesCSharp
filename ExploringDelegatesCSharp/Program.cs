namespace ExploringDelegatesCSharp;

class Program
{
    private delegate double MathOperation(double firstNumber, double secondNumber);
    
    public static void Main(string[] args)
    {
        MathOperation mathOperationAdd = MathematicalOperations.Add;
        MathOperation mathOperationSubtract = MathematicalOperations.Subtract;
        MathOperation mathOperationMultiply = MathematicalOperations.Multiply;
        MathOperation mathOperationDivide = MathematicalOperations.Divide;

        Console.WriteLine("Enter first number:");
        var firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        var secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose mathematical operation: \n 1 - Add; 2 - Subtract; 3 - Multiply; 4 - Divide");
        var operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine($"Result: {mathOperationAdd(firstNumber, secondNumber)}");
                break;
            case 2:
                Console.WriteLine($"Result: {mathOperationSubtract(firstNumber, secondNumber)}");
                break;
            case 3:
                Console.WriteLine($"Result: {mathOperationMultiply(firstNumber, secondNumber)}");
                break;
            case 4:
                Console.WriteLine($"Result: {mathOperationDivide(firstNumber, secondNumber)}");
                break;
            default:
                Console.WriteLine("Transaction number not found");
                break;
        }
    }
}