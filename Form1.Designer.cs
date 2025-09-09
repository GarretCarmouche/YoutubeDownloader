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
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(268, 47);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(529, 27);
            urlTextBox.TabIndex = 0;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlLabel.Location = new Point(12, 41);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(234, 31);
            urlLabel.TabIndex = 1;
            urlLabel.Text = "Youtube Sharing Link:";
            // 
            // downloadButton
            // 
            downloadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            downloadButton.Font = new Font("Segoe UI", 14F);
            downloadButton.Location = new Point(640, 322);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(228, 63);
            downloadButton.TabIndex = 2;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            OutputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OutputLabel.AutoSize = true;
            OutputLabel.Font = new Font("Segoe UI", 10F);
            OutputLabel.Location = new Point(12, 368);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(0, 23);
            OutputLabel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 4;
            label1.Text = "Video Format";
            // 
            // mp4Format
            // 
            mp4Format.AutoSize = true;
            mp4Format.Font = new Font("Segoe UI", 12F);
            mp4Format.Location = new Point(26, 160);
            mp4Format.Name = "mp4Format";
            mp4Format.Size = new Size(73, 32);
            mp4Format.TabIndex = 5;
            mp4Format.TabStop = true;
            mp4Format.Text = "mp4";
            mp4Format.UseVisualStyleBackColor = true;
            // 
            // mkvFormat
            // 
            mkvFormat.AutoSize = true;
            mkvFormat.Font = new Font("Segoe UI", 12F);
            mkvFormat.Location = new Point(26, 198);
            mkvFormat.Name = "mkvFormat";
            mkvFormat.Size = new Size(70, 32);
            mkvFormat.TabIndex = 6;
            mkvFormat.TabStop = true;
            mkvFormat.Text = "mkv";
            mkvFormat.UseVisualStyleBackColor = true;
            // 
            // mp3Format
            // 
            mp3Format.AutoSize = true;
            mp3Format.Font = new Font("Segoe UI", 12F);
            mp3Format.Location = new Point(26, 236);
            mp3Format.Name = "mp3Format";
            mp3Format.Size = new Size(189, 32);
            mp3Format.TabIndex = 7;
            mp3Format.TabStop = true;
            mp3Format.Text = "mp3 [Audio Only]";
            mp3Format.UseVisualStyleBackColor = true;
            // 
            // aacFormat
            // 
            aacFormat.AutoSize = true;
            aacFormat.Font = new Font("Segoe UI", 12F);
            aacFormat.Location = new Point(26, 274);
            aacFormat.Name = "aacFormat";
            aacFormat.Size = new Size(188, 32);
            aacFormat.TabIndex = 8;
            aacFormat.TabStop = true;
            aacFormat.Text = "aac   [Audio Only]";
            aacFormat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 98);
            label2.Name = "label2";
            label2.Size = new Size(314, 31);
            label2.TabIndex = 9;
            label2.Text = "Save Location (directory only)";
            // 
            // directoryBox
            // 
            directoryBox.Location = new Point(268, 148);
            directoryBox.Name = "directoryBox";
            directoryBox.Size = new Size(529, 27);
            directoryBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 397);
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
    }
}
