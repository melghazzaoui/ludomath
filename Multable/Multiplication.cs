using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multable
{
    class Multiplication : AbstractResultChecker, IArithmeticOperation
    {
        public override int getResult(int a, int b)
        {
            return a * b;
        }

        public string getSymbol()
        {
            return "X";
        }

        public bool checkOperandes(int a, int b)
        {
            return true;
        }
    }
}
