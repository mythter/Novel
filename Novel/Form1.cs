namespace Novel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var pos = startLabel.Parent.PointToScreen(startLabel.Location);
            pos = pictureBox1.PointToClient(pos);
            startLabel.Parent = pictureBox1;
            startLabel.Location = pos;
            startLabel.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}