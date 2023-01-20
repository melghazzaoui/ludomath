using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multable
{
    class GridWidget<T> : Control where T : Control
    {
        private T control;
        private int i;
        private int j;

        public GridWidget(T control, int i, int j)
        {
            this.control = control;
            this.i = i;
            this.j = j;
            this.control.Parent = this;
        }

        public int Row
        {
            get { return i; }
        }

        public int Column
        {
            get
            {
                return j;
            }
        }

        public T GridControl
        {
            get
            {
                return control;
            }
        }
    }
}
