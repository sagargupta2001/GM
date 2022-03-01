using Grams.Code_Analysis.Binding;

namespace Grams.CodeAnalysis.Binding
{
    internal sealed class BoundBeginTryStatement : BoundStatement
    {
        public BoundBeginTryStatement(BoundLabel errorLabel)
        {
            ErrorLabel = errorLabel;
        }

        public override BoundNodeKind Kind => BoundNodeKind.BeginTryStatement;
        public BoundLabel ErrorLabel { get; }
    }
}
