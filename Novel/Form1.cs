using System.Drawing.Text;

namespace Novel
{
    public partial class Form1 : Form
    {
        #region Custom font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font ChronoTypeFontRegular;
        #endregion

        int story = 0;
        string? character;
        Bitmap? characterIcon;
        Bitmap chronoIcon = Properties.Resources.Crono_icon_Round;
        bool animating = false;

        public Form1()
        {
            InitializeComponent();
            SetTransperency();

            #region Custom font
            byte[] fontData = Properties.Resources.ChronoType;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.ChronoType.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.ChronoType.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            ChronoTypeFontRegular = new Font(fonts.Families[0], 14.0F);
            characterTextLabel.Font = ChronoTypeFontRegular;
            ChronoTypeFontRegular = new Font(fonts.Families[0], 40.0F);
            startLabel.Font = ChronoTypeFontRegular;
            #endregion
        }

        private async void startLabel_Click(object sender, EventArgs e)
        {
            backPictureBox.Image = Properties.Resources.Scene_1_Normal;
            startLabel.Visible = false;

            bottomPanel.Visible = true;
            characterIconPicBox.Image = Properties.Resources.Crono_icon_Round;

            await StoryStep();
        }

        private async Task StoryStep()
        {
            if (animating)
                return;

            if (story == 0)
            {
                characterTextLabel.Text = "";
                await PrintCronoReply();
                story++;
            }
            else if (story == 1)
            {
                bool on = true;
                frogPointer.Visible  = on;
                roboPointer.Visible  = on;
                marlePointer.Visible = on;
                magusPointer.Visible = on;
                aylaPointer.Visible  = on;
                luccaPointer.Visible = on;
                characterIconPicBox.Image = null;
                characterTextLabel.Text = "";
                animating = true;
                await Print("Choose character", characterTextLabel);
                animating = false;
                story++;
            }
            else if (story == 2)
            {
                bool off = false;
                frogPointer.Visible  = off;
                roboPointer.Visible  = off;
                marlePointer.Visible = off;
                magusPointer.Visible = off;
                aylaPointer.Visible  = off;
                luccaPointer.Visible = off;
                SetCharacterIcon();
                characterIconPicBox.Image = characterIcon;
                characterTextLabel.Text = "";
                await PrintCharacterReply();
                story++;
            }
            else if (story == 3)
            {
                characterTextLabel.Text = "";
                backPictureBox.Image = Properties.Resources.Scene_2_Normal;
                SetSideCharacters();
                characterIconPicBox.Image = chronoIcon;
                await PrintCronoReply();
                story++;
            }
            else if (story == 4)
            {
                characterTextLabel.Text = "";
                await PrintCharacterReply();
                story++;
            }
            else if (story == 5)
            {
                characterTextLabel.Text = "";
                characterIconPicBox.Image = chronoIcon;
                await PrintCronoReply();
                story++;
            }
            else if (story == 6)
            {
                characterTextLabel.Text = "";
                animating = true;
                await PrintCharacterReply();
                animating = false;
                story++;
            }
            else if (story == 7)
            {
                story = 0;
                SetStartScreen();
            }
        }

        private void SetStartScreen()
        {
            rightPictureBox.Visible = false;
            leftPictureBox.Visible = false;
            bottomPanel.Visible = false;
            backPictureBox.Image = Properties.Resources.Title_Screen_Normal;
            startLabel.Visible = true;
        }

