namespace Grams.Code_Analysis
{
    public sealed partial class BinaryExpressionSyntax
    {
        public sealed class NameExpressionSyntax : ExpressionSyntax
        {
            public NameExpressionSyntax(SyntaxToken identifierToken)
            {
                IdentifierToken = identifierToken;
            }

            public override SyntaxKind Kind => SyntaxKind.NameExpression;

            public SyntaxToken IdentifierToken { get; }

            public override IEnumerable<SyntaxNode> GetChildren()
            {
                yield return IdentifierToken;
            }
        }
    }
}
