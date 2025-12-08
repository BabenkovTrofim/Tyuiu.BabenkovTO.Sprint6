namespace Tyuiu.BabenkovTO.Sprint6.Task7.V25
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_BTO = new Panel();
            buttonSaveFile_BTO = new Button();
            buttonDone_BTO = new Button();
            buttonOpenFile_BTO = new Button();
            buttonHelp_BTO = new Button();
            groupBoxTask_BTO = new GroupBox();
            textBoxTask_BTO = new TextBox();
            groupBoxInput_BTO = new GroupBox();
            dataGridViewIn_BTO = new DataGridView();
            groupBoxOutput_BTO = new GroupBox();
            dataGridViewOut_BTO = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipTask = new ToolTip(components);
            panelPredTop_BTO = new Panel();
            splitContainer_BTO = new SplitContainer();
            saveFileDialogMatrix = new SaveFileDialog();
            panelTop_BTO.SuspendLayout();
            groupBoxTask_BTO.SuspendLayout();
            groupBoxInput_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BTO).BeginInit();
            groupBoxOutput_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BTO).BeginInit();
            panelPredTop_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_BTO).BeginInit();
            splitContainer_BTO.Panel1.SuspendLayout();
            splitContainer_BTO.Panel2.SuspendLayout();
            splitContainer_BTO.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_BTO
            // 
            panelTop_BTO.BackColor = Color.White;
            panelTop_BTO.Controls.Add(buttonSaveFile_BTO);
            panelTop_BTO.Controls.Add(buttonDone_BTO);
            panelTop_BTO.Controls.Add(buttonOpenFile_BTO);
            panelTop_BTO.Controls.Add(buttonHelp_BTO);
            panelTop_BTO.Dock = DockStyle.Top;
            panelTop_BTO.Location = new Point(0, 0);
            panelTop_BTO.Margin = new Padding(3, 4, 3, 4);
            panelTop_BTO.Name = "panelTop_BTO";
            panelTop_BTO.Size = new Size(925, 117);
            panelTop_BTO.TabIndex = 3;
            // 
            // buttonSaveFile_BTO
            // 
            buttonSaveFile_BTO.BackColor = Color.White;
            buttonSaveFile_BTO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveFile_BTO.Cursor = Cursors.Hand;
            buttonSaveFile_BTO.Enabled = false;
            buttonSaveFile_BTO.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_BTO.Image = (Image)resources.GetObject("buttonSaveFile_BTO.Image");
            buttonSaveFile_BTO.Location = new Point(184, 16);
            buttonSaveFile_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_BTO.Name = "buttonSaveFile_BTO";
            buttonSaveFile_BTO.Size = new Size(75, 87);
            buttonSaveFile_BTO.TabIndex = 4;
            buttonSaveFile_BTO.UseVisualStyleBackColor = false;
            buttonSaveFile_BTO.Click += buttonSaveFile_Click;
            buttonSaveFile_BTO.MouseEnter += buttonSaveFile_BTO_MouseEnter;
            // 
            // buttonDone_BTO
            // 
            buttonDone_BTO.BackColor = Color.White;
            buttonDone_BTO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_BTO.Cursor = Cursors.Hand;
            buttonDone_BTO.Enabled = false;
            buttonDone_BTO.FlatStyle = FlatStyle.Flat;
            buttonDone_BTO.Image = (Image)resources.GetObject("buttonDone_BTO.Image");
            buttonDone_BTO.Location = new Point(102, 16);
            buttonDone_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonDone_BTO.Name = "buttonDone_BTO";
            buttonDone_BTO.Size = new Size(75, 87);
            buttonDone_BTO.TabIndex = 4;
            toolTipTask.SetToolTip(buttonDone_BTO, "Произвести обработку файла");
            buttonDone_BTO.UseVisualStyleBackColor = false;
            buttonDone_BTO.Click += buttonDone_Click;
            buttonDone_BTO.MouseEnter += buttonDone_BTO_MouseEnter;
            // 
            // buttonOpenFile_BTO
            // 
            buttonOpenFile_BTO.BackColor = Color.White;
            buttonOpenFile_BTO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_BTO.Cursor = Cursors.Hand;
            buttonOpenFile_BTO.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_BTO.Image = (Image)resources.GetObject("buttonOpenFile_BTO.Image");
            buttonOpenFile_BTO.Location = new Point(19, 16);
            buttonOpenFile_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_BTO.Name = "buttonOpenFile_BTO";
            buttonOpenFile_BTO.Size = new Size(75, 87);
            buttonOpenFile_BTO.TabIndex = 5;
            buttonOpenFile_BTO.Text = "\r\n";
            toolTipTask.SetToolTip(buttonOpenFile_BTO, "\r\n");
            buttonOpenFile_BTO.UseVisualStyleBackColor = false;
            buttonOpenFile_BTO.Click += buttonOpenFile_Click;
            buttonOpenFile_BTO.MouseEnter += buttonOpenFile_BTO_MouseEnter;
            // 
            // buttonHelp_BTO
            // 
            buttonHelp_BTO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BTO.BackColor = Color.White;
            buttonHelp_BTO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_BTO.Cursor = Cursors.Hand;
            buttonHelp_BTO.Image = (Image)resources.GetObject("buttonHelp_BTO.Image");
            buttonHelp_BTO.Location = new Point(833, 16);
            buttonHelp_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_BTO.Name = "buttonHelp_BTO";
            buttonHelp_BTO.Size = new Size(78, 87);
            buttonHelp_BTO.TabIndex = 6;
            buttonHelp_BTO.UseVisualStyleBackColor = false;
            buttonHelp_BTO.Click += buttonHelp_Click;
            buttonHelp_BTO.MouseEnter += buttonHelp_BTO_MouseEnter;
            // 
            // groupBoxTask_BTO
            // 
            groupBoxTask_BTO.Controls.Add(textBoxTask_BTO);
            groupBoxTask_BTO.Dock = DockStyle.Fill;
            groupBoxTask_BTO.Location = new Point(0, 0);
            groupBoxTask_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_BTO.Name = "groupBoxTask_BTO";
            groupBoxTask_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_BTO.Size = new Size(925, 133);
            groupBoxTask_BTO.TabIndex = 3;
            groupBoxTask_BTO.TabStop = false;
            groupBoxTask_BTO.Text = "Условие:";
            // 
            // textBoxTask_BTO
            // 
            textBoxTask_BTO.Dock = DockStyle.Fill;
            textBoxTask_BTO.Font = new Font("Segoe UI", 10F);
            textBoxTask_BTO.Location = new Point(3, 24);
            textBoxTask_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_BTO.Multiline = true;
            textBoxTask_BTO.Name = "textBoxTask_BTO";
            textBoxTask_BTO.ReadOnly = true;
            textBoxTask_BTO.Size = new Size(919, 105);
            textBoxTask_BTO.TabIndex = 0;
            textBoxTask_BTO.TabStop = false;
            textBoxTask_BTO.Text = resources.GetString("textBoxTask_BTO.Text");
            // 
            // groupBoxInput_BTO
            // 
            groupBoxInput_BTO.Controls.Add(dataGridViewIn_BTO);
            groupBoxInput_BTO.Dock = DockStyle.Fill;
            groupBoxInput_BTO.Location = new Point(0, 0);
            groupBoxInput_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_BTO.Name = "groupBoxInput_BTO";
            groupBoxInput_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_BTO.Size = new Size(443, 495);
            groupBoxInput_BTO.TabIndex = 0;
            groupBoxInput_BTO.TabStop = false;
            groupBoxInput_BTO.Text = "Ввод:";
            // 
            // dataGridViewIn_BTO
            // 
            dataGridViewIn_BTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_BTO.ColumnHeadersVisible = false;
            dataGridViewIn_BTO.Dock = DockStyle.Fill;
            dataGridViewIn_BTO.Location = new Point(3, 24);
            dataGridViewIn_BTO.Margin = new Padding(3, 4, 3, 4);
            dataGridViewIn_BTO.Name = "dataGridViewIn_BTO";
            dataGridViewIn_BTO.RowHeadersVisible = false;
            dataGridViewIn_BTO.RowHeadersWidth = 51;
            dataGridViewIn_BTO.Size = new Size(437, 467);
            dataGridViewIn_BTO.TabIndex = 0;
            // 
            // groupBoxOutput_BTO
            // 
            groupBoxOutput_BTO.Controls.Add(dataGridViewOut_BTO);
            groupBoxOutput_BTO.Dock = DockStyle.Fill;
            groupBoxOutput_BTO.Location = new Point(0, 0);
            groupBoxOutput_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_BTO.Name = "groupBoxOutput_BTO";
            groupBoxOutput_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_BTO.Size = new Size(477, 495);
            groupBoxOutput_BTO.TabIndex = 0;
            groupBoxOutput_BTO.TabStop = false;
            groupBoxOutput_BTO.Text = "Вывод:";
            // 
            // dataGridViewOut_BTO
            // 
            dataGridViewOut_BTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_BTO.ColumnHeadersVisible = false;
            dataGridViewOut_BTO.Dock = DockStyle.Fill;
            dataGridViewOut_BTO.Location = new Point(3, 24);
            dataGridViewOut_BTO.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOut_BTO.Name = "dataGridViewOut_BTO";
            dataGridViewOut_BTO.RowHeadersVisible = false;
            dataGridViewOut_BTO.RowHeadersWidth = 51;
            dataGridViewOut_BTO.Size = new Size(471, 467);
            dataGridViewOut_BTO.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipTask
            // 
            toolTipTask.IsBalloon = true;
            toolTipTask.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask.ToolTipTitle = "Подсказка";
            // 
            // panelPredTop_BTO
            // 
            panelPredTop_BTO.Controls.Add(groupBoxTask_BTO);
            panelPredTop_BTO.Dock = DockStyle.Top;
            panelPredTop_BTO.Location = new Point(0, 117);
            panelPredTop_BTO.Margin = new Padding(3, 4, 3, 4);
            panelPredTop_BTO.Name = "panelPredTop_BTO";
            panelPredTop_BTO.Size = new Size(925, 133);
            panelPredTop_BTO.TabIndex = 4;
            // 
            // splitContainer_BTO
            // 
            splitContainer_BTO.Dock = DockStyle.Fill;
            splitContainer_BTO.Location = new Point(0, 250);
            splitContainer_BTO.Margin = new Padding(3, 4, 3, 4);
            splitContainer_BTO.Name = "splitContainer_BTO";
            // 
            // splitContainer_BTO.Panel1
            // 
            splitContainer_BTO.Panel1.Controls.Add(groupBoxInput_BTO);
            // 
            // splitContainer_BTO.Panel2
            // 
            splitContainer_BTO.Panel2.Controls.Add(groupBoxOutput_BTO);
            splitContainer_BTO.Size = new Size(925, 495);
            splitContainer_BTO.SplitterDistance = 443;
            splitContainer_BTO.SplitterWidth = 5;
            splitContainer_BTO.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 745);
            Controls.Add(splitContainer_BTO);
            Controls.Add(panelPredTop_BTO);
            Controls.Add(panelTop_BTO);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(940, 782);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 24 | Бабенков Т. О";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelTop_BTO.ResumeLayout(false);
            groupBoxTask_BTO.ResumeLayout(false);
            groupBoxTask_BTO.PerformLayout();
            groupBoxInput_BTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BTO).EndInit();
            groupBoxOutput_BTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BTO).EndInit();
            panelPredTop_BTO.ResumeLayout(false);
            splitContainer_BTO.Panel1.ResumeLayout(false);
            splitContainer_BTO.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_BTO).EndInit();
            splitContainer_BTO.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BTO;
        private Button buttonDone_BTO;
        private Button buttonOpenFile_BTO;
        private Button buttonHelp_BTO;
        private GroupBox groupBoxTask_BTO;
        private TextBox textBoxTask_BTO;
        private GroupBox groupBoxOutput_BTO;
        private GroupBox groupBoxInput_BTO;
        private ToolTip toolTipTask;
        private OpenFileDialog openFileDialogTask;
        private Panel panelPredTop_BTO;
        private SplitContainer splitContainer_BTO;
        private Button buttonSaveFile_BTO;
        private SaveFileDialog saveFileDialogMatrix;
        private DataGridView dataGridViewIn_BTO;
        private DataGridView dataGridViewOut_BTO;
    }
}
