//-----------------------------------------------------------------------
// <Author = "Mohammad Reza" />
// <File = "VersionNumberForm.cs" />
//-----------------------------------------------------------------------

namespace WiXInstallerCreator
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Takes tool name and version number inputs from the user.
    /// </summary>
    public partial class VersionNumberForm : Form
    {
        #region Fields

        /// <summary>
        /// Stores tool name
        /// </summary>
        public string ToolName;
        /// <summary>
        /// Stores version number
        /// </summary>
        public string VersionNumber;
        /// <summary>
        /// Stores project directory
        /// </summary>
        public string ProjectDirectory;
        /// <summary>
        /// Indicates if version number is set manually
        /// </summary>
        public bool Manual = false;
        /// <summary>
        /// Stores application name
        /// </summary>
        public string ApplicationName;
        /// <summary>
        /// Stores file names
        /// </summary>
        private string[] filePaths;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Confirms installer name and version.
        /// </summary>
        public VersionNumberForm(string[] files, string directory)
        {
            InitializeComponent();

            if(files != null && files.Count() > 0)
            {
                filePaths = files;
            }

            ProjectDirectory = directory;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Allows only decimal numbers.
        /// Multiple decimal points are supported.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void VersionTextBoxKeyPress(object sender, KeyPressEventArgs args)
        {
            if(!char.IsControl(args.KeyChar) && !char.IsDigit(args.KeyChar) && args.KeyChar != '.')
            {
                args.Handled = true;
            }
        }

        /// <summary>
        /// Stores installer name and version for main form to use.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void GetVersionButtonClick(object sender, EventArgs args)
        {
            if(manualCheckBox.Checked)
            {
                Manual = true;

                if(versionTextBox.Text != String.Empty && toolNameTextBox.Text != String.Empty)
                {
                    ToolName = toolNameTextBox.Text;
                    VersionNumber = versionTextBox.Text;
                }
            }
            else
            {
                Manual = false;

                if(exeListBox.SelectedItem != null)
                {
                    ApplicationName = exeListBox.SelectedItem.ToString();
                }
            }
            this.Close();
        }

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void VersionNumberFormLoad(object sender, EventArgs args)
        {
            getVersionButton.DialogResult = DialogResult.OK;

            Height = MinimumSize.Height;
            exeListBox.Items.Clear();
            if(filePaths != null)
            {
                exeListBox.Visible = true;
                foreach(string file in filePaths)
                {
                    if(!file.Contains("vshost"))
                    {
                        exeListBox.Items.Add(file.Replace(ProjectDirectory + "\\", ""));
                    }
                }
            }
            else
            {
                exeGroupBox.Visible = false;
                manualGroupBox.Visible = true;
                manualCheckBox.Checked = true;
                manualCheckBox.Enabled = false;
                Height = MinimumSize.Height;
            }
        }

        /// <summary>
        /// Check box checked change event.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void ManualCheckBoxCheckedChanged(object sender, EventArgs args)
        {
            if(manualCheckBox.Checked)
            {
                Height = MaximumSize.Height;
                manualGroupBox.Visible = true;
            }
            else
            {
                Height = MinimumSize.Height;
                manualGroupBox.Visible = false;
            }
        }

        #endregion Methods
    }
}
