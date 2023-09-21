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
            characterTextLabel = new Label();
            bottomPanel = new Panel();
            characterImagePicBox = new PictureBox();
            backgroudTextPicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backPictureBox).BeginInit();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)characterImagePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroudTextPicBox).BeginInit();
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
            // characterTextLabel
            // 
            characterTextLabel.Font = new Font("ChronoType", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            characterTextLabel.ForeColor = SystemColors.Control;
            characterTextLabel.Location = new Point(125, 0);
            characterTextLabel.Name = "characterTextLabel";
            characterTextLabel.Size = new Size(475, 125);
            characterTextLabel.TabIndex = 2;
            characterTextLabel.Text = "label1";
            characterTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            bottomPanel.Anchor = AnchorStyles.Bottom;
            bottomPanel.BackColor = Color.Transparent;
            bottomPanel.Controls.Add(characterImagePicBox);
            bottomPanel.Controls.Add(characterTextLabel);
            bottomPanel.Controls.Add(backgroudTextPicBox);
            bottomPanel.Location = new Point(200, 475);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(600, 125);
            bottomPanel.TabIndex = 3;
            bottomPanel.Visible = false;
            // 
            // characterImagePicBox
            // 
            characterImagePicBox.Location = new Point(25, 25);
            characterImagePicBox.Name = "characterImagePicBox";
            characterImagePicBox.Size = new Size(75, 75);
            characterImagePicBox.TabIndex = 3;
            characterImagePicBox.TabStop = false;
            // 
            // backgroudTextPicBox
            // 
            backgroudTextPicBox.Image = Properties.Resources.background;
            backgroudTextPicBox.Location = new Point(0, 0);
            backgroudTextPicBox.Name = "backgroudTextPicBox";
            backgroudTextPicBox.Size = new Size(600, 125);
            backgroudTextPicBox.TabIndex = 5;
            backgroudTextPicBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(bottomPanel);
            Controls.Add(startLabel);
            Controls.Add(backPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Chrono Trigger Campfire";
            ((System.ComponentModel.ISupportInitialize)backPictureBox).EndInit();
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)characterImagePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroudTextPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backPictureBox;
        private Label startLabel;
        private Label characterTextLabel;
        private Panel bottomPanel;
        private PictureBox characterImagePicBox;
        private PictureBox backgroudTextPicBox;
    }
}