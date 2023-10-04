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

            cts = new CancellationTokenSource();

            #region Custom font
            byte[] fontData = Properties.Resources.ChronoType;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.ChronoType.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.ChronoType.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            ChronoTypeFontRegular = new Font(fonts.Families[0], 14.0F);
            characterPanel.Font = ChronoTypeFontRegular;
            ChronoTypeFontRegular = new Font(fonts.Families[0], 40.0F);
            startLabel.Font = ChronoTypeFontRegular;
            #endregion
        }

        private async void startLabel_Click(object sender, EventArgs e)
        {
            backPictureBox.Image = Properties.Resources.Scene_1_Normal;
            startLabel.Visible = false;

            characterPanel.Visible = true;
            characterPanel.Image = Properties.Resources.Crono_icon_Round;

            await StoryStep();
        }

        private async void backPictureBox_Click(object sender, EventArgs e)
        {
            if (story != 0)
            {
                await StoryStep();
            }
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

            await StoryStep();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Dispose();
        }
    }
}