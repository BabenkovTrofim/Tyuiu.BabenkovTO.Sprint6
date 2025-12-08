using Tyuiu.BabenkovTO.Sprint6.Task7.V25.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            rows = File.ReadLines(filePath).Count();
            string[] strings = File.ReadAllText(filePath).Split("\n");
            columns = strings[0].Split(';').Length;
            int[,] matrix = new int[rows, columns];

            using (StreamReader stream = new StreamReader(filePath))
            {
                string line;
                int count = 0;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] row = line.Split(';');
                    for (int i = 0; i < columns; i++)
                    {
                        matrix[count, i] = Convert.ToInt32(row[i]);
                    }
                    count++;
                }
            }
            return matrix;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_BTO.ColumnCount = columns;
            dataGridViewIn_BTO.RowCount = rows;
            dataGridViewOut_BTO.ColumnCount = columns;
            dataGridViewOut_BTO.RowCount = rows;

            dataGridViewIn_BTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOut_BTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_BTO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone_BTO.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_BTO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_BTO.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = @"C:\DataSprint6";
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_BTO.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_BTO.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_BTO.ColumnCount = 50;
            dataGridViewOut_BTO.ColumnCount = 50;

            dataGridViewIn_BTO.RowCount = 50;
            dataGridViewOut_BTO.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_BTO.Columns[i].Width = 25;
                dataGridViewOut_BTO.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_BTO_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask.ToolTipTitle = "Открыть файл";
        }

        private void buttonSaveFile_BTO_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask.ToolTipTitle = "Сохранить файл";
        }

        private void buttonDone_BTO_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask.ToolTipTitle = "Выполнить";
        }

        private void buttonHelp_BTO_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask.ToolTipTitle = "Справка";
        }
    }
}
