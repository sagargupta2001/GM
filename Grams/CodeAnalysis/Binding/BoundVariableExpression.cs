﻿using Grams.CodeAnalysis.Symbols;

namespace Grams.Code_Analysis.Binding
{
    internal sealed class BoundVariableExpression : BoundExpression
    {
        public BoundVariableExpression(VariableSymbol variable)
        {
            Variable = variable;
        }

        public override BoundNodeKind Kind => BoundNodeKind.VariableExpression;
        public override TypeSymbol Type => Variable.Type;
        public VariableSymbol Variable { get; }
    }
}
