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
            components = new System.ComponentModel.Container();
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
            checkSwitchAutorun = new MaterialSkin.Controls.MaterialCheckBox();
            notifyIcon = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).BeginInit();
            SuspendLayout();
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(18, 74);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(30, 23);
            textBoxTime.TabIndex = 1;
            textBoxTime.TabStop = false;
            textBoxTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(60, 79);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 2;
            label1.Text = "Backup time after changes";
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(18, 106);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(30, 23);
            textBoxCount.TabIndex = 4;
            textBoxCount.TabStop = false;
            textBoxCount.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(61, 110);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 5;
            label2.Text = "Number of changes before backup";
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(237, 0);
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
            label3.Location = new Point(88, 198);
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
            labelLogo.Location = new Point(52, 25);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(153, 37);
            labelLogo.TabIndex = 10;
            labelLogo.Text = "Backuper";
            // 
            // pictureBoxMin
            // 
            pictureBoxMin.BackColor = Color.Transparent;
            pictureBoxMin.Image = (Image)resources.GetObject("pictureBoxMin.Image");
            pictureBoxMin.Location = new Point(211, 6);
            pictureBoxMin.Name = "pictureBoxMin";
            pictureBoxMin.Size = new Size(19, 22);
            pictureBoxMin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMin.TabIndex = 11;
            pictureBoxMin.TabStop = false;
            pictureBoxMin.Click += PictureBoxMinClick;
            // 
            // buttonBrowseFolder
            // 
            buttonBrowseFolder.Location = new Point(32, 146);
            buttonBrowseFolder.Name = "buttonBrowseFolder";
            buttonBrowseFolder.Size = new Size(85, 30);
            buttonBrowseFolder.TabIndex = 0;
            buttonBrowseFolder.TabStop = false;
            buttonBrowseFolder.Text = "Select folder";
            buttonBrowseFolder.UseVisualStyleBackColor = true;
            buttonBrowseFolder.Click += ButtonBrowseFolderClick;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(134, 147);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(85, 30);
            buttonStart.TabIndex = 13;
            buttonStart.Text = "Start backup";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStartBackupClick;
            // 
            // checkSwitchAutorun
            // 
            checkSwitchAutorun.AutoSize = true;
            checkSwitchAutorun.BackColor = Color.Transparent;
            checkSwitchAutorun.Depth = 0;
            checkSwitchAutorun.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkSwitchAutorun.Location = new Point(51, 190);
            checkSwitchAutorun.Margin = new Padding(0);
            checkSwitchAutorun.MouseLocation = new Point(-1, -1);
            checkSwitchAutorun.MouseState = MaterialSkin.MouseState.HOVER;
            checkSwitchAutorun.Name = "checkSwitchAutorun";
            checkSwitchAutorun.Ripple = true;
            checkSwitchAutorun.Size = new Size(26, 30);
            checkSwitchAutorun.TabIndex = 14;
            checkSwitchAutorun.UseVisualStyleBackColor = false;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Backuper";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(267, 239);
            ControlBox = false;
            Controls.Add(checkSwitchAutorun);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private MaterialSkin.Controls.MaterialCheckBox checkSwitchAutorun;
        private NotifyIcon notifyIcon;
    }
}