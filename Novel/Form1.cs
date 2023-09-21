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

            pos = bottomPanel.Parent.PointToScreen(bottomPanel.Location);
            pos = backPictureBox.PointToClient(pos);
            bottomPanel.Parent = backPictureBox;
            bottomPanel.Location = pos;
            bottomPanel.BackColor = Color.Transparent;

            pos = characterTextLabel.Parent.PointToScreen(characterTextLabel.Location);
            pos = backgroudTextPicBox.PointToClient(pos);
            characterTextLabel.Parent = backgroudTextPicBox;
            characterTextLabel.Location = pos;
            characterTextLabel.BackColor = Color.Transparent;

            pos = characterImagePicBox.Parent.PointToScreen(characterImagePicBox.Location);
            pos = backgroudTextPicBox.PointToClient(pos);
            characterImagePicBox.Parent = backgroudTextPicBox;
            characterImagePicBox.Location = pos;
            characterImagePicBox.BackColor = Color.Transparent;

            //pos = pictureBox1.Parent.PointToScreen(pictureBox1.Location);
            //pos = backPictureBox.PointToClient(pos);
            //pictureBox1.Parent = backPictureBox;
            //pictureBox1.Location = pos;
            //pictureBox1.BackColor = Color.Transparent;
        }

        private async void startLabel_Click(object sender, EventArgs e)
        {
            backPictureBox.Image = Properties.Resources.Scene_2_Normal;
            startLabel.Visible = false;

            bottomPanel.Visible = true;
            characterImagePicBox.Image = Properties.Resources.Ayla_icon_Round;
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