using DesignPatterns.Behavioral.Interpreter.Contract;
using DesignPatterns.Behavioral.Interpreter.Implementation;

namespace DesignPatterns.Behavioral.Interpreter;

public class Test
{
    public void Main()
    {
        // 1 + 2 + 2 - 3 => ((1+2) + (2-3))
        ICalculator operand1 = new Operand(1);
        ICalculator operand2 = new Operand(2);
        ICalculator operand3 = new Operand(3);
        
        ICalculator add = new Addition(operand1, operand2);
        ICalculator subtract = new Subtraction(operand2, operand3);
        
        ICalculator result = new Addition(add, subtract);
    }
}