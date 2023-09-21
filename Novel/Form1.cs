namespace Novel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetTransperency();
        }

        private async void startLabel_Click(object sender, EventArgs e)
        {
            backPictureBox.Image = Properties.Resources.Scene_2_Normal;
            startLabel.Visible = false;

            bottomPanel.Visible = true;
            characterImagePicBox.Image = Properties.Resources.Ayla_icon_Round;

            rightPictureBox.Visible = true;
            rightPictureBox.Image = Properties.Resources.Crono;

            leftPictureBox.Visible = true;
            leftPictureBox.Image = Properties.Resources.Ayla;

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

        private void SetTransperency()
        {
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

            pos = leftPictureBox.Parent.PointToScreen(leftPictureBox.Location);
            pos = backPictureBox.PointToClient(pos);
            leftPictureBox.Parent = backPictureBox;
            leftPictureBox.Location = pos;
            leftPictureBox.BackColor = Color.Transparent;

            pos = rightPictureBox.Parent.PointToScreen(rightPictureBox.Location);
            pos = backPictureBox.PointToClient(pos);
            rightPictureBox.Parent = backPictureBox;
            rightPictureBox.Location = pos;
            rightPictureBox.BackColor = Color.Transparent;
        }
    }
}