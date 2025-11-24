using Tyuiu.BabenkovTO.Sprint6.Task3.V27.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[,] { {  9,  13, -14,  23,   1 },
                                   { 15, -17,  21,  25,  23 },
                                   { -4,  29, -20, -10,  14 },
                                   { 27,  33,  12,  33, -12 },
                                   { 18,  -9,  -5,   6,   3 }
                                                              };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);

            dataGridViewMatrix_BTO.ColumnCount = cols;
            dataGridViewMatrix_BTO.RowCount = rows;

            dataGridViewResult_BTO.ColumnCount = cols;
            dataGridViewResult_BTO.RowCount = rows;

            dataGridViewMatrix_BTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewResult_BTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_BTO.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] resMatrix = ds.Calculate(mtrx);
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_BTO.Rows[i].Cells[j].Value = Convert.ToString(resMatrix[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание 3 выполнил студент группы ИИПб-25-1 Бабенков Трофим Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
