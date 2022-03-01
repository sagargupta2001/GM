using Grams.CodeAnalysis.Symbols;

namespace Grams.Code_Analysis
{
    public sealed class VariableSymbol
    {
        internal VariableSymbol(string name, bool isReadOnly, TypeSymbol type)
        {
            Name = name;
            IsReadOnly = isReadOnly;
            Type = type;
        }

        public string Name { get; }
        public bool IsReadOnly { get; }
        public TypeSymbol Type { get; }

        public override string ToString() => Name;
    }
}
