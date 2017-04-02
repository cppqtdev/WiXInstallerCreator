namespace WiXInstallerCreator.Forms
{
    partial class AboutForm
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
            if(disposing && (components != null))
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
            this.toolNameLabel = new System.Windows.Forms.Label();
            this.toolDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // toolNameLabel
            // 
            this.toolNameLabel.AutoSize = true;
            this.toolNameLabel.Location = new System.Drawing.Point(12, 9);
            this.toolNameLabel.Name = "toolNameLabel";
            this.toolNameLabel.Size = new System.Drawing.Size(59, 13);
            this.toolNameLabel.TabIndex = 0;
            this.toolNameLabel.Text = "Tool Name";
            // 
            // toolDescriptionLabel
            // 
            this.toolDescriptionLabel.AutoSize = true;
            this.toolDescriptionLabel.Location = new System.Drawing.Point(12, 31);
            this.toolDescriptionLabel.Name = "toolDescriptionLabel";
            this.toolDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.toolDescriptionLabel.TabIndex = 1;
            this.toolDescriptionLabel.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(15, 51);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(312, 78);
            this.descriptionRichTextBox.TabIndex = 2;
            this.descriptionRichTextBox.Text = "";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 141);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.toolDescriptionLabel);
            this.Controls.Add(this.toolNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About this tool";
            this.Load += new System.EventHandler(this.AboutFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toolNameLabel;
        private System.Windows.Forms.Label toolDescriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
    }
}