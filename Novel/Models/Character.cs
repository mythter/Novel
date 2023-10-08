namespace Novel.Models
{
    public class Character
    {
        public string Name { get; }
        public Bitmap Icon { get; private set; }
        public Bitmap LeftImage { get; private set; }
        public Bitmap RightImage { get; private set; }
        public string[]? Replies { get; set; }

        public Character(string name)
        {
            Name = name;
            Icon = null!;
            LeftImage = null!;
            RightImage = null!;
            SetImages(name);
        }

        private void SetImages(string name)
        {
            switch (name)
            {
                case "Magus":
                    Icon = Properties.Resources.Magus_icon_Round;
                    LeftImage = Properties.Resources.Magus_left;
                    RightImage = Properties.Resources.Magus_right;
                    break;
                case "Frog":
                    Icon = Properties.Resources.Frog_icon_Round;
                    LeftImage = Properties.Resources.Frog_left;
                    RightImage = Properties.Resources.Frog_right;
                    break;
                case "Lucca":
                    Icon = Properties.Resources.Lucca_icon_Round;
                    LeftImage = Properties.Resources.Lucca_left;
                    RightImage = Properties.Resources.Lucca_right;
                    break;
                case "Marle":
                    Icon = Properties.Resources.Marle_icon_Round;
                    LeftImage = Properties.Resources.Marle_left;
                    RightImage = Properties.Resources.Marle_right;
                    break;
                case "Robo":
                    Icon = Properties.Resources.Robo_icon_Round;
                    LeftImage = Properties.Resources.Robo_left;
                    RightImage = Properties.Resources.Robo_right;
                    break;
                case "Ayla":
                    Icon = Properties.Resources.Ayla_icon_Round;
                    LeftImage = Properties.Resources.Ayla_left;
                    RightImage = Properties.Resources.Ayla_right;
                    break;
                case "Crono":
                    Icon = Properties.Resources.Crono_icon_Round;
                    LeftImage = Properties.Resources.Crono_left;
                    RightImage = Properties.Resources.Crono_right;
                    break;
                default:
                    throw new ArgumentException("Character is not chosen.");
            }
        }
    }
}
