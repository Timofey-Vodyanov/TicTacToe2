namespace TicTacToe2
{
    public partial class Form1 : Form
    {
        int switchMoves = 0;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
