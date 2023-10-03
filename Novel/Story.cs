namespace Novel
{
    public partial class Form1
    {
        int story = 0;
        string? character;

        string[] cronoReply = Properties.Resources.CronoReply.Split('\n');
        string[]? characterReply;
        string[]? cronoCharacterReply;

        CancellationTokenSource cts;

        private async Task StoryStep()
        {
            if (story != 2)
                cts?.Cancel();

            if (story == 0 ||
                story == 5 ||
                story == 7 ||
                story == 9)
            {
                story++;
                cts = new CancellationTokenSource();
                await PrintCronoReply();
            }
            else if (story == 1)
            {
                story++;
                SwitchCharacterPointers(true);
                characterIconPicBox.Image = null;
                cts = new CancellationTokenSource();
                await PrintAsync("Choose character", characterTextLabel, cts.Token);
            }
            else if (story == 2 && !string.IsNullOrEmpty(character))
            {
                story++;
                SwitchCharacterPointers(false);
                SetCharacterImages();
                characterIconPicBox.Image = characterIcon;
                cts = new CancellationTokenSource();
                await PrintCharacterReply();
            }
            else if (story == 3)
            {
                story++;
                backPictureBox.Image = Properties.Resources.Scene_2_Normal;
                SetSideCharacters();
                characterIconPicBox.Image = chronoIcon;
                cts = new CancellationTokenSource();
                await PrintCronoReply();
            }
            else if (story == 4 ||
                     story == 6 ||
                     story == 8 ||
                     story == 10)
            {
                story++;
                cts = new CancellationTokenSource();
                await PrintCharacterReply();
            }
            else if (story == 11)
            {
                story = 0;
                character = string.Empty;
                SetStartScreen();
            }
        }

        private async Task PrintCharacterReply()
        {
            characterIconPicBox.Image = characterIcon;
            if (story == 3)
            {
                await PrintAsync(characterReply?[0], characterTextLabel, cts.Token);
            }
            else if (story == 5)
            {
                await PrintAsync(characterReply?[1], characterTextLabel, cts.Token);
            }
            else if (story == 7)
            {
                await PrintAsync(characterReply?[2], characterTextLabel, cts.Token);
            }
            else if (story == 9)
            {
                await PrintAsync(characterReply?[3], characterTextLabel, cts.Token);
            }
            else if (story == 11)
            {
                await PrintAsync(characterReply?[4], characterTextLabel, cts.Token);
            }
        }

        private async Task PrintCronoReply()
        {
            characterIconPicBox.Image = chronoIcon;
            if (story == 1)
            {
                await PrintAsync(cronoReply[0], characterTextLabel, cts.Token);
            }
            else if (story == 4)
            {
                await PrintAsync(cronoCharacterReply?[0], characterTextLabel, cts.Token);

            }
            else if (story == 6)
            {
                await PrintAsync(cronoCharacterReply?[1], characterTextLabel, cts.Token);
            }
            else if (story == 8)
            {
                await PrintAsync(cronoCharacterReply?[2], characterTextLabel, cts.Token);
            }
            else if (story == 10)
            {
                await PrintAsync(cronoCharacterReply?[3], characterTextLabel, cts.Token);
            }
        }

        private async Task PrintAsync(string? text, Label output, CancellationToken token)
        {
            if (output is null || text is null)
                return;

            output.Text = "";
            await Task.Delay(50, token).ContinueWith(tsk => { });
            foreach (var ch in text)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                output.Text += ch;
                await Task.Delay(50, token).ContinueWith(tsk => { });
            }
        }

        private void SwitchCharacterPointers(bool boolean)
        {
            frogPointer.Visible  = boolean;
            roboPointer.Visible  = boolean;
            marlePointer.Visible = boolean;
            magusPointer.Visible = boolean;
            aylaPointer.Visible  = boolean;
            luccaPointer.Visible = boolean;
        }
    }
}
