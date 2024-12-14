using DesignPatterns.Behavioral.Interpreter.Contract;

namespace DesignPatterns.Behavioral.Interpreter.Implementation;

public class Subtraction : ICalculator
{
    private readonly ICalculator _operand1, _operand2;

    public Subtraction(ICalculator operand1, ICalculator operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }

    public decimal Calculate()
    {
        return _operand1.Calculate() - _operand2.Calculate();
    }
}