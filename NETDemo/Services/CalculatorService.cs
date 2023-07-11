namespace NETDemo.Services;

public class CalculatorService : ICalculatorService
{
    public decimal GetAreaOfSquare(decimal side)
    {
        return side * side;
    }
}
