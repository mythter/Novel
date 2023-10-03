using System.Windows.Forms;

namespace Novel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backPictureBox = new PictureBox();
            startLabel = new Label();
            leftPictureBox = new PictureBox();
            rightPictureBox = new PictureBox();
            roboPointer = new PictureBox();
            luccaPointer = new PictureBox();
            frogPointer = new PictureBox();
            marlePointer = new PictureBox();
            aylaPointer = new PictureBox();
            magusPointer = new PictureBox();
            characterPanel = new Controls.CharacterPanel();
            ((System.ComponentModel.ISupportInitialize)backPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roboPointer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)luccaPointer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frogPointer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)marlePointer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aylaPointer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)magusPointer).BeginInit();
            SuspendLayout();
            // 
            // backPictureBox
            // 
            backPictureBox.Dock = DockStyle.Fill;
            backPictureBox.Image = Properties.Resources.Title_Screen_Normal;
            backPictureBox.Location = new Point(0, 0);
            backPictureBox.Name = "backPictureBox";
            backPictureBox.Size = new Size(1000, 600);
            backPictureBox.TabIndex = 0;
            backPictureBox.TabStop = false;
            backPictureBox.Click += backPictureBox_Click;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.BackColor = Color.Transparent;
            startLabel.Font = new Font("ChronoType", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            startLabel.ForeColor = SystemColors.Control;
            startLabel.Location = new Point(425, 341);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(150, 67);
            startLabel.TabIndex = 1;
            startLabel.Text = "Start";
            startLabel.Click += startLabel_Click;
            // 
            // leftPictureBox
            // 
            leftPictureBox.Location = new Point(0, 100);
            leftPictureBox.Name = "leftPictureBox";
            leftPictureBox.Size = new Size(200, 500);
            leftPictureBox.TabIndex = 4;
            leftPictureBox.TabStop = false;
            leftPictureBox.Visible = false;
            // 
            // rightPictureBox
            // 
            rightPictureBox.BackColor = Color.Transparent;
            rightPictureBox.Location = new Point(800, 100);
            rightPictureBox.Name = "rightPictureBox";
            rightPictureBox.Size = new Size(200, 500);
            rightPictureBox.TabIndex = 5;
            rightPictureBox.TabStop = false;
            rightPictureBox.Visible = false;
            // 
            // roboPointer
            // 
            roboPointer.Image = Properties.Resources.pointer;
            roboPointer.Location = new Point(501, 144);
            roboPointer.Name = "roboPointer";
            roboPointer.Size = new Size(20, 20);
            roboPointer.TabIndex = 6;
            roboPointer.TabStop = false;
            roboPointer.Tag = "Robo";
            roboPointer.Visible = false;
            roboPointer.Click += CharacterPointer_Click;
            // 
            // luccaPointer
            // 
            luccaPointer.Image = Properties.Resources.pointer;
            luccaPointer.Location = new Point(569, 179);
            luccaPointer.Name = "luccaPointer";
            luccaPointer.Size = new Size(20, 20);
            luccaPointer.TabIndex = 7;
            luccaPointer.TabStop = false;
            luccaPointer.Tag = "Lucca";
            luccaPointer.Visible = false;
            luccaPointer.Click += CharacterPointer_Click;
            // 
            // frogPointer
            // 
            frogPointer.Image = Properties.Resources.pointer;
            frogPointer.Location = new Point(329, 244);
            frogPointer.Name = "frogPointer";
            frogPointer.Size = new Size(20, 20);
            frogPointer.TabIndex = 8;
            frogPointer.TabStop = false;
            frogPointer.Tag = "Frog";
            frogPointer.Visible = false;
            frogPointer.Click += CharacterPointer_Click;
            // 
            // marlePointer
            // 
            marlePointer.Image = Properties.Resources.pointer;
            marlePointer.Location = new Point(338, 375);
            marlePointer.Name = "marlePointer";
            marlePointer.Size = new Size(20, 20);
            marlePointer.TabIndex = 9;
            marlePointer.TabStop = false;
            marlePointer.Tag = "Marle";
            marlePointer.Visible = false;
            marlePointer.Click += CharacterPointer_Click;
            // 
            // aylaPointer
            // 
            aylaPointer.Image = Properties.Resources.pointer;
            aylaPointer.Location = new Point(680, 244);
            aylaPointer.Name = "aylaPointer";
            aylaPointer.Size = new Size(20, 20);
            aylaPointer.TabIndex = 10;
            aylaPointer.TabStop = false;
            aylaPointer.Tag = "Ayla";
            aylaPointer.Visible = false;
            aylaPointer.Click += CharacterPointer_Click;
            // 
            // magusPointer
            // 
            magusPointer.Image = Properties.Resources.pointer;
            magusPointer.Location = new Point(856, 270);
            magusPointer.Name = "magusPointer";
            magusPointer.Size = new Size(20, 20);
            magusPointer.TabIndex = 11;
            magusPointer.TabStop = false;
            magusPointer.Tag = "Magus";
            magusPointer.Visible = false;
            magusPointer.Click += CharacterPointer_Click;
            // 
            // characterPanel
            // 
            characterPanel.BackgroundImage = (Image)resources.GetObject("characterPanel.BackgroundImage");
            characterPanel.Image = null;
            characterPanel.Location = new Point(200, 475);
            characterPanel.Name = "characterPanel";
            characterPanel.Reply = "";
            characterPanel.Size = new Size(600, 125);
            characterPanel.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(characterPanel);
            Controls.Add(magusPointer);
            Controls.Add(aylaPointer);
            Controls.Add(marlePointer);
            Controls.Add(frogPointer);
            Controls.Add(luccaPointer);
            Controls.Add(roboPointer);
            Controls.Add(rightPictureBox);
            Controls.Add(leftPictureBox);
            Controls.Add(startLabel);
            Controls.Add(backPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chrono Trigger Campfire";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)backPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)roboPointer).EndInit();
            ((System.ComponentModel.ISupportInitialize)luccaPointer).EndInit();
            ((System.ComponentModel.ISupportInitialize)frogPointer).EndInit();
            ((System.ComponentModel.ISupportInitialize)marlePointer).EndInit();
            ((System.ComponentModel.ISupportInitialize)aylaPointer).EndInit();
            ((System.ComponentModel.ISupportInitialize)magusPointer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backPictureBox;
        private Label startLabel;
        private PictureBox leftPictureBox;
        private PictureBox rightPictureBox;
        private PictureBox roboPointer;
        private PictureBox luccaPointer;
        private PictureBox frogPointer;
        private PictureBox marlePointer;
        private PictureBox aylaPointer;
        private PictureBox magusPointer;
        private Controls.CharacterPanel characterPanel;
    }
}