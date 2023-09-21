namespace Novel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var pos = startLabel.Parent.PointToScreen(startLabel.Location);
            pos = backPictureBox.PointToClient(pos);
            startLabel.Parent = backPictureBox;
            startLabel.Location = pos;
            startLabel.BackColor = Color.Transparent;
        }

        private async void startLabel_Click(object sender, EventArgs e)
        {
            backPictureBox.Image = Properties.Resources.Scene_1;
            startLabel.Visible = false;

            await Print("dfsfgsdfsdf k hkjl h ijh klj h jhkjhlkj h l\n ko jkjlhj j hkjhkjh lkh kjl", characterTextLabel);
        }

        private async Task Print(string text, Label output)
        {
            if (output is null)
                return;

            foreach (var ch in text)
            {
                output.Text += ch;
                await Task.Delay(70);
            }
        }
    }
}