        private void SetSideCharacters()
        {
            Random rand = new Random();
            rightPictureBox.Visible = true;
            leftPictureBox.Visible = true;
            int choice = rand.Next(2);
            if (choice == 0)
                leftPictureBox.Image = Properties.Resources.Crono_left;
            else
                rightPictureBox.Image = Properties.Resources.Crono_right;

            switch (character)
            {
                case "Magus":
                    if (choice == 0)
                        rightPictureBox.Image = Properties.Resources.Magus_right;
                    else
                        leftPictureBox.Image = Properties.Resources.Magus_left;
                    break;
                case "Frog":
                    if (choice == 0)
                        rightPictureBox.Image = Properties.Resources.Frog_right;
                    else
                        leftPictureBox.Image = Properties.Resources.Frog_left;
                    break;
                case "Lucca":
                    if (choice == 0)
                        rightPictureBox.Image = Properties.Resources.Lucca_right;
                    else
                        leftPictureBox.Image = Properties.Resources.Lucca_left;
                    break;
                case "Marle":
                    if (choice == 0)
                        rightPictureBox.Image = Properties.Resources.marle_right;
                    else
                        leftPictureBox.Image = Properties.Resources.marle_left;
                    break;
                case "Robo":
                    if (choice == 0)
                        rightPictureBox.Image = Properties.Resources.Robo_right;
                    else
                        leftPictureBox.Image = Properties.Resources.Robo_left;
                    break;
                case "Ayla":
                    if (choice == 0)
                        rightPictureBox.Image = Properties.Resources.Ayla_right;
                    else
                        leftPictureBox.Image = Properties.Resources.Ayla_left;
                    break;
            }
        }

        private async Task PrintMagusReply()
        {
            if (story == 2)
            {
                await Print($"Magus: Let's go Crono", characterTextLabel);
            }
            else if (story == 4)
            {
                await Print("Magus: I plan to return in my time and see what will happen to Kingdom of Zeal", characterTextLabel);
            }
            else if (story == 6)
            {
                await Print("Magus: Thanks Crono, let's go back", characterTextLabel);
            }
        }

        private async Task PrintFrogReply()
        {
            if (story == 2)
            {
                await Print($"Frog: Let's go Crono", characterTextLabel);
            }
            else if (story == 4)
            {
                await Print("Frog: I will return to my time and serve my kingdom as Cyrus did ", characterTextLabel);
            }
            else if (story == 6)
            {
                await Print("Frog: Thanks Crono, you became an amazing swordsman and let's go back we got what we came for", characterTextLabel);
            }
        }

        private async Task PrintLuccaReply()
        {
            if (story == 2)
            {
                await Print($"Lucca: Let's go Crono", characterTextLabel);
            }
            else if (story == 4)
            {
                await Print("Lucca: When we return to our time, I will keep inventing stuff with my dad to help people", characterTextLabel);
            }
            else if (story == 6)
            {
                await Print("Lucca: Thanks Crono, hope I will get some help from you with them and let's go back, we got what we needed", characterTextLabel);
            }
        }

        private async Task PrintMarleReply()
        {
            if (story == 2)
            {
                await Print($"Marle: Let's go Crono", characterTextLabel);
            }
            else if (story == 4)
            {
                await Print("Marle: I want to talk with my father about our adventure and so much more, I need some time to think about it", characterTextLabel);
            }
            else if (story == 6)
            {
                await Print("Marle: I don't know that you were a moms' boy,  everyone is waiting, so let's go back", characterTextLabel);
            }
        }

        private async Task PrintRoboReply()
        {
            if (story == 2)
            {
                await Print($"Robo: Let's go Crono", characterTextLabel);
            }
            else if (story == 4)
            {
                await Print("Robo: I want to see how future will change after Lavos death", characterTextLabel);
            }
            else if (story == 6)
            {
                await Print("Robo: Thanks Crono, you are saver of time and let's go back", characterTextLabel);
            }
        }

        private async Task PrintAylaReply()
        {
            if (story == 2)
            {
                await Print($"Ayla: Ayla wood go", characterTextLabel);
            }
            else if (story == 4)
            {
                await Print($"Ayla: Ayla go home, Ayla eat, Ayla sleep, Ayla marry Kino, Ayla happy", characterTextLabel);
            }
            else if (story == 6)
            {
                await Print($"Ayla: Ayla thank Crono, Ayla go back", characterTextLabel);
            }
        }

