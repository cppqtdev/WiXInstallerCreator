//-----------------------------------------------------------------------
// <Author = "Mohammad Reza" />
// <File = "WiXInstallerCreatorForm.cs" />
//-----------------------------------------------------------------------

namespace WiXInstallerCreator
{
    using InternalToolsCommon.Forms;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml;

    /// <summary>
    /// Main application form. Used to provide functionailty to the user so 
    /// that they can create wix based installer with ease.
    /// </summary>
    public partial class WiXInstallerCreatorForm : Form
    {
        #region Fields

        /// <summary>
        /// Stores tool name
        /// </summary>
        private string ToolName;
        /// <summary>
        /// Stores version number
        /// </summary>
        private string VersionNumber;
        /// <summary>
        /// Stores project directory
        /// </summary>
        private string ProjectDirectory;
        /// <summary>
        /// Indicates if version number is set manually
        /// </summary>
        private bool Manual = false;
        /// <summary>
        /// Stores application name
        /// </summary>
        private string ApplicationName;
        /// <summary>
        /// Stores installer path
        /// </summary>
        private static string installerPath;
        /// <summary>
        /// Background worker to create wix installer
        /// </summary>
        private BackgroundWorker createInstallerBackgroundWorker = new BackgroundWorker();
        /// <summary>
        /// Background worker to get necessary files from shared network directory
        /// </summary>
        private BackgroundWorker getFilesBackgroundWorker = new BackgroundWorker();
        /// <summary>
        /// The network share directory where scripts are stored
        /// </summary>
        private const string RequiredFilesDirectory = @"\\data\shares\ENG\GPE\InternalTestTools\WiXInstallerCreator";
        /// <summary>
        /// Harvested wxs file location
        /// </summary>
        private const string HarvestedFilesFragment = "scripts\\HarvestedFilesFragment.wxs";
        /// <summary>
        /// Template wxs file location
        /// </summary>
        private const string TemplateFile = "scripts\\Template.wxs";
        /// <summary>
        /// Main wxs file location
        /// </summary>
        private const string MainFile = "scripts\\Main.wxs";
        /// <summary>
        /// XML document
        /// </summary>
        private XmlDocument xmlDoc;
        /// <summary>
        /// Inducates if operation is successful
        /// </summary>
        private bool success = false;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Creates a new wix installer creator form.
        /// </summary>
        public WiXInstallerCreatorForm()
        {
            InitializeComponent();

            createInstallerBackgroundWorker.WorkerSupportsCancellation = true;
            createInstallerBackgroundWorker.WorkerReportsProgress = true;
            createInstallerBackgroundWorker.DoWork += new DoWorkEventHandler(CreateInstallerBackgroundWorkerDoWork);
            createInstallerBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CreateInstallerBackgroundWorkerCompleted);

