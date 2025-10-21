using System.Diagnostics.Metrics;

namespace TicTacToe2
{
    public partial class Form1 : Form
    {
        int switchMoves = 0;
        int numberOfUsedSquares = 0;
        Image[] images = {
            Image.FromFile("..\\..\\..\\Resources\\lol.png"),
            Image.FromFile("..\\..\\..\\Resources\\dota.png"),
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Image != null)
            {
                return;
            }
            if (switchMoves++ % 2 == 0)
            {
                bt.Image = images[0];
                label1.Text = "Ход: Игрок 2 (Dota 2)";
            }
            else
            {
                bt.Image = images[1];
                label1.Text = "Ход: Игрок 1 (LoL)";
            }
            numberOfUsedSquares++;
            Check();
        }

        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X != button10)
                {
                    ((Button)X).Image = null;
                    ((Button)X).BackColor = default(Color);
                }
            }
            numberOfUsedSquares = 0;
            switchMoves = 0;
        }
        private void Check()
        {
            if (button1.Image == images[0] && button2.Image == images[0] && button3.Image == images[0]
               || button4.Image == images[0] && button5.Image == images[0] && button6.Image == images[0]
               || button7.Image == images[0] && button9.Image == images[0] && button8.Image == images[0]
               || button1.Image == images[0] && button4.Image == images[0] && button7.Image == images[0]
               || button2.Image == images[0] && button5.Image == images[0] && button8.Image == images[0]
               || button3.Image == images[0] && button6.Image == images[0] && button9.Image == images[0]
               || button1.Image == images[0] && button5.Image == images[0] && button9.Image == images[0]
               || button3.Image == images[0] && button5.Image == images[0] && button7.Image == images[0])
            {
                MessageBox.Show("Победила League of Legends!");
                resetGame();
            }

            else if (button1.Image == images[1] && button2.Image == images[1] && button3.Image == images[1]
            || button4.Image == images[1] && button5.Image == images[1] && button6.Image == images[1]
            || button7.Image == images[1] && button9.Image == images[1] && button8.Image == images[1]
            || button1.Image == images[1] && button4.Image == images[1] && button7.Image == images[1]
            || button2.Image == images[1] && button5.Image == images[1] && button8.Image == images[1]
            || button3.Image == images[1] && button6.Image == images[1] && button9.Image == images[1]
            || button1.Image == images[1] && button5.Image == images[1] && button9.Image == images[1]
            || button3.Image == images[1] && button5.Image == images[1] && button7.Image == images[1])
            {
                MessageBox.Show("Победила Dota 2!");
                resetGame();
            }
            else
            {
                if (numberOfUsedSquares == 9)
                {
                    MessageBox.Show("НИЧЬЯ!");
                    resetGame();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Ход: Игрок 1 (LoL)";
            resetGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
