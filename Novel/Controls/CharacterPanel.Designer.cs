namespace Novel.Controls
{
    partial class CharacterPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            characterIconPicBox = new PictureBox();
            characterTextLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)characterIconPicBox).BeginInit();
            SuspendLayout();
            // 
            // characterIconPicBox
            // 
            characterIconPicBox.Location = new Point(25, 25);
            characterIconPicBox.Name = "characterIconPicBox";
            characterIconPicBox.Size = new Size(75, 75);
            characterIconPicBox.TabIndex = 7;
            characterIconPicBox.TabStop = false;
            // 
            // characterTextLabel
            // 
            characterTextLabel.Font = new Font("ChronoType", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            characterTextLabel.ForeColor = SystemColors.Control;
            characterTextLabel.Location = new Point(106, 0);
            characterTextLabel.Name = "characterTextLabel";
            characterTextLabel.Padding = new Padding(10, 0, 10, 0);
            characterTextLabel.Size = new Size(494, 125);
            characterTextLabel.TabIndex = 6;
            characterTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CharacterPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(characterIconPicBox);
            Controls.Add(characterTextLabel);
            Name = "CharacterPanel";
            Size = new Size(600, 125);
            ((System.ComponentModel.ISupportInitialize)characterIconPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox characterIconPicBox;
        private Label characterTextLabel;
    }
}
