using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grams.Code_Analysis.Binding;

namespace Grams.CodeAnalysis.Binding
{
    internal sealed class BoundGotoStatement : BoundStatement
    {
        public BoundGotoStatement(LabelSymbol label)
        {
            Label = label;
        }

        public override BoundNodeKind Kind => BoundNodeKind.GotoStatement;
        public LabelSymbol Label { get; }
    }
}
