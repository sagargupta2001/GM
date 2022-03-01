using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grams.Code_Analysis.Binding;

namespace Grams.CodeAnalysis.Binding
{
    internal sealed class BoundTryCatchStatement : BoundStatement
    {

        public BoundTryCatchStatement(BoundStatement tryBody, BoundStatement catchBody)
        {
            TryBody = tryBody;
            CatchBody = catchBody;
        }

        public override BoundNodeKind Kind => BoundNodeKind.TryCatchStatement;
        public BoundStatement TryBody { get; }
        public BoundStatement CatchBody { get; }
    }
}
