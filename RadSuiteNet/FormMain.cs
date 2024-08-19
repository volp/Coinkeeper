using RadSuiteNet.Properties;

namespace RadSuiteNet
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Text = Settings.Default.ApplicationTitle;

            SetFormState(FormState.Ready); // TODO: Maintain this state
        }

        public void SetFormState(FormState state) // TODO: Feels messy
        {
            runMenuItem.Enabled = runToolStripButton.Enabled = state != FormState.Running;
            breakMenuItem.Enabled = breakToolStripButton.Enabled = state == FormState.Running;
            stopMenuItem.Enabled = stopToolStripButton.Enabled = state >= FormState.Running;
            restartMenuItem.Enabled = restartToolStripButton.Enabled = state >= FormState.Running;

            runToolStripButton.Text = state >= FormState.Running ? "Continue" : "Start";
            runToolStripButton.ToolTipText = runToolStripButton.Text + " (F5)"; // TODO: Take ShortcutKey snippet from Spectacle
            runMenuItem.Text = "&" + runToolStripButton.Text;
            statusStripStatusLabel.Text = state == FormState.Stopped ? "Stopped" : state == FormState.Running ? "Running" : "Ready";
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Add multi-document support back
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = Settings.Default.OpenFileFilter;
                
                // TODO: Try all of these and see what they do
                //openFileDialog.CheckFileExists = true;
                //openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                }
            }
        }

        private void openFolderMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeAllMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = Settings.Default.SaveAsFileFilter;

                // TODO: Try all of these and see what they do
                //saveFileDialog.CheckFileExists = true;
                //saveFileDialog.CheckPathExists = true;
                //saveFileDialog.CheckWriteAccess = true;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                }
            }
        }

        private void saveAllMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Import";
                openFileDialog.Filter = Settings.Default.ImportFileFilter;

                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                }
            }
        }

        private void printSetupMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redoMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standardMenuItem_Click(object sender, EventArgs e)
        {
            standardToolStrip.Visible = standardMenuItem.Checked;
        }

        private void statusBarMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarMenuItem.Checked;
        }

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
            FormOptions optionsDialog = new FormOptions();
            optionsDialog.ShowDialog();
        }

        private void moveLeftMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moveRightMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moveToStartMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moveToEndMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewHelpMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runMenuItem_Click(object sender, EventArgs e)
        {
            SetFormState(FormState.Running);
        }

        private void breakMenuItem_Click(object sender, EventArgs e)
        {
            SetFormState(FormState.Stopped);
        }

        private void stopMenuItem_Click(object sender, EventArgs e)
        {
            SetFormState(FormState.Ready);
        }

        private void restartMenuItem_Click(object sender, EventArgs e)
        {
            SetFormState(FormState.Running);
        }
    }
}