        private async Task PrintCharacterReply()
        {
            Func<Task> printReply = character switch
            {
                "Magus" => PrintMagusReply,
                "Frog" => PrintFrogReply,
                "Lucca" => PrintLuccaReply,
                "Marle" => PrintMarleReply,
                "Robo" => PrintRoboReply,
                "Ayla" => PrintAylaReply,
                _ => throw new ArgumentException("Character is not chosen."),
            };
            characterTextLabel.Text = "";
            characterIconPicBox.Image = characterIcon;
            animating = true;
            await printReply();
            animating = false;
        }

        private async Task PrintCronoReply()
        {
            characterTextLabel.Text = "";
            animating = true;
            if (story == 0)
            {
                await Print("Crono: I'll go gather some wood for a campfire, who wants to come with me?", characterTextLabel);
            }
            else if (story == 3)
            {
                await Print($"Crono: Hey {character}, what you plan to do when we finish with Lavos?", characterTextLabel);

            }
            else if (story == 5)
            {
                switch (character)
                {
                    case "Magus":
                        await Print("Crono: I see, hope it'll be okay without Lavos that screwed up your mother", characterTextLabel);
                        break;
                    case "Frog":
                        await Print("Crono: I am glad that you have forgiven yourself and can live your life without regrets", characterTextLabel);
                        break;
                    case "Lucca":
                        await Print("Crono: That's nice, I'll be looking for it", characterTextLabel);
                        break;
                    case "Marle":
                        await Print("Crono: That's nice, I can't wait to see my mom again too", characterTextLabel);
                        break;
                    case "Robo":
                        await Print("Crono: I believe it will be good", characterTextLabel);
                        break;
                    case "Ayla":
                        await Print("Crono: Haha, That`s great", characterTextLabel);
                        break;
                }
            }
            animating = false;
        }

        private async Task Print(string text, Label output)
        {
            if (output is null)
                return;

            foreach (var ch in text)
            {
                output.Text += ch;
                await Task.Delay(50);
            }
        }

        private async void backPictureBox_Click(object sender, EventArgs e)
        {
            await StoryStep();
        }

        private async void CharacterPointer_Click(object sender, EventArgs e)
        {
            character = (sender as PictureBox)?.Tag?.ToString();
            await StoryStep();
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

            if (bottomPanel?.Parent is not null)
            {
                pos = bottomPanel.Parent.PointToScreen(bottomPanel.Location);
                pos = backPictureBox.PointToClient(pos);
                bottomPanel.Parent = backPictureBox;
                bottomPanel.Location = pos;
                bottomPanel.BackColor = Color.Transparent;
            }

            if (characterTextLabel?.Parent is not null)
            {
                pos = characterTextLabel.Parent.PointToScreen(characterTextLabel.Location);
                pos = backgroudTextPicBox.PointToClient(pos);
                characterTextLabel.Parent = backgroudTextPicBox;
                characterTextLabel.Location = pos;
                characterTextLabel.BackColor = Color.Transparent;
            }

            if (characterIconPicBox?.Parent is not null)
            {
                pos = characterIconPicBox.Parent.PointToScreen(characterIconPicBox.Location);
                pos = backgroudTextPicBox.PointToClient(pos);
                characterIconPicBox.Parent = backgroudTextPicBox;
                characterIconPicBox.Location = pos;
                characterIconPicBox.BackColor = Color.Transparent;
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

        private void SetCharacterIcon()
        {
            switch (character)
            {
                case "Magus":
                    characterIcon = Properties.Resources.Magus_icon_Round;
                    break;
                case "Frog":
                    characterIcon = Properties.Resources.Frog_icon_Round;
                    break;
                case "Lucca":
                    characterIcon = Properties.Resources.Lucca_icon_Round;
                    break;
                case "Marle":
                    characterIcon = Properties.Resources.Marle_icon_Round;
                    break;
                case "Robo":
                    characterIcon = Properties.Resources.Robo_icon_Round;
                    break;
                case "Ayla":
                    characterIcon = Properties.Resources.Ayla_icon_Round;
                    break;
            }
        }
    }
}