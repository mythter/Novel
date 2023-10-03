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
                characterPanel.Image = null;
                cts = new CancellationTokenSource();
                await PrintAsync("Choose character", cts.Token);
            }
            else if (story == 2 && !string.IsNullOrEmpty(character))
            {
                story++;
                SwitchCharacterPointers(false);
                SetCharacterImages();
                characterPanel.Image = characterIcon;
                cts = new CancellationTokenSource();
                await PrintCharacterReply();
            }
            else if (story == 3)
            {
                story++;
                backPictureBox.Image = Properties.Resources.Scene_2_Normal;
                SetSideCharacters();
                characterPanel.Image = chronoIcon;
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
            characterPanel.Image = characterIcon;
            if (story == 3)
            {
                await PrintAsync(characterReply?[0], cts.Token);
            }
            else if (story == 5)
            {
                await PrintAsync(characterReply?[1], cts.Token);
            }
            else if (story == 7)
            {
                await PrintAsync(characterReply?[2], cts.Token);
            }
            else if (story == 9)
            {
                await PrintAsync(characterReply?[3], cts.Token);
            }
            else if (story == 11)
            {
                await PrintAsync(characterReply?[4], cts.Token);
            }
        }

        private async Task PrintCronoReply()
        {
            characterPanel.Image = chronoIcon;
            if (story == 1)
            {
                await PrintAsync(cronoReply[0], cts.Token);
            }
            else if (story == 4)
            {
                await PrintAsync(cronoCharacterReply?[0], cts.Token);

            }
            else if (story == 6)
            {
                await PrintAsync(cronoCharacterReply?[1], cts.Token);
            }
            else if (story == 8)
            {
                await PrintAsync(cronoCharacterReply?[2], cts.Token);
            }
            else if (story == 10)
            {
                await PrintAsync(cronoCharacterReply?[3], cts.Token);
            }
        }

        private async Task PrintAsync(string? text, CancellationToken token)
        {
            if (text is null)
                return;

            characterPanel.Reply = "";
            await Task.Delay(50, token).ContinueWith(tsk => { });
            foreach (var ch in text)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                characterPanel.Reply += ch;
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
