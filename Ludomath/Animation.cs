using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ludomath
{
    class Animation
    {
        private Timer timer;
        private uint count;
        private uint i = 0;
        private Label label;
        private bool visible;
        private bool isStarted = false;
        public Animation(int interval, uint count, Label label)
        {
            this.label = label;
            visible = label.Visible;
            this.count = count;
            timer = new Timer();
            timer.Interval = interval;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (i++ < count)
            {
                label.Visible = !label.Visible;
            }
            else
            {
                label.Visible = visible;
                isStarted = false;
                timer.Stop();
            }
        }

        public void Start()
        {
            if (!isStarted)
            {
                isStarted = true;
                timer.Start();
            }
        }
    }
}
