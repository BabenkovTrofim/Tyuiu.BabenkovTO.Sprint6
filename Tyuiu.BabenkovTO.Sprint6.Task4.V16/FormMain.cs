using Tyuiu.BabenkovTO.Sprint6.Task4.V16.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task4.V16
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

                int len = stopValue - startValue + 1;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_BTO.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BTO.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_BTO.Text = "";

                chartFunction_BTO.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_BTO.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxResult_BTO.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-25-1 Бабенков Трофим Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4.txt" });
                File.WriteAllText(path, textBoxResult_BTO.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранён успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
