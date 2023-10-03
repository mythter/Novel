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
            get
            {
                return characterTextLabel.Text;
            }
            set
            {
                characterTextLabel.Text = value;
            }
        }

        public Image Image
        {
            get
            {
                return characterIconPicBox.Image;
            }
            set
            {
                characterIconPicBox.Image = value;
            }
        }
    }
}
