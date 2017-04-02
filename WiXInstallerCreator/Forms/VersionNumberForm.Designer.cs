namespace WiXInstallerCreator
{
    partial class VersionNumberForm
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
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.getVersionButton = new System.Windows.Forms.Button();
            this.toolNameTextBox = new System.Windows.Forms.TextBox();
            this.toolNameLabel = new System.Windows.Forms.Label();
            this.exeListBox = new System.Windows.Forms.ListBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.manualGroupBox = new System.Windows.Forms.GroupBox();
            this.manualLabel = new System.Windows.Forms.Label();
            this.manualCheckBox = new System.Windows.Forms.CheckBox();
            this.exeGroupBox = new System.Windows.Forms.GroupBox();
            this.manualGroupBox.SuspendLayout();
            this.exeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(6, 65);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(82, 13);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "Version Number";
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(94, 62);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(198, 20);
            this.versionTextBox.TabIndex = 2;
            this.versionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VersionTextBoxKeyPress);
            // 
            // getVersionButton
            // 
            this.getVersionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getVersionButton.Location = new System.Drawing.Point(232, 233);
            this.getVersionButton.Name = "getVersionButton";
            this.getVersionButton.Size = new System.Drawing.Size(77, 23);
            this.getVersionButton.TabIndex = 3;
            this.getVersionButton.Text = "OK";
            this.getVersionButton.UseVisualStyleBackColor = true;
            this.getVersionButton.Click += new System.EventHandler(this.GetVersionButtonClick);
            // 
            // toolNameTextBox
            // 
            this.toolNameTextBox.Location = new System.Drawing.Point(94, 36);
            this.toolNameTextBox.Name = "toolNameTextBox";
            this.toolNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.toolNameTextBox.TabIndex = 1;
            // 
            // toolNameLabel
            // 
            this.toolNameLabel.AutoSize = true;
            this.toolNameLabel.Location = new System.Drawing.Point(6, 39);
            this.toolNameLabel.Name = "toolNameLabel";
            this.toolNameLabel.Size = new System.Drawing.Size(74, 13);
            this.toolNameLabel.TabIndex = 3;
            this.toolNameLabel.Text = "Installer Name";
            // 
            // exeListBox
            // 
            this.exeListBox.FormattingEnabled = true;
            this.exeListBox.Location = new System.Drawing.Point(6, 34);
            this.exeListBox.Name = "exeListBox";
            this.exeListBox.Size = new System.Drawing.Size(286, 56);
            this.exeListBox.TabIndex = 4;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.noteLabel.Location = new System.Drawing.Point(4, 16);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(265, 12);
            this.noteLabel.TabIndex = 6;
            this.noteLabel.Text = "(Installer name and version will be the same as the selected file)";
            // 
            // manualGroupBox
            // 
            this.manualGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.manualGroupBox.Controls.Add(this.manualLabel);
            this.manualGroupBox.Controls.Add(this.toolNameTextBox);
            this.manualGroupBox.Controls.Add(this.versionLabel);
            this.manualGroupBox.Controls.Add(this.versionTextBox);
            this.manualGroupBox.Controls.Add(this.toolNameLabel);
            this.manualGroupBox.Location = new System.Drawing.Point(11, 136);
            this.manualGroupBox.Name = "manualGroupBox";
            this.manualGroupBox.Size = new System.Drawing.Size(298, 91);
            this.manualGroupBox.TabIndex = 8;
            this.manualGroupBox.TabStop = false;
            this.manualGroupBox.Text = "Name and Version";
            this.manualGroupBox.Visible = false;
            // 
            // manualLabel
            // 
            this.manualLabel.AutoSize = true;
            this.manualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualLabel.ForeColor = System.Drawing.Color.Red;
            this.manualLabel.Location = new System.Drawing.Point(6, 16);
            this.manualLabel.Name = "manualLabel";
            this.manualLabel.Size = new System.Drawing.Size(168, 12);
            this.manualLabel.TabIndex = 7;
            this.manualLabel.Text = "(Automatically skips creating shortcuts)";
            // 
            // manualCheckBox
            // 
            this.manualCheckBox.AutoSize = true;
            this.manualCheckBox.Location = new System.Drawing.Point(11, 113);
            this.manualCheckBox.Name = "manualCheckBox";
            this.manualCheckBox.Size = new System.Drawing.Size(177, 17);
            this.manualCheckBox.TabIndex = 9;
            this.manualCheckBox.Text = "Manually Set Name and Version";
            this.manualCheckBox.UseVisualStyleBackColor = true;
            this.manualCheckBox.CheckedChanged += new System.EventHandler(this.ManualCheckBoxCheckedChanged);
            // 
            // exeGroupBox
            // 
            this.exeGroupBox.Controls.Add(this.exeListBox);
            this.exeGroupBox.Controls.Add(this.noteLabel);
            this.exeGroupBox.Location = new System.Drawing.Point(11, 9);
            this.exeGroupBox.Name = "exeGroupBox";
            this.exeGroupBox.Size = new System.Drawing.Size(298, 98);
            this.exeGroupBox.TabIndex = 10;
            this.exeGroupBox.TabStop = false;
            this.exeGroupBox.Text = "Select Main Application";
            // 
            // VersionNumberForm
            // 
            this.AcceptButton = this.getVersionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 261);
            this.Controls.Add(this.exeGroupBox);
            this.Controls.Add(this.manualCheckBox);
            this.Controls.Add(this.getVersionButton);
            this.Controls.Add(this.manualGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(337, 300);
            this.MinimumSize = new System.Drawing.Size(337, 175);
            this.Name = "VersionNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Version";
            this.Load += new System.EventHandler(this.VersionNumberFormLoad);
            this.manualGroupBox.ResumeLayout(false);
            this.manualGroupBox.PerformLayout();
            this.exeGroupBox.ResumeLayout(false);
            this.exeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Button getVersionButton;
        private System.Windows.Forms.TextBox toolNameTextBox;
        private System.Windows.Forms.Label toolNameLabel;
        private System.Windows.Forms.ListBox exeListBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.GroupBox manualGroupBox;
        private System.Windows.Forms.CheckBox manualCheckBox;
        private System.Windows.Forms.GroupBox exeGroupBox;
        private System.Windows.Forms.Label manualLabel;
    }
}