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
        Bitmap? leftcharacterImage;
        Bitmap? rightcharacterImage;
        bool animating = false;

        readonly Bitmap chronoIcon = Properties.Resources.Crono_icon_Round;

        string[] cronoReply = Properties.Resources.CronoReply.Split('\n');
        string[] characterReply;
        string[] cronoCharacterReply;

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
                await Print(characterReply[0], characterTextLabel);
            }
            else if (story == 4)
            {
                await Print(characterReply[1], characterTextLabel);
            }
            else if (story == 6)
            {
                await Print(characterReply[2], characterTextLabel);
            }
            else if (story == 8)
            {
                await Print(characterReply[3], characterTextLabel);
            }
            else if (story == 10)
            {
                await Print(characterReply[4], characterTextLabel);
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
                await Print(cronoCharacterReply[0], characterTextLabel);

            }
            else if (story == 5)
            {
                await Print(cronoCharacterReply[1], characterTextLabel);
            }
            else if (story == 7)
            {
                await Print(cronoCharacterReply[2], characterTextLabel);
            }
            else if (story == 9)
            {
                await Print(cronoCharacterReply[3], characterTextLabel);
            }
            animating = false;
        }

        private async Task Print(string text, Label output)
        {
            if (output is null)
                return;

            output.Text = "";
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

            characterReply = (sender as PictureBox)?.Tag?.ToString() switch
            {
                "Magus" => Properties.Resources.MagusReply.Split('\n'),
                "Frog" => Properties.Resources.FrogReply.Split('\n'),
                "Lucca" => Properties.Resources.LuccaReply.Split('\n'),
                "Marle" => Properties.Resources.MarleReply.Split('\n'),
                "Robo" => Properties.Resources.RoboReply.Split('\n'),
                "Ayla" => Properties.Resources.AylaReply.Split('\n'),
                _ => throw new ArgumentException("Character is not chosen."),
            };
            cronoCharacterReply = (sender as PictureBox)?.Tag?.ToString() switch
            {
                "Magus" => Properties.Resources.CronoMagusReply.Split('\n'),
                "Frog" => Properties.Resources.CronoFrogReply.Split('\n'),
                "Lucca" => Properties.Resources.CronoLuccaReply.Split('\n'),
                "Marle" => Properties.Resources.CronoMarleReply.Split('\n'),
                "Robo" => Properties.Resources.CronoRoboReply.Split('\n'),
                "Ayla" => Properties.Resources.CronoAylaReply.Split('\n'),
                _ => throw new ArgumentException("Character is not chosen."),
            };

            //switch ((sender as PictureBox)?.Tag?.ToString())
            //{
            //    case "Magus":
            //        characterReply = Properties.Resources.MagusReply.Split('\n');
            //        cronoCharacterReply = Properties.Resources.CronoMagusReply.Split('\n');
            //        break;
            //     case "Frog" :
            //        characterReply = Properties.Resources.FrogReply.Split('\n');
            //        cronoCharacterReply = Properties.Resources.CronoFrogReply.Split('\n');
            //        break;
            //     case "Lucca":
            //        characterReply = Properties.Resources.LuccaReply.Split('\n');
            //        cronoCharacterReply =  Properties.Resources.CronoLuccaReply.Split('\n');
            //        break;
            //     case "Marle":
            //        characterReply =  Properties.Resources.MarleReply.Split('\n');
            //        cronoCharacterReply =  Properties.Resources.CronoMarleReply.Split('\n');
            //         break;
            //     case "Robo" :
            //        characterReply =  Properties.Resources.RoboReply.Split('\n');
            //        cronoCharacterReply =  Properties.Resources.CronoRoboReply.Split('\n');
            //         break;
            //     case "Ayla" :
            //        characterReply =  Properties.Resources.AylaReply.Split('\n');
            //        cronoCharacterReply =  Properties.Resources.CronoAylaReply.Split('\n');
            //        break;
            //    default:
            //        throw new ArgumentException("Character is not chosen.");
            //}

            await StoryStep();
        }

        private void SetSideCharacters()
        {
            Random rand = new Random();
            rightPictureBox.Visible = true;
            leftPictureBox.Visible = true;
            int choice = rand.Next(2);

            leftPictureBox.Image = choice == 0 ? Properties.Resources.Crono_left : leftcharacterImage;
            rightPictureBox.Image = choice == 0 ? rightcharacterImage : Properties.Resources.Crono_right;
        }

        private void SetCharacterImages()
        {
            switch (character)
            {
                case "Magus":
                    characterIcon = Properties.Resources.Magus_icon_Round;
                    leftcharacterImage = Properties.Resources.Magus_left;
                    rightcharacterImage = Properties.Resources.Magus_right;
                    break;
                case "Frog":
                    characterIcon = Properties.Resources.Frog_icon_Round;
                    leftcharacterImage = Properties.Resources.Frog_left;
                    rightcharacterImage = Properties.Resources.Frog_right;
                    break;
                case "Lucca":
                    characterIcon = Properties.Resources.Lucca_icon_Round;
                    leftcharacterImage = Properties.Resources.Lucca_left;
                    rightcharacterImage = Properties.Resources.Lucca_right;
                    break;
                case "Marle":
                    characterIcon = Properties.Resources.Marle_icon_Round;
                    leftcharacterImage = Properties.Resources.Marle_left;
                    rightcharacterImage = Properties.Resources.Marle_right;
                    break;
                case "Robo":
                    characterIcon = Properties.Resources.Robo_icon_Round;
                    leftcharacterImage = Properties.Resources.Robo_left;
                    rightcharacterImage = Properties.Resources.Robo_right;
                    break;
                case "Ayla":
                    characterIcon = Properties.Resources.Ayla_icon_Round;
                    leftcharacterImage = Properties.Resources.Ayla_left;
                    rightcharacterImage = Properties.Resources.Ayla_right;
                    break;
            }
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

        private void SetStartScreen()
        {
            rightPictureBox.Visible = false;
            leftPictureBox.Visible = false;
            bottomPanel.Visible = false;
            backPictureBox.Image = Properties.Resources.Title_Screen_Normal;
            startLabel.Visible = true;
        }
    }
}