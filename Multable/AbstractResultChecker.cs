using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multable
{
    abstract class AbstractResultChecker
    {
        private bool lastCheck;
        public abstract int getResult(int a, int b);
        public bool check(int a, int b, int answer)
        {
            lastCheck = getResult(a, b) == answer;
            return lastCheck;
        }

        public bool LastCheck
        {
            get { return lastCheck; }
        }
    }
}
