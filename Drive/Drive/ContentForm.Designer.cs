﻿namespace Drive
{
    partial class ContentForm
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
            this.contentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(13, 12);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.ReadOnly = true;
            this.contentBox.Size = new System.Drawing.Size(527, 237);
            this.contentBox.TabIndex = 0;
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 261);
            this.Controls.Add(this.contentBox);
            this.Name = "ContentForm";
            this.Text = "ContentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentBox;
    }
}