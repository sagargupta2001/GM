using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grams.CodeAnalysis
{
    internal sealed class LabelSymbol
    {
        internal LabelSymbol(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override string ToString() => Name;
    }
}
