using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    public interface IOceanView
    {
         int GetWidth();
         int GetHeight();
         char GetCellView(int i, int j);
    }
}
