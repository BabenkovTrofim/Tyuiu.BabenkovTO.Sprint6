using Tyuiu.BabenkovTO.Sprint6.Task1.V5.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_BTO.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_BTO.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_BTO.Text = "";
                textBoxResult_BTO.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_BTO.AppendText("|     X     |   f(x)    |" + Environment.NewLine);
                textBoxResult_BTO.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,7:d}    |   {1,6:f2}  |", startValue, valueArray[i]);
                    textBoxResult_BTO.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_BTO.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-25-1 Бабенков Трофим Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
