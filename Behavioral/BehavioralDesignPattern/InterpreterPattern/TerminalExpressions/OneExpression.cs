using InterpreterPattern.AbstractExpressions;

namespace InterpreterPattern.TerminalExpressions
{
    public class OneExpression : Expression
    {
        protected override string One() => "I";
        protected override string Four() => "IV";
        protected override string Five() => "V";
        protected override string Nine() => "IX";
        protected override int Multiplier() => 1;
    }
}