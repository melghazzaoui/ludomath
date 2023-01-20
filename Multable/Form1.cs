using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multable
{
    public partial class MultableMainForm : Form
    {
        private int btnWidth = 90;
        private int btnHeight = 90;
        private int btnHSpace = 0;
        private int btnVSpace = 0;
        int HMargin = 20;
        int VMargin = 20;
        int rows = 9;
        int cols = 9;
        Color initialBackColor;
        Color initialTextBackColor;
        Color initialLabelBackColor;

        private GridTextBox[,] gridWidgets = null;
        private IList<Label> horizontalLabels = new List<Label>();
        private IList<Label> verticalLabels = new List<Label>();
        private IList<Point> coordinates = new List<Point>();
        private IArithmeticOperation operation = new Addition();
        private GridTextBox current = null;

        private Image[] iconHappyList = new Image[] {   Image.FromFile(@"C:\Users\Makram.Elghazzaoui\Desktop\smileys\icon-happy-1.png"),
                                                        Image.FromFile(@"C:\Users\Makram.Elghazzaoui\Desktop\smileys\icon-happy-2.png"),
                                                        Image.FromFile(@"C:\Users\Makram.Elghazzaoui\Desktop\smileys\zeinab-happy.png"),
                                                        Image.FromFile(@"C:\Users\Makram.Elghazzaoui\Desktop\smileys\zeinab-happy-1.png")};

        private Image[] iconSadList = new Image[] {   Image.FromFile(@"C:\Users\Makram.Elghazzaoui\Desktop\smileys\icon-sad-1.png"),
                                                        Image.FromFile(@"C:\Users\Makram.Elghazzaoui\Desktop\smileys\icon-sad-2.png")};

        private Timer timer = new Timer();

        private Image getRandomImageFromArray(Image[] imgArray)
        {
            int i = random.Next(imgArray.Length);
            return imgArray[i];
        }

        private Image getHappyIcon()
        {
            return getRandomImageFromArray(iconHappyList);
        }

        private Image getSadIcon()
        {
            return getRandomImageFromArray(iconSadList);
        }

        private GridTextBox getGridWidgetFromTextBox(TextBox txt)
        {
            return txt.Parent as GridTextBox;
        }

        private void setGridBackColor(Color gridBackColor, Color labelBackColor)
        {
            for(int i=0; i<rows; ++i)
            {
                for(int j=0; j<cols; ++j)
                {
                    gridWidgets[i, j].BackColor = gridBackColor;
                }
                horizontalLabels[i].BackColor = labelBackColor;
                verticalLabels[i].BackColor = labelBackColor;
            }
        }

        private void resetGridBackColor()
        {
            setGridBackColor(initialBackColor, initialLabelBackColor);
        }

        public MultableMainForm()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
            random = new Random(getMillisecondsFrom1970());
        }

        private TextBox createTextBox()
        {
            TextBox txt = new TextBox();
            txt.Text = "";
            txt.Cursor = Cursors.Hand;
            txt.TextAlign = HorizontalAlignment.Center;
            txt.Width = btnWidth - 20;
            txt.Height = btnHeight - 20;
            txt.Location = new Point(10, 10);
            txt.Click += Btn_Click;
            txt.MouseMove += Txt_MouseMove1;
            txt.GotFocus += Txt_GotFocus;
            txt.KeyPress += Txt_KeyPress;
            initialTextBackColor = txt.BackColor;
            txt.Enabled = false;

            return txt;
        }

        private void handleAnswer(TextBox txt)
        {
            GridTextBox gw = txt.Parent as GridTextBox;
            if (gw != null)
            {
                AbstractResultChecker checker = operation as AbstractResultChecker;
                int a = gw.Row + 1;
                int b = gw.Column + 1;
                int answer = int.Parse(txt.Text);
                checker.check(a, b, answer);
                txt.BackColor = checker.LastCheck ? Color.LightGreen : Color.OrangeRed;
                txt.Enabled = false;
                if (!checker.LastCheck)
                {
                    coordinates.Add(new Point(gw.Row, gw.Column));
                    createPictureBox(getSadIcon(), gw);
                }
                else
                {
                    /*createPictureBox(getHappyIcon(), gw);
                    txt.Visible = false;*/
                }

                timer.Start();
            }
        }

        private PictureBox createPictureBox(Image img, Control parent)
        {
            /*PictureBox picture = new PictureBox();
            picture.Width = btnWidth - 20;
            picture.Height = btnHeight - 20;
            picture.Image = img;
            picture.Parent = parent;
            picture.Top = 10;
            picture.Left = 10;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            return picture;*/
            return null;
        }

        private void createTextBoxes(int top, int left)
        {
            gridWidgets = new GridTextBox[rows, cols];
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    TextBox txt = createTextBox();
                    GridTextBox gw = new GridTextBox(txt, i, j);
                    gw.Parent = gbNum;
                    gw.Location = new Point(left + j * (btnHSpace + btnWidth), top + i * (btnVSpace + btnHeight));
                    gw.Width = btnWidth;
                    gw.Height = btnHeight;
                    gw.Font = new Font(FontFamily.GenericSansSerif, 32, FontStyle.Bold);
                    gw.MouseMove += Txt_MouseMove;

                    gridWidgets[i, j] = gw;
                    initialBackColor = gw.BackColor;

                    if (operation.checkOperandes(i+1, j+1))
                    {
                        coordinates.Add(new Point(i, j));
                    }
                    else
                    {
                        txt.BackColor = Color.LightGreen;
                        //txt.Visible = false;
                        createPictureBox(getHappyIcon(), gw);
                    }
                }
            }
        }

        private bool isCharNumeric(char c)
        {
            return '0' <= c && c <= '9'; 
        }

        private int getMillisecondsFrom1970()
        {
            DateTime now = DateTime.Now;
            int milli = 0;
            int hour = 3600 * 1000;
            int day = 24 * hour;
            int month = 30 * day;
            int years = (now.Year - 1970)*365*day;
            int months = now.Month * month;
            int days = now.Day * day;
            int hours = now.Hour * hour;
            int minutes = now.Minute * 60 * 1000;
            int seconds = now.Second * 1000;
            milli = years + months + days + hours + minutes + seconds + now.Millisecond;
            return milli;
        }

        Random random = null;

        private Point getRandomPoint()
        {
            if (coordinates.Count > 0)
            {
                int i = random.Next(coordinates.Count);
                Point pt = coordinates[i];
                coordinates.Remove(pt);
                return pt;
            }
            return new Point(-1, -1);
        }

        private void highlightNextRandomPoint()
        {
            if (current != null)
            {
                AbstractResultChecker arc = operation as AbstractResultChecker;
                if (arc != null && arc.LastCheck)
                {
                    current.GridControl.Text = "";
                }
            }
            Point pt = getRandomPoint();
            if (pt.X >= 0 && pt.Y >= 0)
            {
                GridTextBox gridTxt = gridWidgets[pt.X, pt.Y];
                highlightGridItems(gridTxt);
                current = gridTxt;
            }
            else
            {
                resetGridBackColor();
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (((int)e.KeyChar) == ((int)Keys.Enter) && txt.Text.Length>0)
            {
                handleAnswer(txt);
            }
            else if ((int)e.KeyChar == (int)Keys.Space)
            {
                txt.Text = "";
                txt.BackColor = initialTextBackColor;
                e.KeyChar = '\0';
            }
            else if (!isCharNumeric(e.KeyChar))
            {
                if ((int)e.KeyChar != (int)Keys.Back && (int)e.KeyChar != (int)Keys.Delete)
                {
                    e.KeyChar = '\0';
                }
            }
        }

        private void Txt_MouseMove1(object sender, MouseEventArgs e)
        {
            /*TextBox txt = sender as TextBox;
            if (txt != null)
            {
                highlightGridItems(txt.Parent as GridTextBox);
            }*/
        }        

        private void Txt_MouseMove(object sender, MouseEventArgs e)
        {
            //highlightGridItems(sender as GridTextBox);
        }

        private void highlightGridItems(GridTextBox gw)
        {
            if (gw != null)
            {
                resetGridBackColor();
                if (gw != null)
                {
                    int row = gw.Row;
                    int col = gw.Column;

                    highlightRowAndColumn(row, col);
                }
            }
        }

        private void highlightRowAndColumn(int row, int col)
        {
            for (int j = 0; j <= col; ++j)
            {
                gridWidgets[row, j].BackColor = Color.Turquoise;
            }
            for (int i = 0; i <= row; ++i)
            {
                gridWidgets[i, col].BackColor = Color.Turquoise;
            }

            horizontalLabels[col].BackColor = Color.Turquoise;
            verticalLabels[row].BackColor = Color.Turquoise;
            gridWidgets[row, col].GridControl.Enabled = true;
            gridWidgets[row, col].GridControl.Focus();
            gridWidgets[row, col].GridControl.Text = "";
        }

        private void Txt_GotFocus(object sender, EventArgs e)
        {
            /*TextBox txt = sender as TextBox;
            if (txt != null)
            {
                if (txt.Focused)
                {
                    resetGridBackColor();
                    GridWidget<TextBox> gw = txt.Parent as GridWidget<TextBox>;
                    if (gw != null)
                    {
                        int row = gw.Row;
                        int col = gw.Column;
                        focusedRow = row;
                        focusedCol = col;

                        for (int j = 0; j <= col; ++j)
                        {
                            gridWidgets[row, j].BackColor = Color.Blue;
                        }
                        for (int i = 0; i <= row; ++i)
                        {
                            gridWidgets[i, col].BackColor = Color.Blue;
                        }

                    }
                }
            }*/
        }

        private Label createLabel(string text, Color backColor, Point location, Control parent)
        {
            Label label = new Label();
            label.Parent = parent;
            label.Text = text;
            label.Font = new Font(FontFamily.GenericSansSerif, 32);
            label.Location = location;
            label.Width = btnWidth;
            label.Height = btnHeight;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BackColor = backColor;
            return label;
        }

        private void MultableMainForm_Load(object sender, EventArgs e)
        {
            initialLabelBackColor = Color.Coral;
            Label labelX = createLabel(operation.getSymbol(), Color.Yellow, new Point(HMargin, VMargin), gbNum);
            for (int i=1; i<=rows; ++i)
            {
                Label label = createLabel(i.ToString(), initialLabelBackColor, new Point(HMargin, VMargin + i * (btnVSpace + btnHeight)), gbNum);
                verticalLabels.Add(label);
            }

            for (int j = 1; j <= cols; ++j)
            {
                Label label = createLabel(j.ToString(), initialLabelBackColor, new Point(HMargin + j * (btnHSpace + btnWidth), VMargin), gbNum);
                horizontalLabels.Add(label);
            }

            createTextBoxes(HMargin + btnWidth, VMargin + btnHeight);

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            highlightNextRandomPoint();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                GridTextBox gw = txt.Parent as GridTextBox;
                if (gw != null)
                {
                    int row = gw.Row;
                    int col = gw.Column;
                }
            }
        }

        private void MultableMainForm_Enter(object sender, EventArgs e)
        {
            
        }

        private void MultableMainForm_Leave(object sender, EventArgs e)
        {
            
        }

        private void gbNum_Enter(object sender, EventArgs e)
        {
            //highlightNextRandomPoint();
        }
    }
}
