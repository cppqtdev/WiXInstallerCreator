
namespace WiXInstallerCreator.Forms
{
    using System;
    using System.Reflection;
    using System.Windows.Forms;

    /// <summary>
    /// Shows About Form.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Initializes form components.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get information from Assembly.
        /// </summary>
        /// <param name="sender">Refers to the object that invoked the event that fired the event handler</param>
        /// <param name="args">Provides a value to use with event</param>
        private void AboutFormLoad(object sender, EventArgs args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyTitleAttribute assemblyTitle = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0] as AssemblyTitleAttribute;
            AssemblyDescriptionAttribute assemblyDescription = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)[0] as AssemblyDescriptionAttribute;
            Version versionAssembly = typeof(AboutForm).Assembly.GetName().Version;

            toolNameLabel.Text = assemblyTitle.Title + " - " + versionAssembly.ToString();
            descriptionRichTextBox.Text = assemblyDescription.Description;
        }
    }
}
