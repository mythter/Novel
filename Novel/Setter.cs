namespace Novel
{
    public partial class Form1
    {
        private void SetSideCharacters()
        {
            Random rand = new Random();
            rightPictureBox.Visible = true;
            leftPictureBox.Visible = true;
            int choice = rand.Next(2);

            leftPictureBox.Image = choice == 0 ? Properties.Resources.Crono_left : character?.LeftImage;
            rightPictureBox.Image = choice == 0 ? character?.RightImage : Properties.Resources.Crono_right;
        }

        private void SetTransperency()
        {
            Point pos;

            if (startLabel?.Parent is not null)
            {
                pos = startLabel.Parent.PointToScreen(startLabel.Location);
                pos = backPictureBox.PointToClient(pos);
                startLabel.Parent = backPictureBox;
                startLabel.Location = pos;
                startLabel.BackColor = Color.Transparent;
            }

            if (characterPanel?.Parent is not null)
            {
                pos = characterPanel.Parent.PointToScreen(characterPanel.Location);
                pos = backPictureBox.PointToClient(pos);
                characterPanel.Parent = backPictureBox;
                characterPanel.Location = pos;
                characterPanel.BackColor = Color.Transparent;
            }

            if (leftPictureBox?.Parent is not null)
            {
                pos = leftPictureBox.Parent.PointToScreen(leftPictureBox.Location);
                pos = backPictureBox.PointToClient(pos);
                leftPictureBox.Parent = backPictureBox;
                leftPictureBox.Location = pos;
                leftPictureBox.BackColor = Color.Transparent;
            }

            if (rightPictureBox?.Parent is not null)
            {
                pos = rightPictureBox.Parent.PointToScreen(rightPictureBox.Location);
                pos = backPictureBox.PointToClient(pos);
                rightPictureBox.Parent = backPictureBox;
                rightPictureBox.Location = pos;
                rightPictureBox.BackColor = Color.Transparent;
            }

            if (frogPointer?.Parent is not null)
            {
                pos = frogPointer.Parent.PointToScreen(frogPointer.Location);
                pos = backPictureBox.PointToClient(pos);
                frogPointer.Parent = backPictureBox;
                frogPointer.Location = pos;
                frogPointer.BackColor = Color.Transparent;
            }

            if (aylaPointer?.Parent is not null)
            {
                pos = aylaPointer.Parent.PointToScreen(aylaPointer.Location);
                pos = backPictureBox.PointToClient(pos);
                aylaPointer.Parent = backPictureBox;
                aylaPointer.Location = pos;
                aylaPointer.BackColor = Color.Transparent;
            }

            if (magusPointer?.Parent is not null)
            {
                pos = magusPointer.Parent.PointToScreen(magusPointer.Location);
                pos = backPictureBox.PointToClient(pos);
                magusPointer.Parent = backPictureBox;
                magusPointer.Location = pos;
                magusPointer.BackColor = Color.Transparent;
            }

            if (marlePointer?.Parent is not null)
            {
                pos = marlePointer.Parent.PointToScreen(marlePointer.Location);
                pos = backPictureBox.PointToClient(pos);
                marlePointer.Parent = backPictureBox;
                marlePointer.Location = pos;
                marlePointer.BackColor = Color.Transparent;
            }

            if (luccaPointer?.Parent is not null)
            {
                pos = luccaPointer.Parent.PointToScreen(luccaPointer.Location);
                pos = backPictureBox.PointToClient(pos);
                luccaPointer.Parent = backPictureBox;
                luccaPointer.Location = pos;
                luccaPointer.BackColor = Color.Transparent;
            }

            if (roboPointer?.Parent is not null)
            {
                pos = roboPointer.Parent.PointToScreen(roboPointer.Location);
                pos = backPictureBox.PointToClient(pos);
                roboPointer.Parent = backPictureBox;
                roboPointer.Location = pos;
                roboPointer.BackColor = Color.Transparent;
            }
        }

        private void SetStartScreen()
        {
            rightPictureBox.Visible = false;
            leftPictureBox.Visible = false;
            characterPanel.Visible = false;
            backPictureBox.Image = Properties.Resources.Title_Screen_Normal;
            startLabel.Visible = true;
        }
    }
}
