﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grams.Code_Analysis.Binding;
using Grams.CodeAnalysis.Symbols;

namespace Grams.CodeAnalysis.Binding
{
    internal sealed class BoundCallExpression : BoundExpression
    {
        public BoundCallExpression(FunctionSymbol function, ImmutableArray<BoundExpression> arguments)
        {
            Function = function;
            Arguments = arguments;
        }

        public override BoundNodeKind Kind => BoundNodeKind.CallExpression;
        public override TypeSymbol Type => Function.Type;
        public FunctionSymbol Function { get; }
        public ImmutableArray<BoundExpression> Arguments { get; }
    }
}
