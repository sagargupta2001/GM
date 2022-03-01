using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grams.CodeAnalysis.Symbols
{
    public enum SymbolKind
    {
        Function,
        GlobalVariable,
        LocalVariable,
        Parameter,
        Type,
    }
}
