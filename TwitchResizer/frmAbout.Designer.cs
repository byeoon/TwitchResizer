
namespace TwitchResizer
{
    partial class frmAbout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = System.Drawing.Color.FromArgb(19, 5, 122);
            richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            richTextBox2.Location = new System.Drawing.Point(12, 12);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new System.Drawing.Size(296, 132);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = " Patch Notes\n\n- Interface and color improvements\n- Fixed a bug with the preview on 128x128 pictures\n- Bug fixes";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ClientSize = new System.Drawing.Size(320, 154);
            Controls.Add(richTextBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}