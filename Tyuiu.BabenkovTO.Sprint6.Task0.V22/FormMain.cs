using Tyuiu.BabenkovTO.Sprint6.Task0.V22.Lib;
namespace Tyuiu.BabenkovTO.Sprint6.Task0.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_BTO.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_BTO.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-25-1 Бабенков Трофим Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxFormula_BTO_Click(object sender, EventArgs e)
        {

        }
    }
}
