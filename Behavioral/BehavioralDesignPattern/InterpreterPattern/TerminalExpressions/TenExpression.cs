using InterpreterPattern.AbstractExpressions;

namespace InterpreterPattern.TerminalExpressions
{
    public class TenExpression : Expression
    {
        protected override string One() => "X";
        protected override string Four() => "XL";
        protected override string Five() => "L";
        protected override string Nine() => "XC";
        protected override int Multiplier() => 10;
    }
}