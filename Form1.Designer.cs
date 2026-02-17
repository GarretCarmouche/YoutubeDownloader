namespace YoutubeDownloader
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
            urlTextBox = new TextBox();
            urlLabel = new Label();
            downloadButton = new Button();
            OutputLabel = new Label();
            label1 = new Label();
            mp4Format = new RadioButton();
            mkvFormat = new RadioButton();
            mp3Format = new RadioButton();
            aacFormat = new RadioButton();
            label2 = new Label();
            directoryBox = new TextBox();
            reinstallButton = new Button();
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(335, 59);
            urlTextBox.Margin = new Padding(4);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(660, 31);
            urlTextBox.TabIndex = 0;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlLabel.Location = new Point(15, 51);
            urlLabel.Margin = new Padding(4, 0, 4, 0);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(284, 38);
            urlLabel.TabIndex = 1;
            urlLabel.Text = "Youtube Sharing Link:";
            // 
            // downloadButton
            // 
            downloadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            downloadButton.Font = new Font("Segoe UI", 14F);
            downloadButton.Location = new Point(800, 402);
            downloadButton.Margin = new Padding(4);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(285, 79);
            downloadButton.TabIndex = 2;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            OutputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OutputLabel.AutoSize = true;
            OutputLabel.Font = new Font("Segoe UI", 10F);
            OutputLabel.Location = new Point(15, 460);
            OutputLabel.Margin = new Padding(4, 0, 4, 0);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(0, 28);
            OutputLabel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(15, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 45);
            label1.TabIndex = 4;
            label1.Text = "Video Format";
            // 
            // mp4Format
            // 
            mp4Format.AutoSize = true;
            mp4Format.Font = new Font("Segoe UI", 12F);
            mp4Format.Location = new Point(32, 200);
            mp4Format.Margin = new Padding(4);
            mp4Format.Name = "mp4Format";
            mp4Format.Size = new Size(87, 36);
            mp4Format.TabIndex = 5;
            mp4Format.TabStop = true;
            mp4Format.Text = "mp4";
            mp4Format.UseVisualStyleBackColor = true;
            // 
            // mkvFormat
            // 
            mkvFormat.AutoSize = true;
            mkvFormat.Font = new Font("Segoe UI", 12F);
            mkvFormat.Location = new Point(32, 248);
            mkvFormat.Margin = new Padding(4);
            mkvFormat.Name = "mkvFormat";
            mkvFormat.Size = new Size(84, 36);
            mkvFormat.TabIndex = 6;
            mkvFormat.TabStop = true;
            mkvFormat.Text = "mkv";
            mkvFormat.UseVisualStyleBackColor = true;
            // 
            // mp3Format
            // 
            mp3Format.AutoSize = true;
            mp3Format.Font = new Font("Segoe UI", 12F);
            mp3Format.Location = new Point(32, 295);
            mp3Format.Margin = new Padding(4);
            mp3Format.Name = "mp3Format";
            mp3Format.Size = new Size(228, 36);
            mp3Format.TabIndex = 7;
            mp3Format.TabStop = true;
            mp3Format.Text = "mp3 [Audio Only]";
            mp3Format.UseVisualStyleBackColor = true;
            // 
            // aacFormat
            // 
            aacFormat.AutoSize = true;
            aacFormat.Font = new Font("Segoe UI", 12F);
            aacFormat.Location = new Point(32, 342);
            aacFormat.Margin = new Padding(4);
            aacFormat.Name = "aacFormat";
            aacFormat.Size = new Size(229, 36);
            aacFormat.TabIndex = 8;
            aacFormat.TabStop = true;
            aacFormat.Text = "aac   [Audio Only]";
            aacFormat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(381, 38);
            label2.TabIndex = 9;
            label2.Text = "Save Location (directory only)";
            // 
            // directoryBox
            // 
            directoryBox.Location = new Point(335, 185);
            directoryBox.Margin = new Padding(4);
            directoryBox.Name = "directoryBox";
            directoryBox.Size = new Size(660, 31);
            directoryBox.TabIndex = 10;
            // 
            // reinstallButton
            // 
            reinstallButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reinstallButton.Font = new Font("Segoe UI", 12F);
            reinstallButton.Location = new Point(507, 402);
            reinstallButton.Margin = new Padding(4);
            reinstallButton.Name = "reinstallButton";
            reinstallButton.RightToLeft = RightToLeft.No;
            reinstallButton.Size = new Size(285, 79);
            reinstallButton.TabIndex = 11;
            reinstallButton.Text = "Reinstall \r\nDependencies";
            reinstallButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 496);
            Controls.Add(reinstallButton);
            Controls.Add(directoryBox);
            Controls.Add(label2);
            Controls.Add(aacFormat);
            Controls.Add(mp3Format);
            Controls.Add(mkvFormat);
            Controls.Add(mp4Format);
            Controls.Add(label1);
            Controls.Add(OutputLabel);
            Controls.Add(downloadButton);
            Controls.Add(urlLabel);
            Controls.Add(urlTextBox);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Youtube Downloader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlTextBox;
        private Label urlLabel;
        private Button downloadButton;
        private Label OutputLabel;
        private Label label1;
        private RadioButton mp4Format;
        private RadioButton mkvFormat;
        private RadioButton mp3Format;
        private RadioButton aacFormat;
        private Label label2;
        private TextBox directoryBox;
        private Button reinstallButton;
    }
}
