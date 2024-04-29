using System;

public class FluentCalculator
{
    public Value zero = new Value(0);
    public Value one = new Value(1);
    public Value two = new Value(2);
    public Value three = new Value(3);
    public Value four = new Value(4);
    public Value five = new Value(5);
    public Value six = new Value(6);
    public Value seven = new Value(7);
    public Value eight = new Value(8);
    public Value nine = new Value(9);
    public Value ten = new Value(10);

    public FluentCalculator() { }

    public class Value
    {
        private readonly int _value;

        public Value(int value)
        {
            _value = value;
        }

        public Value(Operation operation, int value)
        {
            switch (operation._operator)
            {
                case "+":
                    _value = operation._operand + value;
                    break;
                case "-":
                    _value = operation._operand - value;
                    break;
                case "*":
                    _value = operation._operand * value;
                    break;
                case "/":
                    if (value == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    _value = operation._operand / value;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
        }

        public Operation plus => new Operation(_value, "+");
        public Operation minus => new Operation(_value, "-");
        public Operation times => new Operation(_value, "*");
        public Operation divideBy => new Operation(_value, "/");

        public static implicit operator int(Value value)
        {
            return value._value;
        }
    }

    public class Operation
    {
        public int _operand;
        public string _operator;

        public Operation(int operand, string op)
        {
            _operand = operand;
            _operator = op;
        }

        public Value one => new Value(this, 1);
        public Value two => new Value(this, 2);
        public Value three => new Value(this, 3);
        public Value four => new Value(this, 4);
        public Value five => new Value(this, 5);
        public Value six => new Value(this, 6);
        public Value seven => new Value(this, 7);
        public Value eight => new Value(this, 8);
        public Value nine => new Value(this, 9);
        public Value ten => new Value(this, 10);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FluentCalculator calculator = new FluentCalculator();

        // Example usage:
        int result = calculator.ten.divideBy.two;
        Console.WriteLine("Result: " + result); // Should print 5

        result = calculator.one.plus.ten - 10;
        Console.WriteLine("Result: " + result); // Should print 1
    }
}