            getFilesBackgroundWorker.WorkerSupportsCancellation = true;
            getFilesBackgroundWorker.WorkerReportsProgress = true;
            getFilesBackgroundWorker.DoWork += new DoWorkEventHandler(GetFilesBackgroundWorkerDoWork);
            getFilesBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(GetFilesBackgroundWorkerCompleted);
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Removes node from xml document.
        /// </summary>
        /// <param name="tagName">Tag name</param>
        /// <param name="innerText">Inner text</param>
        private void RemoveChildNode(string tagName, string innerText)
        {
            if(xmlDoc != null)
            {
                XmlNodeList nodes = xmlDoc.GetElementsByTagName(tagName);
                foreach(XmlNode node in nodes)
                {
                    if(node.Attributes["Id"].InnerText == innerText)
                    {
                        node.ParentNode.RemoveChild(node);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Removes node from xml document.
        /// </summary>
        /// <param name="tagName">Tag name</param>
        private void RemoveChildNode(string tagName)
        {
            if(xmlDoc != null)
            {
                XmlNodeList nodes = xmlDoc.GetElementsByTagName(tagName);
                if(nodes.Count > 0)
                {
                    nodes[0].ParentNode.RemoveChild(nodes[0]);
                }
            }
        }

        /// <summary>
        /// BackgroundWorker to create wix installer.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void CreateInstallerBackgroundWorkerDoWork(object sender, DoWorkEventArgs args)
        {
            ActionForm reporter = sender as ActionForm;

            if(reporter != null)
            {
                if(!createInstallerBackgroundWorker.CancellationPending)
                {
                    reporter.StatusText = "Harvesting files";
                    ExecuteCommand("wix3binaries\\heat.exe dir " + projectBinDirectoryTextBox.Text + " -cg INSTALLFOLDER -gg -scom -sreg -sfrag -srd -out HarvestedFilesFragment.wxs");
                    reporter.ReportProgress(1, 5);

                    reporter.StatusText = "Making necessary changes to file";

                    if(File.Exists(HarvestedFilesFragment))
                    {
                        FindAndReplaceText(HarvestedFilesFragment, HarvestedFilesFragment, "TARGETDIR", "INSTALLFOLDER");
                        FindAndReplaceText(HarvestedFilesFragment, HarvestedFilesFragment, "SourceDir\\", projectBinDirectoryTextBox.Text + "\\");
                        FindAndReplaceText(HarvestedFilesFragment, HarvestedFilesFragment, "ComponentGroup Id", "ComponentGroup Id = \"ProductComponents\" Directory");

                        if(!Manual)
                        {
                            FindAndReplaceText(TemplateFile, MainFile, "[REPLACE_WITH_TOOL_NAME]", GetToolName(HarvestedFilesFragment, projectBinDirectoryTextBox.Text + "\\"));
                            FindAndReplaceText(MainFile, MainFile, "[REPLACE_WITH_FILE_ID_GENERATED_AFTER_HARVESTING]", GetFileIds(HarvestedFilesFragment));
                        }
                        else
                        {
                            FindAndReplaceText(TemplateFile, MainFile, "[REPLACE_WITH_TOOL_NAME]", ToolName);
                            FindAndReplaceText(MainFile, MainFile, "!(bind.FileVersion.[REPLACE_WITH_FILE_ID_GENERATED_AFTER_HARVESTING])", VersionNumber);
                        }

                        FindAndReplaceText(MainFile, MainFile, "[COMPANY]", companyNameTextBox.Text);
                        FindAndReplaceText(MainFile, MainFile, "[REPLACE_WITH_PATH_TO_ICON_FILE]", iconTextBox.Text);
                        FindAndReplaceText(MainFile, MainFile, "[REPLACE_WITH_PATH_TO_BANNER_BMP]", bannerImageTextBox.Text);
                        FindAndReplaceText(MainFile, MainFile, "[REPLACE_WITH_PATH_TO_DIALOG_BMP]", dialogImageTextBox.Text);
                        FindAndReplaceText(MainFile, MainFile, "[UPGRADE_CODE_GUID]", upgradeCodeTextBox.Text);
                        FindAndReplaceText(MainFile, MainFile, "[REPLACE_WITH_GUID_DESKTOP]", GetGuid());
                        FindAndReplaceText(MainFile, MainFile, "[REPLACE_WITH_GUID_PROGRAM]", GetGuid());
                        FindAndReplaceText(MainFile, MainFile, "[REPLACE_WITH_TOOL_DESCRIPTION]", toolDescriptionTextBox.Text);
                        reporter.ReportProgress(1, 5);

                        xmlDoc = new XmlDocument();
                        xmlDoc.Load(MainFile);

                        if(Manual)
                        {
                            RemoveChildNode("Directory", "DesktopFolder");
                            RemoveChildNode("Directory", "ProgramMenuFolder");
                            RemoveChildNode("DirectoryRef", "ApplicationProgramsFolder");
                            RemoveChildNode("ComponentRef", "ApplicationShortcutDesktop");
                            RemoveChildNode("ComponentRef", "ApplicationShortcut");
                        }
                        else
                        {
                            if(!desktopShortcutCheckBox.Checked)
                            {
                                RemoveChildNode("Directory", "DesktopFolder");
                                RemoveChildNode("ComponentRef", "ApplicationShortcutDesktop");
                            }
                        }

                        if(!userAgreementCheckBox.Checked)
                        {
                            RemoveChildNode("WixVariable", "WixUILicenseRtf");
                        }
                        else
                        {
                            RemoveChildNode("UI");
                        }

                        xmlDoc.Save("scripts\\Main.wxs");

                        reporter.StatusText = "Compiling";
                        ExecuteCommand("wix3binaries\\candle.exe HarvestedFilesFragment.wxs Main.wxs");
                        reporter.ReportProgress(1, 5);

                        reporter.StatusText = "Building";
                        ToolName = ToolName.Replace(" ", "");

                        if(File.Exists("scripts\\HarvestedFilesFragment.wixobj") && File.Exists("scripts\\Main.wixobj"))
                        {
                            ExecuteCommand("wix3binaries\\light.exe -ext scripts\\wix3binaries\\WixUIExtension.dll -out " + ToolName + ".msi HarvestedFilesFragment.wixobj Main.wixobj");
                            reporter.ReportProgress(1, 5);

                            reporter.StatusText = "Removing temporary files";
                            DeleteUnnecessaryFiles("scripts", "*.wixobj");
                            DeleteUnnecessaryFiles("scripts", "*.wixpdb");
                            DeleteUnnecessaryFiles("scripts", "HarvestedFilesFragment.wxs");
                            DeleteUnnecessaryFiles("scripts", "Main.wxs");
                            DeleteUnnecessaryFiles("scripts", "*.rtf");
                            MoveFile("scripts", "*.msi");
                            reporter.ReportProgress(1, 5);

                            success = true;
                        }
                        else
                        {
                            MessageBox.Show("Unable to find required files!");
                            success = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to find required files!");
                        success = false;
                    }                                    
                }               
            }
        }

        /// <summary>
        /// Notifies background workers work status.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void CreateInstallerBackgroundWorkerCompleted(object sender, RunWorkerCompletedEventArgs args)
        {
            if(args.Error != null)
            {
                // TODO: Report errors.
            }
            else
            {
                if(success)
                {
                    OpenFolder();
                    statusLabel.Text = "Done";
                }
                else
                {
                    statusLabel.Text = "Errors! Could not create the installer.";
                }
            }
        }

        /// <summary>
        /// BackgroundWorker to copy necessary files from network shared directory.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void GetFilesBackgroundWorkerDoWork(object sender, DoWorkEventArgs args)
        {
            ActionForm reporter = sender as ActionForm;

            if(reporter != null)
            {
                if(!getFilesBackgroundWorker.CancellationPending)
                {
                    reporter.ReportProgress(1, 5);
                    //Now Create all of the directories
                    foreach(string dirPath in Directory.GetDirectories(RequiredFilesDirectory + @"\scripts", "*",
                        SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(RequiredFilesDirectory + @"\scripts", @"scripts\"));
                    }
                    reporter.ReportProgress(3, 5);
                    //Copy all the files & Replaces any files with the same name
                    foreach(string newPath in Directory.GetFiles(RequiredFilesDirectory + @"\scripts", "*.*",
                        SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(RequiredFilesDirectory + @"\scripts", @"scripts\"), true);
                    }
                    reporter.ReportProgress(1, 5);
                }
            }
        }

        /// <summary>
        /// Notifies background workers work status.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void GetFilesBackgroundWorkerCompleted(object sender, RunWorkerCompletedEventArgs args)
        {
            if(args.Error != null)
            {
                // TODO: Report errors.
            }
            else
            {
                statusLabel.Text = "Ready";
            }
        }

        /// <summary>
        /// Run wix commands in command prompt.
        /// </summary>
        /// <param name="command">Command to execute</param>
        private void ExecuteCommand(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;
           
            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.WorkingDirectory = "scripts";
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            try
            {
                process = Process.Start(processInfo);
                process.WaitForExit();

                // *** Read the streams ***
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                exitCode = process.ExitCode;

                // TODO: Report output/error/exitCode.
                Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
                Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
                Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");

                process.Close();
            }
            catch(Exception)
            {
                statusLabel.Text = "Could not run process cmd.exe!";
            }
        }

        /// <summary>
        /// Button click event to initiate main operation.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void CreateInstallerButtonClick(object sender, EventArgs args)
        {
            ToolName = VersionNumber = ApplicationName = String.Empty;

            if(iconTextBox.Text != String.Empty && projectBinDirectoryTextBox.Text != String.Empty && 
                upgradeCodeTextBox.Text != String.Empty && companyNameTextBox.Text != String.Empty && 
                toolDescriptionTextBox.Text != String.Empty)
            {                
                if(!projectBinDirectoryTextBox.Text.Contains(" "))
                {
                    bool exceptionThrown = false;

                    ProjectDirectory = projectBinDirectoryTextBox.Text;

                    string[] filePaths = null;
                    try
                    {
                        filePaths = Directory.GetFiles(projectBinDirectoryTextBox.Text, "*.exe",
                                             SearchOption.TopDirectoryOnly);
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Project Bin Directory not found");
                        exceptionThrown = true;
                    }

                    VersionNumberForm versionForm = new VersionNumberForm(filePaths, ProjectDirectory);
                    versionForm.ShowDialog();

                    if(versionForm.DialogResult == DialogResult.OK)
                    {
                        ApplicationName = versionForm.ApplicationName;
                        ToolName = versionForm.ToolName;
                        VersionNumber = versionForm.VersionNumber;
                        Manual = versionForm.Manual;

                        versionForm.Dispose();
                    }

                    if(!exceptionThrown)
                    {
                        if(Manual)
                        {
                            if(ToolName != null && ToolName != String.Empty && 
                                VersionNumber != null && VersionNumber != String.Empty)
                            {
                                StartOperation();
                            }
                        }
                        else
                        {
                            if(ApplicationName != null && ApplicationName != String.Empty)
                            {
                                StartOperation();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Project Bin Directory should not contain any space for WiX Installer to work properly!");
                }               
            }
            else
            {
                statusLabel.Text = "One or more pieces of information are missing!";
            }
        }

        /// <summary>
        /// Triggers CreateInstallerBackgroundWorker to create the installer.
        /// </summary>
        private void StartOperation()
        {
            if(userAgreementCheckBox.Checked)
            {
                licenseRichTextBox.SaveFile("scripts\\license.rtf", RichTextBoxStreamType.RichText);
            }

            ActionForm reporter = new ActionForm();
            reporter.ActionText = "Operation in progress";
            reporter.DoWork += CreateInstallerBackgroundWorkerDoWork;
            reporter.ActionFinished += CreateInstallerBackgroundWorkerCompleted;
            reporter.ShowDialog(this);
        }

        /// <summary>
        /// Find and replace text.
        /// </summary>
        /// <param name="oldFileName">File to read</param>
        /// <param name="newFileName">File to write</param>
        /// <param name="oldValue">String to replace</param>
        /// <param name="newValue">Replacement string</param>
        private void FindAndReplaceText(string oldFileName, string newFileName, string oldValue, string newValue)
        {
            string text = File.ReadAllText(oldFileName);
            text = text.Replace(oldValue, newValue);
            File.WriteAllText(newFileName, text);
        }

        /// <summary>
        /// Find file id of actual executable.
        /// </summary>
        /// <param name="fileName">File to parse</param>
        private string GetFileIds(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList elemList = doc.GetElementsByTagName("File");
            string attrIdVal = String.Empty;
            for(int index = 0; index < elemList.Count; index++)
            {
                if(elemList[index].Attributes["Source"].Value.EndsWith(ApplicationName))
                {
                    attrIdVal = elemList[index].Attributes["Id"].Value;
                }    
            }

            return attrIdVal;
        }

        /// <summary>
        /// Find tool name.
        /// </summary>
        /// <param name="fileName">File to parse</param>
        /// <param name="path">Replace path to get the tool name</param>
        private string GetToolName(string fileName, string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList elemList = doc.GetElementsByTagName("File");
            string attrSourceVal = "";
            for(int index = 0; index < elemList.Count; index++)
            {
                if(elemList[index].Attributes["Source"].Value.EndsWith(ApplicationName))
                {
                    attrSourceVal = elemList[index].Attributes["Source"].Value.Replace(path, "").Replace(".exe", "");
                }
            }

            ToolName = attrSourceVal;
            if(ToolName == null || ToolName == String.Empty)
            {
                MessageBox.Show("No valid exe file is found in the project directory!");
            }

            return attrSourceVal;
        }

        /// <summary>
        /// Generate Guid.
        /// </summary>
        private string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Populate UpgradeCodeTextBox with new guid value.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void GenerateGuidButtonClick(object sender, EventArgs args)
        {
            upgradeCodeTextBox.Text = GetGuid();
        }

        /// <summary>
        /// Search and delete unnecessary files.
        /// </summary>
        /// <param name="path">Path to delete from</param>
        /// <param name="pattern">Search pattern</param>
        private void DeleteUnnecessaryFiles(string path, string pattern)
        {
            string[] filePaths = Directory.GetFiles(path, pattern);
            foreach(string filePath in filePaths)
            {
                if(filePath.Contains(pattern.Replace("*", "")))
                {
                    File.Delete(filePath);
                }
            }
        }

        /// <summary>
        /// Search and move file(s).
        /// </summary>
        /// <param name="path">Path to move from</param>
        /// <param name="pattern">Search pattern</param>
        private void MoveFile(string path, string pattern)
        {
            installerPath = "Installer\\" + ToolName + "\\" + DateTime.Now.ToString("yyyy-MM-dd HHmmss");
            if(!Directory.Exists(installerPath))
            {
                Directory.CreateDirectory(installerPath);
            }
            string[] filePaths = Directory.GetFiles(path, pattern);
            foreach(string filePath in filePaths)
            {
                if(filePath.Contains(pattern.Replace("*", "")))
                {
                    File.Move(filePath, Path.Combine(installerPath, filePath.Replace("scripts\\", "")));
                }
            }
        }

        /// <summary>
        /// Opens FolderBrowserDialog to browse for project bin directory.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void BrowseProjectBinFolderButtonClick(object sender, EventArgs args)
        {
            DialogResult result = projectFolderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                projectBinDirectoryTextBox.Text = projectFolderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Opens FileDialog to browse for icon file.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void BrowseIconButtonClick(object sender, EventArgs args)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Icon Files (*.ico)|*.ico";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an icon for the installer.";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                iconTextBox.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void WiXInstallerCreatorFormLoad(object sender, EventArgs args)
        {
            Height = MinimumSize.Height;
            if(!Directory.Exists("scripts"))
            {
                ActionForm reporter = new ActionForm();
                reporter.ActionText = "Getting necessary files";
                reporter.DoWork += GetFilesBackgroundWorkerDoWork;
                reporter.ActionFinished += GetFilesBackgroundWorkerCompleted;
                reporter.ShowDialog(this);
            }

            iconTextBox.Text = Path.Combine(Directory.GetCurrentDirectory(), "scripts\\icon.ico");
            dialogImageTextBox.Text = Path.Combine(Directory.GetCurrentDirectory(), "scripts\\dialogbmp.bmp");
            bannerImageTextBox.Text = Path.Combine(Directory.GetCurrentDirectory(), "scripts\\bannerbmp.bmp");
        }

        /// <summary>
        /// Opens FileDialog to browse for dialog image.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void DialogImageButtonClick(object sender, EventArgs args)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Bitmap (*.bmp)|*.bmp";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select a dialog image for the installer.";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                dialogImageTextBox.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// Opens FileDialog to browse for banner image.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void BannerImageButtonClick(object sender, EventArgs args)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Bitmap (*.bmp)|*.bmp";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select a banner image for the installer.";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                bannerImageTextBox.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// Opens folder where newly created installer resides.
        /// </summary>
        private void OpenFolder()
        {
            if(Directory.Exists(installerPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = installerPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", installerPath));
            }
        }

        /// <summary>
        /// Check box check changed event.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void UserAgreementCheckBoxCheckedChanged(object sender, EventArgs args)
        {
            if(userAgreementCheckBox.Checked)
            {
                licenseRichTextBox.Enabled = true;
            }
            else
            {
                licenseRichTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// Opens about form.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void AboutToolStripMenuItemClick(object sender, EventArgs args)
        {
            AboutForm about = new AboutForm(Assembly.GetExecutingAssembly());
            about.ShowDialog(this);
        }

        /// <summary>
        /// Opens confluence page in web browser.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void DocumentationToolStripMenuItemClick(object sender, EventArgs args)
        {
            Process.Start("https://developers.confluence.igt.com/display/internaltools/WiX+Installer+Creator");
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs args)
        {
            Application.Exit();
        }

        /// <summary>
        /// Show or hide advance options.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void AdvanceButtonClick(object sender, EventArgs args)
        {
            if(advanceButton.Text == "Advance")
            {
                Height = MaximumSize.Height;
                advanceButton.Text = "Hide";
                licenseGroupBox.Visible = true;
                installerImagesGroupBox.Visible = true;
            }
            else
            {
                Height = MinimumSize.Height;
                advanceButton.Text = "Advance";
                licenseGroupBox.Visible = false;
                installerImagesGroupBox.Visible = false;
            }
        }

        /// <summary>
        /// Close all background worker before closing the form.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void WiXInstallerCreatorFormFormClosing(object sender, FormClosingEventArgs args)
        {
            if(getFilesBackgroundWorker != null && getFilesBackgroundWorker.IsBusy)
            {
                getFilesBackgroundWorker.CancelAsync();
            }

            if(createInstallerBackgroundWorker != null && createInstallerBackgroundWorker.IsBusy)
            {
                createInstallerBackgroundWorker.CancelAsync();
            }
        }

        #endregion Methods        
    }
}
