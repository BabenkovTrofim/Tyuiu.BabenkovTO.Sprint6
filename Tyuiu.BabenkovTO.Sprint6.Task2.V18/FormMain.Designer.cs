using System.Windows.Forms;
namespace Tyuiu.BabenkovTO.Sprint6.Task2.V18
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxСondition_BTO = new GroupBox();
            textBoxTask_BTO = new TextBox();
            pictureBoxFormula_BTO = new PictureBox();
            groupBoxInput_BTO = new GroupBox();
            labelStopValue_BTO = new Label();
            textBoxStopValue_BTO = new TextBox();
            labelStartValue_BTO = new Label();
            textBoxStartValue_BTO = new TextBox();
            buttonHelp_BTO = new Button();
            buttonDone_BTO = new Button();
            groupBoxOutput_BTO = new GroupBox();
            dataGridViewFunction_BTO = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult_BTO = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxСondition_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BTO).BeginInit();
            groupBoxInput_BTO.SuspendLayout();
            groupBoxOutput_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BTO).BeginInit();
            SuspendLayout();
            // 
            // groupBoxСondition_BTO
            // 
            groupBoxСondition_BTO.Controls.Add(textBoxTask_BTO);
            groupBoxСondition_BTO.Controls.Add(pictureBoxFormula_BTO);
            groupBoxСondition_BTO.Location = new Point(26, 16);
            groupBoxСondition_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxСondition_BTO.Name = "groupBoxСondition_BTO";
            groupBoxСondition_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxСondition_BTO.Size = new Size(586, 413);
            groupBoxСondition_BTO.TabIndex = 6;
            groupBoxСondition_BTO.TabStop = false;
            groupBoxСondition_BTO.Tag = "";
            groupBoxСondition_BTO.Text = "Условие";
            // 
            // textBoxTask_BTO
            // 
            textBoxTask_BTO.BorderStyle = BorderStyle.None;
            textBoxTask_BTO.Location = new Point(7, 29);
            textBoxTask_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_BTO.Multiline = true;
            textBoxTask_BTO.Name = "textBoxTask_BTO";
            textBoxTask_BTO.ReadOnly = true;
            textBoxTask_BTO.Size = new Size(248, 193);
            textBoxTask_BTO.TabIndex = 0;
            textBoxTask_BTO.TabStop = false;
            textBoxTask_BTO.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вынести в виде таблицы.";
            // 
            // pictureBoxFormula_BTO
            // 
            pictureBoxFormula_BTO.Image = (Image)resources.GetObject("pictureBoxFormula_BTO.Image");
            pictureBoxFormula_BTO.Location = new Point(261, 29);
            pictureBoxFormula_BTO.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula_BTO.Name = "pictureBoxFormula_BTO";
            pictureBoxFormula_BTO.Size = new Size(319, 39);
            pictureBoxFormula_BTO.TabIndex = 1;
            pictureBoxFormula_BTO.TabStop = false;
            // 
            // groupBoxInput_BTO
            // 
            groupBoxInput_BTO.Controls.Add(labelStopValue_BTO);
            groupBoxInput_BTO.Controls.Add(textBoxStopValue_BTO);
            groupBoxInput_BTO.Controls.Add(labelStartValue_BTO);
            groupBoxInput_BTO.Controls.Add(textBoxStartValue_BTO);
            groupBoxInput_BTO.Location = new Point(26, 437);
            groupBoxInput_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_BTO.Name = "groupBoxInput_BTO";
            groupBoxInput_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_BTO.Size = new Size(338, 143);
            groupBoxInput_BTO.TabIndex = 7;
            groupBoxInput_BTO.TabStop = false;
            groupBoxInput_BTO.Text = "Ввод данных";
            // 
            // labelStopValue_BTO
            // 
            labelStopValue_BTO.AutoSize = true;
            labelStopValue_BTO.Location = new Point(169, 68);
            labelStopValue_BTO.Name = "labelStopValue_BTO";
            labelStopValue_BTO.Size = new Size(94, 20);
            labelStopValue_BTO.TabIndex = 8;
            labelStopValue_BTO.Text = "Конец шага:";
            // 
            // textBoxStopValue_BTO
            // 
            textBoxStopValue_BTO.Location = new Point(169, 96);
            textBoxStopValue_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxStopValue_BTO.Name = "textBoxStopValue_BTO";
            textBoxStopValue_BTO.Size = new Size(133, 27);
            textBoxStopValue_BTO.TabIndex = 7;
            textBoxStopValue_BTO.Text = "5";
            // 
            // labelStartValue_BTO
            // 
            labelStartValue_BTO.AutoSize = true;
            labelStartValue_BTO.Location = new Point(7, 68);
            labelStartValue_BTO.Name = "labelStartValue_BTO";
            labelStartValue_BTO.Size = new Size(88, 20);
            labelStartValue_BTO.TabIndex = 6;
            labelStartValue_BTO.Text = "Старт шага:";
            // 
            // textBoxStartValue_BTO
            // 
            textBoxStartValue_BTO.Location = new Point(7, 96);
            textBoxStartValue_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxStartValue_BTO.Name = "textBoxStartValue_BTO";
            textBoxStartValue_BTO.Size = new Size(143, 27);
            textBoxStartValue_BTO.TabIndex = 0;
            textBoxStartValue_BTO.Text = "-5";
            // 
            // buttonHelp_BTO
            // 
            buttonHelp_BTO.BackColor = SystemColors.Highlight;
            buttonHelp_BTO.Location = new Point(371, 459);
            buttonHelp_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_BTO.Name = "buttonHelp_BTO";
            buttonHelp_BTO.Size = new Size(96, 121);
            buttonHelp_BTO.TabIndex = 10;
            buttonHelp_BTO.Text = "Справка";
            buttonHelp_BTO.UseVisualStyleBackColor = false;
            buttonHelp_BTO.Click += buttonHelp_Click;
            // 
            // buttonDone_BTO
            // 
            buttonDone_BTO.BackColor = Color.Green;
            buttonDone_BTO.Location = new Point(474, 459);
            buttonDone_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonDone_BTO.Name = "buttonDone_BTO";
            buttonDone_BTO.Size = new Size(142, 121);
            buttonDone_BTO.TabIndex = 9;
            buttonDone_BTO.Text = "Выполнить";
            buttonDone_BTO.UseVisualStyleBackColor = false;
            buttonDone_BTO.Click += butttonDone_Click;
            buttonDone_BTO.MouseDown += buttonDone_MouseDown;
            buttonDone_BTO.MouseEnter += buttonDone_MouseEnter;
            buttonDone_BTO.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBoxOutput_BTO
            // 
            groupBoxOutput_BTO.Controls.Add(dataGridViewFunction_BTO);
            groupBoxOutput_BTO.Controls.Add(labelResult_BTO);
            groupBoxOutput_BTO.Location = new Point(619, 16);
            groupBoxOutput_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_BTO.Name = "groupBoxOutput_BTO";
            groupBoxOutput_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_BTO.Size = new Size(183, 556);
            groupBoxOutput_BTO.TabIndex = 11;
            groupBoxOutput_BTO.TabStop = false;
            groupBoxOutput_BTO.Text = "Вывод данных";
            // 
            // dataGridViewFunction_BTO
            // 
            dataGridViewFunction_BTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_BTO.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_BTO.Location = new Point(7, 77);
            dataGridViewFunction_BTO.Margin = new Padding(3, 4, 3, 4);
            dataGridViewFunction_BTO.Name = "dataGridViewFunction_BTO";
            dataGridViewFunction_BTO.RowHeadersVisible = false;
            dataGridViewFunction_BTO.RowHeadersWidth = 51;
            dataGridViewFunction_BTO.Size = new Size(169, 471);
            dataGridViewFunction_BTO.TabIndex = 9;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // labelResult_BTO
            // 
            labelResult_BTO.AutoSize = true;
            labelResult_BTO.Location = new Point(7, 41);
            labelResult_BTO.Name = "labelResult_BTO";
            labelResult_BTO.Size = new Size(78, 20);
            labelResult_BTO.TabIndex = 8;
            labelResult_BTO.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 607);
            Controls.Add(groupBoxOutput_BTO);
            Controls.Add(groupBoxСondition_BTO);
            Controls.Add(groupBoxInput_BTO);
            Controls.Add(buttonHelp_BTO);
            Controls.Add(buttonDone_BTO);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 18 | Бабенков Т. О. ";
            groupBoxСondition_BTO.ResumeLayout(false);
            groupBoxСondition_BTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BTO).EndInit();
            groupBoxInput_BTO.ResumeLayout(false);
            groupBoxInput_BTO.PerformLayout();
            groupBoxOutput_BTO.ResumeLayout(false);
            groupBoxOutput_BTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BTO).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxСondition_BTO;
        private TextBox textBoxTask_BTO;
        private PictureBox pictureBoxFormula_BTO;
        private GroupBox groupBoxInput_BTO;
        private Label labelStartValue_BTO;
        private TextBox textBoxStartValue_BTO;
        private Button buttonHelp_BTO;
        private Button buttonDone_BTO;
        private Label labelStopValue_BTO;
        private TextBox textBoxStopValue_BTO;
        private GroupBox groupBoxOutput_BTO;
        private Label labelResult_BTO;
        private DataGridView dataGridViewFunction_BTO;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
