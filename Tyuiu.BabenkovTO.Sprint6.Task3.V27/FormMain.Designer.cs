namespace Tyuiu.BabenkovTO.Sprint6.Task3.V27
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
            groupBoxСondition_BTO = new GroupBox();
            textBoxTask_BTO = new TextBox();
            dataGridViewMatrix_BTO = new DataGridView();
            groupBoxOutput_BTO = new GroupBox();
            dataGridViewResult_BTO = new DataGridView();
            labelResult_BTO = new Label();
            buttonDone_BTO = new Button();
            buttonHelp_BTO = new Button();
            groupBoxСondition_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BTO).BeginInit();
            groupBoxOutput_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BTO).BeginInit();
            SuspendLayout();
            // 
            // groupBoxСondition_BTO
            // 
            groupBoxСondition_BTO.Controls.Add(textBoxTask_BTO);
            groupBoxСondition_BTO.Controls.Add(dataGridViewMatrix_BTO);
            groupBoxСondition_BTO.Location = new Point(12, 12);
            groupBoxСondition_BTO.Name = "groupBoxСondition_BTO";
            groupBoxСondition_BTO.Size = new Size(416, 310);
            groupBoxСondition_BTO.TabIndex = 7;
            groupBoxСondition_BTO.TabStop = false;
            groupBoxСondition_BTO.Tag = "";
            groupBoxСondition_BTO.Text = "Условие";
            // 
            // textBoxTask_BTO
            // 
            textBoxTask_BTO.BorderStyle = BorderStyle.None;
            textBoxTask_BTO.Location = new Point(6, 22);
            textBoxTask_BTO.Multiline = true;
            textBoxTask_BTO.Name = "textBoxTask_BTO";
            textBoxTask_BTO.ReadOnly = true;
            textBoxTask_BTO.Size = new Size(217, 192);
            textBoxTask_BTO.TabIndex = 0;
            textBoxTask_BTO.TabStop = false;
            textBoxTask_BTO.Text = "Дана матрица 5 на 5\r\n14   5  -9  18  21\r\n\r\n -5 -12 -12   4  28\r\n\r\n  27  -2 -14  23  27\r\n\r\n -19 -15  17  15   1\r\n\r\n  33   2   6  24  24\r\nВыполнить сортировку по возрастанию в третьем столбце.";
            // 
            // dataGridViewMatrix_BTO
            // 
            dataGridViewMatrix_BTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_BTO.ColumnHeadersVisible = false;
            dataGridViewMatrix_BTO.Location = new Point(243, 37);
            dataGridViewMatrix_BTO.Name = "dataGridViewMatrix_BTO";
            dataGridViewMatrix_BTO.RowHeadersVisible = false;
            dataGridViewMatrix_BTO.Size = new Size(167, 154);
            dataGridViewMatrix_BTO.TabIndex = 8;
            // 
            // groupBoxOutput_BTO
            // 
            groupBoxOutput_BTO.Controls.Add(dataGridViewResult_BTO);
            groupBoxOutput_BTO.Controls.Add(labelResult_BTO);
            groupBoxOutput_BTO.Location = new Point(434, 12);
            groupBoxOutput_BTO.Name = "groupBoxOutput_BTO";
            groupBoxOutput_BTO.Size = new Size(262, 258);
            groupBoxOutput_BTO.TabIndex = 9;
            groupBoxOutput_BTO.TabStop = false;
            groupBoxOutput_BTO.Text = "Вывод данных: ";
            // 
            // dataGridViewResult_BTO
            // 
            dataGridViewResult_BTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BTO.ColumnHeadersVisible = false;
            dataGridViewResult_BTO.Location = new Point(6, 37);
            dataGridViewResult_BTO.Name = "dataGridViewResult_BTO";
            dataGridViewResult_BTO.RowHeadersVisible = false;
            dataGridViewResult_BTO.Size = new Size(174, 154);
            dataGridViewResult_BTO.TabIndex = 1;
            // 
            // labelResult_BTO
            // 
            labelResult_BTO.AutoSize = true;
            labelResult_BTO.Location = new Point(6, 19);
            labelResult_BTO.Name = "labelResult_BTO";
            labelResult_BTO.Size = new Size(63, 15);
            labelResult_BTO.TabIndex = 0;
            labelResult_BTO.Text = "Результат:";
            // 
            // buttonDone_BTO
            // 
            buttonDone_BTO.Location = new Point(483, 276);
            buttonDone_BTO.Name = "buttonDone_BTO";
            buttonDone_BTO.Size = new Size(131, 37);
            buttonDone_BTO.TabIndex = 10;
            buttonDone_BTO.Text = "Выполнить";
            buttonDone_BTO.UseVisualStyleBackColor = true;
            buttonDone_BTO.Click += buttonDone_Click;
            // 
            // buttonHelp_BTO
            // 
            buttonHelp_BTO.FlatStyle = FlatStyle.Flat;
            buttonHelp_BTO.Location = new Point(434, 276);
            buttonHelp_BTO.Name = "buttonHelp_BTO";
            buttonHelp_BTO.Size = new Size(43, 37);
            buttonHelp_BTO.TabIndex = 11;
            buttonHelp_BTO.Text = "?";
            buttonHelp_BTO.UseVisualStyleBackColor = true;
            buttonHelp_BTO.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 325);
            Controls.Add(buttonHelp_BTO);
            Controls.Add(buttonDone_BTO);
            Controls.Add(groupBoxOutput_BTO);
            Controls.Add(groupBoxСondition_BTO);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 27 | Бабенков Т. О. ";
            Load += FormMain_Load;
            groupBoxСondition_BTO.ResumeLayout(false);
            groupBoxСondition_BTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BTO).EndInit();
            groupBoxOutput_BTO.ResumeLayout(false);
            groupBoxOutput_BTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BTO).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxСondition_BTO;
        private TextBox textBoxTask_BTO;
        private DataGridView dataGridViewMatrix_BTO;
        private GroupBox groupBoxOutput_BTO;
        private Label labelResult_BTO;
        private Button buttonDone_BTO;
        private Button buttonHelp_BTO;
        private DataGridView dataGridViewResult_BTO;
    }
}
