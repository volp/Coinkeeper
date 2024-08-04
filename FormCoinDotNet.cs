namespace CoinDotNet
{
    public partial class FormCoinDotNet : Form
    {
        public FormCoinDotNet()
        {
            InitializeComponent();
            Text = Properties.Settings.Default.ApplicationTitle;
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = Properties.Settings.Default.OpenFileFilter;

                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                }
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = Properties.Settings.Default.SaveFileFilter;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                }
            }
        }

        private void importMenuItem_Click(object sender, EventArgs e)
        {
            openMenuItem_Click(sender, e);
        }

        private void pageSetupMenuItem_Click(object sender, EventArgs e)
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

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewHelpMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void validateMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
