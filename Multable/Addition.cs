using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multable
{
    class Addition : AbstractResultChecker, IArithmeticOperation
    {
        public override int getResult(int a, int b)
        {
            return a + b;
        }

        public string getSymbol()
        {
            return "+";
        }

        public bool checkOperandes(int a, int b)
        {
            return getResult(a, b) > 5 && (a != 1 && b != 1);
        }
    }
}
