namespace WiXInstallerCreator
{
    partial class WiXInstallerCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiXInstallerCreatorForm));
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.upgradeCodeLabel = new System.Windows.Forms.Label();
            this.upgradeCodeTextBox = new System.Windows.Forms.TextBox();
            this.iconFileLabel = new System.Windows.Forms.Label();
            this.iconTextBox = new System.Windows.Forms.TextBox();
            this.createInstallerButton = new System.Windows.Forms.Button();
            this.projectBinDirectoryLabel = new System.Windows.Forms.Label();
            this.projectBinDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.generateGuidButton = new System.Windows.Forms.Button();
            this.browseProjectBinFolderButton = new System.Windows.Forms.Button();
            this.browseIconButton = new System.Windows.Forms.Button();
            this.projectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.licenseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dialogImageButton = new System.Windows.Forms.Button();
            this.dialogImageLabel = new System.Windows.Forms.Label();
            this.dialogImageTextBox = new System.Windows.Forms.TextBox();
            this.bannerImageButton = new System.Windows.Forms.Button();
            this.bannerImageLabel = new System.Windows.Forms.Label();
            this.bannerImageTextBox = new System.Windows.Forms.TextBox();
            this.licenseInfoLabel = new System.Windows.Forms.Label();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolDescriptionLabel = new System.Windows.Forms.Label();
            this.userAgreementCheckBox = new System.Windows.Forms.CheckBox();
            this.desktopShortcutCheckBox = new System.Windows.Forms.CheckBox();
            this.projectDescriptiosnGroupBox = new System.Windows.Forms.GroupBox();
            this.toolDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.licenseGroupBox = new System.Windows.Forms.GroupBox();
            this.installerImagesGroupBox = new System.Windows.Forms.GroupBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceButton = new System.Windows.Forms.Button();
            this.mainStatusStrip.SuspendLayout();
            this.projectDescriptiosnGroupBox.SuspendLayout();
            this.licenseGroupBox.SuspendLayout();
            this.installerImagesGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(41, 76);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.companyNameLabel.TabIndex = 3;
            this.companyNameLabel.Text = "Company Name";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(129, 73);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(201, 20);
            this.companyNameTextBox.TabIndex = 2;
            this.companyNameTextBox.Text = "REZA";
            // 
            // upgradeCodeLabel
            // 
            this.upgradeCodeLabel.AutoSize = true;
            this.upgradeCodeLabel.Location = new System.Drawing.Point(11, 50);
            this.upgradeCodeLabel.Name = "upgradeCodeLabel";
            this.upgradeCodeLabel.Size = new System.Drawing.Size(112, 13);
            this.upgradeCodeLabel.TabIndex = 5;
            this.upgradeCodeLabel.Text = "Upgrade Code (GUID)";
            // 
            // upgradeCodeTextBox
            // 
            this.upgradeCodeTextBox.Location = new System.Drawing.Point(129, 47);
            this.upgradeCodeTextBox.Name = "upgradeCodeTextBox";
            this.upgradeCodeTextBox.Size = new System.Drawing.Size(201, 20);
            this.upgradeCodeTextBox.TabIndex = 1;
            // 
            // iconFileLabel
            // 
            this.iconFileLabel.AutoSize = true;
            this.iconFileLabel.Location = new System.Drawing.Point(50, 102);
            this.iconFileLabel.Name = "iconFileLabel";
            this.iconFileLabel.Size = new System.Drawing.Size(73, 13);
            this.iconFileLabel.TabIndex = 9;
            this.iconFileLabel.Text = "Icon File (.ico)";
            // 
            // iconTextBox
            // 
            this.iconTextBox.Location = new System.Drawing.Point(129, 99);
            this.iconTextBox.Name = "iconTextBox";
            this.iconTextBox.Size = new System.Drawing.Size(201, 20);
            this.iconTextBox.TabIndex = 3;
            // 
            // createInstallerButton
            // 
            this.createInstallerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createInstallerButton.Location = new System.Drawing.Point(348, 498);
            this.createInstallerButton.Name = "createInstallerButton";
            this.createInstallerButton.Size = new System.Drawing.Size(89, 23);
            this.createInstallerButton.TabIndex = 10;
            this.createInstallerButton.Text = "Create Installer";
            this.createInstallerButton.UseVisualStyleBackColor = true;
            this.createInstallerButton.Click += new System.EventHandler(this.CreateInstallerButtonClick);
            // 
            // projectBinDirectoryLabel
            // 
            this.projectBinDirectoryLabel.AutoSize = true;
            this.projectBinDirectoryLabel.Location = new System.Drawing.Point(20, 24);
            this.projectBinDirectoryLabel.Name = "projectBinDirectoryLabel";
            this.projectBinDirectoryLabel.Size = new System.Drawing.Size(103, 13);
            this.projectBinDirectoryLabel.TabIndex = 16;
            this.projectBinDirectoryLabel.Text = "Project Bin Directory";
            // 
            // projectBinDirectoryTextBox
            // 
            this.projectBinDirectoryTextBox.Location = new System.Drawing.Point(129, 21);
            this.projectBinDirectoryTextBox.Name = "projectBinDirectoryTextBox";
            this.projectBinDirectoryTextBox.Size = new System.Drawing.Size(201, 20);
            this.projectBinDirectoryTextBox.TabIndex = 0;
            // 
            // generateGuidButton
            // 
            this.generateGuidButton.Location = new System.Drawing.Point(336, 45);
            this.generateGuidButton.Name = "generateGuidButton";
            this.generateGuidButton.Size = new System.Drawing.Size(89, 23);
            this.generateGuidButton.TabIndex = 12;
            this.generateGuidButton.Text = "Generate";
            this.generateGuidButton.UseVisualStyleBackColor = true;
            this.generateGuidButton.Click += new System.EventHandler(this.GenerateGuidButtonClick);
            // 
            // browseProjectBinFolderButton
            // 
            this.browseProjectBinFolderButton.Location = new System.Drawing.Point(336, 19);
            this.browseProjectBinFolderButton.Name = "browseProjectBinFolderButton";
            this.browseProjectBinFolderButton.Size = new System.Drawing.Size(89, 23);
            this.browseProjectBinFolderButton.TabIndex = 11;
            this.browseProjectBinFolderButton.Text = "Browse";
            this.browseProjectBinFolderButton.UseVisualStyleBackColor = true;
            this.browseProjectBinFolderButton.Click += new System.EventHandler(this.BrowseProjectBinFolderButtonClick);
            // 
            // browseIconButton
            // 
            this.browseIconButton.Location = new System.Drawing.Point(336, 97);
            this.browseIconButton.Name = "browseIconButton";
            this.browseIconButton.Size = new System.Drawing.Size(89, 23);
            this.browseIconButton.TabIndex = 13;
            this.browseIconButton.Text = "Browse";
            this.browseIconButton.UseVisualStyleBackColor = true;
            this.browseIconButton.Click += new System.EventHandler(this.BrowseIconButtonClick);
            // 
            // licenseRichTextBox
            // 
            this.licenseRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licenseRichTextBox.Enabled = false;
            this.licenseRichTextBox.Location = new System.Drawing.Point(129, 42);
            this.licenseRichTextBox.Name = "licenseRichTextBox";
            this.licenseRichTextBox.Size = new System.Drawing.Size(296, 78);
            this.licenseRichTextBox.TabIndex = 7;
            this.licenseRichTextBox.Text = "";
            // 
            // dialogImageButton
            // 
            this.dialogImageButton.Location = new System.Drawing.Point(336, 30);
            this.dialogImageButton.Name = "dialogImageButton";
            this.dialogImageButton.Size = new System.Drawing.Size(89, 23);
            this.dialogImageButton.TabIndex = 14;
            this.dialogImageButton.Text = "Browse";
            this.dialogImageButton.UseVisualStyleBackColor = true;
            this.dialogImageButton.Click += new System.EventHandler(this.DialogImageButtonClick);
            // 
            // dialogImageLabel
            // 
            this.dialogImageLabel.AutoSize = true;
            this.dialogImageLabel.Location = new System.Drawing.Point(126, 16);
            this.dialogImageLabel.Name = "dialogImageLabel";
            this.dialogImageLabel.Size = new System.Drawing.Size(180, 13);
            this.dialogImageLabel.TabIndex = 19;
            this.dialogImageLabel.Text = "Dialog Image 503 x 314 pixels (.bmp)";
            // 
            // dialogImageTextBox
            // 
            this.dialogImageTextBox.Location = new System.Drawing.Point(129, 32);
            this.dialogImageTextBox.Name = "dialogImageTextBox";
            this.dialogImageTextBox.Size = new System.Drawing.Size(201, 20);
            this.dialogImageTextBox.TabIndex = 8;
            // 
            // bannerImageButton
            // 
            this.bannerImageButton.Location = new System.Drawing.Point(336, 69);
            this.bannerImageButton.Name = "bannerImageButton";
            this.bannerImageButton.Size = new System.Drawing.Size(89, 23);
            this.bannerImageButton.TabIndex = 15;
            this.bannerImageButton.Text = "Browse";
            this.bannerImageButton.UseVisualStyleBackColor = true;
            this.bannerImageButton.Click += new System.EventHandler(this.BannerImageButtonClick);
            // 
            // bannerImageLabel
            // 
            this.bannerImageLabel.AutoSize = true;
            this.bannerImageLabel.Location = new System.Drawing.Point(126, 55);
            this.bannerImageLabel.Name = "bannerImageLabel";
            this.bannerImageLabel.Size = new System.Drawing.Size(178, 13);
            this.bannerImageLabel.TabIndex = 22;
            this.bannerImageLabel.Text = "Banner Image 500 x 63 pixels (.bmp)";
            // 
            // bannerImageTextBox
            // 
            this.bannerImageTextBox.Location = new System.Drawing.Point(129, 71);
            this.bannerImageTextBox.Name = "bannerImageTextBox";
            this.bannerImageTextBox.Size = new System.Drawing.Size(201, 20);
            this.bannerImageTextBox.TabIndex = 9;
            // 
            // licenseInfoLabel
            // 
            this.licenseInfoLabel.AutoSize = true;
            this.licenseInfoLabel.Location = new System.Drawing.Point(16, 44);
            this.licenseInfoLabel.Name = "licenseInfoLabel";
            this.licenseInfoLabel.Size = new System.Drawing.Size(107, 13);
            this.licenseInfoLabel.TabIndex = 23;
            this.licenseInfoLabel.Text = "User Agreement Text";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 529);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(460, 22);
            this.mainStatusStrip.TabIndex = 24;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolDescriptionLabel
            // 
            this.toolDescriptionLabel.AutoSize = true;
            this.toolDescriptionLabel.Location = new System.Drawing.Point(39, 128);
            this.toolDescriptionLabel.Name = "toolDescriptionLabel";
            this.toolDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.toolDescriptionLabel.TabIndex = 26;
            this.toolDescriptionLabel.Text = "Tool Description";
            // 
            // userAgreementCheckBox
            // 
            this.userAgreementCheckBox.AutoSize = true;
            this.userAgreementCheckBox.Location = new System.Drawing.Point(129, 19);
            this.userAgreementCheckBox.Name = "userAgreementCheckBox";
            this.userAgreementCheckBox.Size = new System.Drawing.Size(124, 17);
            this.userAgreementCheckBox.TabIndex = 6;
            this.userAgreementCheckBox.Text = "Add User Agreement";
            this.userAgreementCheckBox.UseVisualStyleBackColor = true;
            this.userAgreementCheckBox.CheckedChanged += new System.EventHandler(this.UserAgreementCheckBoxCheckedChanged);
            // 
            // desktopShortcutCheckBox
            // 
            this.desktopShortcutCheckBox.AutoSize = true;
            this.desktopShortcutCheckBox.Checked = true;
            this.desktopShortcutCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desktopShortcutCheckBox.Location = new System.Drawing.Point(129, 186);
            this.desktopShortcutCheckBox.Name = "desktopShortcutCheckBox";
            this.desktopShortcutCheckBox.Size = new System.Drawing.Size(143, 17);
            this.desktopShortcutCheckBox.TabIndex = 5;
            this.desktopShortcutCheckBox.Text = "Create Desktop Shortcut";
            this.desktopShortcutCheckBox.UseVisualStyleBackColor = true;
            // 
            // projectDescriptiosnGroupBox
            // 
            this.projectDescriptiosnGroupBox.Controls.Add(this.toolDescriptionTextBox);
            this.projectDescriptiosnGroupBox.Controls.Add(this.projectBinDirectoryTextBox);
            this.projectDescriptiosnGroupBox.Controls.Add(this.desktopShortcutCheckBox);
            this.projectDescriptiosnGroupBox.Controls.Add(this.companyNameTextBox);
            this.projectDescriptiosnGroupBox.Controls.Add(this.companyNameLabel);
            this.projectDescriptiosnGroupBox.Controls.Add(this.toolDescriptionLabel);
            this.projectDescriptiosnGroupBox.Controls.Add(this.upgradeCodeTextBox);
            this.projectDescriptiosnGroupBox.Controls.Add(this.upgradeCodeLabel);
            this.projectDescriptiosnGroupBox.Controls.Add(this.iconTextBox);
            this.projectDescriptiosnGroupBox.Controls.Add(this.iconFileLabel);
            this.projectDescriptiosnGroupBox.Controls.Add(this.projectBinDirectoryLabel);
            this.projectDescriptiosnGroupBox.Controls.Add(this.generateGuidButton);
            this.projectDescriptiosnGroupBox.Controls.Add(this.browseProjectBinFolderButton);
            this.projectDescriptiosnGroupBox.Controls.Add(this.browseIconButton);
            this.projectDescriptiosnGroupBox.Location = new System.Drawing.Point(12, 33);
            this.projectDescriptiosnGroupBox.Name = "projectDescriptiosnGroupBox";
            this.projectDescriptiosnGroupBox.Size = new System.Drawing.Size(436, 214);
            this.projectDescriptiosnGroupBox.TabIndex = 29;
            this.projectDescriptiosnGroupBox.TabStop = false;
            this.projectDescriptiosnGroupBox.Text = "Project Descriptions";
            // 
            // toolDescriptionTextBox
            // 
            this.toolDescriptionTextBox.Location = new System.Drawing.Point(129, 126);
            this.toolDescriptionTextBox.Multiline = true;
            this.toolDescriptionTextBox.Name = "toolDescriptionTextBox";
            this.toolDescriptionTextBox.Size = new System.Drawing.Size(296, 54);
            this.toolDescriptionTextBox.TabIndex = 4;
            // 
            // licenseGroupBox
            // 
            this.licenseGroupBox.Controls.Add(this.userAgreementCheckBox);
            this.licenseGroupBox.Controls.Add(this.licenseRichTextBox);
            this.licenseGroupBox.Controls.Add(this.licenseInfoLabel);
            this.licenseGroupBox.Location = new System.Drawing.Point(12, 253);
            this.licenseGroupBox.Name = "licenseGroupBox";
            this.licenseGroupBox.Size = new System.Drawing.Size(436, 133);
            this.licenseGroupBox.TabIndex = 30;
            this.licenseGroupBox.TabStop = false;
            this.licenseGroupBox.Text = "License";
            this.licenseGroupBox.Visible = false;
            // 
            // installerImagesGroupBox
            // 
            this.installerImagesGroupBox.Controls.Add(this.dialogImageLabel);
            this.installerImagesGroupBox.Controls.Add(this.dialogImageTextBox);
            this.installerImagesGroupBox.Controls.Add(this.dialogImageButton);
            this.installerImagesGroupBox.Controls.Add(this.bannerImageTextBox);
            this.installerImagesGroupBox.Controls.Add(this.bannerImageButton);
            this.installerImagesGroupBox.Controls.Add(this.bannerImageLabel);
            this.installerImagesGroupBox.Location = new System.Drawing.Point(12, 392);
            this.installerImagesGroupBox.Name = "installerImagesGroupBox";
            this.installerImagesGroupBox.Size = new System.Drawing.Size(436, 100);
            this.installerImagesGroupBox.TabIndex = 31;
            this.installerImagesGroupBox.TabStop = false;
            this.installerImagesGroupBox.Text = "Installer Images";
            this.installerImagesGroupBox.Visible = false;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(460, 24);
            this.mainMenuStrip.TabIndex = 32;
            this.mainMenuStrip.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // advanceButton
            // 
            this.advanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.advanceButton.Location = new System.Drawing.Point(253, 498);
            this.advanceButton.Name = "advanceButton";
            this.advanceButton.Size = new System.Drawing.Size(89, 23);
            this.advanceButton.TabIndex = 16;
            this.advanceButton.Text = "Advance";
            this.advanceButton.UseVisualStyleBackColor = true;
            this.advanceButton.Click += new System.EventHandler(this.AdvanceButtonClick);
            // 
            // WiXInstallerCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 551);
            this.Controls.Add(this.advanceButton);
            this.Controls.Add(this.createInstallerButton);
            this.Controls.Add(this.projectDescriptiosnGroupBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.licenseGroupBox);
            this.Controls.Add(this.installerImagesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(476, 590);
            this.MinimumSize = new System.Drawing.Size(476, 345);
            this.Name = "WiXInstallerCreatorForm";
            this.Text = "WiX Installer Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WiXInstallerCreatorFormFormClosing);
            this.Load += new System.EventHandler(this.WiXInstallerCreatorFormLoad);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.projectDescriptiosnGroupBox.ResumeLayout(false);
            this.projectDescriptiosnGroupBox.PerformLayout();
            this.licenseGroupBox.ResumeLayout(false);
            this.licenseGroupBox.PerformLayout();
            this.installerImagesGroupBox.ResumeLayout(false);
            this.installerImagesGroupBox.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label upgradeCodeLabel;
        private System.Windows.Forms.TextBox upgradeCodeTextBox;
        private System.Windows.Forms.Label iconFileLabel;
        private System.Windows.Forms.TextBox iconTextBox;
        private System.Windows.Forms.Button createInstallerButton;
        private System.Windows.Forms.Label projectBinDirectoryLabel;
        private System.Windows.Forms.TextBox projectBinDirectoryTextBox;
        private System.Windows.Forms.Button generateGuidButton;
        private System.Windows.Forms.Button browseProjectBinFolderButton;
        private System.Windows.Forms.Button browseIconButton;
        private System.Windows.Forms.FolderBrowserDialog projectFolderBrowserDialog;
        private System.Windows.Forms.RichTextBox licenseRichTextBox;
        private System.Windows.Forms.Button dialogImageButton;
        private System.Windows.Forms.Label dialogImageLabel;
        private System.Windows.Forms.TextBox dialogImageTextBox;
        private System.Windows.Forms.Button bannerImageButton;
        private System.Windows.Forms.Label bannerImageLabel;
        private System.Windows.Forms.TextBox bannerImageTextBox;
        private System.Windows.Forms.Label licenseInfoLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label toolDescriptionLabel;
        private System.Windows.Forms.CheckBox userAgreementCheckBox;
        private System.Windows.Forms.CheckBox desktopShortcutCheckBox;
        private System.Windows.Forms.GroupBox projectDescriptiosnGroupBox;
        private System.Windows.Forms.GroupBox licenseGroupBox;
        private System.Windows.Forms.GroupBox installerImagesGroupBox;
        private System.Windows.Forms.TextBox toolDescriptionTextBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button advanceButton;
    }
}

