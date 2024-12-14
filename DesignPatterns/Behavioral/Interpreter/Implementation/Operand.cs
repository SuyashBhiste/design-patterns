using DesignPatterns.Behavioral.Interpreter.Contract;

namespace DesignPatterns.Behavioral.Interpreter.Implementation;

public class Operand : ICalculator
{
    private readonly decimal _number;
    
    public Operand(int number)
    {
        _number = number;
    }
    
    public decimal Calculate()
    {
        return _number;
    }
}