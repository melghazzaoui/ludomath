using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multable
{
    interface IArithmeticOperation
    {
        int getResult(int a, int b);
        string getSymbol();
        bool checkOperandes(int a, int b);
    }
}
