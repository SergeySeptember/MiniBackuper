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
            labelAutorun = new Label();
            labelLogo = new Label();
            pictureBoxMin = new PictureBox();
            buttonBrowseFolder = new RoundButton();
            buttonStart = new RoundButton();
            checkBoxAutorun = new MaterialSkin.Controls.MaterialCheckBox();
            notifyIcon = new NotifyIcon(components);
            checkBoxStart = new MaterialSkin.Controls.MaterialCheckBox();
            labelStartAutorun = new Label();
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
            // labelAutorun
            // 
            labelAutorun.AutoSize = true;
            labelAutorun.BackColor = Color.Transparent;
            labelAutorun.Location = new Point(87, 181);
            labelAutorun.Name = "labelAutorun";
            labelAutorun.Size = new Size(126, 15);
            labelAutorun.TabIndex = 9;
            labelAutorun.Text = "Autorun on OS startup";
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
            buttonBrowseFolder.Location = new Point(32, 141);
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
            buttonStart.Location = new Point(134, 142);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(85, 30);
            buttonStart.TabIndex = 13;
            buttonStart.Text = "Start backup";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStartBackupClick;
            // 
            // checkBoxAutorun
            // 
            checkBoxAutorun.AutoSize = true;
            checkBoxAutorun.BackColor = Color.Transparent;
            checkBoxAutorun.Depth = 0;
            checkBoxAutorun.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAutorun.Location = new Point(50, 173);
            checkBoxAutorun.Margin = new Padding(0);
            checkBoxAutorun.MouseLocation = new Point(-1, -1);
            checkBoxAutorun.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxAutorun.Name = "checkBoxAutorun";
            checkBoxAutorun.Ripple = true;
            checkBoxAutorun.Size = new Size(26, 30);
            checkBoxAutorun.TabIndex = 14;
            checkBoxAutorun.UseVisualStyleBackColor = false;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Backuper";
            // 
            // checkBoxStart
            // 
            checkBoxStart.AutoSize = true;
            checkBoxStart.BackColor = Color.Transparent;
            checkBoxStart.Depth = 0;
            checkBoxStart.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxStart.Location = new Point(50, 200);
            checkBoxStart.Margin = new Padding(0);
            checkBoxStart.MouseLocation = new Point(-1, -1);
            checkBoxStart.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxStart.Name = "checkBoxStart";
            checkBoxStart.Ripple = true;
            checkBoxStart.Size = new Size(26, 30);
            checkBoxStart.TabIndex = 15;
            checkBoxStart.UseVisualStyleBackColor = false;
            // 
            // labelStartAutorun
            // 
            labelStartAutorun.AutoSize = true;
            labelStartAutorun.BackColor = Color.Transparent;
            labelStartAutorun.Location = new Point(87, 207);
            labelStartAutorun.Name = "labelStartAutorun";
            labelStartAutorun.Size = new Size(144, 15);
            labelStartAutorun.TabIndex = 16;
            labelStartAutorun.Text = "Start backup at OS startup";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(267, 237);
            ControlBox = false;
            Controls.Add(labelStartAutorun);
            Controls.Add(checkBoxStart);
            Controls.Add(checkBoxAutorun);
            Controls.Add(buttonStart);
            Controls.Add(buttonBrowseFolder);
            Controls.Add(pictureBoxMin);
            Controls.Add(labelLogo);
            Controls.Add(labelAutorun);
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
        private Label labelAutorun;
        private Label labelLogo;
        private PictureBox pictureBoxMin;
        private RoundButton buttonBrowseFolder;
        private RoundButton buttonStart;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxAutorun;
        private NotifyIcon notifyIcon;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxStart;
        private Label labelStartAutorun;
    }
}