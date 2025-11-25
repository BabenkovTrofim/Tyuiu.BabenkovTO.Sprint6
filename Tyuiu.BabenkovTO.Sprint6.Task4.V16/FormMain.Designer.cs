namespace Tyuiu.BabenkovTO.Sprint6.Task4.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_BTO = new Panel();
            buttonDone_BTO = new Button();
            buttonSave_BTO = new Button();
            buttonHelp_BTO = new Button();
            groupBoxInput_BTO = new GroupBox();
            labelStopValue_BTO = new Label();
            textBoxStopValue_BTO = new TextBox();
            labelStartValue_BTO = new Label();
            textBoxStartValue_BTO = new TextBox();
            groupBoxTask_BTO = new GroupBox();
            textBoxTask_BTO = new TextBox();
            panelLeft_BTO = new Panel();
            groupBoxResult_BTO = new GroupBox();
            textBoxResult_BTO = new TextBox();
            panelFill_BTO = new Panel();
            splitter_BTO = new Splitter();
            chartFunction_BTO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_BTO.SuspendLayout();
            groupBoxInput_BTO.SuspendLayout();
            groupBoxTask_BTO.SuspendLayout();
            panelLeft_BTO.SuspendLayout();
            groupBoxResult_BTO.SuspendLayout();
            panelFill_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BTO).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BTO
            // 
            panelTop_BTO.Controls.Add(buttonDone_BTO);
            panelTop_BTO.Controls.Add(buttonSave_BTO);
            panelTop_BTO.Controls.Add(buttonHelp_BTO);
            panelTop_BTO.Controls.Add(groupBoxInput_BTO);
            panelTop_BTO.Controls.Add(groupBoxTask_BTO);
            panelTop_BTO.Dock = DockStyle.Top;
            panelTop_BTO.Location = new Point(0, 0);
            panelTop_BTO.Margin = new Padding(3, 4, 3, 4);
            panelTop_BTO.Name = "panelTop_BTO";
            panelTop_BTO.Size = new Size(1067, 133);
            panelTop_BTO.TabIndex = 0;
            // 
            // buttonDone_BTO
            // 
            buttonDone_BTO.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_BTO.Cursor = Cursors.Hand;
            buttonDone_BTO.Location = new Point(760, 31);
            buttonDone_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonDone_BTO.Name = "buttonDone_BTO";
            buttonDone_BTO.Size = new Size(101, 87);
            buttonDone_BTO.TabIndex = 1;
            buttonDone_BTO.Text = "Выполнить";
            buttonDone_BTO.UseVisualStyleBackColor = false;
            buttonDone_BTO.Click += buttonDone_Click;
            // 
            // buttonSave_BTO
            // 
            buttonSave_BTO.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_BTO.Cursor = Cursors.Hand;
            buttonSave_BTO.Location = new Point(867, 31);
            buttonSave_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonSave_BTO.Name = "buttonSave_BTO";
            buttonSave_BTO.Size = new Size(91, 87);
            buttonSave_BTO.TabIndex = 1;
            buttonSave_BTO.Text = "Сохранить";
            buttonSave_BTO.UseVisualStyleBackColor = false;
            buttonSave_BTO.Click += buttonSave_Click;
            // 
            // buttonHelp_BTO
            // 
            buttonHelp_BTO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BTO.BackColor = SystemColors.ActiveCaption;
            buttonHelp_BTO.Cursor = Cursors.Hand;
            buttonHelp_BTO.Location = new Point(964, 31);
            buttonHelp_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_BTO.Name = "buttonHelp_BTO";
            buttonHelp_BTO.Size = new Size(91, 87);
            buttonHelp_BTO.TabIndex = 1;
            buttonHelp_BTO.Text = "Справка";
            buttonHelp_BTO.UseVisualStyleBackColor = false;
            buttonHelp_BTO.Click += buttonHelp_Click;
            // 
            // groupBoxInput_BTO
            // 
            groupBoxInput_BTO.Controls.Add(labelStopValue_BTO);
            groupBoxInput_BTO.Controls.Add(textBoxStopValue_BTO);
            groupBoxInput_BTO.Controls.Add(labelStartValue_BTO);
            groupBoxInput_BTO.Controls.Add(textBoxStartValue_BTO);
            groupBoxInput_BTO.Location = new Point(456, 4);
            groupBoxInput_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_BTO.Name = "groupBoxInput_BTO";
            groupBoxInput_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_BTO.Size = new Size(297, 125);
            groupBoxInput_BTO.TabIndex = 0;
            groupBoxInput_BTO.TabStop = false;
            groupBoxInput_BTO.Text = "Ввод данных:";
            // 
            // labelStopValue_BTO
            // 
            labelStopValue_BTO.AutoSize = true;
            labelStopValue_BTO.Location = new Point(139, 47);
            labelStopValue_BTO.Name = "labelStopValue_BTO";
            labelStopValue_BTO.Size = new Size(94, 20);
            labelStopValue_BTO.TabIndex = 1;
            labelStopValue_BTO.Text = "Конец шага:";
            // 
            // textBoxStopValue_BTO
            // 
            textBoxStopValue_BTO.Location = new Point(139, 71);
            textBoxStopValue_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxStopValue_BTO.Name = "textBoxStopValue_BTO";
            textBoxStopValue_BTO.Size = new Size(114, 27);
            textBoxStopValue_BTO.TabIndex = 0;
            textBoxStopValue_BTO.Text = "5";
            // 
            // labelStartValue_BTO
            // 
            labelStartValue_BTO.AutoSize = true;
            labelStartValue_BTO.Location = new Point(7, 47);
            labelStartValue_BTO.Name = "labelStartValue_BTO";
            labelStartValue_BTO.Size = new Size(88, 20);
            labelStartValue_BTO.TabIndex = 1;
            labelStartValue_BTO.Text = "Старт шага:";
            // 
            // textBoxStartValue_BTO
            // 
            textBoxStartValue_BTO.Location = new Point(7, 71);
            textBoxStartValue_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxStartValue_BTO.Name = "textBoxStartValue_BTO";
            textBoxStartValue_BTO.Size = new Size(114, 27);
            textBoxStartValue_BTO.TabIndex = 0;
            textBoxStartValue_BTO.Text = "-5";
            // 
            // groupBoxTask_BTO
            // 
            groupBoxTask_BTO.Controls.Add(textBoxTask_BTO);
            groupBoxTask_BTO.Location = new Point(9, 4);
            groupBoxTask_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_BTO.Name = "groupBoxTask_BTO";
            groupBoxTask_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_BTO.Size = new Size(440, 121);
            groupBoxTask_BTO.TabIndex = 0;
            groupBoxTask_BTO.TabStop = false;
            groupBoxTask_BTO.Text = "Условие:";
            // 
            // textBoxTask_BTO
            // 
            textBoxTask_BTO.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_BTO.Location = new Point(7, 29);
            textBoxTask_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_BTO.Multiline = true;
            textBoxTask_BTO.Name = "textBoxTask_BTO";
            textBoxTask_BTO.ReadOnly = true;
            textBoxTask_BTO.Size = new Size(433, 83);
            textBoxTask_BTO.TabIndex = 0;
            textBoxTask_BTO.Text = "Произвести табулирование функции на заданном диапазоне с шагом 1.\r\nПостроить график функции и сохранить в файл OutPutFileTask4V17.txt";
            // 
            // panelLeft_BTO
            // 
            panelLeft_BTO.BackColor = Color.White;
            panelLeft_BTO.Controls.Add(groupBoxResult_BTO);
            panelLeft_BTO.Dock = DockStyle.Left;
            panelLeft_BTO.Location = new Point(0, 133);
            panelLeft_BTO.Margin = new Padding(3, 4, 3, 4);
            panelLeft_BTO.Name = "panelLeft_BTO";
            panelLeft_BTO.Padding = new Padding(6, 7, 6, 7);
            panelLeft_BTO.Size = new Size(240, 415);
            panelLeft_BTO.TabIndex = 0;
            // 
            // groupBoxResult_BTO
            // 
            groupBoxResult_BTO.Controls.Add(textBoxResult_BTO);
            groupBoxResult_BTO.Dock = DockStyle.Left;
            groupBoxResult_BTO.Location = new Point(6, 7);
            groupBoxResult_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult_BTO.Name = "groupBoxResult_BTO";
            groupBoxResult_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult_BTO.Size = new Size(229, 401);
            groupBoxResult_BTO.TabIndex = 0;
            groupBoxResult_BTO.TabStop = false;
            groupBoxResult_BTO.Text = "Вывод:";
            // 
            // textBoxResult_BTO
            // 
            textBoxResult_BTO.Dock = DockStyle.Fill;
            textBoxResult_BTO.Location = new Point(3, 24);
            textBoxResult_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_BTO.Multiline = true;
            textBoxResult_BTO.Name = "textBoxResult_BTO";
            textBoxResult_BTO.ReadOnly = true;
            textBoxResult_BTO.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BTO.Size = new Size(223, 373);
            textBoxResult_BTO.TabIndex = 0;
            // 
            // panelFill_BTO
            // 
            panelFill_BTO.BackColor = Color.Red;
            panelFill_BTO.Controls.Add(splitter_BTO);
            panelFill_BTO.Controls.Add(chartFunction_BTO);
            panelFill_BTO.Dock = DockStyle.Fill;
            panelFill_BTO.Location = new Point(240, 133);
            panelFill_BTO.Margin = new Padding(3, 4, 3, 4);
            panelFill_BTO.Name = "panelFill_BTO";
            panelFill_BTO.Size = new Size(827, 415);
            panelFill_BTO.TabIndex = 1;
            // 
            // splitter_BTO
            // 
            splitter_BTO.BackColor = Color.White;
            splitter_BTO.Location = new Point(0, 0);
            splitter_BTO.Margin = new Padding(3, 4, 3, 4);
            splitter_BTO.Name = "splitter_BTO";
            splitter_BTO.Size = new Size(3, 415);
            splitter_BTO.TabIndex = 2;
            splitter_BTO.TabStop = false;
            // 
            // chartFunction_BTO
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BTO.ChartAreas.Add(chartArea1);
            chartFunction_BTO.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_BTO.Legends.Add(legend1);
            chartFunction_BTO.Location = new Point(0, 0);
            chartFunction_BTO.Margin = new Padding(3, 4, 3, 4);
            chartFunction_BTO.Name = "chartFunction_BTO";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BTO.Series.Add(series1);
            chartFunction_BTO.Size = new Size(827, 415);
            chartFunction_BTO.TabIndex = 1;
            chartFunction_BTO.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.DodgerBlue;
            title1.Name = "График функции";
            title1.Text = "График функции";
            chartFunction_BTO.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 548);
            Controls.Add(panelFill_BTO);
            Controls.Add(panelLeft_BTO);
            Controls.Add(panelTop_BTO);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1083, 584);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 16 | Бабенков Т. О. ";
            panelTop_BTO.ResumeLayout(false);
            groupBoxInput_BTO.ResumeLayout(false);
            groupBoxInput_BTO.PerformLayout();
            groupBoxTask_BTO.ResumeLayout(false);
            groupBoxTask_BTO.PerformLayout();
            panelLeft_BTO.ResumeLayout(false);
            groupBoxResult_BTO.ResumeLayout(false);
            groupBoxResult_BTO.PerformLayout();
            panelFill_BTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BTO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BTO;
        private Panel panelLeft_BTO;
        private Panel panelFill_BTO;
        private GroupBox groupBoxTask_BTO;
        private GroupBox groupBoxResult_BTO;
        private TextBox textBoxResult_BTO;
        private Button buttonHelp_BTO;
        private GroupBox groupBoxInput_BTO;
        private Label labelStartValue_BTO;
        private TextBox textBoxStartValue_BTO;
        private Label labelStopValue_BTO;
        private TextBox textBoxStopValue_BTO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BTO;
        private TextBox textBoxTask_BTO;
        private Button buttonDone_BTO;
        private Button buttonSave_BTO;
        private Splitter splitter_BTO;
    }
}
