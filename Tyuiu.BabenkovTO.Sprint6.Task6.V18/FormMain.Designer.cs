namespace Tyuiu.BabenkovTO.Sprint6.Task6.V18
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_BTO = new Panel();
            buttonDone_BTO = new Button();
            buttonOpenFile_BTO = new Button();
            buttonHelp_BTO = new Button();
            groupBoxTask_BTO = new GroupBox();
            textBoxTask_BTO = new TextBox();
            groupBoxInput_BTO = new GroupBox();
            textBoxInput_BTO = new TextBox();
            groupBoxOutput_BTO = new GroupBox();
            textBoxOutput_BTO = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTipTask = new ToolTip(components);
            panelPredTop_BTO = new Panel();
            splitContainer_BTO = new SplitContainer();
            panelTop_BTO.SuspendLayout();
            groupBoxTask_BTO.SuspendLayout();
            groupBoxInput_BTO.SuspendLayout();
            groupBoxOutput_BTO.SuspendLayout();
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
            // buttonDone_BTO
            // 
            buttonDone_BTO.BackColor = Color.White;
            buttonDone_BTO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_BTO.Cursor = Cursors.Hand;
            buttonDone_BTO.Enabled = false;
            buttonDone_BTO.Image = (Image)resources.GetObject("buttonDone_BTO.Image");
            buttonDone_BTO.Location = new Point(102, 16);
            buttonDone_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonDone_BTO.Name = "buttonDone_BTO";
            buttonDone_BTO.Size = new Size(75, 87);
            buttonDone_BTO.TabIndex = 4;
            toolTipTask.SetToolTip(buttonDone_BTO, "Произвести обработку файла");
            buttonDone_BTO.UseVisualStyleBackColor = false;
            buttonDone_BTO.Click += buttonDone_Click;
            // 
            // buttonOpenFile_BTO
            // 
            buttonOpenFile_BTO.BackColor = Color.White;
            buttonOpenFile_BTO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_BTO.Cursor = Cursors.Hand;
            buttonOpenFile_BTO.Image = (Image)resources.GetObject("buttonOpenFile_BTO.Image");
            buttonOpenFile_BTO.Location = new Point(19, 16);
            buttonOpenFile_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_BTO.Name = "buttonOpenFile_BTO";
            buttonOpenFile_BTO.Size = new Size(75, 87);
            buttonOpenFile_BTO.TabIndex = 5;
            buttonOpenFile_BTO.Text = "\r\n";
            toolTipTask.SetToolTip(buttonOpenFile_BTO, "Открыть файл\r\nВыберите нужный файл для обработки.\r\n");
            buttonOpenFile_BTO.UseVisualStyleBackColor = false;
            buttonOpenFile_BTO.Click += buttonOpenFile_Click;
            // 
            // buttonHelp_BTO
            // 
            buttonHelp_BTO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BTO.BackColor = Color.White;
            buttonHelp_BTO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_BTO.Cursor = Cursors.Hand;
            buttonHelp_BTO.Font = new Font("Segoe UI Black", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_BTO.ForeColor = Color.Green;
            buttonHelp_BTO.Location = new Point(833, 16);
            buttonHelp_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_BTO.Name = "buttonHelp_BTO";
            buttonHelp_BTO.Size = new Size(78, 87);
            buttonHelp_BTO.TabIndex = 6;
            buttonHelp_BTO.Text = "?";
            buttonHelp_BTO.UseVisualStyleBackColor = false;
            buttonHelp_BTO.Click += buttonHelp_Click;
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
            textBoxTask_BTO.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            groupBoxInput_BTO.Controls.Add(textBoxInput_BTO);
            groupBoxInput_BTO.Dock = DockStyle.Fill;
            groupBoxInput_BTO.Location = new Point(0, 0);
            groupBoxInput_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_BTO.Name = "groupBoxInput_BTO";
            groupBoxInput_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_BTO.Size = new Size(307, 495);
            groupBoxInput_BTO.TabIndex = 0;
            groupBoxInput_BTO.TabStop = false;
            groupBoxInput_BTO.Text = "Ввод:";
            // 
            // textBoxInput_BTO
            // 
            textBoxInput_BTO.Dock = DockStyle.Fill;
            textBoxInput_BTO.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInput_BTO.Location = new Point(3, 24);
            textBoxInput_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxInput_BTO.Multiline = true;
            textBoxInput_BTO.Name = "textBoxInput_BTO";
            textBoxInput_BTO.ReadOnly = true;
            textBoxInput_BTO.Size = new Size(301, 467);
            textBoxInput_BTO.TabIndex = 0;
            // 
            // groupBoxOutput_BTO
            // 
            groupBoxOutput_BTO.Controls.Add(textBoxOutput_BTO);
            groupBoxOutput_BTO.Dock = DockStyle.Fill;
            groupBoxOutput_BTO.Location = new Point(0, 0);
            groupBoxOutput_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_BTO.Name = "groupBoxOutput_BTO";
            groupBoxOutput_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_BTO.Size = new Size(613, 495);
            groupBoxOutput_BTO.TabIndex = 0;
            groupBoxOutput_BTO.TabStop = false;
            groupBoxOutput_BTO.Text = "Вывод:";
            // 
            // textBoxOutput_BTO
            // 
            textBoxOutput_BTO.Dock = DockStyle.Fill;
            textBoxOutput_BTO.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOutput_BTO.Location = new Point(3, 24);
            textBoxOutput_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput_BTO.Multiline = true;
            textBoxOutput_BTO.Name = "textBoxOutput_BTO";
            textBoxOutput_BTO.ReadOnly = true;
            textBoxOutput_BTO.Size = new Size(607, 467);
            textBoxOutput_BTO.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipTask
            // 
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
            splitContainer_BTO.SplitterDistance = 307;
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
            Text = "Спринт 6 | Таск 6 | Вариант 18 | Бабенков Т. О ";
            Load += FormMain_Load;
            panelTop_BTO.ResumeLayout(false);
            groupBoxTask_BTO.ResumeLayout(false);
            groupBoxTask_BTO.PerformLayout();
            groupBoxInput_BTO.ResumeLayout(false);
            groupBoxInput_BTO.PerformLayout();
            groupBoxOutput_BTO.ResumeLayout(false);
            groupBoxOutput_BTO.PerformLayout();
            panelPredTop_BTO.ResumeLayout(false);
            splitContainer_BTO.Panel1.ResumeLayout(false);
            splitContainer_BTO.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_BTO).EndInit();
            splitContainer_BTO.ResumeLayout(false);
            ResumeLayout(false);
        }

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
        private TextBox textBoxInput_BTO;
        private TextBox textBoxOutput_BTO;
        private Panel panelPredTop_BTO;
        private SplitContainer splitContainer_BTO;
    }
}
