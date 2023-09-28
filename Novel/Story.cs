namespace Novel
{
    public partial class Form1
    {
        int story = 0;
        string? character;

        bool animating = false;

        string[] cronoReply = Properties.Resources.CronoReply.Split('\n');
        string[]? characterReply;
        string[]? cronoCharacterReply;

        private async Task StoryStep()
        {
            if (animating)
                return;

            if (story == 0 ||
                story == 5 ||
                story == 7 ||
                story == 9)
            {
                await PrintCronoReply();
                story++;
            }
            else if (story == 1)
            {
                bool on = true;
                frogPointer.Visible = on;
                roboPointer.Visible = on;
                marlePointer.Visible = on;
                magusPointer.Visible = on;
                aylaPointer.Visible = on;
                luccaPointer.Visible = on;
                characterIconPicBox.Image = null;
                animating = true;
                await Print("Choose character", characterTextLabel);
                animating = false;
                story++;
            }
            else if (story == 2)
            {
                bool off = false;
                frogPointer.Visible = off;
                roboPointer.Visible = off;
                marlePointer.Visible = off;
                magusPointer.Visible = off;
                aylaPointer.Visible = off;
                luccaPointer.Visible = off;
                SetCharacterImages();
                characterIconPicBox.Image = characterIcon;
                await PrintCharacterReply();
                story++;
            }
            else if (story == 3)
            {
                backPictureBox.Image = Properties.Resources.Scene_2_Normal;
                SetSideCharacters();
                characterIconPicBox.Image = chronoIcon;
                await PrintCronoReply();
                story++;
            }
            else if (story == 4 ||
                     story == 6 ||
                     story == 8 ||
                     story == 10)
            {
                await PrintCharacterReply();
                story++;
            }
            else if (story == 11)
            {
                story = 0;
                SetStartScreen();
            }
        }

        private async Task PrintCharacterReply()
        {
            characterIconPicBox.Image = characterIcon;
            animating = true;
            if (story == 2)
            {
                await Print(characterReply?[0], characterTextLabel);
            }
            else if (story == 4)
            {
                await Print(characterReply?[1], characterTextLabel);
            }
            else if (story == 6)
            {
                await Print(characterReply?[2], characterTextLabel);
            }
            else if (story == 8)
            {
                await Print(characterReply?[3], characterTextLabel);
            }
            else if (story == 10)
            {
                await Print(characterReply?[4], characterTextLabel);
            }
            animating = false;
        }

        private async Task PrintCronoReply()
        {
            characterIconPicBox.Image = chronoIcon;
            animating = true;
            if (story == 0)
            {
                await Print(cronoReply[0], characterTextLabel);
            }
            else if (story == 3)
            {
                await Print(cronoCharacterReply?[0], characterTextLabel);

            }
            else if (story == 5)
            {
                await Print(cronoCharacterReply?[1], characterTextLabel);
            }
            else if (story == 7)
            {
                await Print(cronoCharacterReply?[2], characterTextLabel);
            }
            else if (story == 9)
            {
                await Print(cronoCharacterReply?[3], characterTextLabel);
            }
            animating = false;
        }

        private async Task Print(string? text, Label output)
        {
            if (output is null || text is null)
                return;

            output.Text = "";
            foreach (var ch in text)
            {
                output.Text += ch;
                await Task.Delay(50);
            }
        }
    }
}
