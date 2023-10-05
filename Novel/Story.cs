using Novel.Models;

namespace Novel
{
    public partial class Form1
    {
        int story = 0;

        Character? character;
        Character crono = new Character("Crono")
        {
            Replies = Properties.Resources.CronoReply.Split('\n'),
        };

        CancellationTokenSource cts;

        private async Task StoryStep()
        {
            if (story != 2 || character is not null)
                cts?.Cancel();

            if (story == 0 ||
                story == 5 ||
                story == 7 ||
                story == 9)
            {
                story++;
                cts = new CancellationTokenSource();
                await PrintCronoRepy();
            }
            else if (story == 1)
            {
                story++;
                SwitchCharacterPointers(true);
                characterPanel.Image = null;
                cts = new CancellationTokenSource();
                await PrintAsync("Choose character", cts.Token);
            }
            else if (story == 2 && character is not null)
            {
                story++;
                SwitchCharacterPointers(false);
                characterPanel.Image = character.Icon;
                cts = new CancellationTokenSource();
                await PrintCharacterReply();
            }
            else if (story == 3)
            {
                story++;
                backPictureBox.Image = Properties.Resources.Scene_2_Normal;
                SetSideCharacters();
                characterPanel.Image = crono.Icon;
                cts = new CancellationTokenSource();
                await PrintCronoRepy();
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
                character = null;
                SetStartScreen();
            }
        }

        private async Task PrintCharacterReply()
        {
            characterPanel.Image = character?.Icon;
            if (story == 3)
            {
                await PrintAsync(character?.Replies?[0], cts.Token);
            }
            else if (story == 5)
            {
                await PrintAsync(character?.Replies?[1], cts.Token);
            }
            else if (story == 7)
            {
                await PrintAsync(character?.Replies?[2], cts.Token);
            }
            else if (story == 9)
            {
                await PrintAsync(character?.Replies?[3], cts.Token);
            }
            else if (story == 11)
            {
                await PrintAsync(character?.Replies?[4], cts.Token);
            }
        }

        private async Task PrintCronoRepy()
        {
            characterPanel.Image = crono.Icon;
            if (story == 1)
            {
                await PrintAsync(crono.Replies?[0], cts.Token);
            }
            else if (story == 4)
            {
                await PrintAsync(crono.Replies?[1], cts.Token);

            }
            else if (story == 6)
            {
                await PrintAsync(crono.Replies?[2], cts.Token);
            }
            else if (story == 8)
            {
                await PrintAsync(crono.Replies?[3], cts.Token);
            }
            else if (story == 10)
            {
                await PrintAsync(crono.Replies?[4], cts.Token);
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
            frogPointer.Visible = boolean;
            roboPointer.Visible = boolean;
            marlePointer.Visible = boolean;
            magusPointer.Visible = boolean;
            aylaPointer.Visible = boolean;
            luccaPointer.Visible = boolean;
        }
    }
}
