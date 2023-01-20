using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multable
{
    class GridTextBox : GridWidget<TextBox>
    {
        public GridTextBox(TextBox txt, int i, int j) :
            base(txt, i, j)
        {

        }

        public TextBox TextBoxControl
        {
            get
            {
                return GridControl as TextBox;
            }
        }
    }
}
