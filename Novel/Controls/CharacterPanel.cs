namespace Novel.Controls
{
    public partial class CharacterPanel : UserControl
    {
        public CharacterPanel()
        {
            InitializeComponent();
        }

        public string Reply
        {
            get => characterTextLabel.Text;
            set => characterTextLabel.Text = value;
        }

        public Image? Image
        {
            get => characterIconPicBox.Image;
            set => characterIconPicBox.Image = value;
        }
    }
}
