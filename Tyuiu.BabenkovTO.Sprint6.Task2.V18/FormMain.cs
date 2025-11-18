using System.Windows.Forms;
using Tyuiu.BabenkovTO.Sprint6.Task2.V18.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task2.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void butttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewFunction_BTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_BTO.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_BTO.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);


                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_BTO.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-1 Бабенков Трофим Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BTO.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BTO.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BTO.BackColor = Color.Blue;
        }

    }
}
