using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludomath
{
    public partial class Form1 : Form
    {
        private enum State
        {
            WAITING_FIRST_OPERAND,
            WAITING_OPERATOR,
            WAITING_SECOND_OPERAND,
            WAITING_USER_ANSWER
        }

        private IList<Button> numButtons = new List<Button>();
        private State state = State.WAITING_FIRST_OPERAND;
        private int a;
        private int b;
        private Random random = new Random(Guid.NewGuid().GetHashCode());
        private Animation animation;

        private IList<String> bravoList = new List<String>(new String[]{
            "Bravo Zeinab !",
            "Magnifique !",
            "Je suis fier de toi ! ",
            "Je t'aime !",
            "Je crie de joie !",
            "Tu es un vrai Puma !",
            "Tu as gagné !",
            "Excellente !",
            "Surprenante !"
        });

        private IList<String> waveFileList = new List<String>(new String[]{
            "bravo-zeinab.wav",
            "magnifique.wav",
            "je-suis-fier-de-toi.wav",
            "je-taime.wav",
            "je-crie-de-joie.wav",
            "tu-es-un-vrai-puma.wav",
            "tu-as-gagne.wav",
            "excellente.wav",
            "surprenante.wav"
        });

        private int getResult()
        {
            return a * b;
        }

        public Form1()
        {
            InitializeComponent();
            hideOperationComponents();
        }

        private void hideOperationComponents()
        {
            labelOperande1.Visible = false;
            labelX.Visible = false;
            labelOperande2.Visible = false;
            txtResult.Visible = false;
            btnSubmitAnswer.Visible = false;
            labelEqual.Visible = false;
            labelBravo.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = 4;
            int cols = 3;
            int btnWidth = 150;
            int btnHeight = 150;
            int btnHSpace = 35;
            int btnVSpace = 35;
            int HMargin = 20;
            int VMargin = 20;
            for (int i=0; i<rows; ++i)
            {
                for (int j=0; j<cols; ++j)
                {
                    int num = (j + i * cols) + 1;
                    if (num <= 9 || num == 11)
                    {
                        if (num == 11)
                        {
                            num = 0;
                        }
                        Button btn = new Button();
                        btn.Parent = gbNum;
                        btn.Text = num.ToString();
                        btn.Location = new Point(HMargin + j * (btnHSpace + btnWidth), VMargin + i * (btnVSpace + btnHeight));
                        btn.Width = btnWidth;
                        btn.Height = btnHeight;
                        btn.Font = new Font(FontFamily.GenericSansSerif, 32);
                        btn.BackColor = Color.AliceBlue;
                        btn.Click += Btn_Click;
                        numButtons.Add(btn);
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
            {
                return;
            }

            try
            {
                int num = int.Parse(btn.Text);
                Label label = null;
                switch(state)
                {
                    case State.WAITING_FIRST_OPERAND:
                        state = State.WAITING_OPERATOR;
                        label = labelOperande1;
                        a = num;
                        hideOperationComponents();
                        break;
                    case State.WAITING_SECOND_OPERAND:
                        state = State.WAITING_USER_ANSWER;
                        label = labelOperande2;
                        b = num;
                        labelEqual.Visible = true;
                        txtResult.Visible = true;
                        txtResult.Text = "";
                        txtResult.Focus();
                        btnSubmitAnswer.Visible = true;
                        break;
                    case State.WAITING_OPERATOR:
                        MessageBox.Show("Appuie sur X");
                        break;
                    default:
                        MessageBox.Show("Il faut écire le résultat");
                        break;
                }
                if (label != null)
                {
                    label.Text = btn.Text;
                    label.Visible = true;
                }

            }
            catch(FormatException exc)
            {
                MessageBox.Show("Un nombre est attendu!");
            }
            catch(OverflowException exc)
            {
                MessageBox.Show("Dépassemnt dans l'opération!");
            }
        }

        private void PlayAnimation(bool isGoodAnswer)
        {
            String msg = "";
            Color msgColor;
            String waveFile;
            if (isGoodAnswer)
            {
                int index = random.Next(bravoList.Count);
                msg = bravoList[index];
                waveFile = waveFileList[index];
                msgColor = Color.Green;
            }
            else
            {
                msg = "Essaie encore!";
                waveFile = "essaie-encore.wav";
                msgColor = Color.Red;
            }

            labelBravo.Text = msg;
            labelBravo.ForeColor = msgColor;
            animation = new Animation(250, 8, labelBravo);
            animation.Start();
            SoundPlayer soundPlayer = new SoundPlayer(waveFile);
            soundPlayer.Play();
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (state == State.WAITING_USER_ANSWER)
            {
                bool isGoodAnswer = false;
                if (txtResult.Text.Trim() == getResult().ToString())
                {
                    isGoodAnswer = true;
                    state = State.WAITING_FIRST_OPERAND;
                }
                labelBravo.Visible = true;
                PlayAnimation(isGoodAnswer);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == State.WAITING_OPERATOR)
            {
                state = State.WAITING_SECOND_OPERAND;
                labelX.Visible = true;
            }
        }
    }
}
