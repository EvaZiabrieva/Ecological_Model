using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsEcologicalModel
{
    public struct CellData
    {
        public int Hash { get; }
        public char Symbol { get; }
        public CellData(int hash, char symbol)
        {
            Hash = hash;
            Symbol = symbol;
        }
    }
}
