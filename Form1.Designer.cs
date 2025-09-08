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
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(267, 158);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(924, 27);
            urlTextBox.TabIndex = 0;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlLabel.Location = new Point(12, 152);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(234, 31);
            urlLabel.TabIndex = 1;
            urlLabel.Text = "Youtube Sharing Link:";
            // 
            // downloadButton
            // 
            downloadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            downloadButton.Font = new Font("Segoe UI", 14F);
            downloadButton.Location = new Point(1331, 823);
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
            OutputLabel.Location = new Point(12, 869);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(0, 23);
            OutputLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 898);
            Controls.Add(OutputLabel);
            Controls.Add(downloadButton);
            Controls.Add(urlLabel);
            Controls.Add(urlTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlTextBox;
        private Label urlLabel;
        private Button downloadButton;
        private Label OutputLabel;
    }
}
