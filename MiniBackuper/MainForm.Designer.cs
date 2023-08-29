namespace MiniBackuper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBoxTime = new TextBox();
            label1 = new Label();
            textBoxCount = new TextBox();
            label2 = new Label();
            pictureBoxClose = new PictureBox();
            label3 = new Label();
            labelLogo = new Label();
            pictureBoxMin = new PictureBox();
            buttonBrowseFolder = new RoundButton();
            buttonStart = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).BeginInit();
            SuspendLayout();
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(18, 58);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(30, 23);
            textBoxTime.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(60, 62);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 2;
            label1.Text = "Backup time after changes";
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(18, 105);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(30, 23);
            textBoxCount.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(61, 108);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 5;
            label2.Text = "Number of changes before backup";
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(237, 8);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(24, 24);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 8;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += PictureBoxCloseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(70, 212);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 9;
            label3.Text = "Autorun on OS startup";
            // 
            // labelLogo
            // 
            labelLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLogo.AutoSize = true;
            labelLogo.BackColor = Color.Transparent;
            labelLogo.Font = new Font("SansSerif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogo.ForeColor = Color.Gainsboro;
            labelLogo.Location = new Point(8, 2);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(153, 37);
            labelLogo.TabIndex = 10;
            labelLogo.Text = "Backuper";
            // 
            // pictureBoxMin
            // 
            pictureBoxMin.BackColor = Color.Transparent;
            pictureBoxMin.Image = (Image)resources.GetObject("pictureBoxMin.Image");
            pictureBoxMin.Location = new Point(213, 15);
            pictureBoxMin.Name = "pictureBoxMin";
            pictureBoxMin.Size = new Size(19, 22);
            pictureBoxMin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMin.TabIndex = 11;
            pictureBoxMin.TabStop = false;
            pictureBoxMin.Click += PictureBoxMinClick;
            // 
            // buttonBrowseFolder
            // 
            buttonBrowseFolder.Location = new Point(30, 154);
            buttonBrowseFolder.Name = "buttonBrowseFolder";
            buttonBrowseFolder.Size = new Size(85, 30);
            buttonBrowseFolder.TabIndex = 0;
            buttonBrowseFolder.Text = "Select folder";
            buttonBrowseFolder.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(143, 154);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(85, 30);
            buttonStart.TabIndex = 13;
            buttonStart.Text = "Start backup";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(267, 260);
            Controls.Add(buttonStart);
            Controls.Add(buttonBrowseFolder);
            Controls.Add(pictureBoxMin);
            Controls.Add(labelLogo);
            Controls.Add(label3);
            Controls.Add(pictureBoxClose);
            Controls.Add(label2);
            Controls.Add(textBoxCount);
            Controls.Add(label1);
            Controls.Add(textBoxTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Backuper";
            Load += MainFormLoad;
            MouseDown += MainFormMouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTime;
        private Label label1;
        private TextBox textBoxCount;
        private Label label2;
        private PictureBox pictureBoxClose;
        private Label label3;
        private Label labelLogo;
        private PictureBox pictureBoxMin;
        private RoundButton buttonBrowseFolder;
        private RoundButton buttonStart;
    }
}