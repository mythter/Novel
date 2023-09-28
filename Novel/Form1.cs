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
    }
}