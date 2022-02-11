using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grams.Code_Analysis.Binding;

namespace Grams.CodeAnalysis.Binding
{
    internal sealed class BoundConditionalGotoStatement : BoundStatement
    {
        public BoundConditionalGotoStatement(LabelSymbol label, BoundExpression condition, bool jumpIfFalse = false)
        {
            Label = label;
            Condition = condition;
            JumpIfFalse = jumpIfFalse;
        }

        public override BoundNodeKind Kind => BoundNodeKind.ConditionalGotoStatement;
        public LabelSymbol Label { get; }
        public BoundExpression Condition { get; }
        public bool JumpIfFalse { get; }
    }
}
