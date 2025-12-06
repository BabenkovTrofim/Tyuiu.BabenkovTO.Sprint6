using Tyuiu.BabenkovTO.Sprint6.Task6.V18.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            foreach (string line in File.ReadLines(openFilePath))
            {
                textBoxInput_BTO.AppendText(line + Environment.NewLine);
            }
            groupBoxInput_BTO.Text = groupBoxInput_BTO.Text + " " + openFileDialogTask.FileName;
            buttonDone_BTO.Enabled = true;
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput_BTO.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
