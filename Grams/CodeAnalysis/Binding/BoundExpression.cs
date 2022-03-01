using Grams.CodeAnalysis.Symbols;

namespace Grams.Code_Analysis.Binding
{
    internal abstract class BoundExpression : BoundNode
    {
        public abstract TypeSymbol Type { get; }
    }

}
