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
            BackgroudTextPicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backPictureBox).BeginInit();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)characterImagePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackgroudTextPicBox).BeginInit();
            SuspendLayout();
            // 
            // backPictureBox
            // 
            backPictureBox.Dock = DockStyle.Fill;
            backPictureBox.Image = Properties.Resources.Title_Screen_Dark;
            backPictureBox.Location = new Point(0, 0);
            backPictureBox.Name = "backPictureBox";
            backPictureBox.Size = new Size(899, 507);
            backPictureBox.TabIndex = 0;
            backPictureBox.TabStop = false;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.BackColor = Color.Transparent;
            startLabel.Font = new Font("ChronoType", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            startLabel.ForeColor = SystemColors.Control;
            startLabel.Location = new Point(374, 300);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(150, 67);
            startLabel.TabIndex = 1;
            startLabel.Text = "Start";
            startLabel.Click += startLabel_Click;
            // 
            // characterTextLabel
            // 
            characterTextLabel.Dock = DockStyle.Right;
            characterTextLabel.Location = new Point(125, 0);
            characterTextLabel.Name = "characterTextLabel";
            characterTextLabel.Size = new Size(475, 125);
            characterTextLabel.TabIndex = 2;
            characterTextLabel.Text = "label1";
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(characterImagePicBox);
            bottomPanel.Controls.Add(characterTextLabel);
            bottomPanel.Controls.Add(BackgroudTextPicBox);
            bottomPanel.Location = new Point(151, 382);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(600, 125);
            bottomPanel.TabIndex = 3;
            bottomPanel.Visible = false;
            // 
            // characterImagePicBox
            // 
            characterImagePicBox.Dock = DockStyle.Left;
            characterImagePicBox.Location = new Point(0, 0);
            characterImagePicBox.Name = "characterImagePicBox";
            characterImagePicBox.Size = new Size(125, 125);
            characterImagePicBox.TabIndex = 3;
            characterImagePicBox.TabStop = false;
            // 
            // BackgroudTextPicBox
            // 
            BackgroudTextPicBox.Dock = DockStyle.Fill;
            BackgroudTextPicBox.Location = new Point(0, 0);
            BackgroudTextPicBox.Name = "BackgroudTextPicBox";
            BackgroudTextPicBox.Size = new Size(600, 125);
            BackgroudTextPicBox.TabIndex = 4;
            BackgroudTextPicBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 507);
            Controls.Add(bottomPanel);
            Controls.Add(startLabel);
            Controls.Add(backPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chrono Trigger Campfire";
            ((System.ComponentModel.ISupportInitialize)backPictureBox).EndInit();
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)characterImagePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackgroudTextPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backPictureBox;
        private Label startLabel;
        private Label characterTextLabel;
        private Panel bottomPanel;
        private PictureBox characterImagePicBox;
        private PictureBox BackgroudTextPicBox;
    }
}